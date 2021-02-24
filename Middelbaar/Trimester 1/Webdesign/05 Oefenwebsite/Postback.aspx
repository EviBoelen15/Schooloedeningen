<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Postback.aspx.cs" Inherits="Postback" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            margin-left: 334px;
            background-color: #66FF33;
        }
        .auto-style2 {
            text-align: center;
        }
        .auto-style3 {
            text-align: left;
            width: 123px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:CheckBox ID="chkRestPagina" runat="server" AutoPostBack="True" OnCheckedChanged="chkRestPagina_CheckedChanged" Text="Toon mij de rest van de pagina" />
            <br />
            <asp:Panel ID="PanelASP" runat="server" CssClass="auto-style1" Height="155px" Visible="False" Width="533px">
                <div class="auto-style2">
                    <br />
                    Programmeren in ASP.Net is<br />
                    <div class="auto-style3">
                        <asp:RadioButton ID="rdbLeuk" runat="server" AutoPostBack="True" GroupName="Asp.net" OnCheckedChanged="rdbLeuk_CheckedChanged" Text="Leuk" />
                        <br />
                        <asp:RadioButton ID="rdbMoeilijk" runat="server" AutoPostBack="True" GroupName="Asp.net" OnCheckedChanged="rdbMoeilijk_CheckedChanged" Text="Moeilijk" />
                    </div>
                    <br />
                </div>
            </asp:Panel>
        </div>
        <asp:Label ID="lblVerandering" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
