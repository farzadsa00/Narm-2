using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Models;

namespace User_Interface
{
    public partial class CardActivation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<int> cardNumbers = BusinessLayer.GetNotActiveAccounts();
            for (int i = 0; i < cardNumbers.Count; i++)
                cardActivationCheckBoxList.Items.Add(cardNumbers[i].ToString());
        }

        protected void submitButton_Click(object sender, EventArgs e)
        {
            foreach (CheckBox number in cardActivationCheckBoxList.Items)
                if (number.Checked)
                    BusinessLayer.ActivateCard(Int32.Parse(number.Text));
        }

        protected void LanguageChanged(object sender, EventArgs e)
        {
            Page.Culture = ((RadioButtonList)sender).SelectedValue;
            Page.UICulture = ((RadioButtonList)sender).SelectedValue;

            submitButton.Text = GetLocalResourceObject("submit").ToString();
        }
    }
}