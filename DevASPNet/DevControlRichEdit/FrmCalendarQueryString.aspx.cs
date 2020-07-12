using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevControlRichEdit
{
    public partial class FrmCalendarQueryString : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string date = Request.QueryString["Date"];
            if (String.IsNullOrEmpty(date) == false)
            {
                this.lblDate.Text = date;
            }
            else
            {
                this.lblDate.Text = "없습니다.";
            }
        }
        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = Calendar1.SelectedDate;
            int year = selectedDate.Year;
            int month = selectedDate.Month;
            int day = selectedDate.Day;

            string script = Request.ServerVariables["SCRIPT_NAME"];
            // Request.ServerVariables["SCRIPT_NAME"] : 현재 스크립트 이름
            string strUrl = $"{script}?Date={year}-{month}-{day}";
            Response.Redirect(strUrl);
        }
        }
    }