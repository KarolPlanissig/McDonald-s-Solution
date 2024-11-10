<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="ConfirmarPedido.aspx.cs" Inherits="ProyectoSistemas.ConfirmarPedido" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
        <div class="col-6">
    <div class="mb-3">
        <label for="txtCrew" class="form-label">DNI del empleado</label>
        <asp:TextBox ID="txtCrew"  CssClass="form-control" runat="server" />
    </div>
</div>
        <asp:Button ID="btnAceptar" CssClass="btn btn-primary" OnClick="btnAceptar_Click" runat="server" Text="Confirmar orden" />
    </div>
    

</div>
</asp:Content>
