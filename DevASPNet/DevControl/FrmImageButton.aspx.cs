using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevControl
{
    public partial class FrmImageButton : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.imgWrite.ImageUrl = "images/btn_post.jpg";
            this.imgList.ImageUrl = "./images/btn_list.gif";
        }
        protected void imgWrite_Click(object sender, EventArgs e)
        {
            Response.Write("글쓰기 버튼 클릭됨. <br />");
        }

        protected void imgList_Click(object sender, EventArgs e)
        {
            Response.Write("리스트 버튼 클릭됨. <br />");
        }
    }
}