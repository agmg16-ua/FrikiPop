<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="VerUsuarios.aspx.cs" Inherits="usuWeb.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <asp:Button runat="server" Text="Filtrar" OnClick="Filtrar_Valores"></asp:Button>
        <asp:DropDownList runat="server" id="filtros">
            <asp:ListItem Text="(Seleccione una columna para filtrar)" id="valorInicial"></asp:ListItem>
            <asp:ListItem Text="Nick_name" id="nick"></asp:ListItem>
            <asp:ListItem Text="Nombre" id="nombre"></asp:ListItem>
            <asp:ListItem Text="Apellidos" id="apellidos"></asp:ListItem>
            <asp:ListItem Text="Edad" id="edad"></asp:ListItem>
            <asp:ListItem Text="Administrador" id="administrador"></asp:ListItem>
            <asp:ListItem Text="Localidad" id="localidad"></asp:ListItem>
            <asp:ListItem Text="Provincia" id="provincia"></asp:ListItem>
            <asp:ListItem Text="Pais" id="pais"></asp:ListItem>
        </asp:DropDownList>
        <asp:TextBox runat="server" placeHolder="Introduzca el valor por el que quiera filtrar" id="valorParaFiltrar"></asp:TextBox><br />
        <asp:label runat="server" id="faltaLista"></asp:label>
        <asp:label runat="server" id="faltaValorParaFiltrar"></asp:label>
    </p>
    <asp:GridView CssClass="gridView" ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField HeaderText="Nick_name" DataField="nick_name" SortExpression="nick_name"/>
            <asp:BoundField HeaderText="Nombre" DataField="nombre" SortExpression="nombre"/>
            <asp:BoundField HeaderText="Apellidos" DataField="apellidos" SortExpression="apellidos"/>
            <asp:BoundField HeaderText="Edad" DataField="edad" SortExpression="edad"/>
            <asp:BoundField HeaderText="Contraseña" DataField="contrasenya" SortExpression="contrasenya"/>
            <asp:BoundField HeaderText="Imagen" DataField="url_imagen" SortExpression="url_imagen"/>
            <asp:BoundField HeaderText="Administrador?" DataField="admin" SortExpression="admin"/>
            <asp:BoundField HeaderText="Localidad" DataField="localidad" SortExpression="localidad"/>
            <asp:BoundField HeaderText="Provincia" DataField="provincia" SortExpression="provincia"/>
            <asp:BoundField HeaderText="Pais" DataField="pais" SortExpression="pais"/>
        </Columns>
    </asp:GridView>
    <section id="botonesVerUsuarios">
        <asp:Button class="boton" runat="server" Text="Añadir nuevo usuario" OnClick="CrearUsuario" /><br /><br />
        <asp:TextBox placeHolder="Nombre de usuario" CssClass="cuadroDeTexto" runat="server" ID="eliminar"></asp:TextBox><br /><br />
        <asp:Button class="boton" runat="server" Text="Eliminar usuario" OnClick="EliminarUsuario" />
    </section>
</asp:Content>
