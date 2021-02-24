<%@ Page Language="C#" AutoEventWireup="true" CodeFile="KalenderUitbreiding.aspx.cs" Inherits="KalenderUitbreiding" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            text-align: center;
        }
        .auto-style4 {
            width: 37%;
        }
        .auto-style5 {
            width: 184px;
            height: 23px;
            text-align: center;
        }
        .auto-style6 {
            height: 23px;
            text-align: center;
        }
        .auto-style7 {
            width: 184px;
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <table class="auto-style4">
                <tr>
                    <td class="auto-style7">Begindatum</td>
                    <td class="auto-style2">Einddatum</td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        <asp:Calendar ID="calBegin" runat="server" OnSelectionChanged="calBegin_SelectionChanged"></asp:Calendar>
                    </td>
                    <td class="auto-style2">
                        <asp:Calendar ID="CalEind" runat="server" OnSelectionChanged="CalEind_SelectionChanged"></asp:Calendar>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <asp:Label ID="lblBegin" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td class="auto-style6">
                        <asp:Label ID="lblEind" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" colspan="2">
                        <asp:Label ID="lblVerschil" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
