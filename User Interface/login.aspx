<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="User_Interface.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="CSS/Login.css" rel="stylesheet" type="text/css"  />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <h1><%=GetLocalResourceObject("UrmiaUniversity") %></h1>
    <br />
    <asp:Label ID="loginStatusLabel" runat="server" Text=""></asp:Label>
    <br />
    <asp:RequiredFieldValidator ID="usernameValidator" runat="server" ControlToValidate="usernameTextBox" ErrorMessage="Username should not be empty"></asp:RequiredFieldValidator>
    <br />
    <asp:RequiredFieldValidator ID="passwordValidator" runat="server" ControlToValidate="passwordTextBox" ErrorMessage="Password should not be empty"></asp:RequiredFieldValidator>
    <br />
    <asp:Label ID="usernameLabel" runat="server" CssClass="username" Text="Username : "></asp:Label>
    <asp:TextBox ID="usernameTextBox" runat="server" CssClass="username"></asp:TextBox>
    <br />
    <asp:Label ID="passwordLabel" runat="server" Text="Password :  " CssClass="password"></asp:Label>
    <asp:TextBox ID="passwordTextBox" runat="server" TextMode="Password" CssClass="password"></asp:TextBox>
    <br />
    <asp:CheckBox ID="rememberMeCheckBox" runat="server" Text="Remember Me" />
    <br />
    <br />
    <br />
    <asp:Button ID="loginButton" runat="server" Text="Login" OnClick="loginButton_Click" />
    <br />
    <br />
    <br />
    <asp:RadioButtonList ID="LanguageChangedRadioButtonList" runat="server" OnSelectedIndexChanged="LanguageChanged" AutoPostBack="True">
            <asp:ListItem Value="en-us" Text="English"></asp:ListItem>
            <asp:ListItem Value="FA-IR" Text="فارسی"></asp:ListItem>
    </asp:RadioButtonList>
</asp:Content>
