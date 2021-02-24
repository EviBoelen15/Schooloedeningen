<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Wachtwoord.aspx.cs" Inherits="Wachtwoord" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Wachtwoord:
            <asp:TextBox ID="txtPaswoord" runat="server" AutoPostBack="True" OnTextChanged="txtPaswoord_TextChanged" TextMode="Password"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblFeedback" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
