<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="dropdown_List._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style>
    .mar
    {
        margin-left:400px;
    }
        </style>
    <div class="jumbotron">
        <h1>ASP.NET</h1>
        <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>

    <div class="row">
        <div class="co-lg-12">
            <h2 class="text-center">DropDown List And Calender Control</h2>
        </div>
        <div class="col-lg-12 text-center">
            <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
            <br /><br />
            <asp:Button ID="Button1" runat="server" Text="Click Here" OnClick="Button1_Click" />
            <br /><br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br /><br />
            <asp:CheckBoxList ID="CheckBoxList1" runat="server" RepeatColumns="2" RepeatDirection="Vertical">
                <asp:ListItem Value="0">Item1</asp:ListItem>
                <asp:ListItem Value="1">Item2</asp:ListItem>
                <asp:ListItem Value="2">Item3</asp:ListItem>
                <asp:ListItem Value="3">Item4</asp:ListItem>
            </asp:CheckBoxList>
            <br />
            <asp:Button ID="Button2" runat="server" Text="Click Here!" OnClick="Button2_Click"/>
            <br /><br />
            <asp:Label ID="Label1" runat="server" Text="Single List Box"></asp:Label>
            <br />
            <asp:ListBox ID="ListBox1" runat="server" SelectionMode="Single">
                <asp:ListItem Value="0">ListItem1</asp:ListItem>
                <asp:ListItem Value="1">ListItem2</asp:ListItem>
                <asp:ListItem Value="2">ListItem3</asp:ListItem>
                <asp:ListItem Value="3">ListItem4</asp:ListItem>
            </asp:ListBox>
            <br /><br />
            <asp:Button ID="Button3" runat="server" Text="click" OnClick="Button3_Click"/>
            <br />
             <asp:Label ID="Label2" runat="server" Text="Multiple List Box"></asp:Label>
            <br />
            <asp:ListBox ID="ListBox2" runat="server" SelectionMode="Multiple">
                <asp:ListItem Value="0">ListItem1</asp:ListItem>
                <asp:ListItem Value="1">ListItem2</asp:ListItem>
                <asp:ListItem Value="2">ListItem3</asp:ListItem>
                <asp:ListItem Value="3">ListItem4</asp:ListItem>
            </asp:ListBox>
            <br /><br />
            <asp:Button ID="Button4" runat="server" Text="Click" OnClick="Button4_Click"/>
            <br /><br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Content/calendar-flat.png" Width="50px" Height="50px" OnClick="ImageButton1_Click"/>
        <asp:Calendar ID="Calendar1" runat="server" Visible="false" OnSelectionChanged="Calendar1_SelectionChanged" OnDayRender="Calendar1_DayRender" ></asp:Calendar>
        </div>
    </div>

</asp:Content>
