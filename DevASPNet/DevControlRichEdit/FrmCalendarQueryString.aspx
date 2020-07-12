<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmCalendarQueryString.aspx.cs" Inherits="DevControlRichEdit.FrmCalendarQueryString" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>캘린더 컨틀롤</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            넘겨온 값 : <asp:Label ID="lblDate" runat="server" Text="" />
            <asp:Calendar ID="Calendar1" runat="server" 
                OnSelectionChanged="Calendar1_SelectionChanged"/>
        </div>
    </form>
</body>
</html>
