using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevValidationControl
{
    public partial class FrmRequiredFieldValidator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                Page.SetFocus(this.txtUserId);
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            // isValid 속성 : 유효성 검사가 통과되면 true를 반환
            if (Page.IsValid)
            {
                Page.ClientScript.RegisterClientScriptBlock(
                    this.GetType(),
                    "alretMessage",
                    "<script>alert('통과'); </script>"
                    );
            }
        }


    }
}