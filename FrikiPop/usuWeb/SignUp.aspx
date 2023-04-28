<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="usuWeb.Formulario_web1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>FrikiPop</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>
                Subir imagen:  <asp:Button runat="server" Text="Examinar"  ID="Imagen" OnClick="insertarImagen"/>
            </p>
            <p>
                Nick_name: <asp:TextBox runat="server" ID="Nick1"></asp:TextBox>
            </p>
            <p>
                Nombre: <asp:TextBox runat="server" ID="Nombre1"></asp:TextBox>
            </p>
            <p>
                Apellidos: <asp:TextBox runat="server" ID="Apellidos1"></asp:TextBox>
            </p>
            <p>
                Edad: <asp:TextBox runat="server" ID="Edad1"></asp:TextBox>
            </p>
            <p>
                Pais: <asp:TextBox runat="server" ID="Pais1"></asp:TextBox>
            </p>
            <p>
                Provincia: <asp:TextBox runat="server" ID="Provincia1"></asp:TextBox>
            </p>
            <p>
                Localidad: <asp:TextBox runat="server" ID="Localidad1"></asp:TextBox>
            </p>
            <p>
                Contrasenya: <asp:TextBox runat="server" ID="Contrasenya1"></asp:TextBox>
            </p>
            <asp:Button runat="server" Text="Sign Up"  ID="Crear" OnClick="createUsuario"/>
            <asp:Label runat ="server" ID = "LabelError"></asp:Label>
        </div>
    </form>
</body>
</html>
