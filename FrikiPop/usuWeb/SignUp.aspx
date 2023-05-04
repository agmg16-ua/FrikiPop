<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="usuWeb.Formulario_web2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>FrikiPop</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:CommandField ShowEditButton="True"/>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:CommandField ShowDeleteButton="True" />
                    <asp:BoundField HeaderText="Nick_name" DataField="nick_name" SortExpression="nick_name"/>
                    <asp:BoundField HeaderText="Nombre" DataField="nombre" SortExpression="nombre"/>
                    <asp:BoundField HeaderText="Apellidos" DataField="apellidos" SortExpression="apellidos"/>
                    <asp:BoundField HeaderText="Edad" DataField="edad" SortExpression="edad"/>
                    <asp:BoundField HeaderText="Contraseña" DataField="contrasenya" SortExpression="contrasenya"/>
                    <asp:BoundField HeaderText="Imagen" DataField="url_imagen" SortExpression="url_imagen"/>
                    <asp:BoundField HeaderText="Administrador?" DataField="admin" SortExpression="admin"/>
                    <asp:BoundField HeaderText="Localidad" DataField="localidad" SortExpression="localidad"/>
                    <asp:BoundField HeaderText="Provincia" DataField="provincia" SortExpression="provincia"/>
                    <asp:BoundField HeaderText="Pais" DataField="pais" SortExpression="pais"/>
                </Columns>
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
            <p>
                Subir imagen:  
                <asp:FileUpload ID="FileUpload1" runat="server" Width="437px" />
            </p>
            <p>
                Nick_name: <asp:TextBox runat="server" ID="Nick1" Width="216px"></asp:TextBox>
            </p>
            <p>
                Nombre: <asp:TextBox runat="server" ID="Nombre1" Width="246px"></asp:TextBox>
            </p>
            <p>
                Apellidos: <asp:TextBox runat="server" ID="Apellidos1" Width="230px"></asp:TextBox>
            </p>
            <p>
                Edad: <asp:TextBox runat="server" ID="Edad1" Width="268px"></asp:TextBox>
            </p>
            <p>
                Pais: <asp:TextBox runat="server" ID="Pais1" Width="277px"></asp:TextBox>
            </p>
            <p>
                Provincia: <asp:TextBox runat="server" ID="Provincia1" Width="222px"></asp:TextBox>
            </p>
            <p>
                Localidad: <asp:TextBox runat="server" ID="Localidad1" Width="218px"></asp:TextBox>
            </p>
            <p>
                Contrasenya: <asp:TextBox runat="server" ID="Contrasenya1" Width="192px"></asp:TextBox>
            </p>

            <asp:Button runat="server" Text="Sign Up"  ID="Crear" OnClick="createUsuario" Height="31px" Width="188px"/>
            <asp:Label runat ="server" ID = "LabelError"></asp:Label>
        </div>
    </form>
</body>
</html>
