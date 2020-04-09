<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
<style id="style-class" type="text/css">
    .collClass
    {
        color:red;
        font-size:12px;
    }
    
</style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
                <asp:GridView ID="dgEMailsList" runat="server" AutoGenerateColumns="False" BackColor="White"
                    BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" 
                    AllowPaging="True" AllowSorting="True" CssClass="collClass" 
                    onpageindexchanging="dgEMailsList_PageIndexChanging">
                    <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                    <Columns>
                        <asp:BoundField HeaderText="!" ReadOnly="True" />
                        <asp:BoundField HeaderText="AccountName" />
                        <asp:BoundField HeaderText="Number" />
                        <asp:BoundField HeaderText="From" />
                        <asp:BoundField HeaderText="Subject" />
                        <asp:BoundField HeaderText="Bytes" />
                        <asp:BoundField HeaderText="Received" />
                    </Columns>
                    <RowStyle BackColor="White" ForeColor="#003399" />
                    <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                    <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                    <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                </asp:GridView>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" /></div>
        
    </form>
</body>
</html>
