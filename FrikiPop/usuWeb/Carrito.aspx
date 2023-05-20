<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="usuWeb.Carrito" EnableEventValidation="true" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

      <div class="carritoCompra">

          <section class="topBar">

              <h3 id= "carritoFrikiPop">Carrito FrikiPop </h3>
               <h3 id= "BorrarTodoCarrito"> 
                   <asp:LinkButton ID = "BorrarCarrito" Text= "Borrar todo el carrito" runat="server" OnClick="eliminarCarritoCompra"/>  
               </h3>
          </section>
          
          <div class="ContentCarrito">

                <div class= "EnlistarArticulos">

                    <%--<asp:ListView runat="server" ID="ListView1" GroupItemCount="1" OnSelectedIndexChanged="ListView_SelectedIndexChanged" DataKeyNames="linea" >
                        <ItemTemplate>
                            <img width="150px" src="<%# Eval("url_imagen")  %>" />
                            <%# Eval("nombre") %> 
                            <%# Eval("precio") %> 
                            <asp:Button runat="server" ShowSelectButton="True" Text="Eliminar Articulo" />
                            <br /> <br />
                        </ItemTemplate>
                    </asp:ListView>--%>
                    <asp:GridView runat="server" ID="GridView" AutoGenerateColumns="false" DataKeyNames="linea" OnSelectedIndexChanged="GridView_SelectedIndexChanged" ShowHeader="false" Width="75%" BorderColor="#0f1618" >
                        <Columns>
                            <asp:CommandField ShowSelectButton="True" SelectText="Borrar Articulo" ItemStyle-ForeColor="white" />
                            <asp:BoundField DataField="linea" />
                            <asp:ImageField DataImageUrlField="url_imagen" ControlStyle-Width="150px"></asp:ImageField>
                            <asp:BoundField DataField="nombre" />
                            <asp:BoundField DataField="precio" />
                        </Columns>
                    </asp:GridView>
                </div>

                <div class = "EfectuarPedido">
                    <h3> Precio total del pedido </h3>

                        <div id = "ValorCarritoContainer">

                            <div class = "ContainerLeft"> valor del carrito de compra </div>

                             <div class = "ContainerRight">
                                 <asp:Label ID = "value" runat = "server">


                                 </asp:Label>
                             </div>

                        </div>

                        <div id = "EnvioContainer">

                            <div class = "ContainerLeft"> Envio del pedido </div>

                            <div class = "ContainerRight">5.49€ </div>

                        </div>

                        <div id = "PrecioTotalContainer">

                            <div class = "ContainerLeft">
                                <h5>Total del pedido:</h5>
                            </div>

                            <div class = "ContainerRight">
                                <h5>
                                    <asp:Label ID = "TotalPrecio" runat = "server"> </asp:Label>
                                </h5>
                            </div>

                        </div>

                    <h4> Efectuar Pedido </h4>
             
                            <div id="PedidoContainer">
                                <asp:Button ID = "Button2" runat = "server" Text="Tramitar pedido" CssClass="pedido" OnClick="tramitarPedido"/>
                             </div>
                </div>

            </div>

        </div>

</asp:Content>