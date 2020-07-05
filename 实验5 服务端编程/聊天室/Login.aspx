<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>登录</title>
    <style type="text/css">
        .style1
        {
            width: 377px;
            height: 209px;
        }
        .style2
        {
            width: 89%;
            height: 162px;
        }
        .style3
        {
            height: 29px;
        }
        .style4
        {
            height: 39px;
        }
        .style5
        {
            height: 39px;
            width: 103px;
        }
        .style6
        {
            height: 29px;
            width: 103px;
            text-align: right;
        }
        .style7
        {
            width: 103px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    <asp:Label ID="lblCount" runat="server" Text="Label"></asp:Label>
<table align="center" cellpadding="0" cellspacing="0" class="style1" >
    <tr>
        <td>
            <table align="center" cellpadding="0" cellspacing="0" class="style2">
                <tr>
                    <td class="style5">
                    </td>
                    <td class="style4" colspan="2">
                    </td>
                </tr>
                <tr>
                    <td class="style6">
                        昵称：</td>
                            <td class="style3">
                    <asp:TextBox ID="TextBox1" runat="server" Width="113px"></asp:TextBox>
                            </td>
                            <td class="style3">
                    <asp:Button ID="btnLogin" runat="server" Font-Size="9pt" OnClick="btnLogin_Click"
                        Text="登录" />
                     
                    <asp:Button ID="btnExit" runat="server" Font-Size="9pt" OnClick="btnExit_Click" Text="退出" />
                            </td>
                        </tr>
                        <tr>
                            <td class="style7">
                                 </td>
                            <td colspan="2">
                                 </td>
                        </tr>
                    </table>
                </td>
    </tr>
</table>
    </form>
</body>
</html>