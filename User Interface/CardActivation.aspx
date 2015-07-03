<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="CardActivation.aspx.cs" Inherits="User_Interface.CardActivation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:CheckBoxList ID="cardActivationCheckBoxList" runat="server">
        
    </asp:CheckBoxList>
    <br />
    <br />
    <asp:Button ID="submitButton" runat="server" Text="Submit" OnClick="submitButton_Click" />
    <br />
    <br />
    <br />
    <asp:RadioButtonList ID="languageChangedRadioButtonList" BorderStyle="None" runat="server" OnSelectedIndexChanged="LanguageChanged" AutoPostBack="True">
            <asp:ListItem Value="en-us" Text="English"></asp:ListItem>
            <asp:ListItem Value="FA-IR" Text="فارسی"></asp:ListItem>
    </asp:RadioButtonList>
</asp:Content>
