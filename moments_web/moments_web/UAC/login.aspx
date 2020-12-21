<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="moments_web.UAC.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:TextBox ID="txtFirstName" runat="server" placeholder="first name"></asp:TextBox><br />
    <asp:TextBox ID="txtLastName" runat="server" placeholder="last name"></asp:TextBox><br />
    <asp:TextBox ID="txtEmail" runat="server" placeholder="email"></asp:TextBox><br />
    <asp:TextBox ID="txtPhone" runat="server" placeholder="phone"></asp:TextBox><br />
    <asp:TextBox ID="txtUsername" runat="server" placeholder="username"></asp:TextBox><br />
    <asp:TextBox ID="txtPassword" runat="server" placeholder="password"></asp:TextBox><br />
    <asp:Button ID="btnSubmit" runat="server" Text="sign me up!" OnClick="btnSubmit_Click" />
</asp:Content>
