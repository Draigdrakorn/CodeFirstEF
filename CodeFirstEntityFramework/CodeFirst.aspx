<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CodeFirst.aspx.cs" Inherits="CodeFirstEntityFramework.CodeFirst" %>

<%@ Register Src="~/CodeFirstControl.ascx" TagPrefix="uc1" TagName="CodeFirstControl" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <uc1:CodeFirstControl runat="server" id="CodeFirstContext" />
    </div>
    </form>
</body>
</html>
