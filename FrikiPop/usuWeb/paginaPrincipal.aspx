<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="paginaPrincipal.aspx.cs" Inherits="usuWeb.Formulario_web1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:repeater runat="server" ID="Repeater-PaginaPrincipal">
        <ItemTemplate>
            <div class="articulo-card">
                <!-- imagen-->
                    <figcaption class="articulo-card__caption">
                        <header class="articulo-card__header">
                            <h2 class="articulo-card__nombre"></h2>
                        </header>
                        <footer class="articulo-card__footer">
                            <span class="articulo-card__precio"> =///articulo.precio /span>
                            <asp:Button runat="server" class="articulo-card__button"/>
                            <i class="articulo-card__icon ri-add-line"></i>
                        </footer>
                   </figcaption>
            </div>
        </ItemTemplate>
    </asp:repeater>
</asp:Content>
