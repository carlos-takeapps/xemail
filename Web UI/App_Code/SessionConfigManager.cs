using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

using BAFactory.XEMail.ServiceClient;

/// <summary>
/// Summary description for SessionConfigManager
/// </summary>
public class SessionObjectsManager
{
    static SessionObjectsManager()
    {
    }

    public static XEMailClient GetClientForSession()
    {
        XEMailClient client = (XEMailClient)HttpContext.Current.Session["client"];
        return client;
    }

    public static void SetClientForSession(XEMailClient client)
    {
        HttpContext.Current.Session.Add("client", client);
    }

}
