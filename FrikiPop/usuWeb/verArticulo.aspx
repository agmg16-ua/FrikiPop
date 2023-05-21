<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="verArticulo.aspx.cs" Inherits="usuWeb.verArticulo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<section class="modVerArticulo">
                <asp:Image ID="url_imagen" runat="server"/>
                <h1>
                    <asp:Label ID="nombre" runat="server">
                    </asp:Label>
                </h1>
                <h3>
                    Precio del producto:
                </h3>
                <p>
                    <asp:Label ID="precio" runat="server"></asp:Label>
                </p>
                <h3>
                    Descripción del producto:
                </h3>
                <p>
                    <asp:Label ID="descripcion" runat="server"></asp:Label>
                </p>
                <p>     
                    <asp:Button ID="añadirCesta" runat="server" Text="Añadir al carrito" OnClick="añadirCestaClick">
                    </asp:Button>
                    <asp:Label ID="outputMessageAñadir" runat="server"></asp:Label>
                </p>
                <p>     
                    <asp:Button ID="comprarAhora" runat="server" Text="Comprar ahora" OnClick="comprarAhoraClick">
                    </asp:Button>
                    <asp:Label ID="outputMessageComprar" runat="server"></asp:Label>
                </p>
    </section>
</asp:Content>
