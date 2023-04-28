<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Paises.aspx.cs" Inherits="usuWeb.localidadProvinciaPais" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridViewPaises" runat="server"></asp:GridView>
    <asp:DropDownList ID="DropDownListPaises" runat="server"></asp:DropDownList><br />
    <asp:Button ID="ButtonModPais" runat="server" Text="Modificar" />
    <asp:Button ID="ButtonElPais" runat="server" Text="Eliminar" OnClick="ButtonElPais_Click" />
    <asp:LinkButton ID="LinkButtonLocalidad" runat="server" OnClick="LinkButtonLocalidad_Click">Ver Localidades</asp:LinkButton>
</asp:Content>

