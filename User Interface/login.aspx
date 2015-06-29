<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="User_Interface.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="CSS/Login.css" rel="stylesheet" type="text/css"  />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <h1>Urmia University</h1>
    <br />
    <asp:Label ID="loginStatusLabel" runat="server" Text=""></asp:Label>
    <br />
    <asp:RequiredFieldValidator ID="usernameValidator" runat="server" ControlToValidate="usernameTextBox" ErrorMessage="Username should not be empty"></asp:RequiredFieldValidator>
    <br />
    <asp:RequiredFieldValidator ID="passwordValidator" runat="server" ControlToValidate="passwordTextBox" ErrorMessage="Password should not be empty"></asp:RequiredFieldValidator>
    <br />
    <asp:Label ID="usernameLabel" runat="server" CssClass="username" Text="Username : ">
        <asp:TextBox ID="usernameTextBox" runat="server" CssClass="username"></asp:TextBox>
    </asp:Label>
    <br />
    <asp:Label ID="passwordLabel" runat="server" Text="Password :  " CssClass="password">
        <asp:TextBox ID="passwordTextBox" runat="server" TextMode="Password" CssClass="password"></asp:TextBox>
    </asp:Label>
    <br />
    <br />
    <br />
    <asp:Button ID="loginButton" runat="server" Text="Login" OnClick="loginButton_Click" />
    
</asp:Content>
