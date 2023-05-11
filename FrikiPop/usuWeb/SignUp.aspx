<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="usuWeb.Formulario_web2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="..\App_Style\usuarioStyle.css" />
    <div id="seccionUsuario">
            <h1 style="margin-left:75px">Nueva cuenta</h1>
            <p>
                Subir imagen:&nbsp;&nbsp;  
                <asp:FileUpload ID="FileUpload1" runat="server" Width="437px" />
            </p>
            <p>
                <asp:TextBox placeholder="Nombre de usuario" class ="cuadroDeTexto" runat="server" ID="Nick1"></asp:TextBox>
                <asp:RequiredFieldValidator CssClass="validator" runat="server" ControlToValidate="Nick1" ErrorMessage="Falta introducir un nombre de usuario"></asp:RequiredFieldValidator>
            </p>
            <p>
                <asp:TextBox placeholder="Nombre" class ="cuadroDeTexto"  runat="server" ID="Nombre1"></asp:TextBox>
                <asp:RequiredFieldValidator CssClass="validator" runat="server" ControlToValidate="Nombre1" ErrorMessage="Falta introducir su nombre"></asp:RequiredFieldValidator>

            </p>
            <p>
                <asp:TextBox placeholder="Apellidos" class ="cuadroDeTexto" runat="server" ID="Apellidos1"></asp:TextBox>
                <asp:RequiredFieldValidator CssClass="validator" runat="server" ControlToValidate="Apellidos1" ErrorMessage="Falta introducir sus apellidos"></asp:RequiredFieldValidator>
            </p>
            <p>
                <asp:TextBox placeholder="Edad" class ="cuadroDeTexto" runat="server" ID="Edad1"></asp:TextBox>
                <asp:RequiredFieldValidator CssClass="validator" runat="server" ControlToValidate="Edad1" ErrorMessage="Falta introducir su edad"></asp:RequiredFieldValidator>
            </p>
            <p>
                <asp:DropDownList ID="Paises" runat="server" CssClass="listas" DataSourceID="Database1" DataTextField="pais" DataValueField="pais">
                    <asp:ListItem Text="Seleccione un pais"></asp:ListItem>
                </asp:DropDownList>
                <asp:SqlDataSource ID="Database1" runat="server" ConnectionString="<%$ ConnectionStrings:Database %>" SelectCommand="SELECT [pais] FROM [Pais]"></asp:SqlDataSource>
            </p>
            <p>
                <asp:DropDownList ID="Provincias" runat="server" CssClass="listas" DataSourceID="SqlDatabase" DataTextField="provincia" DataValueField="provincia" OnSelectedIndexChanged="Provincias_SelectedIndexChanged">
                    <asp:ListItem Text="Seleccione una provincia"></asp:ListItem>
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDatabase" runat="server" ConnectionString="<%$ ConnectionStrings:Database %>" SelectCommand="SELECT [provincia] FROM [Provincia]"></asp:SqlDataSource>
                <asp:Label CssClass="labelsDeError" runat ="server" ID = "LabelErrorProvincia"></asp:Label>
            </p>
            <p>
                <asp:DropDownList ID="Localidades" runat="server" CssClass="listas" DataSourceID="SqlDataSource1" DataTextField="localidad" DataValueField="localidad" OnSelectedIndexChanged="Localidades_SelectedIndexChanged">
                    <asp:ListItem Text="Seleccione una localidad"></asp:ListItem>
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Database %>" SelectCommand="SELECT [localidad] FROM [Localidad]"></asp:SqlDataSource>
                <asp:Label CssClass="labelsDeError" runat ="server" ID = "LabelErrorLocalidad"></asp:Label>
            </p>
            <p>
                <asp:TextBox placeholder="Contraseña" class ="cuadroDeTexto" TextMode="Password" runat="server" ID="Contrasenya1"></asp:TextBox>
                <asp:RequiredFieldValidator CssClass="validator" runat="server" ControlToValidate="Contrasenya1" ErrorMessage="Falta introducir una contraseña"></asp:RequiredFieldValidator>
            </p>

            <asp:Button CssClass="boton" runat="server" Text="Sign Up"  ID="Crear" OnClick="createUsuario"/>
            <asp:Label CssClass="labelsDeError" runat ="server" ID = "LabelError"></asp:Label>
        </div>
</asp:Content>
