using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevControl
{
    public partial class FrmButton : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                this.txtNum.Text = "0";
            }

        }

        protected void btnUp_Click(object sender, EventArgs e)
        {
            txtNum.Text = Convert.ToString(Convert.ToInt32(txtNum.Text) + 1);
        }

        protected void btnDown_Click(object sender, EventArgs e)
        {
            txtNum.Text = Convert.ToString(int.Parse(txtNum.Text) - 1);
        }
    }
}