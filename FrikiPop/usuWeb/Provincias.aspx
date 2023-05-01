<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Provincias.aspx.cs" Inherits="usuWeb.Formulario_web3" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section id="modLocalidad">
            <div>
                <asp:GridView ID="GridView" runat="server" AutoGenerateColumns="False" DataKeyNames="localidad, provincia, pais" CssClass="Gridview" OnSelectedIndexChanged="GridView_SelectedIndexChanged">
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" />
                        <asp:BoundField DataField="provincia" HeaderText="Provincia" SortExpression="provincia" ReadOnly="true" />
                        <asp:BoundField DataField="pais" HeaderText="Pais" SortExpression="pais" />
                    </Columns>
                </asp:GridView>
            </div>
            <asp:Label runat="server" for="provincia" Text="Provincia: : "></asp:Label>
            <asp:TextBox runat="server" id="provincia" name="provincia" placeholder="Provincia"/>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" Display="Dynamic" runat="server" ControlToValidate="provincia" ErrorMessage="Rellene este campo"></asp:RequiredFieldValidator>
            <br>
            <asp:Label runat="server" for="pais" Text="Pais: "></asp:Label>
            <asp:TextBox runat="server" id="pais" name="pais" placeholder="Pais"/>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" Display="Dynamic" runat="server" ControlToValidate="pais" ErrorMessage="Rellene este campo"></asp:RequiredFieldValidator>
            <br>
        <section ID="botonesLocalidad">
            <asp:Button runat="server" ID="anyadir" type="submit" Text="Añadir provincia" OnClick="añadir_Click"></asp:Button>
            <asp:Button runat="server" ID="borrar" type="submit" Text="Eliminar provincia" OnClick="borrar_Click"></asp:Button>
            <asp:Button runat="server" Text="Volver" CausesValidation="false" OnClick="Volver_Click" />
        </section>
    </section>
</asp:Content>
