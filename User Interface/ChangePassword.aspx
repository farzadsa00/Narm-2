<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="User_Interface.ChangePassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <asp:Label ID="oldPasswordLabel" runat="server" Text="Old Password : ">
        <asp:TextBox ID="oldPasswordTextBox" runat="server"></asp:TextBox>
    </asp:Label>
    <br />
    <br />
    <asp:Label ID="newPassworddLabel" runat="server" Text="New Password : ">
        <asp:TextBox ID="newPasswordTextBox" runat="server"></asp:TextBox>
    </asp:Label>
    <br />
    <br />
    <asp:Label ID="confirmNewPasswordLabel" runat="server" Text="Confirm new Password : ">
        <asp:TextBox ID="confirmNewPasswordTextBox" runat="server"></asp:TextBox>
    </asp:Label>
    <br />
    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="newPasswordTextBox"
        ControlToValidate="confirmNewPasswordTextBox" ErrorMessage="Confirm password must match new password"></asp:CompareValidator>
    <br />
    <asp:Button ID="submitNewPassword" runat="server" Text="Submit" OnClick="submitNewPassword_Click" />
</asp:Content>
