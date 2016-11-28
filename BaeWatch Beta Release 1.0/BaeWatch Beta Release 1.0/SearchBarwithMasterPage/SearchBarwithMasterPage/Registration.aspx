<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="SearchBarwithMasterPage.Registration" %>

<!DOCTYPE html>
<link href="Layout.css" rel="stylesheet" type="text/css" />
<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title>BaeWatch Beta (Release 1.0)</title>
</head>

<body>
    <form id="form1" runat="server">
        <div class="container">
        <h3>BaeWatch Sign-up Form</h3>
        <h4>Unifying Dating and Networking Into Something Greater :)</h4>
        <table>
        <tr>
            <td><asp:label ID="lblUsername" runat="server" Text="Username"></asp:label></td>
            <td> <asp:textBox ID="txtUserName" runat="server" Width="476px"></asp:textBox></td>
        </tr>
        <tr>
            <td><asp:label ID="lblPassword" runat="server" text="Password"></asp:label></td>
            <td><asp:textbox ID="txtPassword" runat="server" Width="476px"></asp:textbox></td>
            
        </tr>
        <tr>
            
            <td><asp:label ID="lblDescription" runat="server" Text="Description"></asp:label></td>
            <td><asp:textBox ID="txtDescription" runat="server" Width="476px"></asp:textBox></td>
        </tr>
        <tr>
            <td><asp:label ID="lblIntrests" runat="server" Text="Interests "></asp:label></td>
            <td><asp:textBox ID="txtIntrests" runat="server" Width="476px"></asp:textBox></td>
            
        </tr>
        <tr>
            <td> <asp:label ID="lblGender" runat="server" Text="Gender"></asp:label></td>
            <td>
                 <asp:radiobutton ID="Male" Text="Male" runat="server"></asp:radiobutton>
                <asp:radiobutton  ID="Female" Text="Female" runat="server"></asp:radiobutton>
                <asp:radiobutton  ID="Other" Text="Other" runat="server"></asp:radiobutton>
            </td>
        </tr>
        <tr>
            <td><asp:label ID="lblOrientation" runat="server" Text="Orientation "></asp:label></td>
            <td>
                <asp:radiobutton ID="Strait" Text="Straight" runat="server"></asp:radiobutton>
                <asp:radiobutton ID="Gay" Text="Gay" runat="server"></asp:radiobutton>
                <asp:radiobutton ID="OtherOrientation" Text="Other" runat="server"></asp:radiobutton>
            </td>
        </tr>
        <tr>
            <td><asp:label ID="lblType" runat="server" Text="Type "></asp:label></td>
            <td>
                <asp:radiobutton ID="LongT" Text="Long Term" runat="server"></asp:radiobutton>
                <asp:radiobutton ID="ShortT" Text="Short Term" runat="server"></asp:radiobutton>
                <asp:radiobutton ID="Friends" Text="Just Friends" runat="server"></asp:radiobutton>
            </td>
        </tr>
        <tr>
            <td><asp:label ID="lblImage" runat="server" Text="Profile Picture"></asp:label></td>
            <td><asp:FileUpload ID="ImageSearch" runat="server" /></td>
            
        </tr>       
        </table>

        <br />
        <asp:button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" />
        <asp:button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
        <br />
        <br />
        <asp:label ID="lblMessage" runat="server" Text=""></asp:label>
    </div>
    <p class="copyright">&copy; Copyright 2016 <a href="StartScreen.aspx" target="_blank" title="Colorlib">BaeWatch</a></p>
    </form>
</body>
</html>
