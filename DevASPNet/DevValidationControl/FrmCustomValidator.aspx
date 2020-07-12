<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmCustomValidator.aspx.cs" Inherits="DevValidationControl.FrmCustomValidator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>사용자 정의 유효성 검사 컨트롤</h3>
            짝수만 입력:
            <asp:TextBox ID="txtEvenNumber" runat="server"></asp:TextBox>
            <asp:CustomValidator ID="valEvenNumber" runat="server" 
                ErrorMessage="짝수만 입력하시오."
                ControlToValidate="txtEvenNumber"
                OnServerValidate="valEvenNumber_ServerValidate"
                ></asp:CustomValidator>
            <br />

            홀수만 입력:
            <asp:TextBox ID="txtOddNumber" runat="server"></asp:TextBox>
            <asp:CustomValidator ID="CustomValidator1" runat="server" 
                ErrorMessage="홀수만 입력하시오."
                ControlToValidate="txtOddNumber"
                ClientValidationFunction="FuncValidationOddNumber"
                ></asp:CustomValidator>            
            <hr />
            <asp:Button ID="btnSubmit" runat="server" Text="확인" />
        </div>
    </form>
</body>
</html>
