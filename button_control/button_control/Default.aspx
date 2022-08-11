<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="button_control._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .margin
        {
            margin-left:400px;
        }
        .margin2
        {
            margin-left:150px;
        }
    </style>
    <div class="jumbotron">
        <h1 class="Text-center">BUTTON CONTROL AND IMAGE</h1>
    </div>

    <div class="row">
        <div class="col-lg-12">
            <asp:Button ID="Submit" runat="server" Text="Button" BorderStyle="Solid" OnClick="Submit_Click"/><br /><br />
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click" OnClientClick="return confirm('Are you sure to submit!!!')">Submit</asp:LinkButton><br /><br />
            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/NewFolder2/submit-button-png-25800.png" OnClick="ImageButton1_Click" Width="300px" Height="100px"/><br /><br />
            
            <asp:Panel ID="Panel1" runat="server" CssClass="margin" BackColor="SeaGreen" Width="300px" Height="400px">
                <asp:Image ID="Image1" runat="server" ImageUrl="~/NewFolder2/logo_asp45.png"/><br /><br />
                <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server" Width="250px"></asp:TextBox>
                <br /><br />
                <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
                <asp:TextBox ID="TextBox2" runat="server" Width="250px"></asp:TextBox>
                <br /><br />
                <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" CssClass="margin2" BorderStyle="Solid"/>
            </asp:Panel>
        </div>
    </div>

</asp:Content>
