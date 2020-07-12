using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevControl
{
    public partial class FrmListBox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                // 동적으로 항목 추가
                this.lstHobby.Items.Add("축구");
                this.lstHobby.Items.Add("농구");

                // ListItem 클래스
                ListItem li = new ListItem();
                li.Text = "배구";
                li.Value = "VolleyBall";
                this.lstHobby.Items.Add(li);
            }
        }

        protected void btnPrint_Click(object sender, EventArgs e)
        {
            string strMsg = string.Empty;
            for (int i = 0; i < this.lstHobby.Items.Count; ++i)
            {
                if (this.lstHobby.Items[i].Selected)
                {
                    // 선택된 항목이면 출력 문자열에 묶음
                    strMsg += this.lstHobby.Items[i].Text;
                    if (i != this.lstHobby.Items.Count - 1)
                    {
                        strMsg += ", ";
                    }
                }
            }
            this.lblDisplay.Text = strMsg;
        }
    }
}