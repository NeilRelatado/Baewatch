<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="UserProfile.aspx.cs" Inherits="SearchBarwithMasterPage.UserProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 399px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">



    <asp:image ID="ProfilePic" Height="500px" Width="500px" runat="server"></asp:image>
    
    
    
    <div style="font-family: Arial">
<table border="1" style="background: LightGoldenrodYellow">
<div style="font-family: Arial">
<table border="1" style="background: LightGoldenrodYellow">
    <tr>
        <td>
            <b>ID</b>
        </td>
        <td class="auto-style1">
            <asp:Label ID="lblID" runat="server"></asp:Label>
        </td>
    </tr>
     <tr>
        <td>
            <b>Username</b>
        </td>
        <td class="auto-style1">
            <asp:Label ID="lblUsername" runat="server"></asp:Label>
        </td>
    </tr>
          
    <tr>
        <td>
            <b>Description</b>
        </td>
        <td class="auto-style1">
            <asp:Label ID="lblDesc" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <b>Intrests</b>
        </td>
        <td class="auto-style1">
             <asp:Label ID="lblIntest" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
 <b>Gender</b>

        </td>
        
 <td class="auto-style1">
        <asp:Label ID="lblGender" runat="server"></asp:Label>
   </td>
    </tr>
    <tr>
        <td>
            <b>Orientation</b>
        </td>
        <td>
            <asp:label runat="server" ID="lblO"></asp:label>
        </td>
    </tr>
    <tr>
        <td>
            <b>Type</b>
        </td>
        <td>
            <asp:label runat="server" ID="lblType"></asp:label>
        </td>
   </tr>
</table>
</div></table>
 <asp:Button ID="btnAddFriends" runat="server" OnClick="Button1_Click" Text="Add to friends list " />
        <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
        <br />
       

        <asp:textbox runat="server" Height="59px" Width="601px" ID="txrComments"></asp:textbox>
        <asp:button ID="btnPost" runat="server" text="Post" OnClick="btnPost_Click" />

        <asp:gridview runat="server" ID="gridview1" OnSelectedIndexChanged="gridview1_SelectedIndexChanged" AutoGenerateColumns="false" Width="607px">
            <Columns>


              <asp:BoundField DataField ="Comment" HeaderText="" />
            </Columns>

             

        </asp:gridview>
</div>

</asp:Content>
