<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Tarjetas.aspx.cs" Inherits="usuWeb.Tarjeta" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section id="modTarjeta">
            <div>
                <asp:GridView ID="GridView" runat="server" AutoGenerateColumns="False" DataKeyNames="numTarjeta" CssClass="Gridview">
                    <Columns>
                        <asp:BoundField DataField="numTarjeta" HeaderText="Número Tarjeta" SortExpression="numTarjeta" ReadOnly="True" />
                        <asp:BoundField DataField="usuario" HeaderText="Usuario" SortExpression="usuario" />
                        <asp:BoundField DataField="cvv" HeaderText="CVV" SortExpression="cvv" />
                        <asp:BoundField DataField="mes_cad" HeaderText="Mes de caducidad" SortExpression="mes_cad" />
                        <asp:BoundField DataField="anyo_cad" HeaderText="Año de caducidad" SortExpression="anyo_cad" />
                    </Columns>
                </asp:GridView>
            </div>
            <asp:Label runat="server" for="num" Text="Número de tarjeta: "></asp:Label>
            <asp:TextBox runat="server" id="num" name="num" placeholder="Número de tarjeta"/>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorNumTarj"  runat="server" ControlToValidate="num" ErrorMessage="Rellene este campo"></asp:RequiredFieldValidator>
            <br>
            <asp:Label runat="server" for="usuario" Text="Usuario: "></asp:Label>
            <asp:TextBox runat="server" id="usuario" name="usuario" placeholder="Usuario"/>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorUsuario" runat="server" ControlToValidate="usuario" ErrorMessage="Rellene este campo"></asp:RequiredFieldValidator>
            <br>
            <asp:Label runat="server" for="fechaMes" Text="Mes de caducidad: "></asp:Label>
            <asp:TextBox runat="server" id="fechaMes" name="fechaMes" placeholder="Mes de caducidad"/>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorFechaMes" runat="server" ControlToValidate="fechaMes" ErrorMessage="Rellene este campo"></asp:RequiredFieldValidator>
            <br>
            <asp:Label runat="server" for="fechaAnyo" Text="Año de caducidad: "></asp:Label>
            <asp:TextBox runat="server" id="fechaAnyo" name="fechaAnyo" placeholder="Anyo de caducidad"/>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorFechaAnyo" runat="server" ControlToValidate="fechaAnyo" ErrorMessage="Rellene este campo"></asp:RequiredFieldValidator>
            <br>
            <asp:Label runat="server" for="cvvTarj" Text="CVV: "></asp:Label>
            <asp:TextBox runat="server" id="cvvTarj" name="cvvTarj" placeholder="CVV"/>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorCVV" runat="server" ControlToValidate="cvvTarj" ErrorMessage="Rellene este campo"></asp:RequiredFieldValidator>
            <br>
        <section ID="botonesTarjeta">
            <asp:Button runat="server" ID="anyadir" type="submit" Text="Añadir tarjeta" OnClick="anyadir_Click"></asp:Button>
            <asp:Button runat="server" ID="borrar" type="submit" Text="Eliminar tajeta" OnClick="borrar_Click"></asp:Button>
            <asp:Button runat="server" ID="actualizar" type="submit" Text="Actualizar tajeta" OnClick="actualizar_Click"></asp:Button>
        </section>
    </section>
</asp:Content>
