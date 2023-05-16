<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="VerPedido.aspx.cs" Inherits="usuWeb.VerPedido" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section id="Pedidos">
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="num_pedido" GridLines="None" CssClass="Gridview2" OnSelectedIndexChanged="GridView2_SelectedIndexChanged">
            <Columns>
                <asp:TemplateField ItemStyle-HorizontalAlign="center" ItemStyle-VerticalAlign="Middle"></asp:TemplateField>
                <asp:BoundField DataField="num_pedido" HeaderText="numPedido" ReadOnly="True" SortExpression="num_pedido" />
                <asp:BoundField DataField="calle" HeaderText="Calle" SortExpression="calle" />
                <asp:BoundField DataField="fecha" HeaderText="Fecha" SortExpression="fecha" />
                <asp:TemplateField HeaderText="Pedido"><ItemTemplate><asp:Button runat="server" Text="Pedido" PostBackUrl='<%#"~/Pedido.aspx?idPedido="+ Eval("num_pedido")%>'/></ItemTemplate></asp:TemplateField>
            </Columns>
        </asp:GridView>
        <section ID="botonesPedidos">
            <asp:Button runat="server" Text="Volver" CausesValidation="false" OnClick="volverClick" />
        </section>
    </section>
</asp:Content>