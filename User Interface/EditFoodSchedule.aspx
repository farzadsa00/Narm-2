<%@ Page Inherits="User_Interface.EditFoodSchedule" Title="" Language="C#" MasterPageFile="Master.Master" CodeBehind="EditFoodSchedule.aspx.cs" %>
<asp:Content runat="server" ID="Head" ContentPlaceHolderID="head">
    <link href="CSS/StudentHomePage.css" type="text/css" rel="stylesheet"/>
</asp:Content>
<asp:Content runat="server" ID="ContentPlaceHolder1" ContentPlaceHolderID="ContentPlaceHolder1">
    <br />
    <br />
    <table>
        <tr>
            <th>Day</th>
            <th>Date</th>
            <th>Breakfast</th>
            <th>Lunch</th>
            <th>Dinner</th>
        </tr>
        <tr>
            <td>Saturday</td>
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
            <td>Sunday</td>
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
            <td>Monday</td>
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
            <td>Tuesday</td>
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
            <td>Wednesday</td>
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
            <td>Thursday</td>
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
            <td>Friday</td>
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
    <asp:Button ID="submitButton" runat="server" Text="Submit" />
</asp:Content>
