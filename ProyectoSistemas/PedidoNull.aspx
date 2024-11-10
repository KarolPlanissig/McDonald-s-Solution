<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="PedidoNull.aspx.cs" Inherits="ProyectoSistemas.PedidoNull" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <style> .center-text { text-align: center; 
                       font-family: Arial, sans-serif; 
                       color: #FF0000; }             
</style>
 <div class="center-text">
 <h2>No existe un pedido en curso</h2>
     <asp:Label ID="lblNull" CssClass="center-text" runat="server" Text="Regrese a Inicio y realice un pedido"></asp:Label>
     <br />
     <br />
     <asp:Button ID="btnRegresar"  CssClass="btn btn-primary" runat="server" OnClick="btnRegresar_Click" Text="Inicio" />
 </div>
</asp:Content>
