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
                        <asp:ImageField DataImageUrlField="url_imagen" HeaderText="Url imagen" SortExpression="url_imagen" />
                        <asp:BoundField DataField="link_red" HeaderText="Link red" SortExpression="link_red" />
                    </Columns>
                </asp:GridView>
            </div>
            <asp:Label runat="server" for="red" Text="Red: "></asp:Label>
            <asp:TextBox runat="server" id="red" name="red" placeholder="Red"/>
            <br>
            <asp:Label runat="server" for="url_imagen" Text="Url imagen: : "></asp:Label>
            <asp:TextBox runat="server" id="url_imagen" name="url_imagen" placeholder="Url imagen"/>
            <br>
            <asp:Label runat="server" for="link_red" Text="Link red: "></asp:Label>
            <asp:TextBox runat="server" id="link_red" name="link_red" placeholder="Link red"/>
            <br>
            <section ID="botonesRedesSociales">
                <asp:Button runat="server" ID="anyadir" type="submit" Text="Añadir red" OnClick="añadir_Click"></asp:Button>
                <asp:Button runat="server" ID="borrar" type="submit" Text="Eliminar red" OnClick="borrar_Click"></asp:Button>
                <asp:Button runat="server" Text="Volver" CausesValidation="false" OnClick="Volver_Click" />
            </section>
    </section>
</asp:Content>
