<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="redesSociales.aspx.cs" Inherits="usuWeb.redesSociales" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section id="modRedesSociales">
            <div>
                <asp:GridView ID="GridView" runat="server" AutoGenerateColumns="False" DataKeyNames="codigo,nombre,descripcion,precio,url_imagen,usuario,tipo" CssClass="Gridview" OnSelectedIndexChanged="GridView_SelectedIndexChanged">
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" />
                        <asp:BoundField DataField="red" HeaderText="Red" SortExpression="red" />
                        <asp:ImageField DataImageUrlField="url_imagen" HeaderText="Url_imagen" SortExpression="url_imagen" />
                        <asp:BoundField DataField="link_red" HeaderText="Link_red" SortExpression="link_red" />
                    </Columns>
                </asp:GridView>
            </div>
    </section>
</asp:Content>
