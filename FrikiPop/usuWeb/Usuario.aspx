<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Usuario.aspx.cs" Inherits="usuWeb.Formulario_web11" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderUsuario" runat="server">
    <p>
        Nombre de usuario: <asp:TextBox runat="server" ID="Nick"></asp:TextBox>
    </p>
    <p>
        Contraseña: <asp:TextBox runat="server" ID="Contraseña"></asp:TextBox>
    </p>
    <asp:Button runat="server" Text="Log In"  ID="Login" OnClick="LogIn"/>
    <asp:Label runat ="server" ID = "LabelError"></asp:Label>
    <br />
    ¿No tiene una cuenta todavía?:
    <asp:Button runat="server" Text="Sign In"  ID="Signin" OnClick="SignIn"/>

</asp:Content>
