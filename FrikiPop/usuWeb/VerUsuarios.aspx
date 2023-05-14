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
    <div class="SeccionUsuarios">
        <p>
            <asp:Button class="boton" runat="server" Text="Añadir nuevo usuario" OnClick="CrearUsuario" /><br />
        </p>
        <p>
            <asp:TextBox CssClass="cuadroDeTexto" placeHolder="Nombre de usuario" runat="server" ID="eliminar"></asp:TextBox><br />
        </p>
        <p>
            <asp:Button class="boton" runat="server" Text="Eliminar usuario" OnClick="EliminarUsuario" />
        </p>
    </div>
</asp:Content>
