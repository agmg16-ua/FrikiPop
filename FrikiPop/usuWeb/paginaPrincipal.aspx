<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="paginaPrincipal.aspx.cs" Inherits="usuWeb.paginaPrincipal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="main_container">
        <div class="articulos">
            <asp:Listview runat="server" ID="PrincipalListView" DataSourceID="dsArticulos">
                <ItemTemplate>
                    <div class="articulo-card">
                        <asp:Image runat="server" ImageUrl= '<%#Eval("url_imagen")%>'/>
                            <figcaption class="articulo-card__caption">
                                <header class="articulo-card__header">
                                    <h2 class="articulo-card__nombre"><asp:label runat = "server" Text='<%# Eval("nombre") %>'/></h2>
                                </header>
                                <footer class="articulo-card__footer">
                                    <span class="articulo-card__precio"> <%# Eval("precio") %> €</span>
                                    <asp:Button runat="server" class="articulo-card__button"/>
                                    <i class="articulo-card__icon ri-add-line"></i>
                                </footer>
                           </figcaption>
                    </div>
                </ItemTemplate>
            </asp:Listview>
            <asp:SqlDataSource ID="dsArticulos" runat="server" ConnectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True" SelectCommand="SELECT * FROM Articulo"></asp:SqlDataSource>

        </div>
        <div class="publicidad">
            <asp:ImageButton  runat="server" id="publicidad_imagen" OnClick="Publicidad_OnClick" Width="96px"/>
        </div>
    </div>
</asp:Content>