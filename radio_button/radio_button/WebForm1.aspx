<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="radio_button.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title>Radio And Checkbox Demo</title>
    <style>
        .radio
        {
            margin-left:400px;
        }
        .btn
        {
            margin-left:600px;
        }
    </style>
</head>
<body style="background-color:azure;font-family:Arial, Helvetica, sans-serif">
    <form id="form1" runat="server">
    <div>
        <h1>Radio And Checkbox Demo</h1>
    <fieldset>
        <legend style="margin-left:500px">Please Select Your Gender:</legend>
        <asp:RadioButton ID="RadioButton1" runat="server" GroupName="gen" Text="Male" CssClass="radio"/>
        <asp:RadioButton ID="RadioButton2" runat="server" GroupName="gen" Text="Female" CssClass="radio"/>

    </fieldset>
        <asp:Button ID="Button1" runat="server" Text="Click" OnClick="Button1_Click" CssClass="btn"/>
        <br />
        <br />
        <br />

        <fieldset>
            <legend style="margin-left:500px">Please Select Your Eduction:</legend>
            <asp:CheckBox ID="CheckBox1" runat="server"  Text="Matric" CssClass="radio"/>
            <asp:CheckBox ID="CheckBox2" runat="server" Text="Intermidiate" CssClass="radio"/>
            <asp:CheckBox ID="CheckBox3" runat="server" Text="Graduate"/>
            <asp:CheckBox ID="CheckBox4" runat="server" Text="Post-Graduate" CssClass="radio"/>
            <asp:CheckBox ID="CheckBox5" runat="server" Text="Bscs" CssClass="radio"/>
            
        </fieldset>
        <asp:Button ID="Button2" runat="server" Text="Click" OnClick="Button2_Click" CssClass="btn"/>
        <br />
        <br />
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="https://www.google.com/">Google</asp:HyperLink>
        <br />
        <br />
        <br />
        <asp:HyperLink ID="HyperLink2" runat="server" ImageUrl="~/Images/145-512.png" ImageWidth="200px" ImageHeight="200px" NavigateUrl="https://www.google.com/"></asp:HyperLink>
    </div>
    </form>
</body>
</html>
