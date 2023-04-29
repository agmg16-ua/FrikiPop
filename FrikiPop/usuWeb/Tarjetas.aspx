<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Tarjetas.aspx.cs" Inherits="usuWeb.Formulario_web11" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section id="modTarjeta">
        <section ID="modTarjetaLabels">
            <div>
                <asp:GridView ID="GridView" runat="server" AutoGenerateColumns="False" DataKeyNames="numTarjeta" CssClass="Gridview" DataSourceID="SqlDataSource1">
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" />
                        <asp:BoundField DataField="numTarjeta" HeaderText="Número Tarjeta" SortExpression="numTarjeta" ReadOnly="True" />
                        <asp:BoundField DataField="usuario" HeaderText="Usuario" SortExpression="usuario" />
                        <asp:BoundField DataField="cvv" HeaderText="CVV" SortExpression="cvv" />
                        <asp:BoundField DataField="mes_cad" HeaderText="Mes de caducidad" SortExpression="mes_cad" />
                        <asp:BoundField DataField="anyo_cad" HeaderText="Año de caducidad" SortExpression="anyo_cad" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Database" SelectCommand="SELECT * FROM [Tarjeta]"></asp:SqlDataSource>
            </div>
            <asp:Label runat="server" for="num" Text="Número de tarjeta: "></asp:Label>
            <asp:TextBox runat="server" id="num" name="num" placeholder="Número de tarjeta"/>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" Display="Dynamic" runat="server" ControlToValidate="num" ErrorMessage="Rellene este campo"></asp:RequiredFieldValidator>
            <br>
            <asp:Label runat="server" for="usuario" Text="Usuario: "></asp:Label>
            <asp:TextBox runat="server" id="usuario" name="usuario" placeholder="Usuario"/>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" Display="Dynamic" runat="server" ControlToValidate="usuario" ErrorMessage="Rellene este campo"></asp:RequiredFieldValidator>
            <br>
            <asp:Label runat="server" for="fechaMes" Text="Mes de caducidad: "></asp:Label>
            <asp:TextBox runat="server" id="fechaMes" name="fechaMes" placeholder="Mes de caducidad"/>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" Display="Dynamic" runat="server" ControlToValidate="fechaMes" ErrorMessage="Rellene este campo"></asp:RequiredFieldValidator>
            <br>
            <asp:Label runat="server" for="fechaAnyo" Text="Año de caducidad: "></asp:Label>
            <asp:TextBox runat="server" id="TextBox1" name="fechaAnyo" placeholder="Anyo de caducidad"/>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" Display="Dynamic" runat="server" ControlToValidate="fechaAnyo" ErrorMessage="Rellene este campo"></asp:RequiredFieldValidator>
            <br>
            <asp:Label runat="server" for="cvvTarj" Text="CVV: "></asp:Label>
            <asp:TextBox runat="server" id="cvvTarj" name="cvvTarj" placeholder="CVV"/>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" Display="Dynamic" runat="server" ControlToValidate="cvvTarj" ErrorMessage="Rellene este campo"></asp:RequiredFieldValidator>
            <br>
        </section>
        <section ID="botonesTarjeta">
            <asp:Button runat="server" ID="añadir" type="submit" Text="Añadir tarjeta" OnClick="añadir_Click"></asp:Button>
            <asp:Button runat="server" ID="borrar" type="submit" Text="Eliminar tajeta" OnClick="borrar_Click"></asp:Button>
            <asp:Button runat="server" Text="Volver" CausesValidation="false" OnClick="Volver_Click" />
        </section>
    </section>
</asp:Content>
