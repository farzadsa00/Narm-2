<%@ Page Inherits="User_Interface.CardActivation" Title="" Language="C#" MasterPageFile="Master.Master" CodeBehind="CardActivation.aspx.cs"%>
<asp:Content runat="server" ID="Head" ContentPlaceHolderID="head">
    
</asp:Content>

<asp:Content runat="server" ID="ContentPlaceHolder1" ContentPlaceHolderID="ContentPlaceHolder1">
    <asp:CheckBoxList ID="carActivationCheckBoxList" runat="server">
        
    </asp:CheckBoxList>
    <br />
    <br />
    <asp:Button ID="submitButton" runat="server" Text="Submit" OnClick="submitButton_Click" />
</asp:Content>
