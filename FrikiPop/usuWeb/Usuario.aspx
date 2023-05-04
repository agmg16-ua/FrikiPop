<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Usuario.aspx.cs" Inherits="usuWeb.Formulario_web11" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView AutoGenerateColumns="False" DataKeyNames="nick_name" ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
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
    <p>
        <asp:SqlDataSource ID="Database1" runat="server"></asp:SqlDataSource>
        Nombre de usuario: <asp:TextBox runat="server" ID="Nick" Width="226px"></asp:TextBox>
    </p>
    <p>
        Contraseña: <asp:TextBox runat="server" ID="Contrasenya" Width="217px"></asp:TextBox>
    </p>
    <asp:Button runat="server" Text="Log In"  ID="Login" OnClick="LogIn" Height="31px" Width="170px"/>
    <asp:Label runat ="server" ID = "LabelError"></asp:Label>
    <br />
    ¿No tiene una cuenta todavía?:
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/SignUp.aspx">Regístrate aquí</asp:HyperLink>
</asp:Content>
