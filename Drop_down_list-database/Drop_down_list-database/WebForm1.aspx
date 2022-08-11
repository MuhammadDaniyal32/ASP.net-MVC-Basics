<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Drop_down_list_database.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Drop Down List With Database</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Choose Your State"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" DataTextField="State_name" DataValueField="Country_id" AppendDataBoundItems="true" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem Value="0">-------Select State-------</asp:ListItem>

        </asp:DropDownList>

        <asp:Label ID="Label2" runat="server" Text="Choose Your Country"></asp:Label>
        <asp:DropDownList ID="DropDownList2" runat="server" DataValueField="Country_id" DataTextField="Country_name" AppendDataBoundItems="true" AutoPostBack="true" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
            <asp:ListItem Value="0">---------Select Country------</asp:ListItem>
        </asp:DropDownList>

        <asp:Label ID="Label3" runat="server" Text="Choose Your City"></asp:Label>
        <asp:DropDownList ID="DropDownList3" runat="server" DataValueField="city_Id" DataTextField="city_name" AppendDataBoundItems="true" AutoPostBack="true" OnSelectedIndexChanged="DropDownList3_SelectedIndexChanged">
            <asp:ListItem Value="0">---------Select City---------</asp:ListItem>
        </asp:DropDownList>
    </div>
    </form>
</body>
</html>
