<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="BreakExitoso.aspx.cs" Inherits="ProyectoSistemas.BreakExitoso" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <style> .center-text { text-align: center; 
                          font-family: Arial, sans-serif; 
                          color: #4CAF50; }             
   </style>
    <div class="center-text">
    <h2>Break autorizado con exito</h2>
    <asp:Label  ID="lblMensaje" runat="server" Text="" CssClass="center-text "></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnInicio" CssClass="btn btn-primary"  runat="server" OnClick="btnInicio_Click" Text="Inicio" />
    </div>
</asp:Content>
