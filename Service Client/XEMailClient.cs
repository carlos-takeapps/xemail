using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using System.Net;

using BAFactory.Fx.Network.Email;

using BAFactory.XEMail.ServiceClient.WebserviceProxy;

namespace BAFactory.XEMail.ServiceClient
{
    public delegate void XEMailCheckEMailsEventHandler(object sender, EventArgs e);
    public delegate void XEMailClientConfigChangedEventHandler(object sender, EventArgs e);

    public class XEMailClient
    {
        public event XEMailCheckEMailsEventHandler EMailsCheckFinished;
        public event XEMailClientConfigChangedEventHandler ConfigurationChanged;
        private DataSet xEMailsDS;
        private DataTable emailsTable;
        private XEMailWebserviceProxy prxy;

        private XEMailClientConfiguration configurationObject;
        private XEMailProcessStatusManager status;

        public XEMailClientConfiguration ConfigurationObject
        {
            get { return configurationObject; }
            set
            {
                configurationObject = value;
                UpdateClientConfiguration();
            }
        }
        public XEMailProcessStatusManager Status
        {
            get { return status; }
        }

        public DataSet XEMailsDS
        {
            get { return xEMailsDS; }
        }

        public XEMailClient()
            : this("http://webservices.siprod.net/xemail.asmx")
        {
        }
        public XEMailClient(string ServiceURI)
        {
            // Internal Dataset
            xEMailsDS = new DataSet("XEMailDS");

            // Web Service Initialization
            prxy = new XEMailWebserviceProxy();
            prxy.Url = ServiceURI;

            prxy.GetAllPop3EMailsHeadersDSCompleted += new GetAllPop3EMailsHeadersDSCompletedEventHandler(RetrieveAllEMailsHeadersEnded);

            // Config Object
            this.configurationObject = new XEMailClientConfiguration();
            this.configurationObject.AutoCheckEnabled = false;
            this.configurationObject.WebserviceUrl = ServiceURI;
            UpdateClientConfiguration(false);

            this.configurationObject.ConfigurationChanged += new ConfigChangedEventHandler(configurationObject_ConfigurationChanged);

            // Status Object
            status = new XEMailProcessStatusManager();
            status.ProcessFinished += new XEMailProcessFinishedEventHandler(NotifyFinish);

            // The datatables
            this.emailsTable = InitializeLocalDataTable();
            this.xEMailsDS.Tables.Add(emailsTable);
        }

        void configurationObject_ConfigurationChanged(object sender, EventArgs e)
        {
            UpdateClientConfiguration();
        }

        # region EMail Services Methods

        public bool RetrieveAllAccountsEMailsHeaders()
        {
            bool result = true;
            Dictionary<string, XEMailAccount>.Enumerator ie = configurationObject.Accounts.GetEnumerator();
            
            while (ie.MoveNext())
            {
                XEMailAccount account = ie.Current.Value;
                result = RetrieveAllEMailsHeaders(account.AccountName);
            }
            
            return result;
        }

        public bool RetrieveAllEMailsHeaders(string AccountName)
        {
            if (!configurationObject.Accounts.ContainsKey(AccountName) || status.IsInProcess(AccountName))
                return false;

            bool result = true;
            XEMailAccount account = configurationObject.Accounts[AccountName];
            account.IncomingServer.ErrorMessage = new string[0];
            status.AddAccount(AccountName);
            try
            {
                DataSet currentHeaders = prxy.GetAllPop3EMailsHeadersDS(account.IncomingServer.ServerName, account.IncomingServer.ServerPort, account.IncomingServer.Username, account.IncomingServer.UserPassword, account.IncomingServer.SslEnabled);
                DataTable tempTable = ProcessDataSetFor(AccountName, currentHeaders.Tables[0]);
                MergeCurrentEMails(AccountName, tempTable);
            }
            catch (Exception e)
            {
                account.IncomingServer.ErrorMessage = new string[1] { e.Message };
                result = false;
            }
            finally
            {
                status.RemoveAccount(AccountName);
            }
            return result;
        }

        public void BeginRetrieveAllAccountsEMailsHeaders()
        {
            Dictionary<string, XEMailAccount>.Enumerator ie = configurationObject.Accounts.GetEnumerator();
            while (ie.MoveNext())
            {
                XEMailAccount account = ie.Current.Value;
                BeginRetrieveAllEMailsHeaders(account.AccountName);
            }
        }
        
        public void BeginRetrieveAllEMailsHeaders(string AccountName)
        {
            if (!configurationObject.Accounts.ContainsKey(AccountName) || status.IsInProcess(AccountName) || !configurationObject.Accounts[AccountName].IncomingServer.ServerEnabled)
                return;

            XEMailAccount account = configurationObject.Accounts[AccountName];

            status.AddAccount(AccountName);
            object userState = account.AccountName;
            try
            {
                prxy.GetAllPop3EMailsHeadersDSAsync(account.IncomingServer.ServerName, account.IncomingServer.ServerPort, account.IncomingServer.Username, account.IncomingServer.UserPassword, account.IncomingServer.SslEnabled, userState);
            }
            catch (Exception e)
            {
                account.IncomingServer.ErrorMessage = new string[1] { e.Message };
            }
            return;
        }

        private void RetrieveAllEMailsHeadersEnded(object sender, GetAllPop3EMailsHeadersDSCompletedEventArgs e)
        {
            string AccountName = e.UserState.ToString();
            status.RemoveAccount(AccountName);

            DataTable tempTable;
            if (e.Result.Tables.Count > 0)
            {
                tempTable = ProcessDataSetFor(AccountName, e.Result.Tables[0]);
            }
            else
            {
                tempTable = new DataTable();
            }
            MergeCurrentEMails(AccountName, tempTable);

        }

        public void CancelAllRequests()
        {
            foreach (string accountName in status.InProcessAccounts)
            {
                CancelRequest(accountName);   
            }
            prxy.Dispose();
            status.Reset();
        }

        public void CancelRequest(string AccountName)
        {
            prxy.CancelAsync(AccountName);
        }

        public EMailMessage RetrieveEMail(string AccountName, int MessageNumber)
        {
            XEMailAccount account = configurationObject.Accounts[AccountName];
            EMailMessage result = null;
            try
            {
                result = prxy.RetrievePop3EMail(account.IncomingServer.ServerName, account.IncomingServer.ServerPort, account.IncomingServer.Username, account.IncomingServer.UserPassword, account.IncomingServer.SslEnabled, MessageNumber);
            }
            catch (Exception e)
            {
                account.IncomingServer.ErrorMessage = new string[1] { e.Message.ToString() };
            }
            return result;
        }

        public string RetrieveRawEMail(string AccountName, int MessageNumber)
        {
            XEMailAccount account = configurationObject.Accounts[AccountName];
            string result = string.Empty;
            try
            {
                string retrieve = prxy.RetrievePop3RawEMailStream(account.IncomingServer.ServerName, account.IncomingServer.ServerPort, account.IncomingServer.Username, account.IncomingServer.UserPassword, account.IncomingServer.SslEnabled, MessageNumber);
                result = retrieve.Replace("\n","\r\n");
            }
            catch (Exception e)
            {
                account.IncomingServer.ErrorMessage = new string[1] { e.Message.ToString() };
            }
            return result;
        }

        public bool DeleteEMail(string AccountName, int MessageNumber)
        {
            XEMailAccount account = configurationObject.Accounts[AccountName];
            bool result = false;
            try
            {
                result = prxy.DeletePop3EMail(account.IncomingServer.ServerName, account.IncomingServer.ServerPort, account.IncomingServer.Username, account.IncomingServer.UserPassword, account.IncomingServer.SslEnabled, MessageNumber);
            }
            catch (Exception e)
            {
                account.IncomingServer.ErrorMessage = new string[1] { e.Message.ToString() };
            }
            return result;
        }

        public bool SendEMail(string AccountName, EMailMessage EMail)
        {
            XEMailAccount account = configurationObject.Accounts[AccountName];
            bool result = false;
            
            string username;
            string password;
            if (account.UseSameCredentialsToSend)
            {
                username = account.IncomingServer.Username;
                password = account.IncomingServer.UserPassword;
            }
            else
            {
                username = account.OutgoingServer.Username;
                password = account.OutgoingServer.UserPassword;
            }

            try
            {
                result = prxy.SendSmtpEMail(account.OutgoingServer.ServerName, account.OutgoingServer.ServerPort, username, password, account.OutgoingServer.SslEnabled, EMail);
            }
            catch (Exception e)
            {
                account.OutgoingServer.ErrorMessage = new string[] { e.Message.ToString() };
            }
            return result;
        
        }

        # endregion

        # region Local Data Management Helper Methods

        private DataTable InitializeLocalDataTable()
        {
            DataTable result = new DataTable();
            result.Columns.Add("AccountName", typeof(string));

            result.Columns.Add("Priority", typeof(string));
            result.Columns.Add("From", typeof(string));
            result.Columns.Add("Number", typeof(uint));
            result.Columns.Add("Subject", typeof(string));
            result.Columns.Add("Bytes", typeof(uint));
            result.Columns.Add("Date", typeof(DateTime));
            result.Columns.Add("Headers", typeof(string));

            return result;
        }

        private DataTable ProcessDataSetFor(string Account, DataTable Table)
        {
            DataTable result = Table.Copy();
            DataColumn columnID = new DataColumn("AccountName", typeof(string));
            columnID.DefaultValue = Account;
            result.Columns.Add(columnID);

            return result;
        }

        private void MergeCurrentEMails(string AccountName, DataTable tempTable)
        {
            DataRow[] drs = this.emailsTable.Select(string.Format("AccountName = '{0}'", AccountName));

            foreach (DataRow dr in drs)
            {
                this.emailsTable.Rows.Remove(dr);
            }

            foreach (DataRow row in tempTable.Rows)
            {
                this.emailsTable.ImportRow(row);
            }
        }

        # endregion

        # region Events and Notifications

        private void NotifyFinish()
        {
            NotifyFinish(this, new EventArgs());
        }

        void NotifyFinish(object sender, EventArgs e)
        {
            XEMailCheckEMailsEventHandler evnt = EMailsCheckFinished;
            if (evnt != null)
            {
                EMailsCheckFinished(sender, e);
            }
        }

        void UpdateClientConfiguration()
        {
            UpdateClientConfiguration(true);
        }
        void UpdateClientConfiguration(bool Notify)
        {
            if (configurationObject.WebserviceUrl != string.Empty)
            {
                prxy.Url = configurationObject.WebserviceUrl;
            }
            if (configurationObject.NetworkProxy.Enabled)
            {
                this.prxy.Proxy = new WebProxy(configurationObject.NetworkProxy.Url, configurationObject.NetworkProxy.Port);
                NetworkCredential creds = new System.Net.NetworkCredential(configurationObject.NetworkProxy.User, configurationObject.NetworkProxy.Password, configurationObject.NetworkProxy.Domain);
                this.prxy.Proxy.Credentials = creds;
            }

            if (Notify)
            {
                NotifyConfigurationChanged();
            }

        }

        private void NotifyConfigurationChanged()
        {
            if (ConfigurationChanged != null)
            {
                ConfigurationChanged(this, new EventArgs());
            }
        }

        #endregion
    }
}
