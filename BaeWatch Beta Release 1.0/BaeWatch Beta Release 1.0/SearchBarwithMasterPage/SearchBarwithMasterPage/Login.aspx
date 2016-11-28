<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SearchBarwithMasterPage.Login" %>

<!DOCTYPE html>
<link href="Layout.css" rel="stylesheet" type="text/css" />
<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title>BaeWatch Beta (Release 1.0)</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="container">
         <h4 style="font-size: medium">Log In</h4>
         <hr />
         <asp:placeholder runat="server" ID="LoginStatus" Visible="false">
            <p>
               <asp:Literal runat="server" ID="StatusText" />
            </p>
         </asp:placeholder>
         <asp:placeholder runat="server" ID="LoginForm" Visible="false">
            <div style="margin-bottom: 10px">
               <asp:label runat="server" AssociatedControlID="UserName">User name</asp:label>
               <div>
                  <asp:textBox runat="server" ID="UserName" />
               </div>
            </div>
            <div style="margin-bottom: 10px">
               <asp:label runat="server" AssociatedControlID="Password">Password</asp:label>
               <div>
                  <asp:textBox runat="server" ID="Password" TextMode="Password" />
               </div>
            </div>
            <div style="margin-bottom: 10px">
               <div>
                  <asp:button runat="server" OnClick="SignIn" Text="Log in" />
               </div>
            </div>
         </asp:placeholder>
         <asp:placeholder runat="server" ID="LogoutButton" Visible="false">
            <div>
               <div>
                  <asp:button runat="server" OnClick="SignOut" Text="Log out" />
               </div>
            </div>
         </asp:placeholder>
    
    </div>
    </form>
</body>
</html>
