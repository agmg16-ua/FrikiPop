<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Articulos.aspx.cs" Inherits="usuWeb.Articulos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section id="modArticulos">
            <div>
                <asp:GridView ID="GridView" runat="server" AutoGenerateColumns="False" DataKeyNames="codigo,nombre,descripcion,precio,url_imagen,usuario,tipo" CssClass="Gridview" OnSelectedIndexChanged="GridView_SelectedIndexChanged">
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" />
                        <asp:BoundField DataField="codigo" HeaderText="Codigo" SortExpression="codigo" />
                        <asp:BoundField DataField="nombre" HeaderText="Nombre" SortExpression="nombre" />
                        <asp:BoundField DataField="descripcion" HeaderText="Descripcion" SortExpression="descripcion" />
                        <asp:BoundField DataField="precio" HeaderText="Precio" SortExpression="precio" />
                        <asp:ImageField DataImageUrlField="url_imagen" HeaderText="Url imagen" SortExpression="url_imagen" />
                        <asp:BoundField DataField="usuario" HeaderText="Usuario" SortExpression="usuario" />
                        <asp:BoundField DataField="tipo" HeaderText="Tipo" SortExpression="tipo" />
                    </Columns>
                </asp:GridView>
            </div>
    </section>
</asp:Content>
