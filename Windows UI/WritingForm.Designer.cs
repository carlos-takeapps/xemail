namespace BAFactory.XEMail.Windows
{
    partial class WritingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WritingForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnAttachRemove = new System.Windows.Forms.Button();
            this.lbPriority = new System.Windows.Forms.ListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSend = new System.Windows.Forms.ToolStripButton();
            this.lblPriority = new System.Windows.Forms.Label();
            this.lbAttachments = new System.Windows.Forms.ListBox();
            this.lblAttachments = new System.Windows.Forms.Label();
            this.txtEMailSubject = new System.Windows.Forms.TextBox();
            this.txtEMailCC = new System.Windows.Forms.TextBox();
            this.txtEMailTo = new System.Windows.Forms.TextBox();
            this.txtEMailFrom = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblCC = new System.Windows.Forms.Label();
            this.lblForm = new System.Windows.Forms.Label();
            this.MessageBodyComposer = new System.Windows.Forms.RichTextBox();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnAttachRemove);
            this.splitContainer1.Panel1.Controls.Add(this.lbPriority);
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            this.splitContainer1.Panel1.Controls.Add(this.lblPriority);
            this.splitContainer1.Panel1.Controls.Add(this.lbAttachments);
            this.splitContainer1.Panel1.Controls.Add(this.lblAttachments);
            this.splitContainer1.Panel1.Controls.Add(this.txtEMailSubject);
            this.splitContainer1.Panel1.Controls.Add(this.txtEMailCC);
            this.splitContainer1.Panel1.Controls.Add(this.txtEMailTo);
            this.splitContainer1.Panel1.Controls.Add(this.txtEMailFrom);
            this.splitContainer1.Panel1.Controls.Add(this.lblSubject);
            this.splitContainer1.Panel1.Controls.Add(this.lblTo);
            this.splitContainer1.Panel1.Controls.Add(this.lblCC);
            this.splitContainer1.Panel1.Controls.Add(this.lblForm);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.MessageBodyComposer);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.splitContainer1.Size = new System.Drawing.Size(567, 341);
            this.splitContainer1.SplitterDistance = 162;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 3;
            // 
            // btnAttachRemove
            // 
            this.btnAttachRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAttachRemove.Enabled = false;
            this.btnAttachRemove.FlatAppearance.BorderSize = 0;
            this.btnAttachRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttachRemove.Image = ((System.Drawing.Image)(resources.GetObject("btnAttachRemove.Image")));
            this.btnAttachRemove.Location = new System.Drawing.Point(532, 112);
            this.btnAttachRemove.Name = "btnAttachRemove";
            this.btnAttachRemove.Size = new System.Drawing.Size(23, 17);
            this.btnAttachRemove.TabIndex = 18;
            this.btnAttachRemove.UseVisualStyleBackColor = true;
            this.btnAttachRemove.Click += new System.EventHandler(this.btnAttachRemove_Click);
            // 
            // lbPriority
            // 
            this.lbPriority.FormattingEnabled = true;
            this.lbPriority.Items.AddRange(new object[] {
            "Low",
            "Normal",
            "High"});
            this.lbPriority.Location = new System.Drawing.Point(62, 113);
            this.lbPriority.Name = "lbPriority";
            this.lbPriority.Size = new System.Drawing.Size(85, 17);
            this.lbPriority.TabIndex = 17;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSend});
            this.toolStrip1.Location = new System.Drawing.Point(0, 137);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(567, 25);
            this.toolStrip1.TabIndex = 16;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSend
            // 
            this.btnSend.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSend.Image = ((System.Drawing.Image)(resources.GetObject("btnSend.Image")));
            this.btnSend.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(23, 22);
            this.btnSend.Text = "Send";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Location = new System.Drawing.Point(10, 116);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(41, 13);
            this.lblPriority.TabIndex = 15;
            this.lblPriority.Text = "Priority:";
            // 
            // lbAttachments
            // 
            this.lbAttachments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAttachments.Enabled = false;
            this.lbAttachments.FormattingEnabled = true;
            this.lbAttachments.Location = new System.Drawing.Point(228, 112);
            this.lbAttachments.Name = "lbAttachments";
            this.lbAttachments.Size = new System.Drawing.Size(298, 17);
            this.lbAttachments.TabIndex = 13;
            // 
            // lblAttachments
            // 
            this.lblAttachments.AutoSize = true;
            this.lblAttachments.Location = new System.Drawing.Point(153, 116);
            this.lblAttachments.Name = "lblAttachments";
            this.lblAttachments.Size = new System.Drawing.Size(69, 13);
            this.lblAttachments.TabIndex = 12;
            this.lblAttachments.Text = "Attachments:";
            // 
            // txtEMailSubject
            // 
            this.txtEMailSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEMailSubject.BackColor = System.Drawing.SystemColors.Window;
            this.txtEMailSubject.Location = new System.Drawing.Point(62, 87);
            this.txtEMailSubject.Name = "txtEMailSubject";
            this.txtEMailSubject.Size = new System.Drawing.Size(493, 20);
            this.txtEMailSubject.TabIndex = 11;
            // 
            // txtEMailCC
            // 
            this.txtEMailCC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEMailCC.BackColor = System.Drawing.SystemColors.Window;
            this.txtEMailCC.Location = new System.Drawing.Point(62, 61);
            this.txtEMailCC.Multiline = true;
            this.txtEMailCC.Name = "txtEMailCC";
            this.txtEMailCC.Size = new System.Drawing.Size(493, 20);
            this.txtEMailCC.TabIndex = 10;
            // 
            // txtEMailTo
            // 
            this.txtEMailTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEMailTo.BackColor = System.Drawing.SystemColors.Window;
            this.txtEMailTo.Location = new System.Drawing.Point(62, 35);
            this.txtEMailTo.Multiline = true;
            this.txtEMailTo.Name = "txtEMailTo";
            this.txtEMailTo.Size = new System.Drawing.Size(493, 20);
            this.txtEMailTo.TabIndex = 9;
            // 
            // txtEMailFrom
            // 
            this.txtEMailFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEMailFrom.BackColor = System.Drawing.SystemColors.Window;
            this.txtEMailFrom.Location = new System.Drawing.Point(62, 9);
            this.txtEMailFrom.Name = "txtEMailFrom";
            this.txtEMailFrom.ReadOnly = true;
            this.txtEMailFrom.Size = new System.Drawing.Size(493, 20);
            this.txtEMailFrom.TabIndex = 8;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(10, 90);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(46, 13);
            this.lblSubject.TabIndex = 6;
            this.lblSubject.Text = "Subject:";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(13, 38);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(23, 13);
            this.lblTo.TabIndex = 2;
            this.lblTo.Text = "To:";
            // 
            // lblCC
            // 
            this.lblCC.AutoSize = true;
            this.lblCC.Location = new System.Drawing.Point(13, 64);
            this.lblCC.Name = "lblCC";
            this.lblCC.Size = new System.Drawing.Size(24, 13);
            this.lblCC.TabIndex = 1;
            this.lblCC.Text = "CC:";
            // 
            // lblForm
            // 
            this.lblForm.AutoSize = true;
            this.lblForm.Location = new System.Drawing.Point(13, 12);
            this.lblForm.Name = "lblForm";
            this.lblForm.Size = new System.Drawing.Size(33, 13);
            this.lblForm.TabIndex = 0;
            this.lblForm.Text = "From:";
            // 
            // MessageBodyComposer
            // 
            this.MessageBodyComposer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessageBodyComposer.Location = new System.Drawing.Point(5, 5);
            this.MessageBodyComposer.Name = "MessageBodyComposer";
            this.MessageBodyComposer.Size = new System.Drawing.Size(557, 168);
            this.MessageBodyComposer.TabIndex = 0;
            this.MessageBodyComposer.Text = "";
            // 
            // WritingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 341);
            this.Controls.Add(this.splitContainer1);
            this.Name = "WritingForm";
            this.Text = "WritingForm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSend;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.ListBox lbAttachments;
        private System.Windows.Forms.Label lblAttachments;
        private System.Windows.Forms.TextBox txtEMailSubject;
        private System.Windows.Forms.TextBox txtEMailCC;
        private System.Windows.Forms.TextBox txtEMailTo;
        private System.Windows.Forms.TextBox txtEMailFrom;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblCC;
        private System.Windows.Forms.Label lblForm;
        private System.Windows.Forms.RichTextBox MessageBodyComposer;
        private System.Windows.Forms.ListBox lbPriority;
        private System.Windows.Forms.Button btnAttachRemove;
    }
}