<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Designation.aspx.cs" Inherits="Challenge6.DesignationPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title></title>
</head>
<body ">
    <form id="form1" runat="server">
        <div>
            <center >
                <table">
                   
                    <tr>
                        <th>
                            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large">Designation Details</asp:Label>
                        </th>
                    </tr>
                    <tr>
                        <td>
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <th >
                           <asp:Label ID="Label2" runat="server" Text="Department"></asp:Label>
                        </th>
                        <td>
                            <asp:DropDownList ID="DropDownList1" runat="server" ></asp:DropDownList><br />
                        </td>
                    </tr>
                    <tr>
                        <th>
                            <asp:Label ID="Label3" runat="server" Text="Designation Name"></asp:Label>
                        </th>
                        <td>
                            <asp:TextBox ID="TextBox3" runat="server" CssClass="auto-style4" Height="27px" Width="145px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <th >
                            <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" />
                        </th>                       
                    </tr>
                    <tr>
                        <th ><b ><a href="Department.aspx">Add Department</a></b></th>
                    </tr>
                </table>
        </center>
           
         
        </div>
         <center>
        <div class="auto-style1">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="DesignationId" HorizontalAlign="Center" EmptyDataText="No Records to Display" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" OnRowDataBound="GridView1_RowDataBound" CssClass="auto-style2" Height="146px" Width="573px">
                <Columns>
                    <asp:BoundField DataField="DesignationId" HeaderText="Designation Id" />
                    <asp:BoundField DataField="DesignationName" HeaderText="Designation Name" />
                    <asp:TemplateField HeaderText="Department Id">
                        <EditItemTemplate>
                            <asp:DropDownList ID="dropdown2" runat="server" AutoPostBack="true" EnableViewState="true" ></asp:DropDownList>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="label1" runat="server" Text='<%#Eval("DepartmentName") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:CommandField HeaderText="Edit" ShowEditButton="True" />
                    <asp:CommandField HeaderText="Delete" ShowDeleteButton="True" />
                </Columns>
            </asp:GridView>
        </div>
          </center>
    </form>
</body>
</html>
