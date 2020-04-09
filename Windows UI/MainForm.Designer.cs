namespace BAFactory.XEMail.Windows
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MainToolStrip = new System.Windows.Forms.ToolStrip();
            this.tsbCancelCheck = new System.Windows.Forms.ToolStripButton();
            this.tsbCheckEMails = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiFile = new System.Windows.Forms.ToolStripDropDownButton();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConfigurationImport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConfigurationExport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRemoveCurrentConfigFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTools = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiToolsOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiToolsAutocheck = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiViewDebug = new System.Windows.Forms.ToolStripMenuItem();
            this.ddSendEmailFromAccount = new System.Windows.Forms.ToolStripDropDownButton();
            this.MainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.ddAccountFilter = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiAllAccounts = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.dgEMailsList = new System.Windows.Forms.DataGridView();
            this.Priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.From = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bytes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Received = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MessagesContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ViewEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ReplyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReplyAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ForwardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.DeleteEMailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ViewRawHeaderStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewRawEmailStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ApplicationNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.AccountChecksTimer = new System.Windows.Forms.Timer(this.components);
            this.MainToolStrip.SuspendLayout();
            this.MainStatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEMailsList)).BeginInit();
            this.MessagesContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainToolStrip
            // 
            this.MainToolStrip.AllowMerge = false;
            this.MainToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.MainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCancelCheck,
            this.tsbCheckEMails,
            this.toolStripSeparator1,
            this.tsmiFile,
            this.tsmiTools,
            this.tsmiHelp,
            this.ddSendEmailFromAccount});
            this.MainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.MainToolStrip.Name = "MainToolStrip";
            this.MainToolStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MainToolStrip.Size = new System.Drawing.Size(859, 25);
            this.MainToolStrip.TabIndex = 5;
            this.MainToolStrip.Text = "toolStrip1";
            // 
            // tsbCancelCheck
            // 
            this.tsbCancelCheck.BackColor = System.Drawing.Color.Transparent;
            this.tsbCancelCheck.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCancelCheck.Enabled = false;
            this.tsbCancelCheck.Image = ((System.Drawing.Image)(resources.GetObject("tsbCancelCheck.Image")));
            this.tsbCancelCheck.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbCancelCheck.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancelCheck.Name = "tsbCancelCheck";
            this.tsbCancelCheck.Size = new System.Drawing.Size(23, 22);
            this.tsbCancelCheck.Text = "toolStripButton1";
            this.tsbCancelCheck.Click += new System.EventHandler(this.tbsCancelCheck_Click);
            // 
            // tsbCheckEMails
            // 
            this.tsbCheckEMails.BackColor = System.Drawing.Color.Transparent;
            this.tsbCheckEMails.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCheckEMails.Image = ((System.Drawing.Image)(resources.GetObject("tsbCheckEMails.Image")));
            this.tsbCheckEMails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbCheckEMails.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCheckEMails.Name = "tsbCheckEMails";
            this.tsbCheckEMails.Size = new System.Drawing.Size(23, 22);
            this.tsbCheckEMails.Text = "toolStripButton1";
            this.tsbCheckEMails.Click += new System.EventHandler(this.tsbCheckEMails_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsmiFile
            // 
            this.tsmiFile.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmiFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurationToolStripMenuItem,
            this.tsmiFileExit});
            this.tsmiFile.Image = ((System.Drawing.Image)(resources.GetObject("tsmiFile.Image")));
            this.tsmiFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tsmiFile.Size = new System.Drawing.Size(38, 22);
            this.tsmiFile.Text = "&File";
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiConfigurationImport,
            this.tsmiConfigurationExport,
            this.tsmiRemoveCurrentConfigFile});
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.configurationToolStripMenuItem.Text = "&Configuration";
            // 
            // tsmiConfigurationImport
            // 
            this.tsmiConfigurationImport.Name = "tsmiConfigurationImport";
            this.tsmiConfigurationImport.Size = new System.Drawing.Size(220, 22);
            this.tsmiConfigurationImport.Text = "&Import...";
            this.tsmiConfigurationImport.Click += new System.EventHandler(this.tsmiConfigurationImport_Click);
            // 
            // tsmiConfigurationExport
            // 
            this.tsmiConfigurationExport.Name = "tsmiConfigurationExport";
            this.tsmiConfigurationExport.Size = new System.Drawing.Size(220, 22);
            this.tsmiConfigurationExport.Text = "&Export...";
            this.tsmiConfigurationExport.Click += new System.EventHandler(this.tsmiConfigurationExport_Click);
            // 
            // tsmiRemoveCurrentConfigFile
            // 
            this.tsmiRemoveCurrentConfigFile.Name = "tsmiRemoveCurrentConfigFile";
            this.tsmiRemoveCurrentConfigFile.Size = new System.Drawing.Size(220, 22);
            this.tsmiRemoveCurrentConfigFile.Text = "&Remove Current Config File";
            this.tsmiRemoveCurrentConfigFile.Click += new System.EventHandler(this.tsmiRemoveCurrentConfig_Click);
            // 
            // tsmiFileExit
            // 
            this.tsmiFileExit.Name = "tsmiFileExit";
            this.tsmiFileExit.Size = new System.Drawing.Size(148, 22);
            this.tsmiFileExit.Text = "&Exit";
            this.tsmiFileExit.Click += new System.EventHandler(this.tsmiFileExit_Click);
            // 
            // tsmiTools
            // 
            this.tsmiTools.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmiTools.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsmiTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiToolsOptions,
            this.tsmiToolsAutocheck});
            this.tsmiTools.Image = ((System.Drawing.Image)(resources.GetObject("tsmiTools.Image")));
            this.tsmiTools.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiTools.Name = "tsmiTools";
            this.tsmiTools.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tsmiTools.Size = new System.Drawing.Size(49, 22);
            this.tsmiTools.Text = "&Tools";
            // 
            // tsmiToolsOptions
            // 
            this.tsmiToolsOptions.Name = "tsmiToolsOptions";
            this.tsmiToolsOptions.Size = new System.Drawing.Size(131, 22);
            this.tsmiToolsOptions.Text = "&Options...";
            this.tsmiToolsOptions.Click += new System.EventHandler(this.tsmiToolsOptions_Click);
            // 
            // tsmiToolsAutocheck
            // 
            this.tsmiToolsAutocheck.Name = "tsmiToolsAutocheck";
            this.tsmiToolsAutocheck.Size = new System.Drawing.Size(131, 22);
            this.tsmiToolsAutocheck.Text = "&Autocheck";
            this.tsmiToolsAutocheck.CheckedChanged += new System.EventHandler(this.tsmiToolsAutocheck_CheckedChanged);
            this.tsmiToolsAutocheck.Click += new System.EventHandler(this.tsmiToolsAutocheck_Click);
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmiHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout,
            this.tsmiViewDebug});
            this.tsmiHelp.Image = ((System.Drawing.Image)(resources.GetObject("tsmiHelp.Image")));
            this.tsmiHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tsmiHelp.Size = new System.Drawing.Size(45, 22);
            this.tsmiHelp.Text = "&Help";
            this.tsmiHelp.Click += new System.EventHandler(this.tsmiHelp_Click);
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(137, 22);
            this.tsmiAbout.Text = "&About";
            // 
            // tsmiViewDebug
            // 
            this.tsmiViewDebug.Name = "tsmiViewDebug";
            this.tsmiViewDebug.Size = new System.Drawing.Size(137, 22);
            this.tsmiViewDebug.Text = "View &Debug";
            this.tsmiViewDebug.Click += new System.EventHandler(this.tsmiViewDebug_Click);
            // 
            // ddSendEmailFromAccount
            // 
            this.ddSendEmailFromAccount.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ddSendEmailFromAccount.Enabled = false;
            this.ddSendEmailFromAccount.Image = ((System.Drawing.Image)(resources.GetObject("ddSendEmailFromAccount.Image")));
            this.ddSendEmailFromAccount.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ddSendEmailFromAccount.Name = "ddSendEmailFromAccount";
            this.ddSendEmailFromAccount.Size = new System.Drawing.Size(29, 22);
            this.ddSendEmailFromAccount.Text = "toolStripButton1";
            // 
            // MainStatusStrip
            // 
            this.MainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ddAccountFilter,
            this.toolStripStatusLabel1,
            this.tsProgressBar});
            this.MainStatusStrip.Location = new System.Drawing.Point(0, 239);
            this.MainStatusStrip.Name = "MainStatusStrip";
            this.MainStatusStrip.ShowItemToolTips = true;
            this.MainStatusStrip.Size = new System.Drawing.Size(859, 22);
            this.MainStatusStrip.SizingGrip = false;
            this.MainStatusStrip.TabIndex = 6;
            this.MainStatusStrip.Text = "statusStrip1";
            // 
            // ddAccountFilter
            // 
            this.ddAccountFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ddAccountFilter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAllAccounts});
            this.ddAccountFilter.Image = ((System.Drawing.Image)(resources.GetObject("ddAccountFilter.Image")));
            this.ddAccountFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ddAccountFilter.Name = "ddAccountFilter";
            this.ddAccountFilter.Size = new System.Drawing.Size(108, 20);
            this.ddAccountFilter.Text = "Filter by account";
            // 
            // tsmiAllAccounts
            // 
            this.tsmiAllAccounts.Name = "tsmiAllAccounts";
            this.tsmiAllAccounts.Size = new System.Drawing.Size(145, 22);
            this.tsmiAllAccounts.Text = "(all accounts)";
            this.tsmiAllAccounts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.AutoToolTip = true;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(75, 17);
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tsProgressBar
            // 
            this.tsProgressBar.Enabled = false;
            this.tsProgressBar.MarqueeAnimationSpeed = 50;
            this.tsProgressBar.Name = "tsProgressBar";
            this.tsProgressBar.Size = new System.Drawing.Size(100, 16);
            this.tsProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.tsProgressBar.Visible = false;
            // 
            // dgEMailsList
            // 
            this.dgEMailsList.AllowUserToAddRows = false;
            this.dgEMailsList.AllowUserToDeleteRows = false;
            this.dgEMailsList.AllowUserToResizeRows = false;
            this.dgEMailsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgEMailsList.BackgroundColor = System.Drawing.Color.White;
            this.dgEMailsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgEMailsList.CausesValidation = false;
            this.dgEMailsList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgEMailsList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgEMailsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgEMailsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Priority,
            this.AccountName,
            this.Number,
            this.From,
            this.Subject,
            this.Bytes,
            this.Received});
            this.dgEMailsList.ContextMenuStrip = this.MessagesContextMenuStrip;
            this.dgEMailsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgEMailsList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgEMailsList.EnableHeadersVisualStyles = false;
            this.dgEMailsList.Location = new System.Drawing.Point(0, 25);
            this.dgEMailsList.MultiSelect = false;
            this.dgEMailsList.Name = "dgEMailsList";
            this.dgEMailsList.ReadOnly = true;
            this.dgEMailsList.RowHeadersVisible = false;
            this.dgEMailsList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgEMailsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgEMailsList.ShowEditingIcon = false;
            this.dgEMailsList.Size = new System.Drawing.Size(859, 214);
            this.dgEMailsList.TabIndex = 7;
            this.dgEMailsList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEMailsList_CellDoubleClick);
            this.dgEMailsList.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgEMailsList_CellMouseDown);
            this.dgEMailsList.Sorted += new System.EventHandler(this.dgEMailsList_Sorted);
            this.dgEMailsList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgEMailsList_KeyDown);
            this.dgEMailsList.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgEMailsList_KeyUp);
            // 
            // Priority
            // 
            this.Priority.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Priority.FillWeight = 50F;
            this.Priority.HeaderText = "!";
            this.Priority.MaxInputLength = 1;
            this.Priority.MinimumWidth = 2;
            this.Priority.Name = "Priority";
            this.Priority.ReadOnly = true;
            this.Priority.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Priority.Width = 34;
            // 
            // AccountName
            // 
            this.AccountName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AccountName.HeaderText = "Account";
            this.AccountName.Name = "AccountName";
            this.AccountName.ReadOnly = true;
            this.AccountName.Width = 71;
            // 
            // Number
            // 
            this.Number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.Number.DefaultCellStyle = dataGridViewCellStyle1;
            this.Number.FillWeight = 10F;
            this.Number.HeaderText = "#";
            this.Number.MinimumWidth = 2;
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Width = 38;
            // 
            // From
            // 
            this.From.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.From.HeaderText = "From";
            this.From.Name = "From";
            this.From.ReadOnly = true;
            // 
            // Subject
            // 
            this.Subject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Subject.HeaderText = "Subject";
            this.Subject.Name = "Subject";
            this.Subject.ReadOnly = true;
            // 
            // Bytes
            // 
            this.Bytes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.Bytes.DefaultCellStyle = dataGridViewCellStyle2;
            this.Bytes.HeaderText = "Bytes";
            this.Bytes.MaxInputLength = 10;
            this.Bytes.Name = "Bytes";
            this.Bytes.ReadOnly = true;
            this.Bytes.Width = 57;
            // 
            // Received
            // 
            this.Received.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "G";
            dataGridViewCellStyle3.NullValue = null;
            this.Received.DefaultCellStyle = dataGridViewCellStyle3;
            this.Received.HeaderText = "Received";
            this.Received.Name = "Received";
            this.Received.ReadOnly = true;
            this.Received.Width = 77;
            // 
            // MessagesContextMenuStrip
            // 
            this.MessagesContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewEmailToolStripMenuItem,
            this.toolStripSeparator3,
            this.ReplyToolStripMenuItem,
            this.ReplyAllToolStripMenuItem,
            this.ForwardToolStripMenuItem,
            this.toolStripSeparator4,
            this.DeleteEMailToolStripMenuItem,
            this.toolStripSeparator2,
            this.ViewRawHeaderStripMenuItem,
            this.ViewRawEmailStripMenuItem});
            this.MessagesContextMenuStrip.Name = "MessagesContextMenuStrip";
            this.MessagesContextMenuStrip.ShowImageMargin = false;
            this.MessagesContextMenuStrip.Size = new System.Drawing.Size(141, 176);
            this.MessagesContextMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MessagesContextMenuStrip_ItemClicked);
            // 
            // ViewEmailToolStripMenuItem
            // 
            this.ViewEmailToolStripMenuItem.Name = "ViewEmailToolStripMenuItem";
            this.ViewEmailToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.ViewEmailToolStripMenuItem.Text = "&View Email";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(137, 6);
            // 
            // ReplyToolStripMenuItem
            // 
            this.ReplyToolStripMenuItem.Name = "ReplyToolStripMenuItem";
            this.ReplyToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.ReplyToolStripMenuItem.Text = "&Reply";
            // 
            // ReplyAllToolStripMenuItem
            // 
            this.ReplyAllToolStripMenuItem.Name = "ReplyAllToolStripMenuItem";
            this.ReplyAllToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.ReplyAllToolStripMenuItem.Text = "Reply &All";
            // 
            // ForwardToolStripMenuItem
            // 
            this.ForwardToolStripMenuItem.Name = "ForwardToolStripMenuItem";
            this.ForwardToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.ForwardToolStripMenuItem.Text = "&Forward";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(137, 6);
            // 
            // DeleteEMailToolStripMenuItem
            // 
            this.DeleteEMailToolStripMenuItem.Name = "DeleteEMailToolStripMenuItem";
            this.DeleteEMailToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.DeleteEMailToolStripMenuItem.Text = "&Delete EMail";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(137, 6);
            // 
            // ViewRawHeaderStripMenuItem
            // 
            this.ViewRawHeaderStripMenuItem.Name = "ViewRawHeaderStripMenuItem";
            this.ViewRawHeaderStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.ViewRawHeaderStripMenuItem.Text = "View Raw &Header";
            this.ViewRawHeaderStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ViewRawEmailStripMenuItem
            // 
            this.ViewRawEmailStripMenuItem.Name = "ViewRawEmailStripMenuItem";
            this.ViewRawEmailStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.ViewRawEmailStripMenuItem.Text = "View Raw &Email";
            // 
            // ApplicationNotifyIcon
            // 
            this.ApplicationNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("ApplicationNotifyIcon.Icon")));
            this.ApplicationNotifyIcon.Text = "XEmail";
            this.ApplicationNotifyIcon.Visible = true;
            this.ApplicationNotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ApplicationNotifyIcon_MouseDoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(859, 261);
            this.Controls.Add(this.dgEMailsList);
            this.Controls.Add(this.MainStatusStrip);
            this.Controls.Add(this.MainToolStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "XEMail Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.MainToolStrip.ResumeLayout(false);
            this.MainToolStrip.PerformLayout();
            this.MainStatusStrip.ResumeLayout(false);
            this.MainStatusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEMailsList)).EndInit();
            this.MessagesContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip MainToolStrip;
        private System.Windows.Forms.StatusStrip MainStatusStrip;
        private System.Windows.Forms.ToolStripButton tsbCheckEMails;
        private System.Windows.Forms.DataGridView dgEMailsList;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar tsProgressBar;
        private System.Windows.Forms.NotifyIcon ApplicationNotifyIcon;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Timer AccountChecksTimer;
        private System.Windows.Forms.ToolStripDropDownButton tsmiTools;
        private System.Windows.Forms.ToolStripMenuItem tsmiToolsOptions;
        private System.Windows.Forms.ToolStripMenuItem tsmiToolsAutocheck;
        private System.Windows.Forms.ToolStripDropDownButton tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiFileExit;
        private System.Windows.Forms.ContextMenuStrip MessagesContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ViewRawHeaderStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteEMailToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Priority;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn From;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bytes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Received;
        private System.Windows.Forms.ToolStripDropDownButton ddAccountFilter;
        private System.Windows.Forms.ToolStripMenuItem tsmiAllAccounts;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiConfigurationImport;
        private System.Windows.Forms.ToolStripMenuItem tsmiConfigurationExport;
        private System.Windows.Forms.ToolStripDropDownButton tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.ToolStripMenuItem tsmiViewDebug;
        private System.Windows.Forms.ToolStripMenuItem tsmiRemoveCurrentConfigFile;
        private System.Windows.Forms.ToolStripMenuItem ReplyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReplyAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ForwardToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripDropDownButton ddSendEmailFromAccount;
        private System.Windows.Forms.ToolStripMenuItem ViewEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbCancelCheck;
        private System.Windows.Forms.ToolStripMenuItem ViewRawEmailStripMenuItem;

    }
}

