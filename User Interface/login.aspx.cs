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

        }

        protected void loginButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentHomePage.aspx?username=" + usernameTextBox.Text);
            if (BusinessLayer.ValidateStudentCard(usernameTextBox.Text, passwordTextBox.Text) == "ok")
                Response.Redirect("StudentHomePage.aspx?username=" + usernameTextBox.Text);
            else if (usernameTextBox.Text[0] == 'a')
            {
                if (BusinessLayer.ValidateEmployeeCard(usernameTextBox.Text, passwordTextBox.Text) == "ok")
                {
                    throw new NotImplementedException();
                }
            }
            else
                loginStatusLabel.Text = "Username or Password is incorrect";
        }
    }
}