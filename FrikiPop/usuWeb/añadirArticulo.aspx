<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="añadirArticulo.aspx.cs" Inherits="usuWeb.añadirArticulo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section id="modAñadirArticulo">
            <asp:Label runat="server" for="codigo" Text="Codigo: "></asp:Label>
            <asp:TextBox runat="server" id="codigo" name="codigo" placeholder="Codigo"/>
            <br>
            <asp:Label runat="server" for="nombre" Text="Nombre: "></asp:Label>
            <asp:TextBox runat="server" id="nombre" name="nombre" placeholder="Nombre"/>
            <br>
            <asp:Label runat="server" for="descripcion" Text="Descripcion: "></asp:Label>
            <asp:TextBox runat="server" id="descripcion" name="descripcion" placeholder="Descripcion"/>
            <br>
            <asp:Label runat="server" for="precio" Text="Precio: "></asp:Label>
            <asp:TextBox runat="server" id="precio" name="precio" placeholder="Precio"/>
            <br>
            <asp:Label runat="server" for="url_imagen" Text="Url imagen: "></asp:Label>
            <asp:TextBox runat="server" id="url_imagen" name="url_imagen" placeholder="Url imagen"/>
            <br>
            <asp:Label runat="server" for="usuario" Text="Usuario: "></asp:Label>
            <asp:TextBox runat="server" id="usuario" name="usuario" placeholder="Usuario"/>
            <br>
            <asp:Label runat="server" for="tipo" Text="Tipo: "></asp:Label>
            <asp:TextBox runat="server" id="tipo" name="tipo" placeholder="Tipo"/>
            <br>
            <section ID="botonesAñadirArticulo">
                <asp:Button runat="server" ID="anyadir" type="submit" Text="Añadir articulo" OnClick="añadir_Click"></asp:Button>
                <asp:Button runat="server" ID="borrar" type="submit" Text="Eliminar articulo" OnClick="borrar_Click"></asp:Button>
                <asp:Button runat="server" Text="Volver" CausesValidation="false" OnClick="Volver_Click" />
            </section>
    </section>
</asp:Content>
