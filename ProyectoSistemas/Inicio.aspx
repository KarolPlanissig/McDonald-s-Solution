<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="ProyectoSistemas.Inicio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label runat="server" Id="lblNombre" CssClass="H5" Text=""></asp:Label>
    <asp:GridView ID="dgvNombres" runat="server" AutoGenerateColumns="false">
        <Columns>
           <asp:BoundField DataField="Nombre" ControlStyle-CssClass="text-body-secondary" HeaderText="Pedido"/>    
        </Columns>
    </asp:GridView>
    <br />
    <%if (Session["PedidoSesion"] != null)
    { %>
    <asp:Button  runat="server" Id="btnGridView" CssClass="btn btn-primary" OnClick="btnGridView_Click" Text="Confirmar pedido" />
    <asp:Button runat="server" ID="btnGridViewCPedido" CssClass=" btn btn-primary" style="background-color: red; color: white; border-color: red;" OnClick="btnGridViewCPedido_Click" Text="Cancelar pedido" />
     <%  }%>

    
              
     
    <div class="row text-center">
     <h4>Hamburguesas</h4>
 </div>
 <div class="container mx-auto" style="max-width: 900px; margin: 20px;">
     <div class="row justify-content-end">
         <div class="col-md-12">
             <div class="row text-end">
    <asp:Repeater ID="repeatBurgas" runat="server">
        <ItemTemplate>
             <div class="col-md-2 mb-2">
     <div class="card" style="height: 13rem; width: 100%; display: flex; flex-direction: column; justify-content: space-between;">
         <span class="card-title text-center" style="font-size: 0.75rem; display: block;"><%#Eval("Nombre")%></span>
         <img src="<%#Eval("Imagen")%>" class="card-img-top img-fluid" style="max-height: 8rem; height: auto; object-fit: cover;" alt="...">
         <p class="card-text text-center" style="margin: 0;">$<%#Eval("Precio")%></p>
         <div class="d-flex justify-content-center" style="margin-top: 3;"> 
         <asp:Button CssClass="btn btn-primary btn-sm" Text="Agregar" ID="btnAgregarB" style="margin: 0;" OnClick="btnAgregarB_Click1"  CommandArgument='<%#Eval("Nombre") %>' CommandName="NombreBurga" runat="server" />                            
         </div>
         </div>
 </div>
        </ItemTemplate>
    </asp:Repeater>
                             </div>
        </div>
    </div>
</div>
    
    <div class="row text-center">
    <h4>Papas</h4>
    </div>
    <div class="container mx-auto" style="max-width: 900px; margin: 20px;">
        <div class="row justify-content-end">
            <div class="col-md-12">
                <div class="row text-end">
    <asp:Repeater ID="repeatPapas" runat="server">
        <ItemTemplate>
            <div class="col-md-2 mb-2">
     <div class="card" style="height: 13rem; width: 100%; display: flex; flex-direction: column; justify-content: space-between;"">
          <img src="<%#Eval("Imagen")%>" class="card-img-top img-fluid" style="max-height: 7rem; height: auto; object-fit: cover;" alt="...">
      
          <span class="card-title text-center" style="font-size: 0.75rem; display: block;"><%#Eval("Tamaño")%></span>
          <p class="card-text text-center" style="margin: 0;">$<%#Eval("Precio")%></p>
            <div class="d-flex justify-content-center" style="margin-top: 3;">
            <asp:Button CssClass="btn btn-primary btn-sm" Text="Agregar" ID="btnAgregarPapa" CommandArgument='<%#Eval("Tamaño") %>' CommandName="NombrePapa" OnClick="btnAgregarPapa_Click" style="margin: 0;"   runat="server" />
        </div>
     </div>
    </div>

        </ItemTemplate>
    </asp:Repeater>
              </div>
        </div>
    </div>
</div>
    <div class=" row text-center">
    <h4>Bebidas</h4>
    </div>
       <div class="container mx-auto" style="max-width: 900px; margin: 20px;">
            <div class="row justify-content-end">
                <div class="col-md-12">
                    <div class="row text-end">
    <asp:Repeater ID="repeatBebidas" runat="server">
        <ItemTemplate>
                <div class="col-md-2 mb-2">
                    <div class="card" style="height: 13rem; width: 100%; display: flex; flex-direction: column; justify-content: space-between;"">
      <img src="<%#Eval("Imagen")%>" class="card-img-top img-fluid" style="max-height:7rem; height:auto; object-fit:cover;" alt="...">
  
      <span class="card-title text-center" style="font-size:0.75rem; display: block;"><%#Eval("Nombre")%></span>
      <p class="card-text text-center" style="margin: 0;">$<%#Eval("Precio")%></p>
            <div class="d-flex justify-content-center" style="margin-top: 3;">
        <asp:Button CssClass="btn btn-primary btn-sm" Text="Agregar" ID="btnAgregarBebida" style="margin: 0;" CommandArgument='<%#Eval("Nombre") + "," + Eval("Precio").ToString()%> ' CommandName="NombreBebida" OnClick="btnAgregarBebida_Click1"  runat="server" />
            </div>
                </div>
                    </div>
        </ItemTemplate>
    </asp:Repeater>
              </div>
        </div>
    </div>
</div>

</asp:Content>
