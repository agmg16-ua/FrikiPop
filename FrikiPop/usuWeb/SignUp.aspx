﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="usuWeb.Formulario_web2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
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
</asp:Content>