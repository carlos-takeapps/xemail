using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace BAFactory.XEMail.ServiceClient
{
    [Serializable]
    public class XEMailAccount
    {
        private int id;
        private string accountName;
        private ServerConfiguration incomingServer;
        private ServerConfiguration outgoingServer;
        private bool useSameCredentialsToSend;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string AccountName
        {
            get { return accountName; }
            set { accountName = value; }
        }
        internal ServerConfiguration IncomingServer
        {
            get { return incomingServer; }
            set { incomingServer = value; }
        }
        internal ServerConfiguration OutgoingServer
        {
            get { return outgoingServer; }
            set { outgoingServer = value; }
        }
        public bool UseSameCredentialsToSend
        {
            get { return useSameCredentialsToSend; }
            set { useSameCredentialsToSend = value; }
        }

        public bool SendEnabled
        {
            get { return outgoingServer.ServerEnabled; }
        }

        public XEMailAccount() { }
        public XEMailAccount(string AccountName)
        {
            this.AccountName = AccountName;
        }
    }

    public class XEMailAccountCollection : Dictionary<string, XEMailAccount>
    {
        public XEMailAccountCollection() : base() { }

        public DataTable GetTableForDataSource()
        {
            DataTable result = new DataTable();

            DataColumn colId = new DataColumn("ID", typeof(int));
            colId.AutoIncrement = true;
            result.Columns.Add(colId);
            result.PrimaryKey = new DataColumn[1] { colId };

            DataColumn colAccount = new DataColumn("AccountName", typeof(string));
            colAccount.DefaultValue = "new@account";
            colAccount.Unique = true;
            result.Columns.Add(colAccount);

            DataColumn colSameCredentials = new DataColumn("useSameCredentialsToSend", typeof(bool));
            colSameCredentials.DefaultValue = true;
            result.Columns.Add(colSameCredentials);

            DataColumn colIncEnabled = new DataColumn("IncomingServerEnabled", typeof(bool));
            colIncEnabled.DefaultValue = false;
            result.Columns.Add(colIncEnabled);

            DataColumn colIncProtocol = new DataColumn("IncomingServerProtocol", typeof(string));
            colIncProtocol.DefaultValue = string.Empty;
            result.Columns.Add(colIncProtocol);

            DataColumn colIncServer = new DataColumn("IncomingServerName", typeof(string));
            colIncServer.DefaultValue = string.Empty;
            result.Columns.Add(colIncServer);

            DataColumn colIncPort = new DataColumn("IncomingServerPort", typeof(int));
            colIncPort.DefaultValue = 110;
            result.Columns.Add(colIncPort);

            DataColumn colIncUsername = new DataColumn("IncomingUserName", typeof(string));
            colIncUsername.DefaultValue = string.Empty;
            result.Columns.Add(colIncUsername);

            DataColumn colIncPassword = new DataColumn("IncomingUserPassword", typeof(string));
            colIncPassword.DefaultValue = string.Empty;
            result.Columns.Add(colIncPassword);

            DataColumn colIncSsl = new DataColumn("IncomingSslEnabled", typeof(bool));
            colIncSsl.DefaultValue = false;
            result.Columns.Add(colIncSsl);

            DataColumn colOutEnabled = new DataColumn("OutgoingServerEnabled", typeof(bool));
            colOutEnabled.DefaultValue = false;
            result.Columns.Add(colOutEnabled);

            DataColumn colOutProtocol = new DataColumn("OutgoingServerProtocol", typeof(string));
            colOutProtocol.DefaultValue = string.Empty;
            result.Columns.Add(colOutProtocol);

            DataColumn colOutServer = new DataColumn("OutgoingServerName", typeof(string));
            colOutServer.DefaultValue = string.Empty;
            result.Columns.Add(colOutServer);

            DataColumn colOutPort = new DataColumn("OutgoingServerPort", typeof(int));
            colOutPort.DefaultValue = 25;
            result.Columns.Add(colOutPort);

            DataColumn colOutUsername = new DataColumn("OutgoingUserName", typeof(string));
            colOutUsername.DefaultValue = string.Empty;
            result.Columns.Add(colOutUsername);

            DataColumn colOutPassword = new DataColumn("OutgoingUserPassword", typeof(string));
            colOutPassword.DefaultValue = string.Empty;
            result.Columns.Add(colOutPassword);

            DataColumn colOutSsl = new DataColumn("OutgoingSslEnabled", typeof(bool));
            colOutSsl.DefaultValue = false;
            result.Columns.Add(colOutSsl);

            foreach (string key in this.Keys)
            {
                DataRow dr = result.NewRow();

                dr["AccountName"] = this[key].AccountName;
                dr["UseSameCredentialsToSend"] = this[key].UseSameCredentialsToSend;

                dr["IncomingServerEnabled"] = this[key].IncomingServer.ServerEnabled;
                dr["IncomingServerProtocol"] = this[key].IncomingServer.ServerProtocol;
                dr["IncomingServerName"] = this[key].IncomingServer.ServerName;
                dr["IncomingServerPort"] = this[key].IncomingServer.ServerPort;
                dr["IncomingUserName"] = this[key].IncomingServer.Username;
                dr["IncomingUserPassword"] = this[key].IncomingServer.UserPassword;
                dr["IncomingSslEnabled"] = this[key].IncomingServer.SslEnabled;

                dr["OutgoingServerEnabled"] = this[key].OutgoingServer.ServerEnabled;
                dr["OutgoingServerProtocol"] = this[key].OutgoingServer.ServerProtocol;
                dr["OutgoingServerName"] = this[key].OutgoingServer.ServerName;
                dr["OutgoingServerPort"] = this[key].OutgoingServer.ServerPort;
                dr["OutgoingUserName"] = this[key].OutgoingServer.Username;
                dr["OutgoingUserPassword"] = this[key].OutgoingServer.UserPassword;
                dr["OutgoingSslEnabled"] = this[key].OutgoingServer.SslEnabled;

                result.Rows.Add(dr);
            }

            return result;
        }

        public bool LoadAccountsFromTable(DataTable Accounts)
        {
            bool result = false;

            foreach (DataRow dr in Accounts.Rows)
            {
                string key = dr["AccountName"].ToString();

                if (!this.ContainsKey(key))
                {
                    XEMailAccount newAccount = new XEMailAccount();
                    this.Add(key, newAccount);
                }

                this[key].Id = int.Parse(dr["id"].ToString());
                this[key].AccountName = dr["AccountName"].ToString();
                this[key].UseSameCredentialsToSend = bool.Parse(dr["useSameCredentialsToSend"].ToString());

                this[key].IncomingServer = new ServerConfiguration();
                this[key].IncomingServer.ServerEnabled = bool.Parse(dr["IncomingServerEnabled"].ToString());
                this[key].IncomingServer.ServerProtocol = (ServerProtocol)Enum.ToObject(typeof(ServerProtocol), 1);
                this[key].IncomingServer.ServerName = dr["IncomingServerName"].ToString();
                this[key].IncomingServer.ServerPort = int.Parse(dr["IncomingServerPort"].ToString());
                this[key].IncomingServer.Username = dr["IncomingUserName"].ToString();
                this[key].IncomingServer.UserPassword = dr["IncomingUserPassword"].ToString();
                this[key].IncomingServer.SslEnabled = bool.Parse(dr["IncomingSslEnabled"].ToString());

                this[key].OutgoingServer = new ServerConfiguration();
                this[key].OutgoingServer.ServerEnabled = bool.Parse(dr["OutgoingServerEnabled"].ToString());
                this[key].OutgoingServer.ServerProtocol = (ServerProtocol)Enum.ToObject(typeof(ServerProtocol), 1);
                this[key].OutgoingServer.ServerName = dr["OutgoingServerName"].ToString();
                this[key].OutgoingServer.ServerPort = int.Parse(dr["OutgoingServerPort"].ToString());
                this[key].OutgoingServer.Username = dr["OutgoingUserName"].ToString();
                this[key].OutgoingServer.UserPassword = dr["OutgoingUserPassword"].ToString();
                this[key].OutgoingServer.SslEnabled = bool.Parse(dr["OutgoingSslEnabled"].ToString());
            }
            string[] keys = new string[this.Keys.Count];
            this.Keys.CopyTo(keys, 0);
            foreach (string key in keys)
            {
                if (Accounts.Select(string.Format("AccountName = '{0}'", key)).Length == 0)
                {
                    this.Remove(key);
                }
            }
            result = true;
            return result;
        }
    }
}
