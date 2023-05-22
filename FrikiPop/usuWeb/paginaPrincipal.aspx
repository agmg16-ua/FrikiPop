<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="paginaPrincipal.aspx.cs" Inherits="usuWeb.paginaPrincipal"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="..\App_Style\paginaPrincipalStyle.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="main_container">
        <div class="articulos">
            <asp:Listview runat="server" ID="PrincipalListView">
                <ItemTemplate>
                    <div class="articulo-card">
                        <asp:ImageButton runat="server" id="imagen_articulo" PostbackUrl='<%#"~/verArticulo.aspx?codigo=" + Eval("codigo") %>' imageUrl= '<%#Eval("url_imagen")%>' Width="200px"/>
                            <figcaption class="articulo-card__caption">
                                <header class="articulo-card__header">
                                    <h2 class="articulo-card__nombre"><asp:label runat = "server" Text='<%# Eval("nombre") %>'/></h2>
                                </header>
                                <footer class="articulo-card__footer">
                                    <span class="articulo-card__precio"> <%# Eval("precio") %> €</span>
                                </footer>
                           </figcaption>
                    </div>
                </ItemTemplate>
            </asp:Listview>
        </div>
        <div class="publicidad">
            <asp:ImageButton  runat="server" id="publicidad_imagen" Width="96px"/>
        </div>
    </div>
</asp:Content>