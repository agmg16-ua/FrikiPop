<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Localidades.aspx.cs" Inherits="usuWeb.Localidades" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section id="modLocalidad">
            <div>
                <asp:GridView ID="GridView" runat="server" AutoGenerateColumns="False" DataKeyNames="localidad" CssClass="gridView" OnSelectedIndexChanged="GridView_SelectedIndexChanged">
                    <Columns>
                        <asp:BoundField DataField="localidad" HeaderText="Localidad" SortExpression="localidad" ReadOnly="True" />
                        <asp:BoundField DataField="provincia" HeaderText="Provincia" SortExpression="provincia" />
                        <asp:BoundField DataField="pais" HeaderText="Pais" SortExpression="pais" />
                    </Columns>
                </asp:GridView>
            </div>
            <asp:Label runat="server" for="localidad" Text="Localidad: "></asp:Label>
            <asp:TextBox runat="server" id="localidad_text" name="localidad" placeholder="Localidad"/>
            <%-- <asp:RequiredFieldValidator ID="RequiredFieldValidator1" Display="Dynamic" runat="server" ControlToValidate="localidad" ErrorMessage="Rellene este campo"></asp:RequiredFieldValidator> --%>
            <br>
            <asp:Label runat="server" for="provincia" Text="Provincia: : "></asp:Label>
            <asp:TextBox runat="server" id="provincia_text" name="provincia" placeholder="Provincia"/>
            <br>
            <asp:Label runat="server" for="pais" Text="Pais: "></asp:Label>
            <asp:TextBox runat="server" id="pais_text" name="pais" placeholder="Pais"/>
            <br>
        <section ID="botonesLocalidad">
            <asp:Button runat="server" ID="anyadir" type="submit" Text="Añadir localidad" OnClick="añadir_Click"></asp:Button>
            <asp:Button runat="server" ID="borrar" type="submit" Text="Eliminar localidad" OnClick="borrar_Click"></asp:Button>
            <asp:Button runat="server" Text="Ver Provincias" CausesValidation="false" OnClick="Provincias_Click" />
        </section>
    </section>
</asp:Content>
