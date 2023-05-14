<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Usuario.aspx.cs" Inherits="usuWeb.Formulario_web11" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="..\App_Style\usuarioStyle.css" />
    <div class="SeccionUsuario">
        <h1 style="margin-left:50px; margin-top:200px">Inicio de sesión</h1>
        <p>
            <asp:TextBox class ="cuadroDeTexto" placeholder="Nombre de usuario" runat="server" ID="Nick" ></asp:TextBox>
            <asp:RequiredFieldValidator CssClass="validator" runat="server" ControlToValidate="Nick" ErrorMessage="Falta el nombre de usuario"></asp:RequiredFieldValidator>
        </p>
        <p>
            <asp:TextBox class ="cuadroDeTexto" placeholder="Contraseña" TextMode="Password" runat="server" ID="Contrasenya"></asp:TextBox>
            <asp:RequiredFieldValidator CssClass="validator" runat="server" ControlToValidate="Contrasenya" ErrorMessage="Falta la contraseña"></asp:RequiredFieldValidator>
        </p>
        <asp:Button class="boton"  id="Login" runat="server" Text="Log In" OnClick="LogIn"/>
        <asp:Label runat ="server" ID = "LabelError"></asp:Label>
        <br /><br />
        ¿No tiene una cuenta todavía?
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/SignUp.aspx">Regístrate aquí</asp:HyperLink>
    </div>
</asp:Content>
