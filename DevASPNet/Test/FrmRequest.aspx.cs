using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Test
{
    public partial class FrmRequest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string userID = string.Empty;
            string password = string.Empty;
            string name = string.Empty; ;
            string age = string.Empty;

            // 1. Request 객체의 QueryString 컬렉션
            userID = Request.QueryString["UserID"];
            // 2. Request 객체의 Params 컬렉션
            password = Request.Params["Password"];
            // 3. Request 객체의 Form 컬렉션 
            name = Request.Form["Name"];
            // 4. Request 객체 자체로 받기
            age = Request["Age"];

            string Msg = $"입력하신 아이디는 {userID} <br/>"
                + $"암호는 {password} <br/>"
                + $"이름은 {name} <br/>"
                + $"나이는 {age}살 입니다. <br/><br/>";
            Response.Write(Msg);
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            // ASP.NET에서 Request 개체보다는 컨트롤 속성을 사용해서 값은 받는다.
            string name = Name.Text;
            int age = Convert.ToInt16(Age.Text);
        }
        
    }
}