using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.IsolatedStorage;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

using BAFactory.Fx.Network.Email;
using BAFactory.Fx.Utilities.Encoding;
using BAFactory.XEMail.ServiceClient;

namespace BAFactory.XEMail.Windows
{
    public partial class MainForm : Form
    {
        private XEMailClient client;
        private DataTable emailsTable;
        private int lastCount;
        private Icon noNewMessages;
        private Icon NewMessages;
        private static List<string> debugInfo;
        private static int bugCount;
        private static string tsmiViewDebugText;
        private static bool minimized;
        private bool displayWindow;

        private const string defaultConfigFile = "XEMailConfig.xml";

        private bool enabled;

        public MainForm()
        {
            //ValidateUser();
            InitializeComponent();
            InitializeObjects();
            ImportConfiguration(ConfigFileLocationOptions.IsolatedStorage, defaultConfigFile);
            BindDataGrid();
            BindAccountsList();
        }
        static MainForm()
        {
            bugCount = 0;
            debugInfo = new List<string>();
            SettsmiDebugInfoText("View &Debug");
        }

        internal static void AddDebugInfo(string[] NewDebugInfo)
        {
            debugInfo.Add(string.Empty);

            debugInfo.Add(string.Concat((++bugCount).ToString(), " ---> New Info: ", DateTime.Now));
            debugInfo.Add("--------------------------------------------------");

            foreach (string line in NewDebugInfo)
            {
                debugInfo.Add(line);
            }
            SettsmiDebugInfoText("View &Debug !!!");
        }

        internal static void ClearDebugInfo()
        {
            debugInfo = new List<string>();
            SettsmiDebugInfoText("View &Debug");
        }

        internal static void SettsmiDebugInfoText(string text)
        {
            tsmiViewDebugText = text;
        }

        private void InitializeObjects()
        {
            client = new XEMailClient();
            AccountChecksTimer = new Timer();
            AccountChecksTimer.Tick += new EventHandler(AccountChecksTimer_Tick);
            client.EMailsCheckFinished += new XEMailCheckEMailsEventHandler(CheckEMailsEnded);
            client.ConfigurationChanged += new XEMailClientConfigChangedEventHandler(ClientConfigurationChanged);
            this.MaximizeBox = false;
            lastCount = 0;
            displayWindow = true;
            noNewMessages = ApplicationNotifyIcon.Icon;
            NewMessages = SystemIcons.Information;
        }

        private void BindDataGrid()
        {
            this.dgEMailsList.AutoGenerateColumns = false;
            this.dgEMailsList.CellFormatting += new DataGridViewCellFormattingEventHandler(dgEMailsList_CellFormatting);

            this.dgEMailsList.Columns["AccountName"].DataPropertyName = "AccountName";
            this.dgEMailsList.Columns["Priority"].DataPropertyName = "Priority";
            this.dgEMailsList.Columns["From"].DataPropertyName = "From";
            this.dgEMailsList.Columns["Number"].DataPropertyName = "Number";
            this.dgEMailsList.Columns["Subject"].DataPropertyName = "Subject";
            this.dgEMailsList.Columns["Bytes"].DataPropertyName = "Bytes";
            this.dgEMailsList.Columns["Received"].DataPropertyName = "Date";
            this.dgEMailsList.Columns["Received"].ValueType = typeof(DateTime);

            this.dgEMailsList.DataSource = this.emailsTable;
            this.dgEMailsList.Sort(this.dgEMailsList.Columns["Received"], ListSortDirection.Descending);
        }

        private void ImportConfiguration()
        {
            ImportConfiguration(ConfigFileLocationOptions.IsolatedStorage, defaultConfigFile);
        }
        private void ImportConfiguration(ConfigFileLocationOptions Location, string Path)
        {
            Stream strm = null;
            try
            {
                strm = GetLocationStream(Location, Path, FileMode.Open);
                if (strm != null && strm.CanRead)
                {
                    LoadConfiguration(strm);
                }
            }
            catch
            {
                return;
            }
            finally
            {
                if (strm != null)
                    strm.Close();
            }
        }

        private void ExportConfiguration()
        {
            ExportConfiguration(ConfigFileLocationOptions.IsolatedStorage, defaultConfigFile);
        }
        private void ExportConfiguration(ConfigFileLocationOptions Location, string Path)
        {
            Stream strm = null;
            try
            {
                strm = GetLocationStream(Location, Path, FileMode.Create);
                if (strm != null && strm.CanWrite)
                {
                    SaveConfiguration(strm);
                }
            }
            catch
            {
                return;
            }
            finally
            {
                if (strm != null)
                    strm.Close();
            }
        }

        private void LoadConfiguration(Stream ReadingStream)
        {
            if (ReadingStream == null || !ReadingStream.CanRead)
            {
                return;
            }
            XmlTextReader xr = new XmlTextReader(ReadingStream);
            XmlDocument doc = new XmlDocument();
            doc.Load(xr);
            client.ConfigurationObject.ImportConfigurationFromXml(doc);
            if (xr != null)
            {
                xr.Close();
            }
        }

        private void SaveConfiguration(Stream WrittingStream)
        {
            XmlTextWriter xr = new XmlTextWriter(WrittingStream, Encoding.UTF8);
            xr.Indentation = 3;
            client.ConfigurationObject.ExportConfigurationToXml().Save(xr);
            xr.Close();
        }

        private void BindAccountsList()
        {
            this.ddAccountFilter.TextChanged += new EventHandler(ddAccountFilter_TextChanged);

            this.ddAccountFilter.DropDown.Items.Clear();

            ToolStripMenuItem btn = new ToolStripMenuItem();
            btn.Text = "(all accounts)";
            btn.Click += new EventHandler(ddAccountFilter_Click);
            this.ddAccountFilter.DropDown.Items.Add(btn);

            foreach (string key in client.ConfigurationObject.Accounts.Keys)
            {
                btn = new ToolStripMenuItem();
                btn.Text = key;
                btn.Click += new EventHandler(ddAccountFilter_Click);
                this.ddAccountFilter.DropDown.Items.Add(btn);
            }

            this.ddSendEmailFromAccount.DropDown.Items.Clear();

            ddSendEmailFromAccount.Enabled = false;
            foreach (XEMailAccount account in client.ConfigurationObject.Accounts.Values)
            {
                if (!account.SendEnabled)
                {
                    continue;
                }
                btn = new ToolStripMenuItem();
                btn.Text = account.AccountName;
                btn.Click += new EventHandler(ddSendEmailFromAccount_Click);
                this.ddSendEmailFromAccount.DropDown.Items.Add(btn);
                ddSendEmailFromAccount.Enabled = true;
            }

        }

        private void StartEmailsCheck()
        {
            StartEmailsCheck(true);
        }
        private void StartEmailsCheck(bool DoAsync)
        {
            tsProgressBar.Visible = true;
            this.tsbCheckEMails.Enabled = false;
            this.tsbCancelCheck.Enabled = true;
            this.dgEMailsList.Enabled = false;
            this.ddAccountFilter.Enabled = false;

            if (DoAsync)
                client.BeginRetrieveAllAccountsEMailsHeaders();
            else
                client.RetrieveAllAccountsEMailsHeaders();
        }

        private void CancelEmailsCheck()
        {
            client.CancelAllRequests();
            tsProgressBar.Visible = false;
            this.tsbCheckEMails.Enabled = true;
            this.tsbCancelCheck.Enabled = false;
            this.dgEMailsList.Enabled = true;
            this.ddAccountFilter.Enabled = true;
        }

        private void SetIcon(bool HasNewMessages)
        {
            if (HasNewMessages)
            {
                ApplicationNotifyIcon.Icon = NewMessages;
                ApplicationNotifyIcon.BalloonTipText = "You have new Emails";
                ApplicationNotifyIcon.BalloonTipTitle = "New Emails";
                ApplicationNotifyIcon.BalloonTipIcon = ToolTipIcon.Info;

                ApplicationNotifyIcon.ShowBalloonTip(10000);
            }
            else
            {
                ApplicationNotifyIcon.Icon = noNewMessages;
            }
        }

        private void ShowReadingEMailForm(int MessageNumber, string AccountId)
        {
            EMailMessage email = client.RetrieveEMail(AccountId, MessageNumber);
            ShowReadingEMailForm(email, AccountId, MessageNumber);
        }
        private void ShowReadingEMailForm(EMailMessage Message, string AccountId, int MessageNumber)
        {
            if (Message == null)
            {
                MessageBox.Show("There was an error retrieving the email.");
                return;
            }

            ReadingForm rForm = new ReadingForm(Message, client.ConfigurationObject.Accounts[AccountId].SendEnabled);
            DialogResult dr = rForm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                MessageActions action = rForm.Action;
                if (action == MessageActions.Delete)
                {
                    DeleteMessage(AccountId, MessageNumber);
                    return;
                }

                ShowWritingEMailForm(Message, AccountId, action);
            }
            SetDataGridFocus();
        }

        private void ShowWritingEMailForm(int MessageNumber, string AccountId, MessageActions Action)
        {
            EMailMessage email = client.RetrieveEMail(AccountId, MessageNumber);
            ShowWritingEMailForm(email, AccountId, Action);
        }
        private void ShowWritingEMailForm(EMailMessage Message, string AccountId, MessageActions Action)
        {
            if (Message == null)
            {
                MessageBox.Show("There was an error retrieving the email.");
                return;
            }

            WritingForm wForm = new WritingForm(Message, Action, AccountId);
            DialogResult dResult = wForm.ShowDialog();
            if (dResult == DialogResult.OK)
            {
                client.SendEMail(AccountId, wForm.Message);
            }
            SetDataGridFocus();
        }

        # region Clien Events Handlers

        private void CheckEMailsEnded(object sender, EventArgs e)
        {
            tsProgressBar.Visible = false;
            this.tsbCheckEMails.Enabled = true;
            this.tsbCancelCheck.Enabled = false;
            this.dgEMailsList.Enabled = true;
            this.ddAccountFilter.Enabled = true;

            emailsTable = client.XEMailsDS.Tables[0];
            BindDataGrid();

            if (emailsTable.Rows.Count > lastCount)
            {
                SetIcon(true);
            }
            lastCount = emailsTable.Rows.Count;

            SetDataGridFocus();
        }

        private void ClientConfigurationChanged(object sender, EventArgs e)
        {
            this.AccountChecksTimer.Enabled = this.client.ConfigurationObject.AutoCheckEnabled;
            this.AccountChecksTimer.Interval = this.client.ConfigurationObject.CheckInterval * 60000;

            if (this.AccountChecksTimer.Enabled)
            {
                this.AccountChecksTimer.Start();
            }
            this.tsmiToolsAutocheck.Checked = this.client.ConfigurationObject.AutoCheckEnabled;
            BindAccountsList();
        }

        # endregion

        #region Controls Events Handlers

        #region MainForm
        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                this.displayWindow = false;
            }
        }

        protected override void OnShown(EventArgs e)
        {
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ExportConfiguration();
            this.client.CancelAllRequests();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ApplicationNotifyIcon.Visible = false;
            ApplicationNotifyIcon.Dispose();
        }
        #endregion

        #region DataGrid Events Handlers
        private void dgEMailsList_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.dgEMailsList.Rows[e.RowIndex].Selected = true;
            }
        }

        private void dgEMailsList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null)
            {
                switch (dgEMailsList.Columns[e.ColumnIndex].Name)
                {
                    case "Priority":
                        switch (e.Value.ToString())
                        {
                            case "High":
                                e.Value = "!";
                                break;
                            case "Low":
                                e.Value = "*";
                                break;
                            case "Normal":
                                e.Value = string.Empty;
                                break;
                        }
                        break;
                    case "From":
                        Regex rxNameAddress = new Regex("<.*>$");
                        Match matchNameAddress = rxNameAddress.Match(e.Value.ToString());
                        if (matchNameAddress.Success)
                        {
                            string nombre = e.Value.ToString().Remove(matchNameAddress.Index - 1);

                            e.Value = XEMailMessagesHandler.GetUTF8DecodedText(nombre);
                        }
                        ((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].ToolTipText = matchNameAddress.Value;
                        break;
                    case "Subject":
                        try
                        {
                            e.Value = XEMailMessagesHandler.GetUTF8DecodedText(e.Value.ToString());
                        }
                        catch (EncodingException ex)
                        {
                            e.Value = ex.OriginalText;
                            string debugText = string.Format("Message: {0}{4}Original Text: {3}{4}Source: {1}{4}Stack Trace: {2}", ex.Message, ex.Source, ex.StackTrace, ex.OriginalText, System.Environment.NewLine);
                            MainForm.AddDebugInfo(new string[] { debugText });
                        }
                        break;
                }
            }
        }

        private void dgEMailsList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int messageNum = int.Parse(dgEMailsList.Rows[e.RowIndex].Cells["Number"].Value.ToString());
            string AccountId = dgEMailsList.Rows[e.RowIndex].Cells["AccountName"].Value.ToString();

            ShowReadingEMailForm(messageNum, AccountId);
        }

        private void dgEMailsList_Sorted(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgvr in dgEMailsList.Rows)
            {
                dgvr.ContextMenuStrip = this.MessagesContextMenuStrip;
            }
        }

        private void dgEMailsList_KeyUp(object sender, KeyEventArgs e)
        {
            if (dgEMailsList.SelectedRows.Count < 1)
            {
                return;
            }
            DataGridViewRow row = dgEMailsList.SelectedRows[0];

            string AccountId = row.Cells["AccountName"].Value.ToString();
            int msgNmbr = int.Parse(row.Cells["Number"].Value.ToString());

            switch (e.KeyCode)
            {
                case Keys.Delete:
                    DeleteMessage(AccountId, msgNmbr);
                    break;
                case Keys.Enter:
                    ShowReadingEMailForm(msgNmbr, AccountId);
                    break;
            }
        }

        private void dgEMailsList_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Delete:
                    e.Handled = true;
                    break;
                case Keys.Enter:
                    e.Handled = true;
                    break;
            }
        }

        #endregion

        #region ToolStrip Controls Events Handlers
        private void tsbCheckEMails_Click(object sender, EventArgs e)
        {
            if (this.client.ConfigurationObject.Accounts.Keys.Count == 0)
            {
                return;
            }
            StartEmailsCheck();
        }

        private void tbsCancelCheck_Click(object sender, EventArgs e)
        {
            if (this.client.ConfigurationObject.Accounts.Keys.Count == 0)
            {
                return;
            }
            CancelEmailsCheck();
        }

        private void tsmiFileExit_Click(object sender, EventArgs e)
        {
            this.ExportConfiguration();
            this.Close();
        }

        private void tsmiConfigurationExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = "XML file (*.xml)|*.xml";
            fd.AddExtension = true;
            //fd.AutoUpgradeEnabled = true;
            fd.CheckFileExists = false;
            fd.CheckPathExists = true;
            fd.FileName = defaultConfigFile;
            fd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            fd.Title = "Export Configuration";
            DialogResult sfdResult = fd.ShowDialog();
            if (sfdResult == DialogResult.OK)
            {
                FileInfo fi = new FileInfo(fd.FileName);
                if (!Directory.Exists(fi.Directory.ToString()))
                {
                    return;
                }
                ExportConfiguration(ConfigFileLocationOptions.FileSystem, fd.FileName);
            }
        }

        private void tsmiConfigurationImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "XML file (*.xml)|*.xml";
            fd.CheckFileExists = true;
            fd.CheckPathExists = true;
            fd.FileName = defaultConfigFile;
            fd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            fd.Title = "Import Configuration";
            DialogResult opdResult = fd.ShowDialog();
            if (opdResult == DialogResult.OK)
            {
                FileInfo fi = new FileInfo(fd.FileName);
                {
                    if (!fi.Exists)
                    {
                        return;
                    }
                    ImportConfiguration(ConfigFileLocationOptions.FileSystem, fd.FileName);
                }
            }
        }

        private void tsmiToolsOptions_Click(object sender, EventArgs e)
        {
            XEMailClientConfiguration tmpConfig = client.ConfigurationObject.Clone();
            OptionsForm optionsDlg = new OptionsForm(tmpConfig);

            DialogResult result = optionsDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                client.ConfigurationObject = optionsDlg.Configuration;
                ExportConfiguration();
            }
        }

        private void tsmiToolsAutocheck_CheckedChanged(object sender, EventArgs e)
        {
            this.client.ConfigurationObject.AutoCheckEnabled = ((ToolStripMenuItem)sender).Checked;
        }

        private void tsmiToolsAutocheck_Click(object sender, EventArgs e)
        {
            ((ToolStripMenuItem)sender).Checked = !((ToolStripMenuItem)sender).Checked;
        }

        private void tsmiRemoveCurrentConfig_Click(object sender, EventArgs e)
        {
            RemoveConfigurationFile();
        }

        private void tsmiHelp_Click(object sender, EventArgs e)
        {
            tsmiViewDebug.Text = MainForm.tsmiViewDebugText;
        }

        private void tsmiViewDebug_Click(object sender, EventArgs e)
        {
            ErrorForm err = new ErrorForm(debugInfo);
            DialogResult goOn = err.ShowDialog();
            SettsmiDebugInfoText("View &Debug");
        }
        #endregion

        #region Configuration Methods
        private void RemoveConfigurationFile()
        {
            IsolatedStorageFile isf = IsolatedStorageFile.GetUserStoreForDomain();
            if (isf != null)
            {
                try
                {
                    isf.DeleteFile(defaultConfigFile);
                }
                finally
                {
                    isf.Close();
                    isf = null;
                }
            }
        }
        #endregion

        private void ApplicationNotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SetIcon(false);
            displayWindow = !(displayWindow);

            if (displayWindow)
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
                //this.Visible = true;
                this.BringToFront();
            }
            else
            {
                //this.Visible = false;
                this.Hide();
            }
        }

        private void AccountChecksTimer_Tick(object sender, EventArgs e)
        {
            StartEmailsCheck();
        }

        private void MessagesContextMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            DataGridViewRow row = dgEMailsList.SelectedRows[0];

            string AccountId = row.Cells["AccountName"].Value.ToString();
            int msgNmbr = int.Parse(row.Cells["Number"].Value.ToString());
            EMailMessage email = null;
            RawViewForm headerForm = null;

            switch (e.ClickedItem.Name)
            {
                case "ViewRawHeaderStripMenuItem":
                    headerForm = new RawViewForm();
                    DataRow[] dr = emailsTable.Select(string.Format(@"AccountName = '{0}' and Number = {1}", AccountId, msgNmbr));
                    headerForm.RawViewText = dr[0]["Headers"].ToString();
                    headerForm.ShowDialog();
                    break;
                case "ViewRawEmailStripMenuItem":
                    headerForm = new RawViewForm();
                    headerForm.RawViewText = client.RetrieveRawEMail(AccountId, msgNmbr);
                    headerForm.ShowDialog();
                    break;
                case "DeleteEMailToolStripMenuItem":
                    DeleteMessage(AccountId, msgNmbr);
                    break;
                case "ReplyToolStripMenuItem":
                    email = client.RetrieveEMail(AccountId, msgNmbr);
                    ShowWritingEMailForm(email, AccountId, MessageActions.Reply);
                    break;
                case "ReplyAllToolStripMenuItem":
                    email = client.RetrieveEMail(AccountId, msgNmbr);
                    ShowWritingEMailForm(email, AccountId, MessageActions.ReplyAll);
                    break;
                case "ForwardToolStripMenuItem":
                    email = client.RetrieveEMail(AccountId, msgNmbr);
                    ShowWritingEMailForm(email, AccountId, MessageActions.Forward);
                    break;
                case "ViewEmailToolStripMenuItem":
                    ShowReadingEMailForm(msgNmbr, AccountId);
                    break;
                default:
                    break;
            }
        }

        private void ddAccountFilter_Click(object sender, EventArgs e)
        {
            this.ddAccountFilter.Text = ((ToolStripMenuItem)sender).Text;
        }

        private void ddSendEmailFromAccount_Click(object sender, EventArgs e)
        {
            string accountId = ((ToolStripMenuItem)sender).Text;
            EMailMessage message = new EMailMessage();
            message.Body = new EMailBodyAlternateView();
            message.Body.ContentStream = "!!!";
            ShowWritingEMailForm(message, accountId, MessageActions.Compose);

        }

        private void ddAccountFilter_TextChanged(object sender, EventArgs e)
        {
            string filterStrg = string.Empty;
            if (((ToolStripDropDownButton)sender).Text != "(all accounts)")
            {
                filterStrg = string.Format("AccountName = '{0}'", ((ToolStripDropDownButton)sender).Text);
            }
            ((DataTable)this.dgEMailsList.DataSource).DefaultView.RowFilter = filterStrg;
        }

        private void SetDataGridFocus()
        {
            dgEMailsList.Focus();
        }

        #endregion

        #region Local Message's Methods
        private void DeleteMessage(string AccountId, int msgNmbr)
        {
            DialogResult answer = MessageBox.Show(string.Format("Are you sure you want to delete email {0}?", msgNmbr), "!", MessageBoxButtons.YesNo);
            if (answer == DialogResult.Yes)
            {
                client.DeleteEMail(AccountId, msgNmbr);
                StartEmailsCheck();
            }
        }
        #endregion

        #region Other Methods
        private Stream GetLocationStream(ConfigFileLocationOptions Location, String FilePath, FileMode Mode)
        {
            Stream result = null;
            if (Location == ConfigFileLocationOptions.IsolatedStorage && !Path.IsPathRooted(FilePath))
            {
                result = new IsolatedStorageFileStream(FilePath, Mode);
            }
            else if (Location == ConfigFileLocationOptions.FileSystem)
            {
                result = new FileStream(FilePath, FileMode.OpenOrCreate);
            }
            return result;
        }
        #endregion

        private enum ConfigFileLocationOptions
        {
            FileSystem,
            IsolatedStorage
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }
    }

    public enum MessageActions
    {
        Compose,
        Delete,
        Reply,
        ReplyAll,
        Forward,
        DoNothing
    }
}