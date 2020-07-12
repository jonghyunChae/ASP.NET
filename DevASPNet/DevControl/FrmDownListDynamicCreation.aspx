<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmDownListDynamicCreation.aspx.cs" Inherits="DevControl.FrmDownListDynamicCreation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
            <hr />

            <asp:Button ID="btnGet" runat="server" Text="값 가져오기"
                OnClick="btnGet_Click" />
            <hr />
            <asp:Label ID="Label1" runat="server" Text="" />
        </div>
    </form>
</body>
</html>
