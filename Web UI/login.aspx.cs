using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.IO;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Web.Configuration;
using System.Xml;

using BAFactory.XEMail.ServiceClient;

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void LoginAuthenticate(object sender, AuthenticateEventArgs e)
    {
        bool authenticated = FormsAuthentication.Authenticate(this.LoginForm.UserName, this.LoginForm.Password);
        
        if (authenticated)
        {
            XEMailClient client = new XEMailClient();

            string configPath = string.Concat(AppDomain.CurrentDomain.BaseDirectory, LoginForm.UserName, ".xml");

            if (!File.Exists(configPath))
            {
                Response.Redirect("userconfig.aspx");                
            }
            else
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(configPath);

                XEMailClientConfiguration newConfig = new XEMailClientConfiguration();
                newConfig.ImportConfigurationFromXml(doc);

                client.ConfigurationObject = newConfig;
            }

            SessionObjectsManager.SetClientForSession(client);

            FormsAuthentication.RedirectFromLoginPage(this.LoginForm.UserName, true);
        }
    }
}
