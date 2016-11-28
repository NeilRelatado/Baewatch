<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StartScreen.aspx.cs" Inherits="SearchBarwithMasterPage.StartScreen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Welcome to BaeWatch"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Button ID="btnSignIn" runat="server" Text="Sign In" OnClick="btnSignIn_Click" />
        <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" />
    
    </div>
    </form>
</body>
</html>
