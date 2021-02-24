<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Inschrijvingen.aspx.cs" Inherits="Inschrijvingen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 62%;
        }
        .auto-style2 {
            text-align: center;
            font-size: xx-large;
            color: #CC3300;
            background-color: #FFCC99;
        }     
        .auto-style3 {
            text-align: left;
            font-size: xx-large;
            color: #CC3300;
            background-color: #FFCC99;
        }     
        .auto-style6 {
            width: 154px;
            height: 55px;
            background-color: #FFCC99;
        }
        .auto-style7 {
            width: 927px;
            height: 55px;
            background-color: #FFCC99;
        }
        .auto-style8 {
            font-size: medium;
        }
        .auto-style9 {
            width: 100%;
        }
        .auto-style10 {
            height: 24px;
        }
        .auto-style11 {
            height: 40px;
            text-align: center;
        }
        .auto-style12 {
            text-align: center;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2" colspan="2">
                    <asp:Label ID="lblTitel" runat="server" Text="Studiedag"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Familienaam</td>
                <td class="auto-style7">
                    <asp:TextBox ID="txtFamilie" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Voornaam</td>
                <td class="auto-style7">
                    <asp:TextBox ID="txtVoornaam" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">E-mailadres</td>
                <td class="auto-style7">
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Geboortedatum</td>
                <td class="auto-style7">
                    <asp:Calendar ID="calKalender" runat="server" SelectedDate="<%# DateTime.Today %>" ></asp:Calendar>
                </td>
            </tr>
            <tr>
                <td class="auto-style2" colspan="2">
                    <asp:Button ID="btnGenereer" runat="server" Text="Genereer" Width="200px" OnClick="btnGenereer_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style3" colspan="2">
                    <asp:Panel ID="Panel1" runat="server" Height="140px" Visible="False">
                        <table class="auto-style9">
                            <tr>
                                <td> <asp:Label ID="Label1" runat="server" Text="Identificatie: " CssClass="auto-style8"></asp:Label></td>
                                <td><asp:Label ID="lblId" runat="server" Text="lblId" CssClass="auto-style8"></asp:Label></td>
                            </tr>
                            <tr>
                                <td class="auto-style10"><asp:Label ID="Label3" runat="server" Text="Sleutel: " CssClass="auto-style8"></asp:Label></td>
                                <td class="auto-style10"><asp:Label ID="lblSleutel" runat="server" Text="lblSleutel" CssClass="auto-style8"></asp:Label></td>
                            </tr>
                            <tr>
                                <td colspan="2" class="auto-style12"><asp:Button ID="btnAanmelden" runat="server" Text="Aanmelden" Width="203px" />
                        </td>
                            </tr>
                            <tr>
                                <td class="auto-style11" colspan="2"> <asp:Label ID="lblResultaat" runat="server" Text="lblResultaat"></asp:Label></td>
                            </tr>
                        </table>
                                       
                       
                    </asp:Panel>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
