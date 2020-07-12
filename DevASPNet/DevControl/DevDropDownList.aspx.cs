using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevControl
{
    public partial class DevDropDownList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.Page.IsPostBack == false && lstJob.Items.Count > 1)
            {
                this.lstJob.SelectedIndex = 1;
            }
        }

        protected void lstJob_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 문자열 변수 선언과 동시 초기화
            string strMsg = lstJob.SelectedItem.Text + "를 선택하셨습니다.";
            this.lblDisplay.Text = strMsg;
        }
    }
}