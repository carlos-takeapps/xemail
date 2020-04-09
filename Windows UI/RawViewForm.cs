using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BAFactory.XEMail.Windows
{
    public partial class RawViewForm : Form
    {
        internal string RawViewText
        {
            get { return RawViewTextBox.Text; }
            set { RawViewTextBox.Text = value;
            this.RawViewTextBox.Select(0, 0);
        }
        }

        public RawViewForm()
        {
            InitializeComponent();
        }
    }
}