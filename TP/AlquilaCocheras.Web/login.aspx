<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Anonimo.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="AlquilaCocheras.Web.login" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder_Head" runat="server">
    <title>Estacionalo | Login</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder_Principal" runat="server">
    <div class="container container-padding-top login">
        <h2 class="titulo-pagina center-align">Ingresar</h2>
        <div class="formulario login">
            <div class="row">
                <div class="input-field col s12">
                    <i class="material-icons prefix">perm_identity</i>
                    <asp:TextBox ID="txtEmail" runat="server" ClientIDMode="Static"></asp:TextBox>
                    <label for="txtEmail">Email</label>
                    <div class="mensaje-error-validacion">
                        <asp:RegularExpressionValidator ID="RegularExpressionValidatorEmail" runat="server" ErrorMessage="(*)Ingrese un email valido" ControlToValidate="txtEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                        <br />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorEmail" runat="server" ErrorMessage="(*) Ingrese un Email" ControlToValidate="txtEmail"></asp:RequiredFieldValidator>
                    </div>
                </div>

                <div class="input-field col s12">
                    <i class="material-icons prefix">fingerprint</i>
                    <asp:TextBox ID="txtContrasenia" runat="server" TextMode="Password" ClientIDMode="Static"></asp:TextBox>
                    <label for="txtContrasenia">Password</label>
                    <div class="mensaje-error-validacion">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorContrasenia" runat="server" ErrorMessage="(*) Ingrese una contraseña" ControlToValidate="txtContrasenia"></asp:RequiredFieldValidator>
                    </div>
                </div>
            </div>
            <div class="row">
                <%--Si el usuario no existe o si no coinciden las credenciales, mostrar mensaje "Usuario y/o Contraseña inválidos"--%>
                <div class="col s12">
                    <asp:Label ID="lblResultado" runat="server"><%= MensajeError %></asp:Label>
                </div>
                <div class="center-align">
                    <div class="row">
                        <div class="col s12">
                            <a href="/registracion.aspx" class="btn">Registrarse</a>
                            <asp:Button ID="btnLogin"  runat="server" Text="Ingresar" ClientIDMode="Static" OnClick="btnLogin_Click" CssClass="btn" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
