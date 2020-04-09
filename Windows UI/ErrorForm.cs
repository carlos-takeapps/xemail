using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BAFactory.XEMail.Windows
{
    public partial class ErrorForm : Form
    {
        public ErrorForm(List<string> DebugInfo)
        {
            InitializeComponent();
            this.txtException.Lines = DebugInfo.ToArray();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            MainForm.ClearDebugInfo();
            this.Close();
        }
    }
}