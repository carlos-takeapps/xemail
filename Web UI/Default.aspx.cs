using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

using BAFactory.Fx.Network.Email;
using BAFactory.XEMail.ServiceClient;

public partial class _Default : System.Web.UI.Page
{
    private XEMailClient client;
    private DataTable emailsTable;

    protected void Page_Load(object sender, EventArgs e)
    {
        client = SessionObjectsManager.GetClientForSession();

        if (!Page.IsPostBack)
        {
            CheckEmails();
        }

        BindDataGrid();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        CheckEmails();
    }

    private void CheckEmails()
    {
        if (client != null)
        {
            StartEmailsCheck(false);
        }
    }

    private void StartEmailsCheck()
    {
        StartEmailsCheck(true);
    }
    
    private void StartEmailsCheck(bool DoAsync)
    {
        if (DoAsync)
            client.BeginRetrieveAllAccountsEMailsHeaders();
        else
            client.RetrieveAllAccountsEMailsHeaders();
    }
    
    private void BindDataGrid()
    {
        emailsTable = client.XEMailsDS.Tables[0];

        this.dgEMailsList.AutoGenerateColumns = false;
        //this.dgEMailsList.CellFormatting += new DataGridViewCellFormattingEventHandler(dgEMailsList_CellFormatting);

        //this.dgEMailsList.Columns[1].DataPropertyName = "AccountName";
        //this.dgEMailsList.Columns[0].DataPropertyName = "Priority";
        //this.dgEMailsList.Columns[3].DataPropertyName = "From";
        //this.dgEMailsList.Columns[2].DataPropertyName = "Number";
        //this.dgEMailsList.Columns[4].DataPropertyName = "Subject";
        //this.dgEMailsList.Columns[5].DataPropertyName = "Bytes";
        //this.dgEMailsList.Columns[6].DataPropertyName = "Date";
        //this.dgEMailsList.Columns[6].ValueType = typeof(DateTime);

        this.dgEMailsList.DataSource = this.emailsTable;
        ((BoundField)this.dgEMailsList.Columns[0]).DataField = "Priority";
        ((BoundField)this.dgEMailsList.Columns[1]).DataField = "AccountName";
        ((BoundField)this.dgEMailsList.Columns[2]).DataField = "Number";
        ((BoundField)this.dgEMailsList.Columns[3]).DataField = "From";
        ((BoundField)this.dgEMailsList.Columns[4]).DataField = "Subject";
        ((BoundField)this.dgEMailsList.Columns[5]).DataField = "Bytes";
        ((BoundField)this.dgEMailsList.Columns[6]).DataField = "Date";

        //this.dgEMailsList.Sort(this.dgEMailsList.Columns[2].ToString(), SortDirection.Descending);
        this.dgEMailsList.DataBind();
    }

    protected void dgEMailsList_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        dgEMailsList.PageIndex = e.NewPageIndex;
        client.ToString();
        dgEMailsList.DataBind();
    }
}
