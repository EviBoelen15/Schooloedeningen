<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Dieren.aspx.cs" Inherits="Dieren" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Selecteer je lievelingsdier: "></asp:Label>
        <asp:ListBox ID="lstDieren" runat="server" AutoPostBack="True" Height="123px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Width="125px">
            <asp:ListItem>hond</asp:ListItem>
            <asp:ListItem>kat</asp:ListItem>
            <asp:ListItem>muis</asp:ListItem>
            <asp:ListItem>paard</asp:ListItem>
            <asp:ListItem>hamster</asp:ListItem>
            <asp:ListItem>vis</asp:ListItem>
        </asp:ListBox>
        <br />
        <br />
        <br />
        <asp:Label ID="lblKeuze" runat="server"></asp:Label>
    </form>
</body>
</html>
