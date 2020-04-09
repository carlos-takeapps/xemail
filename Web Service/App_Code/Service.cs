using System;
using System.Data;
using System.Net;
using System.Net.Mail;
using System.Web.Services;
using BAFactory.Fx.Network.Email;
using BAFactory.Fx.Utilities.Email;

[WebService(Namespace = "http://www.siprod.net/webservices/XEMail/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
public class Service : System.Web.Services.WebService
{
    public Service()
    {
        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    /// <summary>
    /// Retrieves the list of emails stored on the server.
    /// </summary>
    /// <param name="Server">The Server Name or IP address.</param>
    /// <param name="Username">The Username.</param>
    /// <param name="Password">The Password.</param>
    /// <returns></returns>
    [WebMethod]
    public EMailsListElement[] ListPop3EMails(String Server, int Port, string Username, string Password, bool Ssl)
    {
        Pop3Provider popMngr = new Pop3Provider(Server, Port, Username, Password, Ssl);
        EMailsListElement[] mails = new EMailsListElement[0];
        try
        {
            popMngr.OpenConnection();
            mails = popMngr.ListEmails();
            popMngr.CloseConnection();
        }
        catch
        {
        }

        return mails;
    }

    [WebMethod]
    public EMailMessage[] GetAllPop3EMailsHeaders(String Server, int Port, string Username, string Password, bool ssl)
    {
        Pop3Provider popMngr = new Pop3Provider(Server, Port, Username, Password, ssl);
        EMailMessage[] mails = new EMailMessage[0];
        try
        {
            popMngr.OpenConnection();
            mails = popMngr.GetAllMessagesHeaders(0);
            popMngr.CloseConnection();
        }
        catch
        {
        }
        return mails;

    }

    [WebMethod]
    public EMailMessage[] GetAllPop3EMailsHeadersDecoded(String Server, int Port, string Username, string Password, bool Ssl)
    {
        Pop3Provider popMngr = new Pop3Provider(Server, Port, Username, Password, Ssl);
        EMailMessage[] mails = new EMailMessage[0];
        try
        {
            //mails = popMngr.GetAllMessagesHeaders(0, true);
            throw new ApplicationException("Not implemented");
        }
        catch
        {
        }

        throw new ApplicationException("Not implemented");

        //return mails;

    }

    [WebMethod]
    public DataSet GetAllPop3EMailsHeadersDS(String Server, int Port, string Username, string Password, bool Ssl)
    {
        Pop3Provider popMngr = new Pop3Provider(Server, Port, Username, Password, Ssl);
        DataSet XEMails = new DataSet();
        
        try
        {
            popMngr.OpenConnection();
            XEMails.Tables.Add(popMngr.GetAllMessagesHeadersDT(0));
            popMngr.CloseConnection();
        }
        catch
        {
        }

        return XEMails;
    }
    
    [WebMethod]
    public string GetAllPop3EMailsHeadersHtml(String Server, int Port, string Username, string Password, bool Ssl)
    {
        EMailMessage[] emails = GetAllPop3EMailsHeaders(Server, Port, Username, Password, Ssl);

        System.Text.StringBuilder bldr = new System.Text.StringBuilder();

        bldr.Append("<div><table>");
        bldr.Append("<tr><td>#</td><td>from</td><td>subject</td><td>date</td></tr>");
        foreach (EMailMessage em in emails)
        {
            bldr.AppendFormat("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td></tr>", em.Number, em.From, em.Subject, em.Date);
        }
        bldr.Append("</table></div>");

        return bldr.ToString();
    }

    [WebMethod]
    public EMailMessage RetrievePop3EMail(String Server, int Port, string Username, string Password, bool Ssl, int MessageNumber)
    {
        Pop3Provider popMngr = new Pop3Provider(Server, Port, Username, Password, Ssl);
        EMailMessage mails = null;
        try
        {
            popMngr.OpenConnection();
            mails = popMngr.RetrieveEmail(MessageNumber);
            popMngr.CloseConnection();
        }
        catch
        {
        }

        return mails;
    }

    [WebMethod]
    public String RetrievePop3RawEMailStream(String Server, int Port, string Username, string Password, bool Ssl, int MessageNumber)
    {
        Pop3Provider popMngr = new Pop3Provider(Server, Port, Username, Password, Ssl);
        string mail = string.Empty;
        try
        {
            popMngr.OpenConnection();
            mail = popMngr.RetrieveRawEmailStream(MessageNumber);
            popMngr.CloseConnection();
        }
        catch
        {
        }

        return mail;
    }

    [WebMethod]
    public bool DeletePop3EMail(String Server, int Port, string Username, string Password, bool Ssl, int MessageNumber)
    {
        Pop3Provider popMngr = new Pop3Provider(Server, Port, Username, Password, Ssl);
        bool result = false;
        try
        {
            popMngr.OpenConnection();
            result = popMngr.DeleteMessage(MessageNumber);
            popMngr.CloseConnection();
        }
        catch
        {
        }

        return result;
    }

    [WebMethod]
    public bool SendSmtpEMail(String Server, int Port, string Username, string Password, bool Ssl, EMailMessage Message)
    {
        bool result = false;

        MailMessage msMail = (MailMessage)Message;

        SmtpClient smtpClient;
        smtpClient = new SmtpClient(Server, Port);
        smtpClient.EnableSsl = Ssl;
        smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
        smtpClient.Credentials = new NetworkCredential(Username, Password);
        try
        {
            smtpClient.Send(msMail);
            result = true;
        }
        catch
        {
        }

        return result;
    }


}
