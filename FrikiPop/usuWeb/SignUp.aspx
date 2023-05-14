<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="usuWeb.Formulario_web2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="..\App_Style\usuarioStyle.css" />
    <h1>Nueva cuenta</h1>
    <section id="fotoPerfil">
        Subir imagen:&nbsp;&nbsp;
        <asp:FileUpload ID="FileUpload1" runat="server" />
    </section>
    <section id="cuadrosTextoUsuario">
        <asp:TextBox placeholder="Nombre de usuario" class ="cuadroDeTexto" runat="server" ID="Nick1"></asp:TextBox>
        <asp:RequiredFieldValidator CssClass="validator" runat="server" ControlToValidate="Nick1" ErrorMessage="Falta introducir un nombre de usuario"></asp:RequiredFieldValidator>
        <asp:TextBox placeholder="Nombre" class ="cuadroDeTexto"  runat="server" ID="Nombre1"></asp:TextBox>
        <asp:RequiredFieldValidator CssClass="validator" runat="server" ControlToValidate="Nombre1" ErrorMessage="Falta introducir su nombre"></asp:RequiredFieldValidator>
        <asp:TextBox placeholder="Apellidos" class ="cuadroDeTexto" runat="server" ID="Apellidos1"></asp:TextBox>
        <asp:RequiredFieldValidator CssClass="validator" runat="server" ControlToValidate="Apellidos1" ErrorMessage="Falta introducir sus apellidos"></asp:RequiredFieldValidator>
        <asp:TextBox placeholder="Edad" class ="cuadroDeTexto" runat="server" ID="Edad1"></asp:TextBox>
        <asp:RequiredFieldValidator CssClass="validator" runat="server" ControlToValidate="Edad1" ErrorMessage="Falta introducir su edad"></asp:RequiredFieldValidator>
        <asp:TextBox placeholder="Pais" class ="cuadroDeTexto" runat="server" ID="Pais1"></asp:TextBox>
        <asp:RequiredFieldValidator CssClass="validator" runat="server" ControlToValidate="Pais1" ErrorMessage="Falta introducir su pais de nacimiento"></asp:RequiredFieldValidator>
        <asp:TextBox placeholder="Provincia" class ="cuadroDeTexto" runat="server" ID="Provincia1"></asp:TextBox>
        <asp:RequiredFieldValidator CssClass="validator" runat="server" ControlToValidate="Provincia1" ErrorMessage="Falta introducir su provincia de nacimiento"></asp:RequiredFieldValidator>
        <asp:TextBox placeholder="Localidad" class ="cuadroDeTexto" runat="server" ID="Localidad1"></asp:TextBox>
        <asp:RequiredFieldValidator CssClass="validator" runat="server" ControlToValidate="Localidad1" ErrorMessage="Falta introducir su localidad de nacimiento"></asp:RequiredFieldValidator>
        <asp:TextBox placeholder="Contraseña" class ="cuadroDeTexto" TextMode="Password" runat="server" ID="Contrasenya1"></asp:TextBox>
        <asp:RequiredFieldValidator CssClass="validator" runat="server" ControlToValidate="Contrasenya1" ErrorMessage="Falta introducir una contraseña"></asp:RequiredFieldValidator>
    </section>
    <section id="botonesUsuario">
        <asp:Button CssClass="boton" runat="server" Text="Sign Up"  ID="Crear" OnClick="createUsuario"/>
        <asp:Label runat ="server" ID = "LabelError"></asp:Label>
    </section>
</asp:Content>
