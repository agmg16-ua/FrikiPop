<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Usuario.aspx.cs" Inherits="usuWeb.Formulario_web11" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderUsuario" runat="server">
    <p>
        Nombre de usuario: <asp:TextBox runat="server" ID="Nick" Width="226px"></asp:TextBox>
    </p>
    <p>
        Contraseña: <asp:TextBox runat="server" ID="Contraseña" Width="298px"></asp:TextBox>
    </p>
    <asp:Button runat="server" Text="Log In"  ID="Login" OnClick="LogIn" Height="51px" Width="194px"/>
    <asp:Label runat ="server" ID = "LabelError"></asp:Label>
    <br />
    ¿No tiene una cuenta todavía?:
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/SignUp.aspx">Regístrate aquí</asp:HyperLink>

</asp:Content>
