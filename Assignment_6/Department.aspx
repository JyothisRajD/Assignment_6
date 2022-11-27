<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Department.aspx.cs" Inherits="Challenge6.DepartmentPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large">Department Details</asp:Label>
                <table>
                    <tr>
                        <td>
                            <br />
                        </td>
                    </tr>
                    
                    <tr>
                        <th>
                            <asp:Label ID="Label2" runat="server" Text="Department Name"></asp:Label>
                        </th>
                        <td>
                            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <th>
                            <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" />
                        </th>                       
                    </tr>
                    <tr>
                        <th><a href="Designation.aspx">Designation</a></th>
                    </tr>
                    <tr>
                        <th colspan="2">
                            <asp:Label ID="Label3" runat="server"></asp:Label>
                        </th>
                    </tr>
                   
                </table>
       
            </center>
        </div>
    </form>
</body>
</html>
