<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="LibraryManagement.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Book Name"></asp:Label>
        <asp:TextBox ID="Bkname1" runat="server"></asp:TextBox>
        <br />
        <p>
            <asp:Button ID="Button1" runat="server" Text="check" />
        </p>
    </form>
</body>
</html>
