<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Practical_5A.WebForm1" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Website Navigation</h2>
            <asp:Menu ID="menu1" runat="server" DataSourcelD="siteMapDataSource" Orientation="Horizontal"></asp:Menu>
            <asp:SiteMapDataSource ID="siteMapDataSource" runat="server" ShowStartingNode="false" />
        </div>
    </form>
</body>
</html>
