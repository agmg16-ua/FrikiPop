<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="VerUsuarios.aspx.cs" Inherits="usuWeb.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AutoGenerateColumns="False">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:BoundField ItemStyle-HorizontalAlign="Center" HeaderText="Nick_name" DataField="nick_name" SortExpression="nick_name"/>
            <asp:BoundField ItemStyle-HorizontalAlign="Center" HeaderText="Nombre" DataField="nombre" SortExpression="nombre"/>
            <asp:BoundField ItemStyle-HorizontalAlign="Center" HeaderText="Apellidos" DataField="apellidos" SortExpression="apellidos"/>
            <asp:BoundField ItemStyle-HorizontalAlign="Center" HeaderText="Edad" DataField="edad" SortExpression="edad"/>
            <asp:BoundField ItemStyle-HorizontalAlign="Center" HeaderText="Contraseña" DataField="contrasenya" SortExpression="contrasenya"/>
            <asp:BoundField ItemStyle-HorizontalAlign="Center" HeaderText="Imagen" DataField="url_imagen" SortExpression="url_imagen"/>
            <asp:BoundField ItemStyle-HorizontalAlign="Center" HeaderText="Administrador?" DataField="admin" SortExpression="admin"/>
            <asp:BoundField ItemStyle-HorizontalAlign="Center" HeaderText="Localidad" DataField="localidad" SortExpression="localidad"/>
            <asp:BoundField ItemStyle-HorizontalAlign="Center" HeaderText="Provincia" DataField="provincia" SortExpression="provincia"/>
            <asp:BoundField ItemStyle-HorizontalAlign="Center" HeaderText="Pais" DataField="pais" SortExpression="pais"/>
        </Columns>
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
    </asp:GridView>
    <asp:Button runat="server" Text="Añadir nuevo usuario" OnClick="CrearUsuario" /><br />
    Nombre de usuario:&nbsp&nbsp<asp:TextBox runat="server" ID="eliminar" placeholder="Nick_name"></asp:TextBox><br />
    <asp:Button runat="server" Text="Eliminar usuario" OnClick="EliminarUsuario" />
</asp:Content>
