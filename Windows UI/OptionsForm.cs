using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using BAFactory.XEMail.Windows;
using BAFactory.XEMail.ServiceClient;

namespace BAFactory.XEMail.Windows
{
    internal partial class OptionsForm : Form
    {
        private XEMailClientConfiguration configObj;
        internal XEMailClientConfiguration Configuration
        {
            get { return configObj; }
            set { configObj = value; }
        }

        internal OptionsForm(XEMailClientConfiguration Config)
        {
            InitializeComponent();

            this.configObj = Config;      
            
            BindControls();
        }

        private void BindControls()
        {
            // Accounts Config
            BindingSource bs = new BindingSource();
            DataTable tempDataTable = this.configObj.Accounts.GetTableForDataSource();
            bs.DataSource = tempDataTable;
            if (tempDataTable.Rows.Count == 0)
            {
                DataRow newRow = tempDataTable.NewRow();
                tempDataTable.Rows.Add(newRow);
            }
            this.bindingNavigator1.BindingSource = bs;

            this.tbAccountName.DataBindings.Add("Text", bs, "AccountName");
            this.cbSameCredentials.DataBindings.Add("Checked", bs, "useSameCredentialsToSend");

            // Incoming Server Configuration
            this.scAccountConfig.Panel1.DataBindings.Add("Enabled", cbIncomingEnabled, "Checked");
            this.cbIncomingEnabled.DataBindings.Add("Checked", bs, "IncomingServerEnabled");
            //this.cbIncomingProtocol.DataBindings.Add("SelectedIndex", bs, "IncomingServerProtocol");
            this.tbIncomingServerName.DataBindings.Add("Text", bs, "IncomingServerName");
            this.tbIncomingServerPort.DataBindings.Add("Text", bs, "IncomingServerPort");
            this.tbIncomingUserName.DataBindings.Add("Text", bs, "IncomingUserName");
            this.tbIncomingUserPassword.DataBindings.Add("Text", bs, "IncomingUserPassword");
            this.cbIncomingSslEnabled.DataBindings.Add("Checked", bs, "IncomingSslEnabled");

            // Outgoing Server Configuration
            this.scAccountConfig.Panel2.DataBindings.Add("Enabled", cbOutgoingEnabled, "Checked");
            this.cbOutgoingEnabled.DataBindings.Add("Checked", bs, "OutgoingServerEnabled");
            //this.cbOutgoingProtocol.DataBindings.Add("SelectedIndex", bs, "OutgoingServerProtocol");
            this.tbOutgoingServerName.DataBindings.Add("Text", bs, "OutgoingServerName");
            this.tbOutgoingServerPort.DataBindings.Add("Text", bs, "OutgoingServerPort");
            this.tbOutgoingUserName.DataBindings.Add("Text", bs, "OutgoingUserName");
            this.tbOutgoingUserPassword.DataBindings.Add("Text", bs, "OutgoingUserPassword");
            this.cbOutgoingSslEnabled.DataBindings.Add("Checked", bs, "OutgoingSslEnabled");

            this.tbOutgoingUserName.DataBindings.Add("Enabled", cbSameCredentials, "Checked");
            this.tbOutgoingUserPassword.DataBindings.Add("Enabled", cbSameCredentials, "Checked");
            
            // Program config
            this.cbAutoCheck.DataBindings.Add("Checked", this.configObj, "AutoCheckEnabled");
            this.nupInterval.DataBindings.Add("Value", this.configObj, "CheckInterval");
            this.tbServiceUrl.DataBindings.Add("Text", this.configObj, "WebserviceUrl");

            // Network Config
            this.cbNetProxyEnabled.DataBindings.Add("Checked", this.configObj, "NetworkProxy.Enabled");
            this.gbNetProxy.DataBindings.Add("Enabled", cbNetProxyEnabled, "Checked");
            this.tbNetProxyUrl.DataBindings.Add("Text", this.configObj, "NetworkProxy.Url");
            this.tbNetProxyPort.DataBindings.Add("Text", this.configObj, "NetworkProxy.Port");
            this.tbNetProxyUser.DataBindings.Add("Text", this.configObj, "NetworkProxy.User");
            this.tbNetProxyDomain.DataBindings.Add("Text", this.configObj, "NetworkProxy.Domain");
            this.tbNetProxyPass.DataBindings.Add("Text", this.configObj, "NetworkProxy.Password");
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DataTable table = (DataTable)this.bindingNavigator1.BindingSource.DataSource;
            DataRowView dr = (DataRowView)this.bindingNavigator1.BindingSource.Current;
            if (dr != null)
            {
                dr.EndEdit();
            }

            this.configObj.Accounts.LoadAccountsFromTable(table);
        }

        private void btnDefaultUrl_Click(object sender, EventArgs e)
        {
            this.configObj.WebserviceUrl  = this.tbServiceUrl.Text = "http://webservices.siprod.net/xemail.asmx";
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (((DataTable)this.bindingNavigator1.BindingSource.DataSource).Rows.Count == 0)
            {
                tbAccountName.Enabled = true;
                cbIncomingEnabled.Enabled = true;
                cbOutgoingEnabled.Enabled = true;
            }
        }
    }
}