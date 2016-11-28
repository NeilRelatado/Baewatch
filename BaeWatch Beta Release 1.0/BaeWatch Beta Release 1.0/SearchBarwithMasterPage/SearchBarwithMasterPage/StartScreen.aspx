<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StartScreen.aspx.cs" Inherits="SearchBarwithMasterPage.StartScreen" %>

<!DOCTYPE html>
<link href="Layout.css" rel="stylesheet" type="text/css" />
<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title>BaeWatch Beta (Release 1.0)</title>
</head>

<body>
    <form id="form1" runat="server">
    <div class="container">
        <h2>Welcome to</h2>
        <!--<asp:label ID="Label1" runat="server" Text="Greetings and Welcome to BaeWatch"></asp:label>-->
        <br />
        <img alt="BaeWatch Official Logo" src="/images/logo.png" height="128" width:"128" />
        <br />
        <br />
        <asp:button ID="btnSignIn" runat="server" Text="Sign In" OnClick="btnSignIn_Click" />
        <asp:button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" />
    </div>
    </form>
</body>
</html>
