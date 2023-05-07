<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="usuWeb.Admin" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section id="admin">
        <div>
            <h1>
                Menu del Administrador
            </h1>
            <h2>
                "Un gran poder conlleva una gran responsabilidad"
            </h2>

            <section id="opcionesAdmin">
                <asp:Button runat="server" ID="usuariosAdmin" Text="Gestion de Usuarios" PostBackUrl="~/VerUsuarios.aspx"/>
                <asp:Button runat="server" ID="estadisticasAdmin" Text="Ver Estadisticas" />
                <asp:Button runat="server" ID="ubicacionesAdmin" Text="Gestion de Ubicaciones" PostBackUrl="~/Paises.aspx" />
                <asp:Button runat="server" ID="redesSocialesAdmin" Text="Gestion de Redes Sociales" PostBackUrl="~/redesSociales.aspx" />
                <asp:Button runat="server" ID="publicidadAdmin" Text="Gestion de Publicidad" PostBackUrl="~/Publicidad.aspx" />
            </section>
        </div>
    </section>
</asp:Content>
