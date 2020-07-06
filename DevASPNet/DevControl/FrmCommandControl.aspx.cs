using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevControl
{
    public partial class FrmCommandControl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnCommand_Click(object sender, EventArgs e)
        {
            //sender : 현재 이벤트 호출한 객체 (이름으로 접근 가능)
            // 버튼 컨트롤인지 링크 컨트롤인지 구분 가능
            if (sender == btnButton)
            {
                this.lblDisplay.Text = "버튼 클릭됨.";
            }
            else if(sender == btnLink)
            {
                this.lblDisplay.Text = "링크버튼 클릭됨.";
            }
        }
        protected void btnImage_Click(object sender, ImageClickEventArgs e)
        {
            //XXXEventArgs 클래스형 매개 변수는 현재 시점에서 필요한 추가 정보제공
            // 클릭된 이미지의 좌표 출력
            this.lblDisplay.Text = $"이미지 버튼 클릭됨. <br /> X:{e.X}, Y:{e.Y}";
            // 해당 이미지의 가로 20픽셀, 세로 20픽셀 이상 클릭하면 이동
            if (e.X > 20 && e.Y > 20)
            {
                Response.Redirect("http://dotnetkorea.com/");
            }
        }

    }
}