<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Practical_3A.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Calendar ID="Calendar1" OnDayRender="Calendar1_DayRender" OnSelectionChanged="Calendar1_SelectionChanged" runat="server"></asp:Calendar>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Result" OnClick="btnResult_Click" />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Reset" OnClick="btnReset_Click"/>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label><br />
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label><br />
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label><br />
        <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label><br />
        <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label><br />
    </div>
    </form>
</body>
</html>
