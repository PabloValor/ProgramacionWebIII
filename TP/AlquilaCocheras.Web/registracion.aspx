<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Anonimo.Master" AutoEventWireup="true" CodeBehind="registracion.aspx.cs" Inherits="AlquilaCocheras.Web.registracion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder_Head" runat="server">
    <title>Estacionalo | Registración</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder_Principal" runat="server">
    <div class="container container-padding-top confirmar-reserva">
        <h2 class="titulo-pagina center-align">Registrarse</h2>

        <div class="row">
            <div class="col s12 m6">
                <asp:Label ID="label1" runat="server" Text="Nombre: "></asp:Label>
                <asp:TextBox ID="txtNombre" runat="server" ClientIDMode="Static"></asp:TextBox>

                <div class="mensaje-error-validacion">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorNombre"
                        runat="server" ErrorMessage="Ingrese un nombre"
                        ControlToValidate="txtNombre" Display="Dynamic">
                    </asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidatorNombre" runat="server"
                        ErrorMessage="Ingrese en nombre solo letras" ControlToValidate="txtNombre"
                        ValidationExpression="^[a-zA-Z ]*$" Display="Dynamic">
                    </asp:RegularExpressionValidator>
                </div>
            </div>
            <div class="col s12 m6">
                <asp:Label ID="label2" runat="server" Text="Apellido: "></asp:Label>
                <asp:TextBox ID="txtApellido" runat="server" ClientIDMode="Static"></asp:TextBox>

                <div class="mensaje-error-validacion">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorApellido" runat="server"
                        ErrorMessage="Ingrese un apellido"
                        ControlToValidate="txtApellido" Display="Dynamic">
                    </asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidatorApellido" runat="server"
                        ErrorMessage="Ingrese en apellido solo letras"
                        ControlToValidate="txtApellido" ValidationExpression="^[a-zA-Z ]*$" Display="Dynamic">
                    </asp:RegularExpressionValidator>
                </div>
            </div>

            <div class="col s12">
                <asp:Label ID="label3" runat="server" Text="Email: "></asp:Label>
                <asp:TextBox ID="txtEmail" runat="server" ClientIDMode="Static"></asp:TextBox>
                <div class="mensaje-error-validacion">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorEmail" runat="server"
                        ErrorMessage="Ingrese un email" ControlToValidate="txtEmail" Display="Dynamic">
                    </asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidatorEmail"
                        runat="server" ErrorMessage="Ingrese un email valido"
                        ControlToValidate="txtEmail"
                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" Display="Dynamic">
                    </asp:RegularExpressionValidator>
                </div>
            </div>

            <div class="col s12 m6">
                <asp:Label ID="label4" runat="server" Text="Contraseña: "></asp:Label>
                <asp:TextBox ID="txtContrasenia" runat="server" TextMode="Password" ClientIDMode="Static"></asp:TextBox>

                <div class="mensaje-error-validacion">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorContrasenia" runat="server"
                        ErrorMessage="Ingrese una contraseña" ControlToValidate="txtContrasenia" Display="Dynamic">
                    </asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator Display="Dynamic" ControlToValidate="txtContrasenia"
                        ID="RegularExpressionValidatorContrasenia"
                        ValidationExpression="^[A-Z].*(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,20}$" runat="server"
                        ErrorMessage="Contraseña - Caracteres : 8 Minimo, 20 Maximo. Debe comenzar con una mayuscula y contener un numero">
                    </asp:RegularExpressionValidator>
                </div>
            </div>

            <div class="col s12 m6">
                <asp:Label ID="label5" runat="server" Text="Confirme Contraseña: "></asp:Label>
                <asp:TextBox ID="txtConfContrasenia" runat="server" TextMode="Password" ClientIDMode="Static"></asp:TextBox>
            </div>
            <div class="mensaje-error-validacion">
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorConfContrasenia" runat="server"
                    ErrorMessage="Ingrese una contraseña" ControlToValidate="txtConfContrasenia" Display="Dynamic">
                </asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CompareValidatorConfContrasenia" runat="server"
                    ErrorMessage="Ingrese Contrasenias iguales" ControlToCompare="txtContrasenia"
                    ControlToValidate="txtConfContrasenia" Display="Dynamic">
                </asp:CompareValidator>
            </div>

            <div class="col s12">
                <asp:RadioButtonList ID="rblPerfil" runat="server" ClientIDMode="Static">
                    <asp:ListItem Text="Cliente" Value="1" />
                    <asp:ListItem Text="Propietario" Value="2" />
                </asp:RadioButtonList>

                <div class="mensaje-error-validacion">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorPerfil" runat="server"
                        ErrorMessage="Ingrese una opcion"
                        ControlToValidate="rblPerfil" Display="Dynamic">
                    </asp:RequiredFieldValidator>
                </div>
            </div>
        </div>
        <div class="col s12">
            <asp:Label ID="lblResultado" runat="server"></asp:Label>
            <asp:Button ID="btnRegistrarUsuario" runat="server" Text="Registrar usuario" ClientIDMode="Static" OnClick="btnRegistrarUsuario_Click" />
        </div>
    </div>
</asp:Content>
