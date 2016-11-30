<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AccountSettings.aspx.cs" Inherits="SearchBarwithMasterPage.AccountSettings" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 119px;
        }
        .auto-style2 {
            width: 309px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">

    <b>Update your Information</b>
    <table style="width: 100%;">
        <tr>
            <td class="auto-style1"><b>Description:</b></td>
            <td class="auto-style2">
                <asp:textbox ID="txtDescription" runat="server" Width="969px"></asp:textbox>
            </td>
            <td>
                <asp:button ID="btnUpdateDesc" runat="server" text="Update" OnClick="btnUpdateDesc_Click" />
            </td>
            
        </tr>
        <tr>
            <td class="auto-style1"><b>Intrests: </b></td>
            <td class="auto-style2">
                <asp:textbox  ID="txtIntrests" runat="server" Width="969px"></asp:textbox>
            </td>
            <td>
                <asp:button ID="btnUpdateInt" runat="server" text="Update" OnClick="btnUpdateInt_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style1"><b>Gender</b></td>
            <td class="auto-style2">
                
                 <asp:radiobutton ID="Male" GroupName="Genders" Text="Male" runat="server"></asp:radiobutton>
                <asp:radiobutton  ID="Female" GroupName="Genders" Text="Female" runat="server"></asp:radiobutton>
                <asp:radiobutton  ID="Other" GroupName="Genders" Text="Other" runat="server"></asp:radiobutton>
            </td>
            <td class="auto-style2">
                <asp:button ID="btnUpdateGender" runat="server" text="Update" OnClick="btnUpdateGender_Click" />
            </td>
            
        </tr>
        <tr>
            <td><asp:label ID="lblOrientation" runat="server" Text="Orientation "></asp:label></td>
            <td>
                <asp:radiobutton ID="Strait" GroupName="Orientation" Text="Straight" runat="server"></asp:radiobutton>
                <asp:radiobutton ID="Gay" Text="Gay" GroupName="Orientation"  runat="server"></asp:radiobutton>
                <asp:radiobutton ID="OtherOrientation" GroupName="Orientation" Text="Other" runat="server"></asp:radiobutton>
            </td>
            <td class="auto-style2">
                <asp:button ID="btnOrientation" runat="server" text="Update" OnClick="btnOrientation_Click"/>
            </td>
        </tr>
        <tr>
            <td><asp:label ID="lblType" runat="server" Text="Type "></asp:label></td>
            <td>
                <asp:radiobutton ID="LongT" Text="Long Term" runat="server"></asp:radiobutton>
                <asp:radiobutton ID="ShortT" Text="Short Term" runat="server"></asp:radiobutton>
                <asp:radiobutton ID="Friends" Text="Just Friends" runat="server"></asp:radiobutton>
            </td>
            <td class="auto-style2">
                <asp:button ID="btnUpdateType" runat="server" text="Update" />
            </td>
        </tr>
        <tr>
            <td><asp:label ID="lblImage" runat="server" Text="Profile Picture"></asp:label></td>
            <td><asp:FileUpload ID="ImageSearch" runat="server" /></td>
            <td class="auto-style2">
                <asp:button ID="btnUpdateImage" runat="server" text="Update" />
            </td>
            
        </tr>       
    </table>
    <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
    <br />















    <asp:Button ID="btnDelete" runat="server" Text="Delete your account" OnClick="btnDelete_Click" />
</asp:Content>
