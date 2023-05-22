﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Estadisticas.aspx.cs" Inherits="usuWeb.Formulario_web12" %>
<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="texto1" >
        <h2 class="Stats"> Estadísticas</h2>
    </div>
    <div class="texto2" >
        <h3 class="Stats"> TOP USUARIOS CON MAS VENTAS</h3>
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
             <br><!--salto de linea-->
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
         <br>
         <div class="texto3" >
         <h3 class="Stats">NUMERO DE ARTICULOS VENDIDOS DE CADA TIPO</h3>
         </div>
         <br>
        <article id="tablatipoarticulos">
            <asp:GridView ID="topTipoArticulos" runat="server" AutoGenerateColumns="False" DataKeyNames="tipo">
                <Columns>
                    <asp:BoundField DataField="tipo" HeaderText="Tipo" ReadOnly="True" SortExpression="tipo" />
                    <asp:BoundField DataField="numVentas" HeaderText="Ventas realizadas" SortExpression="numVentas" />
                </Columns>
            </asp:GridView>
             <br>
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
             <br>
            </article>
    </section>
</asp:Content>
