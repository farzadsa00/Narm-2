using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Models;
using BLL;

namespace User_Interface
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Browser.Cookies && Request.Cookies["RememberMe"]!=null)
            {
                HttpCookie cookie = Request.Cookies["RememberMe"];
                Response.Redirect("StudentHomePage.aspx?username=" + cookie.Value);
            }
        }
        protected void loginButton_Click(object sender, EventArgs e)
        {
            if (BusinessLayer.ValidateStudentCard(usernameTextBox.Text, passwordTextBox.Text) == "ok")
            {
                if (rememberMeCheckBox.Checked)
                    CreateRememberMeCookie();
                Response.Redirect("StudentHomePage.aspx?username=" + usernameTextBox.Text);
            }
            else if (usernameTextBox.Text[0] == 'a')
            {
                if (BusinessLayer.ValidateEmployeeCard(usernameTextBox.Text, passwordTextBox.Text) == "ok")
                {
                    if (rememberMeCheckBox.Checked)
                        CreateRememberMeCookie();
                    Response.Redirect("EmployeeHomePage.aspx?username=" + usernameTextBox.Text);
                }
            }
            else
                loginStatusLabel.Text = @"Username or Password is incorrect";
        }
        private void CreateRememberMeCookie()
        {
                HttpCookie cookie = new HttpCookie("RememberMe", usernameTextBox.Text);
                cookie.Expires.AddMonths(1);
                Response.Cookies.Add(cookie);
        }
        protected void LanguageChanged(object sender, EventArgs e)
        {
            Page.Culture = ((RadioButtonList)sender).SelectedValue;
            Page.UICulture = ((RadioButtonList)sender).SelectedValue;

            usernameValidator.ErrorMessage = GetLocalResourceObject("UserNotEmpty").ToString();
            passwordValidator.ErrorMessage = GetLocalResourceObject("PassNotEmpty").ToString();
            usernameLabel.Text = GetLocalResourceObject("Username").ToString();
            passwordLabel.Text = GetLocalResourceObject("Password").ToString();
            loginButton.Text = GetLocalResourceObject("Login").ToString();
            rememberMeCheckBox.Text = GetLocalResourceObject("rememberme").ToString();
        }
    }
}