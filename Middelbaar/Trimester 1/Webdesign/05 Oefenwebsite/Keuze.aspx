<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Keuze.aspx.cs" Inherits="Keuze" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            background-color: #FFCC99;
        }
        .auto-style3 {
            width: 185px;
            background-color: #FFCC99;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 class="auto-style2">Maak je keuze!</h1>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3">Taal:</td>
                    <td class="auto-style2">
                        <asp:DropDownList ID="ddlTaal" runat="server">
                            <asp:ListItem Selected="True">Kies een taal:</asp:ListItem>
                            <asp:ListItem>Nederlands</asp:ListItem>
                            <asp:ListItem>Frans</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Aangeboden sessies:</td>
                    <td class="auto-style2">
                        <asp:CheckBoxList ID="chklSessies" runat="server">
                            <asp:ListItem>ASP.NET met databanken</asp:ListItem>
                            <asp:ListItem>ASP.NET zonder databanken</asp:ListItem>
                            <asp:ListItem>OOP</asp:ListItem>
                            <asp:ListItem>ADO.NET</asp:ListItem>
                            <asp:ListItem>XML</asp:ListItem>
                            <asp:ListItem>UML</asp:ListItem>
                        </asp:CheckBoxList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Receptie:</td>
                    <td class="auto-style2">
                        <asp:CheckBox ID="chkReceptie" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Middagmaal</td>
                    <td class="auto-style2">
                        <asp:RadioButtonList ID="rdblMiddagmaal" runat="server">
                            <asp:ListItem>Soep</asp:ListItem>
                            <asp:ListItem>Broodjes</asp:ListItem>
                            <asp:ListItem>Warme maaltijd</asp:ListItem>
                            <asp:ListItem>Geen middagmaal</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Button ID="btnInschrijven" runat="server" OnClick="btnInschrijven_Click" Text="Bevestig inschrijving" />
                    </td>
                    <td class="auto-style2">
                        <asp:Label ID="lblBevestiging" runat="server" Text="Label" Visible="False"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
