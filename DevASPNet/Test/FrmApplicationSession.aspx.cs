using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNet_1
{
    public partial class FrmApplicationSession : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Application["Count"] == null)
            {
                Application.Lock();
                Application["Count"] = 1;
                Application.UnLock();
            }
            else
            {
                Application["Count"] = (int)Application["Count"] + 1;
            }

            if (Session["Count"] == null)
            {
                Session["Count"] = 1;
            }
            else
            {
                Session["Count"] = (int)Session["Count"] + 1;
            }

            // 누구나 1씩 증가
            this.lblApplication.Text = Application["Count"].ToString();
            // 현재 접속자만 1씩 증가
            this.lblSession.Text = Session["Count"].ToString();
            // 현재 접속자 고유 접속 번호
            this.lblSessionID.Text = Session.SessionID;
            // 현재 세션 유지 시간
            this.lblTimeOut.Text = Session.Timeout.ToString();
        }
    }
}