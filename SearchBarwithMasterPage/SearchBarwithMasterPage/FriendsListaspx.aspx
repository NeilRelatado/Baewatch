<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="FriendsListaspx.aspx.cs" Inherits="SearchBarwithMasterPage.FriendsListaspx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">
    <asp:gridview ID="GridView1" runat="server" AutoGenerateColumns="false" Width="864px">
        <Columns>
              
              <asp:BoundField DataField ="Username" HeaderText="Friend Name " />
              <asp:BoundField DataField ="FriendID" HeaderText="ID" />
              <asp:BoundField DataField ="Name" HeaderText="Friend Name" />
              

        </Columns>

    </asp:gridview>
</asp:Content>
