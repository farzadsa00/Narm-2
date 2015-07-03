<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="EditFoodSchedule.aspx.cs" Inherits="User_Interface.EditFoodSchedule" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="CSS\StudentHomePage.css" rel="stylesheet" type="text/css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <table>
        <tr>
            <th><%=GetLocalResourceObject("Day") %></th>
            <th><%=GetLocalResourceObject("Date") %></th>
            <th><%=GetLocalResourceObject("Breakfast") %></th>
            <th><%=GetLocalResourceObject("Lunch") %></th>
            <th><%=GetLocalResourceObject("Dinner") %></th>
        </tr>
        <tr>
            <td><%=GetLocalResourceObject("saturday") %></td>
            <td class="saturday-date"></td>
            <td class="saturday-breakfast">
                <asp:DropDownList ID="saturdayBreakfastDropDownList" runat="server" CssClass="checkboxlist">
                    
                </asp:DropDownList>
            </td>
            <td class="saturday-lunch">
                <asp:DropDownList ID="saturdayLunchDropDownList" runat="server" CssClass="checkboxlist">
                
                </asp:DropDownList>
            </td>
            <td class="saturday-dinner">
                <asp:DropDownList ID="saturdayDinnerDropDownList" runat="server" CssClass="checkboxlist">
                
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td><%=GetLocalResourceObject("sunday") %></td>
            <td class="sunday-date"></td>
            <td class="sunday-breakfast">
                <asp:DropDownList ID="sundayBreakfastDropDownList" runat="server" CssClass="checkboxlist">
                
                </asp:DropDownList>
            </td>
            <td class="sunday-lunch">
                <asp:DropDownList ID="sundayLunchDropDownList" runat="server" CssClass="checkboxlist">
                
                </asp:DropDownList>
            </td>
            <td class="sunday-dinner">
                <asp:DropDownList ID="sundayDinnerDropDownList" runat="server" CssClass="checkboxlist">
                
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td><%=GetLocalResourceObject("monday") %></td>
            <td class="monday-date"></td>
            <td class="monday-breakfast">
                <asp:DropDownList ID="mondayBreakfastDropDownList" runat="server" CssClass="checkboxlist">
                
                </asp:DropDownList>
            </td>
            <td class="monday-lunch">
                <asp:DropDownList ID="mondayLunchDropDownList" runat="server" CssClass="checkboxlist">
                
                </asp:DropDownList>
            </td>
            <td class="monday-dinner">
                <asp:DropDownList ID="mondayDinnerDropDownList" runat="server" CssClass="checkboxlist">
                
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td><%=GetLocalResourceObject("tuesday") %></td>
            <td class="tuesday-date"></td>
            <td class="tuesday-breakfast">
                <asp:DropDownList ID="tuesdayBreakfastDropDownList" runat="server" CssClass="checkboxlist">
                
                </asp:DropDownList>
            </td>
            <td class="tuesday-lunch">
                <asp:DropDownList ID="tuesdayLunchDropDownList" runat="server" CssClass="checkboxlist">
                
                </asp:DropDownList>
            </td>
            <td class="tuesday-dinner">
                <asp:DropDownList ID="tuesdayDinnerDropDownList" runat="server" CssClass="checkboxlist">
                
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td><%=GetLocalResourceObject("wednesday") %></td>
            <td class="wednesday-date"></td>
            <td class="wednesday-breakfast">
                <asp:DropDownList ID="wednesdayBreakfastDropDownList" runat="server" CssClass="checkboxlist">
                
                </asp:DropDownList>
            </td>
            <td class="wednesday-lunch">
                <asp:DropDownList ID="wednesdayLunchDropDownList" runat="server" CssClass="checkboxlist">
                
                </asp:DropDownList>
            </td>
            <td class="wednesday-dinner">
                <asp:DropDownList ID="wednesdayDinnerDropDownList" runat="server" CssClass="checkboxlist">
                
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td><%=GetLocalResourceObject("thursday") %></td>
            <td class="thursday-date"></td>
            <td class="thursday-breakfast">
                <asp:DropDownList ID="thursdayBreakfastDropDownList" runat="server" CssClass="checkboxlist">
                
                </asp:DropDownList>
            </td>
            <td class="thursday-lunch">
                <asp:DropDownList ID="thursdayLunchDropDownList" runat="server" CssClass="checkboxlist">
                
                </asp:DropDownList>
            </td>
            <td class="thursday-dinner">
                <asp:DropDownList ID="thursdayDinnerDropDownList" runat="server" CssClass="checkboxlist">
                
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td><%=GetLocalResourceObject("friday") %></td>
            <td class="friday-date"></td>
            <td class="friday-breakfast">
                <asp:DropDownList ID="fridayBreakfastDropDownList" runat="server" CssClass="checkboxlist">
                
                </asp:DropDownList>
            </td>
            <td class="friday-lunch">
                <asp:DropDownList ID="fridayLunchDropDownList" runat="server" CssClass="checkboxlist">
                
                </asp:DropDownList>
            </td>
            <td class="friday-dinner">
                <asp:DropDownList ID="fridayDinnerDropDownList" runat="server" CssClass="checkboxlist">
                   
                </asp:DropDownList>
            </td>
        </tr>
    </table>
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
