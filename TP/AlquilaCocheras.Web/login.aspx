<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Anonimo.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="AlquilaCocheras.Web.login" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder_Head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder_Principal" runat="server">

    <asp:Label ID="label3" runat="server" Text="Email: "></asp:Label>
    <asp:TextBox ID="txtEmail" runat="server" ClientIDMode="Static"></asp:TextBox>
    <asp:RegularExpressionValidator ID="RegularExpressionValidatorEmail" runat="server" ErrorMessage="Ingrese un email valido" ControlToValidate="txtEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" Display="Dynamic">*</asp:RegularExpressionValidator>
    <asp:RequiredFieldValidator ID="RequiredFieldValidatorEmail" runat="server" ErrorMessage="Ingrese un Email" ControlToValidate="txtEmail" Display="Dynamic">*</asp:RequiredFieldValidator>

    <asp:Label ID="label2" runat="server" Text="Contraseña: "></asp:Label>
    <asp:TextBox ID="txtContrasenia" runat="server" TextMode="Password" ClientIDMode="Static"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidatorContrasenia" runat="server" ErrorMessage="Ingrese una contraseña" ControlToValidate="txtContrasenia" Display="Dynamic">*</asp:RequiredFieldValidator>
   
     <%--Si el usuario no existe o si no coinciden las credenciales, mostrar mensaje "Usuario y/o Contraseña inválidos"--%>
    <asp:Label ID="lblResultado" runat="server"></asp:Label>
    <asp:Button ID="btnLogin" runat="server" Text="Ingresar" ClientIDMode="Static" OnClick="btnLogin_Click" />

    <a href="/registracion.aspx">Registrarse como nuevo usuario.</a>

    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />

</asp:Content>
