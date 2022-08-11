<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Email_sending._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .text
        {
            width:100%;
            margin-bottom:20px;
            margin-top:16px;
            resize:vertical;
            padding:12px;
            border:1px solid #ccc;
            border-radius:4px;
            box-sizing:border-box;
        }
    </style>
    <div class="container">
        <div class="Row">
            <h1 class="text-center">EMAIL SENDING DEMO</h1>
            <div class="form-group">
                <asp:Label ID="Label1" runat="server" Text="To"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server" CssClass="text"></asp:TextBox>
                <br/>
                <asp:Label ID="Label2" runat="server" Text="From" ></asp:Label>
                <asp:TextBox ID="TextBox2" runat="server" CssClass="text"></asp:TextBox>
                <br/>
                <asp:Label ID="Label3" runat="server" Text="Subject"></asp:Label>
                <asp:TextBox ID="TextBox3" runat="server" CssClass="text"></asp:TextBox>
                <br/>
                <asp:Label ID="Label4" runat="server" Text="Body"></asp:Label>
                <asp:TextBox ID="TextBox4" runat="server" CssClass="text"></asp:TextBox>
                <br/>
                <asp:Button ID="Button1" runat="server" Text="SEND" OnClick="Button1_Click"/>
                <br/>
                <asp:Label ID="Label5" runat="server"></asp:Label>
            </div>
        </div>
    </div>

</asp:Content>
