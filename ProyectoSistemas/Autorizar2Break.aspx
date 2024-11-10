<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Autorizar2Break.aspx.cs" Inherits="ProyectoSistemas.Autorizar2Break" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <style> .center-text { text-align: center; 
                       font-family: Arial, sans-serif; 
                       color: #FF0000; }             
</style>
    <h2 class="center-text">Estas autorizando un 2do break</h2>   
    <div class="container">
    <div class="row">
        <div class="col-6">
            <div class="mb-3">
                <label for="txtUsuario" class="form-label">Usuario</label>
                <asp:TextBox ID="txtUsuario" CssClass="form-control" runat="server" />
            </div>
        </div>
        <div class="col-6">
            <div class="mb-3">
                <label for="txtClave" class="form-label">Contraseña</label>
                <asp:TextBox ID="txtClave" placeholder="****" TextMode="Password" CssClass="form-control" runat="server" />
            </div>
        </div>
        
        <asp:Button ID="btnConfirmarAutorizacion" CssClass="btn btn-primary" Onclick="btnConfirmarAutorizacion_Click"   runat="server" Text="Confirmar Break" />

    </div>
    </div>

</asp:Content>
