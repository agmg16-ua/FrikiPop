<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="usuWeb.Formulario_web11" %>
<asp:Content ID="Carrito1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Carrito2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

      <div class="carrito">
          <div class="topBar">
              <h3 id="carritoFrikiPop">Carrito FrikiPop</h3>
               <h3 id="BorrarTodoCarrito"> 
                   <asp:LinkButton ID = "BorrarCarrito" Text= "Borrar todo el carrito" runat="server" OnClick="eliminarCarritoCompra"/>
               </h3>
          </div>
            

        </div>




</asp:Content>
  
