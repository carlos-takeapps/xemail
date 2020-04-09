using System.Data;
using System.Net;
using System.Net.Mail;

using BAFactory.Fx.Network.Email;
using BAFactory.Fx.Utilities.Email;

namespace SiProd.Applications.XEMail.WCFService
{
    public class XEMailService : IXEMailService
    {
        #region IXEmailService Members

        public EMailsListElement[] ListPop3EMails(string Server, int Port, string Username, string Password, bool Ssl)
        {
            Pop3Manager popMngr = new Pop3Manager(Server, Port, Username, Password, Ssl);
            EMailsListElement[] mails = new EMailsListElement[0];
            try
            {
                mails = popMngr.ListEmails();
            }
            catch
            {
            }

            return mails;
        }

        public EMailMessage[] GetAllPop3EMailsHeaders(string Server, int Port, string Username, string Password, bool Ssl)
        {
            Pop3Manager popMngr = new Pop3Manager(Server, Port, Username, Password);
            EMailMessage[] mails = new EMailMessage[0];
            try
            {
                mails = popMngr.GetAllMessagesHeaders(0);
            }
            catch
            {
            }
            return mails;
        }

        public DataSet GetAllPop3EMailsHeadersDS(string Server, int Port, string Username, string Password, bool Ssl)
        {
            Pop3Manager popMngr = new Pop3Manager(Server, Port, Username, Password, Ssl);
            DataSet XEMails = new DataSet();

            try
            {
                XEMails.Tables.Add(popMngr.GetAllMessagesHeadersDT(0));
            }
            catch
            {
            }

            return XEMails;
        }

        public EMailMessage RetrievePop3EMail(string Server, int Port, string Username, string Password, bool Ssl, int MessageNumber)
        {
            Pop3Manager popMngr = new Pop3Manager(Server, Port, Username, Password, Ssl);
            EMailMessage mails = null;
            try
            {
                mails = popMngr.RetrieveEmail(MessageNumber);
            }
            catch
            {
            }

            return mails;
        }

        public string RetrievePop3RawEMailStream(string Server, int Port, string Username, string Password, bool Ssl, int MessageNumber)
        {
            Pop3Manager popMngr = new Pop3Manager(Server, Port, Username, Password, Ssl);
            string mail = string.Empty;
            try
            {
                mail = popMngr.RetrieveRawEmailStream(MessageNumber);
            }
            catch
            {
            }

            return mail;
        }

        public bool DeletePop3EMail(string Server, int Port, string Username, string Password, bool Ssl, int MessageNumber)
        {
            Pop3Manager popMngr = new Pop3Manager(Server, Port, Username, Password, Ssl);
            bool result = false;
            try
            {
                result = popMngr.DeleteMessage(MessageNumber);
            }
            catch
            {
            }

            return result;
        }

        public bool SendSmtpEMail(string Server, int Port, string Username, string Password, bool Ssl, BAFactory.Fx.Network.Email.EMailMessage Message)
        {
            bool result = true;

            MailMessage msMail = (MailMessage)Message;

            SmtpClient smtpClient;
            smtpClient = new SmtpClient(Server, Port);
            smtpClient.EnableSsl = Ssl;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.Credentials = new NetworkCredential(Username, Password);
            
            smtpClient.Send(msMail);

            return result;
        }

        #endregion
    }
}
