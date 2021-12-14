<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LibraryManagement.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            User Name :<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p>
            Password :
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <asp:Button ID="Button1" runat="server" Height="53px" OnClick="Button1_Click" style="margin-bottom: 0px" Text="Login" Width="88px" />
        <asp:Label ID="Label6" runat="server"></asp:Label>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
