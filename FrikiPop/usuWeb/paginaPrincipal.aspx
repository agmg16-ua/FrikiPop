<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="paginaPrincipal.aspx.cs" Inherits="usuWeb.Formulario_web1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Paises.aspx">Gestionar Ubicaciones</asp:HyperLink>
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Tarjetas.aspx">Gestionar Tarjetas</asp:HyperLink>
        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Publicidad.aspx">Gestionar Publicidad</asp:HyperLink>
</asp:Content>
