using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Test
{
    public partial class FrmResponseBuffer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 0. 페이지를 매번 읽어옴
            Response.Expires = -1;
            // 1. 버퍼링 사용
            Response.Buffer = true;
            // 2. 화면 글쓰기
            Response.Write("1. 현재 글은 보여짐 <br/>");
            // 3. 현재 버퍼 출력
            Response.Flush();
            // 4. 화면 글쓰기
            Response.Write("2. 현재 글은 안보임 <br/>");
            // 5. 현재 버퍼 내용 비우기
            Response.Clear();
            // 6. 문자열 출력
            Response.Write("3. 보여짐 <br/>");
            // 7. 현재 페이지 종료
            Response.End(); // Flush + End
            // 8. 문자열 출력
            Response.Write("4. 실행 안 됨. <br/>");
        }
    }
}