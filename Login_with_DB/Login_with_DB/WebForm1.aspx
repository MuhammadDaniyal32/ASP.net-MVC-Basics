<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Login_with_DB.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>LOGIN</title>
    <style type="text/css">
        .auto-style1 {
            width: 91px;
        }
        #Text1 {
            width: 258px;
        }
        #Password1 {
            width: 260px;
        }
        .auto-style2 {
            width: 100%;
            height: 188px;
        }
        .margin
        {
            margin-left:580px;
        }
        .auto-style4 {
            width: 91px;
            height: 78px;
        }
        .auto-style5 {
            width: 240px;
            height: 78px;
        }
        .auto-style6 {
            height: 78px;
        }
        .auto-style10 {
            width: 91px;
            height: 99px;
        }
        .auto-style11 {
            width: 240px;
            height: 99px;
        }
        .auto-style12 {
            height: 99px;
        }
        .auto-style15 {
            width: 91px;
            height: 105px;
        }
        .auto-style16 {
            width: 240px;
            height: 105px;
        }
        .auto-style17 {
            height: 105px;
        }
    </style>
</head>
<body style="height: 251px">
    <form id="form1" runat="server">
    <div>
        
        <table class="auto-style2" style="margin-left:400px;">
            <tr>
                <td class="auto-style4"></td>
                <td colspan="1" style="font-family:'Segoe UI';font-size:larger" class="auto-style5">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; LOGIN</td>
                <td class="auto-style6"></td>
            </tr>
            <tr>
                <td class="auto-style15">Username:</td>
                <td class="auto-style16">
                    <asp:TextBox ID="TextBox1" runat="server" Height="34px" Width="231px"></asp:TextBox>
                </td>
                <td class="auto-style17"></td>
            </tr>
            <tr>
                <td class="auto-style10">Password:</td>
                <td class="auto-style11">
                    <asp:TextBox ID="TextBox2" runat="server" Height="34px" Width="231px"></asp:TextBox>
                    <br /><br /><br />
                    <asp:Label ID="Label1" runat="server" Text="Invalid Username and Password!!!!" Font-Bold="True" Font-Italic="True" ForeColor="#CC0000"></asp:Label>
                </td>
                <td class="auto-style12"></td>
            </tr>
            <tr>
                <td class="auto-style1">
        
                    &nbsp;</td>
            </tr>
        </table>
        
            <asp:Button ID="Button1" runat="server" Text="Login" CssClass="margin" BackColor="#FFFF99" BorderStyle="None" Height="39px" Width="92px" OnClick="Button1_Click"/>
        
    </div>
        
    </form>
</body>
</html>
