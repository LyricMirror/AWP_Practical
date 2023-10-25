<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Practical_3B.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TreeView ID="TreeView1" runat="server" Width="150px" ImageSet="Arrows">
                <Nodes>
                    <asp:TreeNode Text="ASP.NET Practs" Value="New Node">
                        <asp:TreeNode Text="Calendar Control" Value="RED" NavigateUrl=""></asp:TreeNode>
                        <asp:TreeNode Text="Constructor Overloading" Value="GREEN" NavigateUrl=""></asp:TreeNode>
                        <asp:TreeNode NavigateUrl="" Text="Inheritance" Value="BLUE"></asp:TreeNode>
                        <asp:TreeNode NavigateUrl="" Text="Class Properties" Value="ClassProperties"></asp:TreeNode>
                    </asp:TreeNode>
                </Nodes>
            </asp:TreeView>
            <asp:DataList ID="DataList1" runat="server">
                <ItemTemplate>
                    <table class="table" border="1">
                        <tr>
                            <td>Roll Num : <%# Eval("sid") %><br />
                                Name : <%# Eval("sname") %><br />
                                Class : <%# Eval("sclass")%>
                            </td>
                        </tr>
                    </table>
                </ItemTemplate>
            </asp:DataList>
        </div>
    </form>
</body>
</html>
