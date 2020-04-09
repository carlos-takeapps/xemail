using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using BAFactory.Fx.Network.Email;
using BAFactory.XEMail.ServiceClient;

namespace BAFactory.XEMail.Windows
{
    public partial class WritingForm : Form
    {
        private EMailMessage message;
        private string accountId;
        private MessageActions action;

        public EMailMessage Message
        {
            get { return message; }
        }
        public string AccountId
        {
            get { return accountId; }
        }

        private WritingForm()
        {
            InitializeComponent();
        }
        public WritingForm(EMailMessage Message, MessageActions Action, string AccountId)
            : this()
        {
            if (Message == null)
            {
                MessageBox.Show("Error Retrieving Message");
                return;
            }

            if (AccountId == null || AccountId == string.Empty)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }

            this.message = Message;
            this.action = Action;
            this.accountId = AccountId;

            SetUpEMail();

            FillControls();
        }

        private void FillControls()
        {
            this.txtEMailFrom.Text = XEMailMessagesHandler.GetEMailAddressTag(message.From);
            this.txtEMailSubject.Text = message.Subject;
            this.lbPriority.SelectedItem = message.Priority;
            if (action != MessageActions.Compose)
            {
                this.MessageBodyComposer.Text = message.Body.ContentStream;
            }

            this.txtEMailTo.Text = XEMailMessagesHandler.GetConcatenatedAddressesStrings(message.To);

            FillAttachmentsListBox();

            return;
        }

        private void FillAttachmentsListBox()
        {
            this.lbAttachments.Items.Clear();
            this.lbAttachments.Items.Add("(Attachments)");
            if (this.message.Attachments != null && this.message.Attachments.Length > 0)
            {
                bool attached = false;
                foreach (EMailAttachment attach in this.message.Attachments)
                {
                    if (attach.FileName != null)
                    {
                        this.lbAttachments.Items.Add(attach.FileName);
                        attached = true;
                    }
                }
                if (attached)
                {
                    this.lbAttachments.Enabled = true;
                    this.btnAttachRemove.Enabled = true;
                }
            }
            else
            {
                this.lbAttachments.Enabled = false;
                this.btnAttachRemove.Enabled = false;
            }
        }

        private bool LoadEMailContent()
        {
            accountId = this.txtEMailFrom.Text;
            message.Subject = this.txtEMailSubject.Text;
            message.Priority = this.lbPriority.SelectedItem.ToString();
            message.Body.ContentStream = this.MessageBodyComposer.Text;

            message.To = XEMailMessagesHandler.ParseEMailsString(this.txtEMailTo.Text);
            message.CC = XEMailMessagesHandler.ParseEMailsString(this.txtEMailCC.Text);
            if (message.To.Length == 0)
            {
                MessageBox.Show("No valid recipients where set.");
                return false;
            }

            return true;
        }

        private void SetUpEMail()
        {
            EMailAddress newSender = new EMailAddress(accountId);

            message.Subject = string.Concat(GetNewSubject(), XEMailMessagesHandler.GetUTF8DecodedText(this.message.Subject));
            message.Body.ContentStream = string.Concat(GetBodyHeader(), XEMailMessagesHandler.GetTextOnlyBodyView(message));

            if (action != MessageActions.Forward && action != MessageActions.Compose)
            {
                message.Attachments = new EMailAttachment[0];

                List<EMailAddress> recipients = new List<EMailAddress>();
                if (message.ReplyTo.Address == "@")
                {
                    recipients.Add(message.From);
                }
                else
                {
                    recipients.Add(message.ReplyTo);
                }

                if (action == MessageActions.ReplyAll)
                {
                    foreach (EMailAddress recipient in message.To)
                    {
                        if (recipient.Address == accountId)
                        {
                            continue;
                        }
                        recipients.Add(recipient);
                    }
                    foreach (EMailAddress recipient in message.CC)
                    {
                        if (recipient.Address == accountId)
                        {
                            continue;
                        }
                        recipients.Add(recipient);
                    }
                }
                message.To = recipients.ToArray();
            }
            else
            {
                message.To = new EMailAddress[0];
            }
            message.From = newSender;
        }

        private string GetNewSubject()
        {
            string result = string.Empty;
            switch (action)
            {
                case MessageActions.Forward:
                    result = "FW: ";
                    break;
                case MessageActions.Reply:
                case MessageActions.ReplyAll:
                    result = "RE: ";
                    break;
                default:
                    result = string.Empty;
                    break;
            }
            return result;
        }
        private string GetBodyHeader()
        {
            StringBuilder result = new StringBuilder();
            result.Append("\r\n\r\n\r\n\r\n\r\n\r\n");
            result.Append("----- Original Message -----\r\n");
            result.AppendFormat("From: {0}\r\n", message.From);
            result.AppendFormat("To: {0}\r\n", XEMailMessagesHandler.GetConcatenatedAddressesStrings(message.To));
            result.AppendFormat("Subject: {0}\r\n", message.Subject);
            result.AppendFormat("Sent: {0}\r\n", message.Date);
            return result.ToString();
        }

        #region Controls Event Handlers
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (LoadEMailContent())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnAttachRemove_Click(object sender, EventArgs e)
        {
            if (lbAttachments.SelectedItem == null || lbAttachments.SelectedItem.ToString() == string.Empty)
            {
                return;
            }
            EMailAttachment[] tmp = new EMailAttachment[message.Attachments.Length - 1];
            int copied = 0;
            for (int i = 0; i < message.Attachments.Length; ++i)
            {
                if (message.Attachments[i].FileName != lbAttachments.SelectedItem.ToString())
                {
                    tmp[i + copied] = message.Attachments[i];
                }
                else
                {
                    copied = -1;
                }
            }
            message.Attachments = tmp;
            this.FillAttachmentsListBox();
        }
        #endregion
    }
}
