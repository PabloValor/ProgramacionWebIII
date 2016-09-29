<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Anonimo.Master" AutoEventWireup="true" CodeBehind="registracion.aspx.cs" Inherits="AlquilaCocheras.Web.registracion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder_Head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder_Principal" runat="server">
    <asp:Label ID="label1" runat="server" Text="Nombre: "></asp:Label>
    <asp:TextBox ID="txtNombre" runat="server" ClientIDMode="Static"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Ingrese un nombre" ControlToValidate="txtNombre">*</asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Ingrese en nombre solo letras" ControlToValidate="txtNombre" ValidationExpression="^[a-zA-Z ]*$">*</asp:RegularExpressionValidator>
    

    <asp:Label ID="label2" runat="server" Text="Apellido: "></asp:Label>
    <asp:TextBox ID="txtApellido" runat="server" ClientIDMode="Static"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Ingrese un apellido" ControlToValidate="txtApellido">*</asp:RequiredFieldValidator>
       <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ErrorMessage="Ingrese en apellido solo letras" ControlToValidate="txtApellido" ValidationExpression="^[a-zA-Z ]*$">*</asp:RegularExpressionValidator>


    <asp:Label ID="label3" runat="server" Text="Email: "></asp:Label>
    <asp:TextBox ID="txtEmail" runat="server" ClientIDMode="Static"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Ingrese un email" ControlToValidate="txtEmail">*</asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Ingrese un email valido" ControlToValidate="txtEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
    
    <asp:Label ID="label4" runat="server" Text="Contraseña: "></asp:Label>
    <asp:TextBox ID="txtContrasenia" runat="server" TextMode="Password" ClientIDMode="Static"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Ingrese una contraseña" ControlToValidate="txtContrasenia">*</asp:RequiredFieldValidator>
   
    <asp:Label ID="label5" runat="server" Text="Confirme Contraseña: "></asp:Label>
    <asp:TextBox ID="txtConfContrasenia" runat="server" TextMode="Password" ClientIDMode="Static"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Ingrese una contraseña" ControlToValidate="txtConfContrasenia">*</asp:RequiredFieldValidator>
    <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Ingrese Email iguales" ControlToCompare="txtContrasenia" ControlToValidate="txtConfContrasenia"></asp:CompareValidator>

    <asp:RadioButtonList ID="rblPerfil" runat="server" ClientIDMode="Static">
        <asp:ListItem Text="Cliente" Value="1" />
        <asp:ListItem Text="Propietario" Value="2" />
    </asp:RadioButtonList>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Ingrese una opcion" ControlToValidate="rblPerfil">*</asp:RequiredFieldValidator>
   

    <asp:Label ID="lblResultado" runat="server"></asp:Label>
    <asp:Button ID="btnRegistrarUsuario" runat="server" Text="Registrar usuario" ClientIDMode="Static" OnClick="btnRegistrarUsuario_Click" />
    
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
</asp:Content>
