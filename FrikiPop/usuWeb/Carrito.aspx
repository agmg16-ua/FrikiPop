<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="usuWeb.Carrito" %>
<asp:Content ID="Carrito1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Carrito2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

      <div class="carritoCompra">

          <div class="topBar">

              <h3 id= "carritoFrikiPop">Carrito FrikiPop </h3>
               <h3 id= "BorrarTodoCarrito"> 
                   <asp:LinkButton ID = "BorrarCarrito" Text= "Borrar todo el carrito" runat="server" OnClick="eliminarCarritoCompra"/>  
               </h3>
          </div>
          
          <div class="ContentCarrito">

                <div class= "EnlistarArticulos">

                  <asp:Repeater ID = "Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">

                    <ItemTemplate>

                        <div class = "Articulo">

                            <div class = "Image">

                                <asp:ImageButton PostBackUrl = '<%#"~/Articulos.aspx?nombre = "+ Eval("nombre") + "&url_imagen=" + Eval("url_imagen") + 
                               "&precio = " + Eval("precio") + "&codigo=" + Eval("codigo")%>' runat = "server" ImageUrl = '<%#Eval("url_imagen")%>'/>

                            </div>

                            <div  class = "Info" >

                               <h3> <asp:Literal runat = "server" Text='<%# Eval("nombre") %>'/> </h3>

                                <asp:GridView runat= "server" AutoGenerateColumns= "false">
                                    <Columns>
                                         <asp:BoundField DataField= "precio" DataFormatString="{0:C}" HeaderText="Precio" />
                                    </Columns>
                                </asp:GridView>

                               <strong>ID del Articulo: </strong> 
                               <span> <%= string.Format("{0:D2}", Eval("articulo")) %> </span>
                               <br/>

                            
                            </div>

                            <div class = "PrecioFinal">

                                <<asp:Button ID = "Button1" Text = "Borrar" runat="server" OnClick="deleteArticulo" CommandArgument='<%# Eval("articulo") %>' CssClass="Borrar" />

                                <h3>
                                    <strong> <asp:Label runat = "server" Text='<%# Eval("importe") %>' />€ </strong>

                                </h3>

                            </div>

                        </div>

                    </ItemTemplate>

                   </asp:Repeater>

                </div>

                <div class = "EfectuarPedido">

                    <h3> Precio total del pedido </h3>

                        <div id = "ValorCarritoContainer">

                            <div class = "ContainerLeft"> valor del carrito de compra </div>

                             <div class = "ContainerRight">
                                 <asp:Label ID = "value" runat = "server"> </asp:Label>
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