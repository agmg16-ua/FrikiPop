<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="paginaPrincipal.aspx.cs" Inherits="usuWeb.Formulario_web1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Repeater runat="server" ID="PrincipalRepeater">
        <ItemTemplate>
            <div class="articulo-card">
                <asp:Image runat="server" ImageUrl= '<%#Eval("url_imagen")%>'/>
                    <figcaption class="articulo-card__caption">
                        <header class="articulo-card__header">
                            <h2 class="articulo-card__nombre"><asp:Literal runat = "server" Text='<%# Eval("nombre") %>'/></h2>
                        </header>
                        <footer class="articulo-card__footer">
                            <span class="articulo-card__precio"> <%# Eval("precio") %> </span>
                            <asp:Button runat="server" class="articulo-card__button"/>
                            <i class="articulo-card__icon ri-add-line"></i>
                        </footer>
                   </figcaption>
            </div>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
