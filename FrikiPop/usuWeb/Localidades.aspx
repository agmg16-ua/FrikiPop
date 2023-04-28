<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Localidades.aspx.cs" Inherits="usuWeb.Localidades" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    <asp:Button ID="ButtonModLocalidad" runat="server" Text="Modificar" />
    <asp:Button ID="ButtonElLocalidad" runat="server" Text="Eliminar" />
    <asp:LinkButton ID="LinkButtonProvincias" runat="server">Ver Provincias</asp:LinkButton>
</asp:Content>
