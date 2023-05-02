<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Publicidad.aspx.cs" Inherits="usuWeb.Formulario_web12" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section id="modPublicidad">
            <div>
                <asp:GridView ID="GridView" runat="server" AutoGenerateColumns="False" DataKeyNames="id_publi" CssClass="Gridview">
                    <Columns>
                        <asp:BoundField DataField="id_publi" HeaderText="ID publicidad" SortExpression="id_publi" ReadOnly="True" />
                        <asp:BoundField DataField="id_empresa" HeaderText="ID Empresa" SortExpression="id_empresa" />
                        <asp:BoundField DataField="url_imagen" HeaderText="Imagen" SortExpression="url_imagen" />
                        <asp:BoundField DataField="link_empresa" HeaderText="Link Empresa" SortExpression="link_empresa" />
                    </Columns>
                </asp:GridView>
            </div>
            <asp:Label runat="server" for="id_p" Text="ID Publicidad: "></asp:Label>
            <asp:TextBox runat="server" id="id_p" name="id_p" placeholder="ID Publicidad"/>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="id_p" ErrorMessage="Rellene este campo"></asp:RequiredFieldValidator>
            <br>
            <asp:Label runat="server" for="id_e" Text="ID Empresa: "></asp:Label>
            <asp:TextBox runat="server" id="id_e" name="id_e" placeholder="ID Empresa"/>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="id_e" ErrorMessage="Rellene este campo"></asp:RequiredFieldValidator>
            <br>
            <asp:Label runat="server" for="link_e" Text="Link Empresa: " />
            <asp:TextBox runat="server" id="link_e" name="link_e" placeholder="Link Empresa"/>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="link_e" ErrorMessage="Rellene este campo"></asp:RequiredFieldValidator>
            <br>
            <asp:Label runat="server" for="imagen" Text="Imagen: " />
            <asp:TextBox runat="server" id="imagen" name="imagen" placeholder="Imagen"/>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="imagen" ErrorMessage="Rellene este campo"></asp:RequiredFieldValidator>
            <br>
        <section ID="botonesPublicidad">
            <asp:Button runat="server" ID="anyadir" type="submit" Text="Añadir Publicidad" OnClick="anyadir_Click" />
            <asp:Button runat="server" ID="borrar" type="submit" Text="Eliminar Publicidad" OnClick="borrar_Click" />
            <asp:Button runat="server" Text="Volver" CausesValidation="false" OnClick="Volver_Click" />
        </section>
    </section>
</asp:Content>
