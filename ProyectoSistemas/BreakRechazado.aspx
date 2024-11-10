<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="BreakRechazado.aspx.cs" Inherits="ProyectoSistemas.BreakRechazado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style> .center-text { text-align: center; 
                       font-family: Arial, sans-serif; 
                       color: #FF0000; }             
</style>
    <div class="center-text">
    <h1>Break rechazado</h1>
        <asp:Label ID="lblRechazado" runat="server" Text="Hola"></asp:Label>
        <br />
        <br />
    <asp:Button ID="btnIntentar" runat="server" CssClass="btn btn-primary" OnClick="btnIntentar_Click" Text="Intentar de nuevo" />
    <asp:Button ID="btnMenu" runat="server" CssClass="btn btn-primary" OnClick="btnMenu_Click" Text="Menú" />
    </div>
    <br />

    <div class="center-text">
    <asp:Button ID="btnAutorizar" CssClass="btn btn-primary" OnClick="btnAutorizar_Click"  runat="server" Text="AutorizarBreak" />
    </div>
</asp:Content>
