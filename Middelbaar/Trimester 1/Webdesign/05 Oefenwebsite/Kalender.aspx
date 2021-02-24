<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Kalender.aspx.cs" Inherits="Kalender" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Calendar ID="calKalender" runat="server" OnSelectionChanged="calKalender_SelectionChanged"></asp:Calendar>
            <br />
            <asp:Label ID="lblLabel" runat="server" Text="Label"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
