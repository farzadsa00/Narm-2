﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Models;

namespace User_Interface
{
    public partial class ChangePassword : System.Web.UI.Page
    {
        private static string previousPage = String.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                previousPage = Request.UrlReferrer.ToString();
        }

        protected void submitNewPassword_Click(object sender, EventArgs e)
        {
            StudentInfo studentInfo = BusinessLayer.GetStudentInfo(Request.QueryString["username"]);
            BusinessLayer.ChangePassword(studentInfo, confirmNewPasswordTextBox.Text);
            Response.Redirect(previousPage);
        }

        protected void LanguageChanged(object sender, EventArgs e)
        {
            Page.Culture = ((RadioButtonList)sender).SelectedValue;
            Page.UICulture = ((RadioButtonList)sender).SelectedValue;

            oldPasswordLabel.Text = GetLocalResourceObject("oldpassword").ToString();
            newPasswordLabel.Text = GetLocalResourceObject("newpassword").ToString();
            confirmNewPasswordLabel.Text = GetLocalResourceObject("confirm").ToString();
            CompareValidator1.ErrorMessage = GetLocalResourceObject("compare").ToString();
            submitNewPassword.Text = GetLocalResourceObject("submit").ToString();
        }
    }
}