using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

using BAFactory.XEMail.ServiceClient;

public partial class UserConfig : System.Web.UI.Page
{
    private XEMailClient client;

    protected void Page_Load(object sender, EventArgs e)
    {
        client = SessionObjectsManager.GetClientForSession();
        BindDataGrid();
    }

    protected void BindDataGrid()
    {
        if (client==null)
        {
            Response.Redirect("login.aspx");
        }

        dgAccounts.DataSource = client.ConfigurationObject.Accounts.GetTableForDataSource();
        dgAccounts.DataBind();
    }

    protected void dgAccounts_RowEditing(object sender, GridViewEditEventArgs e)
    {
        dgAccounts.EditIndex = e.NewEditIndex;
        dgAccounts.DataBind();
    }
}
