<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Chat.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    </div>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
        <ContentTemplate>
            <asp:ListBox ID="lbList" runat="server" Height="345px" Width="180px"></asp:ListBox> <asp:TextBox ID="txtContent" runat="server" Height="345px" TextMode="MultiLine" Width="380px"></asp:TextBox>
            <br />
            <asp:Timer ID="Timer1" runat="server" Interval="1000" ontick="Timer1_Tick">
            </asp:Timer>
            
        </ContentTemplate>
    </asp:UpdatePanel>
    <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional">
        <ContentTemplate>
            <asp:TextBox ID="txtMessage" runat="server" Width="316px"></asp:TextBox>
            <asp:Button ID="btnSend" runat="server" onClick="btnSend_Click" Text="发送" />
            <asp:Button ID="btnExit" runat="server"   
                Text="退出" onclick="btnExit_Click" />
        </ContentTemplate>
    </asp:UpdatePanel>
    </form>
</body>
</html>