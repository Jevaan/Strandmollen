<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Win911Config._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="DK_btn" runat="server" Text="DK Vagthavende" OnClick="DK_btn_Click" />
        <asp:Button ID="SE_btn" runat="server" Text="SE Vagthavende" OnClick="SE_btn_Click" />
        <asp:Button ID="SE_Shutdown_btn" runat="server" Text="SE Bagvagt" />
        <asp:Button ID="Stop_btn" runat="server" Text="Stop 911" />
    
    </div>
    </form>
</body>
</html>
