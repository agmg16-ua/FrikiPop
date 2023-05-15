<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Estadisticas.aspx.cs" Inherits="usuWeb.Formulario_web12" %>
<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="texto" >
        <h2 id="prod"> Top 10 productos </h2>   
        <h2 id="client"> Top 10 clientes</h2>
        <h2 class="Stats"> Estadísticas</h2>
    </div>
    <section id="content" >
        <article id="tablausuarios">
            <asp:GridView ID="topUsuarios" runat="server" AutoGenerateColumns="False" DataKeyNames="nick_name" >
                <Columns>
                    <asp:BoundField DataField="nick_name" HeaderText="Nickname" ReadOnly="True" SortExpression="nick_name" />
                    <asp:BoundField DataField="nombre" HeaderText="Nombre" SortExpression="nombre" />
                    <asp:BoundField DataField="apellidos" HeaderText="Apellidos" SortExpression="apellidos" />
                    <asp:BoundField DataField="numVentas" HeaderText="Ventas Realizadas" SortExpression="numVentas" />
                </Columns>
            </asp:GridView> 

            <asp:Chart ID="Grafica1" runat="server" Width="400px"   >
                <Series>
                    <asp:Series Name="Series1" XValueMember="nick_name" IsXValueIndexed="true"  YValueMembers="numVentas"></asp:Series>
                </Series>
                <Titles>
                    <asp:Title Text="Nº de ventas por usuario"></asp:Title>
                </Titles>
                <ChartAreas>
                    <asp:ChartArea  Name="ChartArea1"> <AxisX IntervalAutoMode="VariableCount"></AxisX></asp:ChartArea>
                </ChartAreas>
            </asp:Chart>

            </article>
        <article id="tablatipoarticulos">
            <asp:GridView ID="topTipoArticulos" runat="server" AutoGenerateColumns="False" DataKeyNames="tipo">
                <Columns>
                    <asp:BoundField DataField="tipo" HeaderText="Tipo" ReadOnly="True" SortExpression="tipo" />
                    <asp:BoundField DataField="numVentas" HeaderText="Ventas realizadas" SortExpression="numVentas" />
                </Columns>
            </asp:GridView>
               <asp:Chart ID="Grafica2" runat="server" Width="400px"   >
                <Series>
                    <asp:Series Name="Series1" XValueMember="tipo" IsXValueIndexed="true"  YValueMembers="numVentas"></asp:Series>
                </Series>
                <Titles>
                    <asp:Title Text="Nº de ventas de articulos por tipos"></asp:Title>
                </Titles>
                <ChartAreas>
                    <asp:ChartArea  Name="ChartArea1"> <AxisX IntervalAutoMode="VariableCount"></AxisX></asp:ChartArea>
                </ChartAreas>
            </asp:Chart>

            </article>
    </section>
</asp:Content>
