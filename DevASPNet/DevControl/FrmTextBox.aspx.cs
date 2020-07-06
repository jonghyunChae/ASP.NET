using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevControl
{
    public partial class FrmTextBox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            // 이름 받아오기
            string strName = this.txtSingleLine.Text;

            // 소개 받아오기
            string strIntro = this.txtMultiLine.Text;

            // 암호 받아오기
            string strPassword = this.txtPassword.Text;

            // 출력
            Response.Write(
                $"{strName} + <br />" +
                $"{strIntro} + <br />" +
                $"{strPassword} + <br />");

        }
    }
}