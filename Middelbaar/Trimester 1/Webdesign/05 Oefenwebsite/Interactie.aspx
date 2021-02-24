<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Interactie.aspx.cs" Inherits="Interactie" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 20px;
        }
        .auto-style3 {
            width: 20px;
            height: 23px;
        }
        .auto-style4 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">Naam:</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtNaam" runat="server" AutoPostBack="True" OnTextChanged="txtNaam_TextChanged"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Voornaam:</td>
                <td>
                    <asp:TextBox ID="txtVoornaam" runat="server" AutoPostBack="True" OnTextChanged="txtVoornaam_TextChanged"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Panel ID="pnlKalender" runat="server" Visible="False">
                        <asp:Label ID="lblAanspreking" runat="server" Text="Label"></asp:Label>
                        <br />
                        Gelieve een datum in de toekoms te selecteren:
                        <asp:Calendar ID="CalKalender" runat="server" OnSelectionChanged="CalKalender_SelectionChanged"></asp:Calendar>
                        <br />
                        <asp:Label ID="lblDatum" runat="server" Text="Label" Visible="False"></asp:Label>
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Panel ID="pnlLogo" runat="server" Visible="False">
                        Indien u het logo van Visual Studio wilt zien, gelieve op onderstaande knop te drukken.<br />
                        <asp:Button ID="btnLogo" runat="server" Text="Toon Logo" OnClick="btnLogo_Click" />
                        <br />
                        <asp:Image ID="imgLogo" runat="server" ImageUrl="~/Images/OefeningBaartKunst.jpg" Visible="False" />
                        <br />
                    </asp:Panel>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
