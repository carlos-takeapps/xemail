namespace BAFactory.XEMail.Windows
{
    partial class RawViewForm
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
            this.RawViewTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // HeaderTextBox
            // 
            this.RawViewTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RawViewTextBox.Location = new System.Drawing.Point(0, 0);
            this.RawViewTextBox.Multiline = true;
            this.RawViewTextBox.Name = "HeaderTextBox";
            this.RawViewTextBox.ReadOnly = true;
            this.RawViewTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RawViewTextBox.Size = new System.Drawing.Size(364, 201);
            this.RawViewTextBox.TabIndex = 0;
            // 
            // ViewRawHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 201);
            this.Controls.Add(this.RawViewTextBox);
            this.Name = "ViewRawHeader";
            this.Text = "ViewRawHeader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RawViewTextBox;
    }
}