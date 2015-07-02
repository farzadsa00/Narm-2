<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="User_Interface.ChangePassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <asp:Label ID="oldPasswordLabel" runat="server" Text="Old Password : "></asp:Label>
    <asp:TextBox ID="oldPasswordTextBox" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="newPasswordLabel" runat="server" Text="New Password : "></asp:Label>
    <asp:TextBox ID="newPasswordTextBox" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="confirmNewPasswordLabel" runat="server" Text="Confirm new Password : "></asp:Label>
    <asp:TextBox ID="confirmNewPasswordTextBox" runat="server"></asp:TextBox>
    <br />
    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="newPasswordTextBox"
        ControlToValidate="confirmNewPasswordTextBox" ErrorMessage="Confirm password must match new password"></asp:CompareValidator>
    <br />
    <asp:Button ID="submitNewPassword" runat="server" Text="Submit" OnClick="submitNewPassword_Click" />
    <br />
    <br />
    <br />
    <asp:RadioButtonList ID="languageChangedRadioButtonList" BorderStyle="None" runat="server" OnSelectedIndexChanged="LanguageChanged" AutoPostBack="True">
            <asp:ListItem Value="en-us" Text="English"></asp:ListItem>
            <asp:ListItem Value="FA-IR" Text="فارسی"></asp:ListItem>
    </asp:RadioButtonList>
</asp:Content>
