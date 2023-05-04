<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Usuario.aspx.cs" Inherits="usuWeb.Formulario_web11" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <asp:SqlDataSource ID="Database1" runat="server"></asp:SqlDataSource>
        Nombre de usuario: <asp:TextBox  runat="server" ID="Nick" Width="226px" ></asp:TextBox>
    </p>
    <p>
        Contraseña: <asp:TextBox TextMode="Password" runat="server" ID="Contrasenya" Width="217px"></asp:TextBox>
    </p>
    <asp:Button runat="server" Text="Log In"  ID="Login" OnClick="LogIn" Height="31px" Width="170px"/>
    <asp:Label runat ="server" ID = "LabelError"></asp:Label>
    <br />
    ¿No tiene una cuenta todavía?:
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/SignUp.aspx">Regístrate aquí</asp:HyperLink>
</asp:Content>
