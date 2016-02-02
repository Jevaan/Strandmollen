<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Win911Config._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="StatusUpdatePanel" runat="server">
            <ContentTemplate>
                <asp:Label ID="StatusLabel" runat="server" Text="Starter..."></asp:Label>
                <asp:Label ID="ConfigLabel" runat="server" Text=" "></asp:Label>
                <asp:Timer ID="UpdateTimer" runat="server" Interval="3000" OnTick="UpdateTick">
                </asp:Timer>
            </ContentTemplate>
        </asp:UpdatePanel>
        <p><br />
    
        <asp:Button ID="DK_btn" runat="server" Text="DK Vagthavende" OnClick="DK_btn_Click" Width="120px" />
        <asp:Button ID="SE_btn" runat="server" Text="SE Vagthavende" OnClick="SE_btn_Click" Width="120px" /><br />
        <asp:Button ID="SE_Shutdown_btn" runat="server" Text="SE Bagvagt" Width="120px" OnClick="SE_Shutdown_btn_Click" />
        <asp:Button ID="Stop_btn" runat="server" Text="Stop 911" Width="120px" OnClick="Stop_btn_Click" />
    
        </p>
    </form>
</body>
</html>
