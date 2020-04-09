namespace BAFactory.XEMail.Windows
{
    partial class OptionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsForm));
            this.scAccountConfig = new System.Windows.Forms.SplitContainer();
            this.lblServerProtocol = new System.Windows.Forms.Label();
            this.tbIncomingUserPassword = new System.Windows.Forms.TextBox();
            this.cbIncomingProtocol = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbIncomingUserName = new System.Windows.Forms.TextBox();
            this.cbIncomingSslEnabled = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbIncomingServerPort = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbIncomingServerName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbSameCredentials = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbOutgoingUserPassword = new System.Windows.Forms.TextBox();
            this.cbOutgoingProtocol = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbOutgoingUserName = new System.Windows.Forms.TextBox();
            this.cbOutgoingSslEnabled = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbOutgoingServerPort = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbOutgoingServerName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblIncomingServer = new System.Windows.Forms.Label();
            this.cbIncomingEnabled = new System.Windows.Forms.CheckBox();
            this.cbOutgoingEnabled = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblAccountName = new System.Windows.Forms.Label();
            this.tbAccountName = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageAccounts = new System.Windows.Forms.TabPage();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tabPageAppOptions = new System.Windows.Forms.TabPage();
            this.btnDefaultUrl = new System.Windows.Forms.Button();
            this.lblServiceUrl = new System.Windows.Forms.Label();
            this.tbServiceUrl = new System.Windows.Forms.TextBox();
            this.lblAutoCheck = new System.Windows.Forms.Label();
            this.cbAutoCheck = new System.Windows.Forms.CheckBox();
            this.lblInterval = new System.Windows.Forms.Label();
            this.nupInterval = new System.Windows.Forms.NumericUpDown();
            this.tabPageNetwork = new System.Windows.Forms.TabPage();
            this.gbNetProxy = new System.Windows.Forms.GroupBox();
            this.tbNetProxyPass = new System.Windows.Forms.TextBox();
            this.lblNetPort = new System.Windows.Forms.Label();
            this.tbNetProxyUrl = new System.Windows.Forms.TextBox();
            this.tbNetProxyPort = new System.Windows.Forms.TextBox();
            this.tbNetProxyUser = new System.Windows.Forms.TextBox();
            this.tbNetProxyDomain = new System.Windows.Forms.TextBox();
            this.lblNetDomain = new System.Windows.Forms.Label();
            this.lblNetProxy = new System.Windows.Forms.Label();
            this.lblNetPass = new System.Windows.Forms.Label();
            this.lblNetUser = new System.Windows.Forms.Label();
            this.cbNetProxyEnabled = new System.Windows.Forms.CheckBox();
            this.scAccountConfig.Panel1.SuspendLayout();
            this.scAccountConfig.Panel2.SuspendLayout();
            this.scAccountConfig.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageAccounts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.tabPageAppOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupInterval)).BeginInit();
            this.tabPageNetwork.SuspendLayout();
            this.gbNetProxy.SuspendLayout();
            this.SuspendLayout();
            // 
            // scAccountConfig
            // 
            this.scAccountConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.scAccountConfig.CausesValidation = false;
            this.scAccountConfig.IsSplitterFixed = true;
            this.scAccountConfig.Location = new System.Drawing.Point(9, 60);
            this.scAccountConfig.Name = "scAccountConfig";
            // 
            // scAccountConfig.Panel1
            // 
            this.scAccountConfig.Panel1.Controls.Add(this.lblServerProtocol);
            this.scAccountConfig.Panel1.Controls.Add(this.tbIncomingUserPassword);
            this.scAccountConfig.Panel1.Controls.Add(this.cbIncomingProtocol);
            this.scAccountConfig.Panel1.Controls.Add(this.label3);
            this.scAccountConfig.Panel1.Controls.Add(this.tbIncomingUserName);
            this.scAccountConfig.Panel1.Controls.Add(this.cbIncomingSslEnabled);
            this.scAccountConfig.Panel1.Controls.Add(this.label4);
            this.scAccountConfig.Panel1.Controls.Add(this.tbIncomingServerPort);
            this.scAccountConfig.Panel1.Controls.Add(this.label5);
            this.scAccountConfig.Panel1.Controls.Add(this.tbIncomingServerName);
            this.scAccountConfig.Panel1.Controls.Add(this.label6);
            // 
            // scAccountConfig.Panel2
            // 
            this.scAccountConfig.Panel2.Controls.Add(this.cbSameCredentials);
            this.scAccountConfig.Panel2.Controls.Add(this.label1);
            this.scAccountConfig.Panel2.Controls.Add(this.tbOutgoingUserPassword);
            this.scAccountConfig.Panel2.Controls.Add(this.cbOutgoingProtocol);
            this.scAccountConfig.Panel2.Controls.Add(this.label7);
            this.scAccountConfig.Panel2.Controls.Add(this.tbOutgoingUserName);
            this.scAccountConfig.Panel2.Controls.Add(this.cbOutgoingSslEnabled);
            this.scAccountConfig.Panel2.Controls.Add(this.label8);
            this.scAccountConfig.Panel2.Controls.Add(this.tbOutgoingServerPort);
            this.scAccountConfig.Panel2.Controls.Add(this.label9);
            this.scAccountConfig.Panel2.Controls.Add(this.tbOutgoingServerName);
            this.scAccountConfig.Panel2.Controls.Add(this.label10);
            this.scAccountConfig.Size = new System.Drawing.Size(471, 150);
            this.scAccountConfig.SplitterDistance = 238;
            this.scAccountConfig.TabIndex = 23;
            this.scAccountConfig.TabStop = false;
            // 
            // lblServerProtocol
            // 
            this.lblServerProtocol.AutoSize = true;
            this.lblServerProtocol.Location = new System.Drawing.Point(3, 0);
            this.lblServerProtocol.Name = "lblServerProtocol";
            this.lblServerProtocol.Size = new System.Drawing.Size(83, 13);
            this.lblServerProtocol.TabIndex = 20;
            this.lblServerProtocol.Text = "Server Protocol:";
            // 
            // tbIncomingUserPassword
            // 
            this.tbIncomingUserPassword.Location = new System.Drawing.Point(101, 105);
            this.tbIncomingUserPassword.Name = "tbIncomingUserPassword";
            this.tbIncomingUserPassword.Size = new System.Drawing.Size(121, 20);
            this.tbIncomingUserPassword.TabIndex = 7;
            this.tbIncomingUserPassword.UseSystemPasswordChar = true;
            // 
            // cbIncomingProtocol
            // 
            this.cbIncomingProtocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIncomingProtocol.Enabled = false;
            this.cbIncomingProtocol.FormattingEnabled = true;
            this.cbIncomingProtocol.Items.AddRange(new object[] {
            "HTTP",
            "IMAP",
            "POP3",
            "SMTP"});
            this.cbIncomingProtocol.Location = new System.Drawing.Point(101, 0);
            this.cbIncomingProtocol.Name = "cbIncomingProtocol";
            this.cbIncomingProtocol.Size = new System.Drawing.Size(121, 21);
            this.cbIncomingProtocol.Sorted = true;
            this.cbIncomingProtocol.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Server Hostname:";
            // 
            // tbIncomingUserName
            // 
            this.tbIncomingUserName.Location = new System.Drawing.Point(101, 79);
            this.tbIncomingUserName.Name = "tbIncomingUserName";
            this.tbIncomingUserName.Size = new System.Drawing.Size(121, 20);
            this.tbIncomingUserName.TabIndex = 6;
            // 
            // cbIncomingSslEnabled
            // 
            this.cbIncomingSslEnabled.AutoSize = true;
            this.cbIncomingSslEnabled.Location = new System.Drawing.Point(140, 131);
            this.cbIncomingSslEnabled.Name = "cbIncomingSslEnabled";
            this.cbIncomingSslEnabled.Size = new System.Drawing.Size(82, 17);
            this.cbIncomingSslEnabled.TabIndex = 8;
            this.cbIncomingSslEnabled.Text = "Enable SSL";
            this.cbIncomingSslEnabled.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Server Port:";
            // 
            // tbIncomingServerPort
            // 
            this.tbIncomingServerPort.Location = new System.Drawing.Point(101, 53);
            this.tbIncomingServerPort.Name = "tbIncomingServerPort";
            this.tbIncomingServerPort.Size = new System.Drawing.Size(121, 20);
            this.tbIncomingServerPort.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "User Account:";
            // 
            // tbIncomingServerName
            // 
            this.tbIncomingServerName.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.tbIncomingServerName.Location = new System.Drawing.Point(101, 27);
            this.tbIncomingServerName.Name = "tbIncomingServerName";
            this.tbIncomingServerName.Size = new System.Drawing.Size(121, 20);
            this.tbIncomingServerName.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "User Password:";
            // 
            // cbSameCredentials
            // 
            this.cbSameCredentials.AutoSize = true;
            this.cbSameCredentials.Location = new System.Drawing.Point(9, 131);
            this.cbSameCredentials.Name = "cbSameCredentials";
            this.cbSameCredentials.Size = new System.Drawing.Size(127, 17);
            this.cbSameCredentials.TabIndex = 14;
            this.cbSameCredentials.Text = "Use same credentials";
            this.cbSameCredentials.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Server Protocol:";
            // 
            // tbOutgoingUserPassword
            // 
            this.tbOutgoingUserPassword.Location = new System.Drawing.Point(98, 105);
            this.tbOutgoingUserPassword.Name = "tbOutgoingUserPassword";
            this.tbOutgoingUserPassword.Size = new System.Drawing.Size(121, 20);
            this.tbOutgoingUserPassword.TabIndex = 13;
            this.tbOutgoingUserPassword.UseSystemPasswordChar = true;
            // 
            // cbOutgoingProtocol
            // 
            this.cbOutgoingProtocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOutgoingProtocol.Enabled = false;
            this.cbOutgoingProtocol.FormattingEnabled = true;
            this.cbOutgoingProtocol.Items.AddRange(new object[] {
            "POP3",
            "SMTP",
            "IMAP",
            "HTTP"});
            this.cbOutgoingProtocol.Location = new System.Drawing.Point(98, 0);
            this.cbOutgoingProtocol.Name = "cbOutgoingProtocol";
            this.cbOutgoingProtocol.Size = new System.Drawing.Size(121, 21);
            this.cbOutgoingProtocol.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Server Hostname:";
            // 
            // tbOutgoingUserName
            // 
            this.tbOutgoingUserName.Location = new System.Drawing.Point(98, 79);
            this.tbOutgoingUserName.Name = "tbOutgoingUserName";
            this.tbOutgoingUserName.Size = new System.Drawing.Size(121, 20);
            this.tbOutgoingUserName.TabIndex = 12;
            // 
            // cbOutgoingSslEnabled
            // 
            this.cbOutgoingSslEnabled.AutoSize = true;
            this.cbOutgoingSslEnabled.Location = new System.Drawing.Point(137, 131);
            this.cbOutgoingSslEnabled.Name = "cbOutgoingSslEnabled";
            this.cbOutgoingSslEnabled.Size = new System.Drawing.Size(82, 17);
            this.cbOutgoingSslEnabled.TabIndex = 15;
            this.cbOutgoingSslEnabled.Text = "Enable SSL";
            this.cbOutgoingSslEnabled.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Server Port:";
            // 
            // tbOutgoingServerPort
            // 
            this.tbOutgoingServerPort.Location = new System.Drawing.Point(98, 53);
            this.tbOutgoingServerPort.Name = "tbOutgoingServerPort";
            this.tbOutgoingServerPort.Size = new System.Drawing.Size(121, 20);
            this.tbOutgoingServerPort.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "User Account:";
            // 
            // tbOutgoingServerName
            // 
            this.tbOutgoingServerName.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.tbOutgoingServerName.Location = new System.Drawing.Point(98, 27);
            this.tbOutgoingServerName.Name = "tbOutgoingServerName";
            this.tbOutgoingServerName.Size = new System.Drawing.Size(121, 20);
            this.tbOutgoingServerName.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "User Password:";
            // 
            // lblIncomingServer
            // 
            this.lblIncomingServer.AutoSize = true;
            this.lblIncomingServer.Location = new System.Drawing.Point(6, 37);
            this.lblIncomingServer.Name = "lblIncomingServer";
            this.lblIncomingServer.Size = new System.Drawing.Size(84, 13);
            this.lblIncomingServer.TabIndex = 22;
            this.lblIncomingServer.Text = "Incoming Server";
            // 
            // cbIncomingEnabled
            // 
            this.cbIncomingEnabled.AutoSize = true;
            this.cbIncomingEnabled.Location = new System.Drawing.Point(110, 35);
            this.cbIncomingEnabled.Name = "cbIncomingEnabled";
            this.cbIncomingEnabled.Size = new System.Drawing.Size(59, 17);
            this.cbIncomingEnabled.TabIndex = 2;
            this.cbIncomingEnabled.Text = "Enable";
            this.cbIncomingEnabled.UseVisualStyleBackColor = true;
            // 
            // cbOutgoingEnabled
            // 
            this.cbOutgoingEnabled.AutoSize = true;
            this.cbOutgoingEnabled.Location = new System.Drawing.Point(349, 35);
            this.cbOutgoingEnabled.Name = "cbOutgoingEnabled";
            this.cbOutgoingEnabled.Size = new System.Drawing.Size(59, 17);
            this.cbOutgoingEnabled.TabIndex = 9;
            this.cbOutgoingEnabled.Text = "Enable";
            this.cbOutgoingEnabled.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Outgoing Server";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(334, 276);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 17;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(415, 276);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblAccountName
            // 
            this.lblAccountName.AutoSize = true;
            this.lblAccountName.Location = new System.Drawing.Point(12, 12);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(81, 13);
            this.lblAccountName.TabIndex = 17;
            this.lblAccountName.Text = "Account Name:";
            // 
            // tbAccountName
            // 
            this.tbAccountName.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.tbAccountName.Location = new System.Drawing.Point(110, 9);
            this.tbAccountName.Name = "tbAccountName";
            this.tbAccountName.Size = new System.Drawing.Size(153, 20);
            this.tbAccountName.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageAccounts);
            this.tabControl1.Controls.Add(this.tabPageAppOptions);
            this.tabControl1.Controls.Add(this.tabPageNetwork);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(494, 270);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPageAccounts
            // 
            this.tabPageAccounts.Controls.Add(this.cbOutgoingEnabled);
            this.tabPageAccounts.Controls.Add(this.lblIncomingServer);
            this.tabPageAccounts.Controls.Add(this.scAccountConfig);
            this.tabPageAccounts.Controls.Add(this.bindingNavigator1);
            this.tabPageAccounts.Controls.Add(this.lblAccountName);
            this.tabPageAccounts.Controls.Add(this.cbIncomingEnabled);
            this.tabPageAccounts.Controls.Add(this.label2);
            this.tabPageAccounts.Controls.Add(this.tbAccountName);
            this.tabPageAccounts.Location = new System.Drawing.Point(4, 22);
            this.tabPageAccounts.Name = "tabPageAccounts";
            this.tabPageAccounts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAccounts.Size = new System.Drawing.Size(486, 244);
            this.tabPageAccounts.TabIndex = 0;
            this.tabPageAccounts.Text = "Accounts";
            this.tabPageAccounts.UseVisualStyleBackColor = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(9, 213);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.bindingNavigator1.Size = new System.Drawing.Size(247, 25);
            this.bindingNavigator1.TabIndex = 16;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tabPageAppOptions
            // 
            this.tabPageAppOptions.Controls.Add(this.btnDefaultUrl);
            this.tabPageAppOptions.Controls.Add(this.lblServiceUrl);
            this.tabPageAppOptions.Controls.Add(this.tbServiceUrl);
            this.tabPageAppOptions.Controls.Add(this.lblAutoCheck);
            this.tabPageAppOptions.Controls.Add(this.cbAutoCheck);
            this.tabPageAppOptions.Controls.Add(this.lblInterval);
            this.tabPageAppOptions.Controls.Add(this.nupInterval);
            this.tabPageAppOptions.Location = new System.Drawing.Point(4, 22);
            this.tabPageAppOptions.Name = "tabPageAppOptions";
            this.tabPageAppOptions.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAppOptions.Size = new System.Drawing.Size(486, 244);
            this.tabPageAppOptions.TabIndex = 1;
            this.tabPageAppOptions.Text = "Program";
            this.tabPageAppOptions.UseVisualStyleBackColor = true;
            // 
            // btnDefaultUrl
            // 
            this.btnDefaultUrl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDefaultUrl.Location = new System.Drawing.Point(332, 80);
            this.btnDefaultUrl.Name = "btnDefaultUrl";
            this.btnDefaultUrl.Size = new System.Drawing.Size(49, 21);
            this.btnDefaultUrl.TabIndex = 11;
            this.btnDefaultUrl.Text = "default";
            this.btnDefaultUrl.UseVisualStyleBackColor = true;
            this.btnDefaultUrl.Click += new System.EventHandler(this.btnDefaultUrl_Click);
            // 
            // lblServiceUrl
            // 
            this.lblServiceUrl.AutoSize = true;
            this.lblServiceUrl.Location = new System.Drawing.Point(15, 84);
            this.lblServiceUrl.Name = "lblServiceUrl";
            this.lblServiceUrl.Size = new System.Drawing.Size(83, 13);
            this.lblServiceUrl.TabIndex = 10;
            this.lblServiceUrl.Text = "Webservice Url:";
            // 
            // tbServiceUrl
            // 
            this.tbServiceUrl.Location = new System.Drawing.Point(132, 81);
            this.tbServiceUrl.Name = "tbServiceUrl";
            this.tbServiceUrl.Size = new System.Drawing.Size(194, 20);
            this.tbServiceUrl.TabIndex = 9;
            // 
            // lblAutoCheck
            // 
            this.lblAutoCheck.AutoSize = true;
            this.lblAutoCheck.Location = new System.Drawing.Point(15, 20);
            this.lblAutoCheck.Name = "lblAutoCheck";
            this.lblAutoCheck.Size = new System.Drawing.Size(104, 13);
            this.lblAutoCheck.TabIndex = 8;
            this.lblAutoCheck.Text = "Autocheck Enabled:";
            // 
            // cbAutoCheck
            // 
            this.cbAutoCheck.AutoSize = true;
            this.cbAutoCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbAutoCheck.Location = new System.Drawing.Point(132, 21);
            this.cbAutoCheck.Name = "cbAutoCheck";
            this.cbAutoCheck.Size = new System.Drawing.Size(15, 14);
            this.cbAutoCheck.TabIndex = 7;
            this.cbAutoCheck.UseVisualStyleBackColor = true;
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Location = new System.Drawing.Point(15, 49);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(90, 13);
            this.lblInterval.TabIndex = 6;
            this.lblInterval.Text = "Interval (minutes):";
            // 
            // nupInterval
            // 
            this.nupInterval.Location = new System.Drawing.Point(132, 47);
            this.nupInterval.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            this.nupInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupInterval.Name = "nupInterval";
            this.nupInterval.Size = new System.Drawing.Size(53, 20);
            this.nupInterval.TabIndex = 5;
            this.nupInterval.ThousandsSeparator = true;
            this.nupInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tabPageNetwork
            // 
            this.tabPageNetwork.Controls.Add(this.gbNetProxy);
            this.tabPageNetwork.Controls.Add(this.cbNetProxyEnabled);
            this.tabPageNetwork.Location = new System.Drawing.Point(4, 22);
            this.tabPageNetwork.Name = "tabPageNetwork";
            this.tabPageNetwork.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNetwork.Size = new System.Drawing.Size(486, 244);
            this.tabPageNetwork.TabIndex = 2;
            this.tabPageNetwork.Text = "Network";
            this.tabPageNetwork.UseVisualStyleBackColor = true;
            // 
            // gbNetProxy
            // 
            this.gbNetProxy.Controls.Add(this.tbNetProxyPass);
            this.gbNetProxy.Controls.Add(this.lblNetPort);
            this.gbNetProxy.Controls.Add(this.tbNetProxyUrl);
            this.gbNetProxy.Controls.Add(this.tbNetProxyPort);
            this.gbNetProxy.Controls.Add(this.tbNetProxyUser);
            this.gbNetProxy.Controls.Add(this.tbNetProxyDomain);
            this.gbNetProxy.Controls.Add(this.lblNetDomain);
            this.gbNetProxy.Controls.Add(this.lblNetProxy);
            this.gbNetProxy.Controls.Add(this.lblNetPass);
            this.gbNetProxy.Controls.Add(this.lblNetUser);
            this.gbNetProxy.Location = new System.Drawing.Point(11, 30);
            this.gbNetProxy.Name = "gbNetProxy";
            this.gbNetProxy.Size = new System.Drawing.Size(467, 166);
            this.gbNetProxy.TabIndex = 11;
            this.gbNetProxy.TabStop = false;
            this.gbNetProxy.Text = "Network Proxy Configuration";
            // 
            // tbNetProxyPass
            // 
            this.tbNetProxyPass.Location = new System.Drawing.Point(111, 127);
            this.tbNetProxyPass.Name = "tbNetProxyPass";
            this.tbNetProxyPass.Size = new System.Drawing.Size(350, 20);
            this.tbNetProxyPass.TabIndex = 3;
            this.tbNetProxyPass.UseSystemPasswordChar = true;
            // 
            // lblNetPort
            // 
            this.lblNetPort.AutoSize = true;
            this.lblNetPort.Location = new System.Drawing.Point(6, 52);
            this.lblNetPort.Name = "lblNetPort";
            this.lblNetPort.Size = new System.Drawing.Size(72, 13);
            this.lblNetPort.TabIndex = 10;
            this.lblNetPort.Text = "Network Port:";
            // 
            // tbNetProxyUrl
            // 
            this.tbNetProxyUrl.Location = new System.Drawing.Point(111, 23);
            this.tbNetProxyUrl.Name = "tbNetProxyUrl";
            this.tbNetProxyUrl.Size = new System.Drawing.Size(350, 20);
            this.tbNetProxyUrl.TabIndex = 0;
            // 
            // tbNetProxyPort
            // 
            this.tbNetProxyPort.Location = new System.Drawing.Point(111, 49);
            this.tbNetProxyPort.Name = "tbNetProxyPort";
            this.tbNetProxyPort.Size = new System.Drawing.Size(350, 20);
            this.tbNetProxyPort.TabIndex = 9;
            // 
            // tbNetProxyUser
            // 
            this.tbNetProxyUser.Location = new System.Drawing.Point(111, 75);
            this.tbNetProxyUser.Name = "tbNetProxyUser";
            this.tbNetProxyUser.Size = new System.Drawing.Size(350, 20);
            this.tbNetProxyUser.TabIndex = 1;
            // 
            // tbNetProxyDomain
            // 
            this.tbNetProxyDomain.Location = new System.Drawing.Point(111, 101);
            this.tbNetProxyDomain.Name = "tbNetProxyDomain";
            this.tbNetProxyDomain.Size = new System.Drawing.Size(350, 20);
            this.tbNetProxyDomain.TabIndex = 2;
            // 
            // lblNetDomain
            // 
            this.lblNetDomain.AutoSize = true;
            this.lblNetDomain.Location = new System.Drawing.Point(6, 104);
            this.lblNetDomain.Name = "lblNetDomain";
            this.lblNetDomain.Size = new System.Drawing.Size(89, 13);
            this.lblNetDomain.TabIndex = 7;
            this.lblNetDomain.Text = "Network Domain:";
            // 
            // lblNetProxy
            // 
            this.lblNetProxy.AutoSize = true;
            this.lblNetProxy.Location = new System.Drawing.Point(6, 26);
            this.lblNetProxy.Name = "lblNetProxy";
            this.lblNetProxy.Size = new System.Drawing.Size(79, 13);
            this.lblNetProxy.TabIndex = 4;
            this.lblNetProxy.Text = "Network Proxy:";
            // 
            // lblNetPass
            // 
            this.lblNetPass.AutoSize = true;
            this.lblNetPass.Location = new System.Drawing.Point(6, 130);
            this.lblNetPass.Name = "lblNetPass";
            this.lblNetPass.Size = new System.Drawing.Size(99, 13);
            this.lblNetPass.TabIndex = 6;
            this.lblNetPass.Text = "Network Password:";
            // 
            // lblNetUser
            // 
            this.lblNetUser.AutoSize = true;
            this.lblNetUser.Location = new System.Drawing.Point(6, 78);
            this.lblNetUser.Name = "lblNetUser";
            this.lblNetUser.Size = new System.Drawing.Size(75, 13);
            this.lblNetUser.TabIndex = 5;
            this.lblNetUser.Text = "Network User:";
            // 
            // cbNetProxyEnabled
            // 
            this.cbNetProxyEnabled.AutoSize = true;
            this.cbNetProxyEnabled.Location = new System.Drawing.Point(11, 7);
            this.cbNetProxyEnabled.Name = "cbNetProxyEnabled";
            this.cbNetProxyEnabled.Size = new System.Drawing.Size(117, 17);
            this.cbNetProxyEnabled.TabIndex = 8;
            this.cbNetProxyEnabled.Text = "Use Network Proxy";
            this.cbNetProxyEnabled.UseVisualStyleBackColor = true;
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 305);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Config Options";
            this.scAccountConfig.Panel1.ResumeLayout(false);
            this.scAccountConfig.Panel1.PerformLayout();
            this.scAccountConfig.Panel2.ResumeLayout(false);
            this.scAccountConfig.Panel2.PerformLayout();
            this.scAccountConfig.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageAccounts.ResumeLayout(false);
            this.tabPageAccounts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.tabPageAppOptions.ResumeLayout(false);
            this.tabPageAppOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupInterval)).EndInit();
            this.tabPageNetwork.ResumeLayout(false);
            this.tabPageNetwork.PerformLayout();
            this.gbNetProxy.ResumeLayout(false);
            this.gbNetProxy.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbIncomingUserPassword;
        private System.Windows.Forms.TextBox tbIncomingUserName;
        private System.Windows.Forms.TextBox tbIncomingServerPort;
        private System.Windows.Forms.TextBox tbIncomingServerName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageAccounts;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TabPage tabPageAppOptions;
        private System.Windows.Forms.Label lblInterval;
        private System.Windows.Forms.NumericUpDown nupInterval;
        private System.Windows.Forms.Label lblAutoCheck;
        private System.Windows.Forms.CheckBox cbAutoCheck;
        private System.Windows.Forms.CheckBox cbIncomingSslEnabled;
        private System.Windows.Forms.Label lblServiceUrl;
        private System.Windows.Forms.TextBox tbServiceUrl;
        private System.Windows.Forms.Button btnDefaultUrl;
        private System.Windows.Forms.TabPage tabPageNetwork;
        private System.Windows.Forms.Label lblNetDomain;
        private System.Windows.Forms.Label lblNetPass;
        private System.Windows.Forms.Label lblNetUser;
        private System.Windows.Forms.Label lblNetProxy;
        private System.Windows.Forms.TextBox tbNetProxyPass;
        private System.Windows.Forms.TextBox tbNetProxyDomain;
        private System.Windows.Forms.TextBox tbNetProxyUser;
        private System.Windows.Forms.TextBox tbNetProxyUrl;
        private System.Windows.Forms.CheckBox cbNetProxyEnabled;
        private System.Windows.Forms.Label lblNetPort;
        private System.Windows.Forms.TextBox tbNetProxyPort;
        private System.Windows.Forms.GroupBox gbNetProxy;
        private System.Windows.Forms.ComboBox cbIncomingProtocol;
        private System.Windows.Forms.Label lblServerProtocol;
        private System.Windows.Forms.Label lblIncomingServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbOutgoingUserPassword;
        private System.Windows.Forms.ComboBox cbOutgoingProtocol;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbOutgoingUserName;
        private System.Windows.Forms.CheckBox cbOutgoingSslEnabled;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbOutgoingServerPort;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbOutgoingServerName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblAccountName;
        private System.Windows.Forms.TextBox tbAccountName;
        private System.Windows.Forms.CheckBox cbIncomingEnabled;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.CheckBox cbSameCredentials;
        private System.Windows.Forms.CheckBox cbOutgoingEnabled;
        private System.Windows.Forms.SplitContainer scAccountConfig;
    }
}