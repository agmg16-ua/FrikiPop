<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="VerUsuarios.aspx.cs" Inherits="usuWeb.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView CssClass="gridView" ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField ItemStyle-HorizontalAlign="Center" HeaderText="Nick_name" DataField="nick_name" SortExpression="nick_name">
                <ItemStyle HorizontalAlign="Center"></ItemStyle>
            </asp:BoundField>
            <asp:BoundField ItemStyle-HorizontalAlign="Center" HeaderText="Nombre" DataField="nombre" SortExpression="nombre">
                <ItemStyle HorizontalAlign="Center"></ItemStyle>
            </asp:BoundField>
            <asp:BoundField ItemStyle-HorizontalAlign="Center" HeaderText="Apellidos" DataField="apellidos" SortExpression="apellidos">
                <ItemStyle HorizontalAlign="Center"></ItemStyle>
            </asp:BoundField>
            <asp:BoundField ItemStyle-HorizontalAlign="Center" HeaderText="Edad" DataField="edad" SortExpression="edad">
                <ItemStyle HorizontalAlign="Center"></ItemStyle>
            </asp:BoundField>
            <asp:BoundField ItemStyle-HorizontalAlign="Center" HeaderText="Contraseña" DataField="contrasenya" SortExpression="contrasenya">
                <ItemStyle HorizontalAlign="Center"></ItemStyle>
            </asp:BoundField>
            <asp:BoundField ItemStyle-HorizontalAlign="Center" HeaderText="Imagen" DataField="url_imagen" SortExpression="url_imagen">
                <ItemStyle HorizontalAlign="Center"></ItemStyle>
            </asp:BoundField>
            <asp:BoundField ItemStyle-HorizontalAlign="Center" HeaderText="Administrador?" DataField="admin" SortExpression="admin">
                <ItemStyle HorizontalAlign="Center"></ItemStyle>
            </asp:BoundField>
            <asp:BoundField ItemStyle-HorizontalAlign="Center" HeaderText="Localidad" DataField="localidad" SortExpression="localidad">
                <ItemStyle HorizontalAlign="Center"></ItemStyle>
            </asp:BoundField>
            <asp:BoundField ItemStyle-HorizontalAlign="Center" HeaderText="Provincia" DataField="provincia" SortExpression="provincia">
                <ItemStyle HorizontalAlign="Center"></ItemStyle>
            </asp:BoundField>
            <asp:BoundField ItemStyle-HorizontalAlign="Center" HeaderText="Pais" DataField="pais" SortExpression="pais">
                <ItemStyle HorizontalAlign="Center"></ItemStyle>
            </asp:BoundField>
        </Columns>
    </asp:GridView>
    <asp:Button class="boton" runat="server" Text="Añadir nuevo usuario" OnClick="CrearUsuario" /><br />
    <asp:TextBox CssClass="cuadroDeTexto" placeHolder="Nombre de usuario" runat="server" ID="eliminar"></asp:TextBox><br />
    <asp:Button class="boton" runat="server" Text="Eliminar usuario" OnClick="EliminarUsuario" />
</asp:Content>
