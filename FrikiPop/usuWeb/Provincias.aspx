<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Provincias.aspx.cs" Inherits="usuWeb.Provincias" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridViewProvincia" runat="server"></asp:GridView>
    <asp:Button ID="ButtonModProvincia" runat="server" Text="Modificar" />
    <asp:Button ID="ButtonElProvincia" runat="server" Text="Eliminar" />
</asp:Content>
