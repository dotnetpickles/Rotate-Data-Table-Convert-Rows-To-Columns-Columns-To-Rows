<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .grdhead
        {
            background-color: #003399 !important;
            color: White !important;
            width: 100px;
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <asp:GridView ID="grdProducts" CssClass="Grid" HeaderStyle-CssClass="header" runat="server" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4">
        <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
<HeaderStyle CssClass="header" BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF"></HeaderStyle>
        <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
        <RowStyle BackColor="White" ForeColor="#003399" />
        <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
        <SortedAscendingCellStyle BackColor="#EDF6F6" />
        <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
        <SortedDescendingCellStyle BackColor="#D6DFDF" />
        <SortedDescendingHeaderStyle BackColor="#002876" />
    </asp:GridView>
    <br />
    <asp:Button ID="btnConvertRowstoColumns" runat="server" Text="Rows to Columns" OnClick="btnConvertRowstoColumns_Click"
        CommandArgument="RowstoColumns" />
    <asp:Button ID="btnConvertColumnstoRows" runat="server" Text="Columns to Rows" OnClick="btnConvertRowstoColumns_Click"
        CommandArgument="ColumnstoRows" Visible="false" />
    </form>
</body>
</html>
