<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Publicidad.aspx.cs" Inherits="usuWeb.Formulario_web12" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section id="modPublicidad">
            <div>
                <asp:GridView ID="GridView" runat="server" AutoGenerateColumns="False" DataKeyNames="id_publi" CssClass="Gridview" OnSelectedIndexChanged="GridView_SelectedIndexChanged" DataSourceID="SqlDataSource1">
                    <Columns>
                        <asp:BoundField DataField="id_publi" HeaderText="id_publi" SortExpression="id_publi" ReadOnly="True" />
                        <asp:BoundField DataField="id_empresa" HeaderText="id_empresa" SortExpression="id_empresa" />
                        <asp:BoundField DataField="url_imagen" HeaderText="url_imagen" SortExpression="url_imagen" />
                        <asp:BoundField DataField="link_empresa" HeaderText="link_empresa" SortExpression="link_empresa" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Publicidad]"></asp:SqlDataSource>
            </div>
            <asp:Label runat="server" for="id_p" Text="ID Publicidad: "></asp:Label>
            <asp:TextBox runat="server" id="id_p" name="id_p" placeholder="ID Publicidad"/>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" Display="Dynamic" runat="server" ControlToValidate="id_p" ErrorMessage="Rellene este campo"></asp:RequiredFieldValidator>
            <br>
            <asp:Label runat="server" for="id_e" Text="ID Empresa: "></asp:Label>
            <asp:TextBox runat="server" id="id_e" name="id_e" placeholder="ID Empresa"/>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" Display="Dynamic" runat="server" ControlToValidate="id_e" ErrorMessage="Rellene este campo"></asp:RequiredFieldValidator>
            <br>
            <asp:Label runat="server" for="link_e" Text="Link Empresa: "></asp:Label>
            <asp:TextBox runat="server" id="link_e" name="link_e" placeholder="Link Empresa"/>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" Display="Dynamic" runat="server" ControlToValidate="link_e" ErrorMessage="Rellene este campo"></asp:RequiredFieldValidator>
            <br>
            <asp:Label runat="server" for="imagen" Text="Imagen: "></asp:Label>
            <asp:TextBox runat="server" id="imagen" name="imagen" placeholder="Imagen"/>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" Display="Dynamic" runat="server" ControlToValidate="imagen" ErrorMessage="Rellene este campo"></asp:RequiredFieldValidator>
            <br>
        <section ID="botonesPublicidad">
            <asp:Button runat="server" ID="añadir" type="submit" Text="Añadir Publicidad" OnClick="añadir_Click"></asp:Button>
            <asp:Button runat="server" ID="borrar" type="submit" Text="Eliminar Publicidad" OnClick="borrar_Click"></asp:Button>
            <asp:Button runat="server" Text="Volver" CausesValidation="false" OnClick="Volver_Click" />
        </section>
    </section>
</asp:Content>
