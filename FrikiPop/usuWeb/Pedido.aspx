<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Pedido.aspx.cs" Inherits="usuWeb.Pedido" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="#" rel="stylesheet" />
    <div class="contenedor">
        <div class="pedido">
            <div class="Sup">
                <h2 id="Titulo">Pedido</h2>
            </div>
            <div class="PedidoContenido">
                <div class="listadoProductos">
                    <asp:ListView ID="ListView1" runat="server">
                    <ItemTemplate>
                        <div class="producto">
                            <div class="imagen">
                               <!-- <asp:ImageButton PostBackUrl='<%#"~/Articulos.aspx?nombre="+ Eval("nombre") + "&urlimagen=" + Eval("urlimagen") + "&precio=" + Eval("precio") + "&cod=" + Eval("num_pedido")%>'
                                    runat="server" ImageUrl='<%#Eval("urlimagen")%>' style="max-height:100%; max-width:100%; display: block; margin: auto; "/>-->
                            </div>
                            <div class="info">
                                <h2><asp:Label runat="server" Text='<%# Eval("nombre") %>' /></h2>
                                <h3><asp:Label runat="server" Text='<%# Eval("tipo") %>' /></h3>
                                <br />
                                <h4><asp:Label runat="server" Text='<%# string.Format("{0:C}", Eval("precio")) %>' /></h4>
                                <b>Id Artículo: </b><asp:Label runat="server" Text='<%# string.Format("{0:D6}", Eval("articulo")) %>' /><br />
                                <div class="informacionProducto">
                                    <br />
                                    <b>Estado:</b><asp:Label runat="server" Text='<%# Eval("estado_carrito") %>' />
                                </div>
                            </div>
                            <div class="precioResultante">
                                <h2><b><asp:Label runat="server" Text='<%# Eval("total") %>' />€</b></h2>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:ListView>
                </div>
                <div class="infoPedido">
                    <h2>ID: #<asp:Label ID="id" runat="server"></asp:Label></h2>
                        <div class="Sup">
                            <div class="contenedorIzq">Precio del Pedido:</div>
                            <div class="contenedorDer"><asp:Label ID="valor" runat="server"></asp:Label></div>
                        </div>
                        <div class="Sup">
                            <div class="contenedorIzq">Envío:</div>
                            <div class="contenedorDer">5,00 €</div>
                        </div>
                        <div id="totalContenedor">
                            <div class="contenedorIzq"><h4>Total:</h4></div>
                            <div class="contenedorDer"><h4><asp:Label ID="total" runat="server"></asp:Label></h4></div>
                        </div>

                    <br /><br />
                    <h3>DATOS DEL PEDIDO: </h3>
                        <div class="Sup">
                            <div class="contenedorIzq">Método de pago:</div>
                            <div class="contenedorDer">Tarjeta</div>
                        </div>
                        <div class="Sup">
                            <div class="contenedorIzq">Fecha:</div>
                            <div class="contenedorDer"><asp:Label ID="fecha" runat="server"></asp:Label></div>
                        </div>
                        <div class="Sup"> 
                            <div class="contenedorIzq">Dirección:</div>
                            <div class="contenedorDer"><asp:Label ID="direccion" runat="server"></asp:Label></div>
                        </div>
                        <div id="devolucion">DEVOLUCIÓN</div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
