<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Textbox_property._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .txt1
        {
            margin-left:200px;
        }
    </style>
    <div class="jumbotron">
        <h1>MY FIRST ASP.NET</h1>
        <p class="lead">In This App we are using textbox and events</p>
        <asp:TextBox ID="TextBox1" runat="server" Height="100px" MaxLength="8" ToolTip="Please Enter TEXT" OnTextChanged="txtchng" AutoPostBack="true" CssClass="txt1"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" Height="100px" MaxLength="8" ToolTip="Please Enter TEXT"  AutoPostBack="true" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
        
        <div style="padding:20px;margin-left:370px;color:brown"><asp:Button ID="Button1" runat="server" BackColor="Yellow"  Text="CLICK HERE!" OnClick="Button1_Click" /></div>
    </div>

    <div class="row">
        <div class="col-md-4">
            <asp:Label ID="Label1" runat="server" Text="" Font-Bold="true" ForeColor="Sienna" Font-Size="Large"></asp:Label>
        </div>
        <div class="col-md-4">
            <asp:Label ID="Label2" runat="server" Text="" Font-Bold="true" ForeColor="SpringGreen" Font-Size="Large"></asp:Label>
        </div>
    </div>

</asp:Content>
