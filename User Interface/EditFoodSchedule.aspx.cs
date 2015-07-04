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
    public partial class EditFoodSchedule : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //FoodSchedule schedule = BusinessLayer.GetSchdeule();
            //saturdayBreakfastDropDownList.Items.Add(schedule.Breakfasts[0]);
            //saturdayBreakfastDropDownList.Items.Add(schedule.Breakfasts[1]);
            //saturdayBreakfastDropDownList.Items.Add(schedule.Lunches[0]);
            //saturdayBreakfastDropDownList.Items.Add(schedule.Lunches[1]);
            //saturdayBreakfastDropDownList.Items.Add(schedule.Dinners[0]);
            //saturdayBreakfastDropDownList.Items.Add(schedule.Dinners[1]);

            //sundayBreakfastDropDownList.Items.Add(schedule.Breakfasts[0]);
            //sundayBreakfastDropDownList.Items.Add(schedule.Breakfasts[1]);
            //sundayBreakfastDropDownList.Items.Add(schedule.Lunches[0]);
            //sundayBreakfastDropDownList.Items.Add(schedule.Lunches[1]);
            //sundayBreakfastDropDownList.Items.Add(schedule.Dinners[0]);
            //sundayBreakfastDropDownList.Items.Add(schedule.Dinners[1]);

            //mondayBreakfastDropDownList.Items.Add(schedule.Breakfasts[0]);
            //mondayBreakfastDropDownList.Items.Add(schedule.Breakfasts[1]);
            //mondayBreakfastDropDownList.Items.Add(schedule.Lunches[0]);
            //mondayBreakfastDropDownList.Items.Add(schedule.Lunches[1]);
            //mondayBreakfastDropDownList.Items.Add(schedule.Dinners[0]);
            //mondayBreakfastDropDownList.Items.Add(schedule.Dinners[1]);

            //tuesdayBreakfastDropDownList.Items.Add(schedule.Breakfasts[0]);
            //tuesdayBreakfastDropDownList.Items.Add(schedule.Breakfasts[1]);
            //tuesdayBreakfastDropDownList.Items.Add(schedule.Lunches[0]);
            //tuesdayBreakfastDropDownList.Items.Add(schedule.Lunches[1]);
            //tuesdayBreakfastDropDownList.Items.Add(schedule.Dinners[0]);
            //tuesdayBreakfastDropDownList.Items.Add(schedule.Dinners[1]);

            //wednesdayBreakfastDropDownList.Items.Add(schedule.Breakfasts[0]);
            //wednesdayBreakfastDropDownList.Items.Add(schedule.Breakfasts[1]);
            //wednesdayBreakfastDropDownList.Items.Add(schedule.Lunches[0]);
            //wednesdayBreakfastDropDownList.Items.Add(schedule.Lunches[1]);
            //wednesdayBreakfastDropDownList.Items.Add(schedule.Dinners[0]);
            //wednesdayBreakfastDropDownList.Items.Add(schedule.Dinners[1]);

            //thursdayBreakfastDropDownList.Items.Add(schedule.Breakfasts[0]);
            //thursdayBreakfastDropDownList.Items.Add(schedule.Breakfasts[1]);
            //thursdayBreakfastDropDownList.Items.Add(schedule.Lunches[0]);
            //thursdayBreakfastDropDownList.Items.Add(schedule.Lunches[1]);
            //thursdayBreakfastDropDownList.Items.Add(schedule.Dinners[0]);
            //thursdayBreakfastDropDownList.Items.Add(schedule.Dinners[1]);

            //fridayBreakfastDropDownList.Items.Add(schedule.Breakfasts[0]);
            //fridayBreakfastDropDownList.Items.Add(schedule.Breakfasts[1]);
            //fridayBreakfastDropDownList.Items.Add(schedule.Lunches[0]);
            //fridayBreakfastDropDownList.Items.Add(schedule.Lunches[1]);
            //fridayBreakfastDropDownList.Items.Add(schedule.Dinners[0]);
            //fridayBreakfastDropDownList.Items.Add(schedule.Dinners[1]);
        }

        protected void LanguageChanged(object sender, EventArgs e)
        {
            Page.Culture = ((RadioButtonList)sender).SelectedValue;
            Page.UICulture = ((RadioButtonList)sender).SelectedValue;

            submitButton.Text = GetLocalResourceObject("Submit").ToString();
        }

        protected void submitButton_Click(object sender, EventArgs e)
        {
            FoodSchedule schedule = new FoodSchedule();
            schedule.Breakfasts.Clear();
            schedule.Lunches.Clear();
            schedule.Dinners.Clear();

            schedule.Breakfasts.Add(saturdayBreakfastDropDownList.Items[0].Value);
            schedule.Breakfasts.Add(saturdayBreakfastDropDownList.Items[1].Value);
            schedule.Breakfasts.Add(sundayBreakfastDropDownList.Items[0].Value);
            schedule.Breakfasts.Add(sundayBreakfastDropDownList.Items[1].Value);
            schedule.Breakfasts.Add(mondayBreakfastDropDownList.Items[0].Value);
            schedule.Breakfasts.Add(mondayBreakfastDropDownList.Items[1].Value);
            schedule.Breakfasts.Add(tuesdayBreakfastDropDownList.Items[0].Value);
            schedule.Breakfasts.Add(tuesdayBreakfastDropDownList.Items[1].Value);
            schedule.Breakfasts.Add(wednesdayBreakfastDropDownList.Items[0].Value);
            schedule.Breakfasts.Add(wednesdayBreakfastDropDownList.Items[1].Value);
            schedule.Breakfasts.Add(thursdayBreakfastDropDownList.Items[0].Value);
            schedule.Breakfasts.Add(thursdayBreakfastDropDownList.Items[1].Value);
            schedule.Breakfasts.Add(fridayBreakfastDropDownList.Items[0].Value);
            schedule.Breakfasts.Add(fridayBreakfastDropDownList.Items[1].Value);

            schedule.Lunches.Add(saturdayLunchDropDownList.Items[0].Value);
            schedule.Lunches.Add(saturdayLunchDropDownList.Items[1].Value);
            schedule.Lunches.Add(sundayLunchDropDownList.Items[0].Value);
            schedule.Lunches.Add(sundayLunchDropDownList.Items[1].Value);
            schedule.Lunches.Add(mondayLunchDropDownList.Items[0].Value);
            schedule.Lunches.Add(mondayLunchDropDownList.Items[1].Value);
            schedule.Lunches.Add(tuesdayLunchDropDownList.Items[0].Value);
            schedule.Lunches.Add(tuesdayLunchDropDownList.Items[1].Value);
            schedule.Lunches.Add(wednesdayLunchDropDownList.Items[0].Value);
            schedule.Lunches.Add(wednesdayLunchDropDownList.Items[1].Value);
            schedule.Lunches.Add(thursdayLunchDropDownList.Items[0].Value);
            schedule.Lunches.Add(thursdayLunchDropDownList.Items[1].Value);
            schedule.Lunches.Add(fridayLunchDropDownList.Items[0].Value);
            schedule.Lunches.Add(fridayLunchDropDownList.Items[1].Value);

            schedule.Dinners.Add(saturdayDinnerDropDownList.Items[0].Value);
            schedule.Dinners.Add(saturdayDinnerDropDownList.Items[1].Value);
            schedule.Dinners.Add(sundayDinnerDropDownList.Items[0].Value);
            schedule.Dinners.Add(sundayDinnerDropDownList.Items[1].Value);
            schedule.Dinners.Add(mondayDinnerDropDownList.Items[0].Value);
            schedule.Dinners.Add(mondayDinnerDropDownList.Items[1].Value);
            schedule.Dinners.Add(tuesdayDinnerDropDownList.Items[0].Value);
            schedule.Dinners.Add(tuesdayDinnerDropDownList.Items[1].Value);
            schedule.Dinners.Add(wednesdayDinnerDropDownList.Items[0].Value);
            schedule.Dinners.Add(wednesdayDinnerDropDownList.Items[1].Value);
            schedule.Dinners.Add(thursdayDinnerDropDownList.Items[0].Value);
            schedule.Dinners.Add(thursdayDinnerDropDownList.Items[1].Value);
            schedule.Dinners.Add(fridayDinnerDropDownList.Items[0].Value);
            schedule.Dinners.Add(fridayDinnerDropDownList.Items[1].Value);

            BusinessLayer.AddSchedule(schedule);
        }
    }
}