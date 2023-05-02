<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Paises.aspx.cs" Inherits="usuWeb.Paises" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section id="modPais">
            <div>
                Seleccione el Pais que desea modificar: <br />
                <asp:GridView ID="GridView" runat="server" AutoGenerateColumns="False" DataKeyNames="pais" OnSelectedIndexChanged="GridView_SelectedIndexChanged" >
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" />
                        <asp:BoundField DataField="pais" HeaderText="Pais" SortExpression="pais" ReadOnly="true" />
                    </Columns>
                </asp:GridView>
            </div>
            
            <br />Si quiere añadir o eliminar un pais, escribalo a continuación: <br />
            <asp:Label runat="server" for="pais" Text="Pais: "></asp:Label>
            <asp:TextBox runat="server" id="pais" name="pais" placeholder="Pais"/>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" Display="Dynamic" runat="server" ControlToValidate="pais" ErrorMessage="Rellene este campo"></asp:RequiredFieldValidator>
            <br>
        <section ID="botonesPaises">
            <asp:Button runat="server" ID="anyadir" type="submit" Text="Añadir pais" OnClick="añadir_Click"></asp:Button>
            <asp:Button runat="server" ID="borrar" type="submit" Text="Eliminar pais" OnClick="borrar_Click"></asp:Button>
            <asp:Button runat="server" Text="Volver" CausesValidation="false" OnClick="Volver_Click" />
        </section>
    </section>
</asp:Content>
