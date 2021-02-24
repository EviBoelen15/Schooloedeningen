<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_Lay-Out.master" AutoEventWireup="true" CodeFile="Invoeren.aspx.cs" Inherits="Invoeren" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>Welkom op de website van Enrico ufficiale Giudiziario Labo</h1>
    <ul>
      
        <li><a href="Algemene informatie.aspx">Algemene informatie</a> </li>
        <li></li>
        <li> <a href="Invoeren.aspx">Invoeren</a> </li>
    </ul>
    
    <div id="Textinhoud">
        <h2>Invoeren</h2>
        <h3>Bodybuilding wedstrijd / concorso di bodybuilding in Italia:</h3>
        <p>Voer hier de informatie in:</p>
        <p> &nbsp; Gerechtsdeurwaarder:&nbsp;
            <asp:TextBox ID="txtbxGerechtsdeurwaarder" runat="server"></asp:TextBox>
        </p>
        <p> &nbsp;&nbsp;Bloedwaarde:
            <asp:TextBox ID="txtbxBloedwaarde" runat="server"></asp:TextBox>
        </p>
        <p> 
            <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
            <asp:Label ID="DatumControle" runat="server" Text=""></asp:Label>
        </p>  
              
            <asp:Button ID="Button1" runat="server" Text="Verzend" OnClick="Button1_Click" />
            <br />
            

            <div id="Informatie"> 
                <asp:Label ID="lblgerechtsdeurwaarder" runat="server" Text="Gerechtsdeurwaarder: "></asp:Label>
                <br />
                <asp:Label ID="lblBloedwaarde" runat="server" Text="Bloedwaarde: "></asp:Label>
                <br />
                <asp:Label ID="lbldatum" runat="server" Text="Datum: "></asp:Label>
            </div>      
        
    </div>
     <h1 style="background-color:red">- </h1>
</asp:Content>

