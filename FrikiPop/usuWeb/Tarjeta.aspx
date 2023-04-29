<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Tarjeta.aspx.cs" Inherits="usuWeb.Formulario_web11" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section id="modTarj">
        <section ID="modTarjLabels">
            <div>
                <asp:GridView ID="GridView" runat="server" AutoGenerateColumns="False" DataKeyNames="numero" GridLines="None" CssClass="Gridview">
                    <Columns>
                        <asp:TemplateField ItemStyle-HorizontalAlign="center"></asp:TemplateField>
                        <asp:BoundField DataField="usuario" HeaderText="Usuario" SortExpression="usuario" />
                        <asp:BoundField DataField="numero" HeaderText="Numero" ReadOnly="True" SortExpression="numero" />
                        <asp:BoundField DataField="mes_cad" HeaderText="Mes Caducidad" SortExpression="mes_cad" />
                        <asp:BoundField DataField="anyo_cad" HeaderText="Año Caducidad" SortExpression="anyo_cad" />
                        <asp:BoundField DataField="cvv" HeaderText="CVV" SortExpression="cvv" />
                    </Columns>
                </asp:GridView>
            </div>
            <asp:Label runat="server" for="num" Text="Número de tarjeta: "></asp:Label>
            <asp:TextBox runat="server" id="num" name="numTarj" placeholder="Número de tarjeta"/>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" Display="Dynamic" runat="server" ControlToValidate="num" Text="Rellene este campo" ErrorMessage="Rellene este campo"></asp:RequiredFieldValidator>
            <br>
            <asp:Label runat="server" for="nameTarj" Text="Nombre del titular: "></asp:Label>
            <asp:TextBox runat="server" id="nameTarj" name="nameTarj" placeholder="Nombre del titular"/>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" Display="Dynamic" runat="server" ControlToValidate="nameTarj" Text="Rellene este campo" ErrorMessage="Rellene este campo"></asp:RequiredFieldValidator>
            <br>
            <asp:Label runat="server" for="fechaTarj" Text="Fecha de caducidad: "></asp:Label>
            <asp:TextBox runat="server" id="fechaTarj" name="fechaTarj" placeholder="Fecha de caducidad"/>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" Display="Dynamic" runat="server" ControlToValidate="fechaTarj" Text="Rellene este campo" ErrorMessage="Rellene este campo"></asp:RequiredFieldValidator>
            <br>
            <asp:Label runat="server" for="cvvTarj" Text="CVV: "></asp:Label>
            <asp:TextBox runat="server" id="cvvTarj" name="cvvTarj" placeholder="CVV"/>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" Display="Dynamic" runat="server" ControlToValidate="cvvTarj" Text="Rellene este campo" ErrorMessage="Rellene este campo"></asp:RequiredFieldValidator>
            <br>
        </section>
        <section ID="botonesTarj">
            <asp:Button runat="server" ID="asociar" type="submit" Text="Asociar tarjeta" OnClick="asociar_Click"></asp:Button>
            <asp:Button runat="server" ID="borrar" type="submit" Text="Eliminar tajeta" OnClick="borrar_Click"></asp:Button>
            <asp:Button runat="server" Text="Volver" CausesValidation="false" OnClick="Volver_Click" />
        </section>
    </section>
</asp:Content>
