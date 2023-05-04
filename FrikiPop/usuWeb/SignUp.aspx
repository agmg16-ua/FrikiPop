<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="usuWeb.Formulario_web2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
            <p>
                Subir imagen:&nbsp;&nbsp;&nbsp;&nbsp;  
                <asp:FileUpload ID="FileUpload1" runat="server" Width="437px" />
            </p>
            <p>
                Nick_name:&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox runat="server" ID="Nick1" Width="216px"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Nick1" ErrorMessage="Tiene que introducir un nombre de usuario obligatoriamente"></asp:RequiredFieldValidator>
            </p>
            <p>
                Nombre:&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox runat="server" ID="Nombre1" Width="246px"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Nombre1" ErrorMessage="Tiene que introducir su nombre obligatoriamente"></asp:RequiredFieldValidator>

            </p>
            <p>
                Apellidos:&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox runat="server" ID="Apellidos1" Width="230px"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Apellidos1" ErrorMessage="Tiene que introducir sus apellidos obligatoriamente"></asp:RequiredFieldValidator>
            </p>
            <p>
                Edad:&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox runat="server" ID="Edad1" Width="268px"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Edad1" ErrorMessage="Tiene que introducir su edad obligatoriamente"></asp:RequiredFieldValidator>
            </p>
            <p>
                Pais:&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox runat="server" ID="Pais1" Width="277px"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Pais1" ErrorMessage="Tiene que introducir su pais de nacimiento obligatoriamente"></asp:RequiredFieldValidator>
            </p>
            <p>
                Provincia:&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox runat="server" ID="Provincia1" Width="222px"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Provincia1" ErrorMessage="Tiene que introducir su provincia de nacimiento obligatoriamente"></asp:RequiredFieldValidator>
            </p>
            <p>
                Localidad:&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox runat="server" ID="Localidad1" Width="218px"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Localidad1" ErrorMessage="Tiene que introducir su localidad de nacimiento obligatoriamente"></asp:RequiredFieldValidator>
            </p>
            <p>
                Contrasenya:&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox TextMode="Password" runat="server" ID="Contrasenya1" Width="192px"></asp:TextBox>
                <asp:RegularExpressionValidator runat="server" ControlToValidate="contrasenya1"></asp:RegularExpressionValidator>
                <asp:RequiredFieldValidator  runat="server" ControlToValidate="Contrasenya1" ErrorMessage="Tiene que introducir una contraseña obligatoriamente"></asp:RequiredFieldValidator>
            </p>

            <asp:Button runat="server" Text="Sign Up"  ID="Crear" OnClick="createUsuario" Height="31px" Width="188px"/>
            <asp:Label runat ="server" ID = "LabelError"></asp:Label>
        </div>
</asp:Content>
