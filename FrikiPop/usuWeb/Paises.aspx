<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Paises.aspx.cs" Inherits="usuWeb.Paises" %>

<asp:Content runat="server" ID="Content1" ContentPlaceHolderID="head" >
    <link rel="stylesheet" href="..\App_Style\ubicacionesStyle.css" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section id="modPais">
            <div>
                Seleccione el Pais que desea ver las Provincias: <br />
                <asp:GridView ID="GridView" runat="server" AutoGenerateColumns="False" DataKeyNames="pais" CssClass="gridView" OnSelectedIndexChanged="GridView_SelectedIndexChanged" >
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" ControlStyle-CssClass="selectButton" />
                        <asp:BoundField DataField="pais" HeaderText="Pais" SortExpression="pais" ReadOnly="true" />
                    </Columns>
                </asp:GridView>
            </div>
            
       <section id="textoPaises">
            <br />Si quiere añadir o eliminar un pais, escribalo a continuación: <br />
            <asp:TextBox runat="server" id="pais_text" CssClass="cuadroDeTexto" name="pais" placeholder="Pais"/>
            <br>
       </section>

        <section ID="botonesPaises" >
            <asp:Button runat="server" ID="anyadir" CssClass="boton" type="submit" Text="Añadir pais" OnClick="añadir_Click"></asp:Button>
            <asp:Button runat="server" ID="borrar" CssClass="boton" type="submit" Text="Eliminar pais" OnClick="borrar_Click"></asp:Button>
        </section>
    </section>
</asp:Content>
