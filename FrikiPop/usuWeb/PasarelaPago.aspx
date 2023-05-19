<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="PasarelaPago.aspx.cs" Inherits="usuWeb.PasarelaPago" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:GridView ID="GridView" runat="server" GridLines="None" AutoGenerateColumns="False" DataKeyNames="numTarjeta" CssClass="Gridview" OnSelectedIndexChanged="GridView_SelectedIndexChanged">
            <Columns>
                <asp:CommandField ShowSelectButton="True" ControlStyle-CssClass="selectButton" HeaderText="Seleccionar Tarjeta" />
                <asp:BoundField DataField="numTarjeta" HeaderText="Número Tarjeta" SortExpression="numTarjeta" ReadOnly="True" />
                <asp:BoundField DataField="mes_cad" HeaderText="Mes de caducidad" SortExpression="mes_cad" />
                <asp:BoundField DataField="anyo_cad" HeaderText="Año de caducidad" SortExpression="anyo_cad" />
            </Columns>
        </asp:GridView>
   </div>
     <asp:Label runat="server" for="num" Text="Número de tarjeta: "></asp:Label>
     <asp:TextBox runat="server" id="num" name="num" placeholder="Número de tarjeta"/>
     <asp:RequiredFieldValidator ID="RequiredFieldValidatorNumTarj"  runat="server" ControlToValidate="num" ErrorMessage="Rellene este campo"></asp:RequiredFieldValidator>
           
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
    <asp:TextBox runat="server" id="cvvTarj" name="cvvTarj" placeholder="CVV" />
    <asp:RequiredFieldValidator ID="RequiredFieldValidatorCVV" runat="server" ControlToValidate="cvvTarj" ErrorMessage="Rellene este campo"></asp:RequiredFieldValidator>
     
    <br>

    <asp:Label ID="Message" runat="server"></asp:Label>

     <section ID="botonesTarjeta">
            <asp:Button runat="server" ID="anyadir" type="submit" Text="Añadir tarjeta" OnClick="anyadir_Click"></asp:Button>
            <asp:Button runat="server" ID="borrar" type="submit" Text="Eliminar tajeta" OnClick="borrar_Click"></asp:Button>
            <asp:Button runat="server" ID="pagar" type="submit" Text="Pagar" OnClick="pagar_Click"></asp:Button>
     </section>
</asp:Content>
