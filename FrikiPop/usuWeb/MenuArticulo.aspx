<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="MenuArticulo.aspx.cs" Inherits="usuWeb.MenuArticulo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <section id="artic">
        <div>
            <h1>
                Menu Articulo (solo para visualizacion de interfaces)
            </h1>

            <section id="opcionesArticulo">
                <asp:Button runat="server" ID="verArticulo" Text="Ver un Articulo concreto" PostBackUrl="~/verArticulo.aspx" />
                <asp:Button runat="server" ID="anyadirArticulo" Text="Añadir un Articulo" PostBackUrl="~/añadirArticulo.aspx" />
            </section>
        </div>
    </section>
</asp:Content>
