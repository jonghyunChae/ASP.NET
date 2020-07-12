using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevControl
{
    public partial class FrmDownListDynamicCreation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <= 2; ++i)
            {
                DropDownList ddl = new DropDownList();
                ddl.ID = $"ddl{i}";
                ddl.Items.Add(new ListItem("Text1", "Value1"));
                ddl.Items.Add(new ListItem("Text2", "Value2"));
                ddl.Items.Add(new ListItem("Text3", "Value3"));
                this.PlaceHolder1.Controls.Add(ddl);
            }
        }

        protected void btnGet_Click(object sender, EventArgs e)
        {
            this.Label1.Text = "선택된 값 : ";
            for (int i = 0; i <= 2; ++i)
            {
                DropDownList ddl = this.PlaceHolder1.FindControl($"ddl{i}") as DropDownList;
                if (ddl != null)
                {
                    this.Label1.Text += ddl.SelectedValue + ", ";
                }
            }
        }
    }
}