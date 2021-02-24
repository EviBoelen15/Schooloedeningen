<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Tekstvakken.aspx.cs" Inherits="Tekstvakken" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtVak1" runat="server" AutoPostBack="True" OnTextChanged="txtVak1_TextChanged"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtVak2" runat="server" AutoPostBack="True" Height="64px" OnTextChanged="txtVak2_TextChanged" TextMode="MultiLine"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblVak1" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Label ID="lblVak2" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
