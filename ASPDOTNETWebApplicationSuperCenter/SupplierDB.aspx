<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SupplierDB.aspx.cs" Inherits="ASPDOTNETWebApplicationSuperCenter.WebForm2" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            List of Suppliers for the Super Center Store</div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SuperCenterRetailStoreConnectionString2 %>" ProviderName="<%$ ConnectionStrings:SuperCenterRetailStoreConnectionString2.ProviderName %>" SelectCommand="SELECT * FROM [suppliers]"></asp:SqlDataSource>
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="supplier_id" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="supplier_id" HeaderText="supplier_id" ReadOnly="True" SortExpression="supplier_id" />
                <asp:BoundField DataField="company_name" HeaderText="company_name" SortExpression="company_name" />
                <asp:BoundField DataField="contact_name" HeaderText="contact_name" SortExpression="contact_name" />
                <asp:BoundField DataField="contact_title" HeaderText="contact_title" SortExpression="contact_title" />
                <asp:BoundField DataField="address" HeaderText="address" SortExpression="address" />
                <asp:BoundField DataField="city" HeaderText="city" SortExpression="city" />
                <asp:BoundField DataField="region" HeaderText="region" SortExpression="region" />
                <asp:BoundField DataField="postal_code" HeaderText="postal_code" SortExpression="postal_code" />
                <asp:BoundField DataField="country" HeaderText="country" SortExpression="country" />
                <asp:BoundField DataField="phone" HeaderText="phone" SortExpression="phone" />
                <asp:BoundField DataField="fax" HeaderText="fax" SortExpression="fax" />
                <asp:BoundField DataField="homepage" HeaderText="homepage" SortExpression="homepage" />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
