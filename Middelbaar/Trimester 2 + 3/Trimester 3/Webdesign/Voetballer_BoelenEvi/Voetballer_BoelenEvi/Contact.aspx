<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Contact.aspx.cs" Inherits="Contact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="VraagofComment" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h1>Stel een vraag of commentaar</h1>
    <div>
        <div>
            <div>
                <asp:Label ID="LblNaam" runat="server" Text="Geef uw naam in: "></asp:Label>
            </div>

            <div>
                <asp:TextBox ID="TxtNaam" runat="server"></asp:TextBox>
            </div>
        </div>
        <div>
            <div>
                <asp:Label ID="LblEmail" runat="server" Text="Geef uw e-mail adres: "></asp:Label>
            </div>

            <div>
                <asp:TextBox ID="TxtEmail" runat="server"></asp:TextBox>
            </div>
        </div>
        <div>
            <div>
                <asp:Label ID="LblVraag" runat="server" Text="Geef hier uw vraag in: "></asp:Label>
            </div>

            <div>
                <asp:TextBox ID="TxtVraag" runat="server"></asp:TextBox>
            </div>
        </div>
        <div>
            <asp:Button ID="Btnverzend" runat="server" Text="Button" />
        </div>

    </div>
</asp:Content>

