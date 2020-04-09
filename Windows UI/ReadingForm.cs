using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using BAFactory.Fx.Network.Email;
using BAFactory.XEMail.ServiceClient;

namespace BAFactory.XEMail.Windows
{
    public partial class ReadingForm : Form
    {
        private EMailMessage message;
        private MessageActions action;
        private bool accountSendEnabled;

        public EMailMessage Message
        {
            get { return message; }
            set { message = value; }
        }
        public MessageActions Action
        {
            get { return action; }
        }

        public string MessageBodyText
        {
            get { return this.MessageBodyDisplay.Text; }
            set { this.MessageBodyDisplay.Text = value; }
        }

        private ReadingForm()
        {
            InitializeComponent();
            action = MessageActions.DoNothing;
        }

        public ReadingForm(EMailMessage Message, bool AccountSendEnabled)
            : this()
        {
            if (Message == null)
            {
                MessageBox.Show("Error Retrieving Message");
                return;
            }

            this.message = Message;
            this.accountSendEnabled = AccountSendEnabled;

            FillContros();
        }

        private void FillContros()
        {
            if (this.message.Subject != null)
            {
                this.txtEMailSubject.Text = XEMailMessagesHandler.GetUTF8DecodedText(Message.Subject);
            }
            if (this.message.From != null)
            {
                this.txtEMailFrom.Text = XEMailMessagesHandler.GetUTF8DecodedText(XEMailMessagesHandler.GetEMailAddressTag(this.message.From)); 
            }

            if (this.message.To != null)
            {
                txtEMailTo.Text = XEMailMessagesHandler.GetUTF8DecodedText(XEMailMessagesHandler.GetConcatenatedAddressesStrings(this.message.To)); 
            }

            if (this.message.CC != null)
            {
                this.txtEMailCC.Text = XEMailMessagesHandler.GetUTF8DecodedText(XEMailMessagesHandler.GetConcatenatedAddressesStrings(this.message.CC));
            }

            this.lbAttachments.Items.Add("(Attachments)");
            if (this.message.Attachments != null && this.message.Attachments.Length > 0)
            {
                bool added = false;
                foreach (EMailAttachment attach in this.message.Attachments)
                {
                    if (attach.FileName != null)
                    {
                        this.lbAttachments.Items.Add(attach.FileName);
                        added = true;
                    }
                }
                if (added)
                {
                    this.lbAttachments.Enabled = true;
                }
            }
            else
            {
                this.lbAttachments.Enabled = false;
            }

            this.txtPriority.Text = message.Priority;

            this.btnReply.Enabled = this.btnReplyAll.Enabled = this.btnForward.Enabled = accountSendEnabled;

            this.MessageBodyDisplay.DocumentText = XEMailMessagesHandler.GetHigherBodyView(message);
        }

        private void CloseMessageFor(MessageActions Action)
        {
            this.action = Action;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void lbAttachments_DoubleClick(object sender, EventArgs e)
        {
            string value = ((ListBox)sender).SelectedItem.ToString();
            string content = string.Empty;
            string fileName = string.Empty;
            string contentType = string.Empty;
            byte[] contentBytes = new byte[0];

            foreach (EMailAttachment attach in this.message.Attachments)
            {
                if (attach.FileName != null && attach.FileName == value)
                {
                    fileName = attach.FileName;
                    contentType = attach.ContentTransferEncoding;
                    content = attach.ContentStream;
                    break;
                }
            }

            switch (contentType.ToLower())
            {
                case "base64":
                    contentBytes = Convert.FromBase64String(content);
                    break;
                case "7bit":
                    contentBytes = Encoding.UTF7.GetBytes(content);
                    break;
                case "8bit":
                    contentBytes = Encoding.UTF8.GetBytes(content);
                    break;
            }

            if (contentBytes != null && fileName != null)
            {
                FolderBrowserDialog fd = new FolderBrowserDialog();
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    FileStream stream = new FileStream(string.Format(@"{0}\{1}", fd.SelectedPath, fileName), FileMode.Create);
                    stream.Write(contentBytes, 0, contentBytes.Length);
                    stream.Close();

                }
            }
        }

        private void btnReply_Click(object sender, EventArgs e)
        {
            CloseMessageFor(MessageActions.Reply);
        }

        private void btnReplyAll_Click(object sender, EventArgs e)
        {
            CloseMessageFor(MessageActions.ReplyAll);
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            CloseMessageFor(MessageActions.Forward);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            CloseMessageFor(MessageActions.Delete);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbAttachments_DoubleClick(sender, e);
        }
    }
}