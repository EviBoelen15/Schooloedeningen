<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Invoeren.aspx.cs" Inherits="Bloedwaardes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>Test hier uw bloed op doping:  </h1>    <br>
    <asp:Label ID="lblDeurw" runat="server" Text="Deurwaarder: "></asp:Label>
    <asp:TextBox ID="tbDeurw" runat="server"></asp:TextBox>
    <br><br>
    <asp:Label ID="lbldatum" runat="server" Text="Geef de huidige datum in."></asp:Label><br><br>
    <asp:Calendar ID="cd" runat="server"></asp:Calendar><br>
    <asp:Label ID="lbluitleg" runat="server" Text="Voer hieronder uw bloedwaardes in:"></asp:Label><br>
    <asp:TextBox ID="tbbloedwaarde" runat="server"></asp:TextBox><br><br>
    <asp:Button ID="btnbereken" runat="server" Text="Bereken mijn doping gehalte." OnClick="btnbereken_Click" />
    <br><br>
    <asp:Label ID="lblresultaat" runat="server" Text=""></asp:Label>
</asp:Content>

