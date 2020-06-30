using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace ASPNet_1
{
    public partial class FrmPageLoad : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 동적으로 페이지 제목 변경하는 세 가지 방법
            this.Title = "제목이 바뀝니다.";
            this.Page.Title = "제목이 출력됩니다.";
            this.Page.Header.Title = "Page 클래스";

            // 외부 스타일 시트 정의
            HtmlLink objHtmlLink = new HtmlLink();
            objHtmlLink.Href = "DevASPNET.css";
            objHtmlLink.Attributes.Add("rel", "stylesheet");
            objHtmlLink.Attributes.Add("type", "text/css");

            // Head 태그 정의, 외부스타일과 메타태그 등록
            HtmlHead objHtmlHead = Page.Header;
            objHtmlHead.Controls.Add(objHtmlLink);

            // 동적으로 페이지에 스타일시트 적용하는 방법
            Style objButtonStyle = new Style();
            objButtonStyle.ForeColor = System.Drawing.Color.Navy; // color:Navy;
            objButtonStyle.Font.Size = 9; // font-size:9pt
            objButtonStyle.Font.Name = "Verdana";

            this.Page.Header.StyleSheet.RegisterStyle(objButtonStyle, null);

            this.btnNewBack.CssClass = objButtonStyle.RegisteredCssClass;
            this.btnPostBack.CssClass = objButtonStyle.RegisteredCssClass;

            Style objDivStyle = new Style();
            objDivStyle.ForeColor = System.Drawing.Color.Blue;
            objDivStyle.Font.Size = 9;
            objDivStyle.Font.Name = "Verdana";
            objDivStyle.Font.Italic = true;
            Page.Header.StyleSheet.CreateStyleRule(objDivStyle, null, "body, div");

            if (Page.IsPostBack == false)
            {
                Response.Write("1. 폼이 처음 로드할 때만 실행 <br />");
            }
                
            Response.Write("2. 폼이 로드될 때 마다 실행 <br />");
        }

        protected void btnPostBack_Click(object sender, EventArgs e)
        {
            string strJs = @"
                    <script>
                    window.alert('포스트 백 됨');
                    </script>
                ";
            ClientScript.RegisterClientScriptBlock(this.GetType(), "MyScript", strJs);
        }

        protected void btnNewLoad_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmPageLoad.aspx");
        }
    }
}