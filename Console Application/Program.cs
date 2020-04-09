using System;
using System.Configuration;
using System.Net;
using System.Net.Mail;
using BAFactory.XEMail.ConsoleApplication.XEMail;

namespace BAFactory.XEMail.ConsoleApplication
{
    class Program
    {
        private static ServiceSoapClient client;
        private static SendSmtpEMailRequest req;
        private static SendSmtpEMailResponse resp;

        static void Main(string[] args)
        {
            if (args.Length < 3)
            {
                Console.WriteLine("Provide all arguments: [recipient] [subject] [message]");
                return;
            }

            XEMail.EMailAddress recipient = CreateAddress(args[0]);
            XEMail.EMailAddress from = CreateAddress(GetConfigValue("from"));

            client = new ServiceSoapClient();
            req = new SendSmtpEMailRequest();

            LoadConfiguration(ref req);

            req.Message = CreateMessage(from, recipient, args[0], args[1]);

            try
            {
                WebRequest.DefaultWebProxy.Credentials = System.Net.CredentialCache.DefaultNetworkCredentials;
                resp = client.SendSmtpEMail(req);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            if (resp != null)
            {
                Console.WriteLine(string.Concat("Message was", resp.SendSmtpEMailResult ? string.Empty : "NOT ", " sent"));
            }
#if(DEBUG)
            Console.ReadLine();
#endif
        }

        private static void LoadConfiguration(ref SendSmtpEMailRequest req)
        {
            req.Password = GetConfigValue("password");
            req.Port = int.Parse(GetConfigValue("port"));
            req.Server = GetConfigValue("server");
            req.Ssl = bool.Parse(GetConfigValue("Ssl"));
            req.Username = GetConfigValue("username");
        }

        private static string GetConfigValue(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

        private static EMailAddress CreateAddress(string address)
        {
            MailAddress test = new MailAddress(address);

            EMailAddress result = new EMailAddress();
            result.Address = address;
            return result;
        }

        private static EMailMessage CreateMessage(EMailAddress from, EMailAddress recipient, string subject, string message)
        {
            EMailMessage result = new EMailMessage();
            
            result.Subject = subject;
            result.From = from;
            result.To = new EMailAddress[1];
            result.To[0] = recipient;
            result.Body = new EMailBodyAlternateView();
            result.Body.ContentStream = message;

            return result;
        }
    }
}
