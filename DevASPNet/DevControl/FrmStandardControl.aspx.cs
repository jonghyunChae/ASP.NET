using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevControl
{
    public partial class FrmStandardControl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btnHtml.Value = "HTML 서버 컨트롤 - 버튼";
            btnServer.Text = "표준 컨트롤 - 버튼";
        }
    }
}