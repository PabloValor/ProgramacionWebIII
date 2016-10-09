<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Propietarios.Master" AutoEventWireup="true" CodeBehind="perfil.aspx.cs" Inherits="AlquilaCocheras.Web.propietarios.perfil" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder_Head" runat="server">
    <title>Estacionalo | Mi Perfil </title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder_Principal" runat="server">
    <div class="container container-padding-top">
        <h2 class="titulo-pagina center-align">Mi perfil</h2>
        <div class="formulario">
            <div class="row">
                <div class="input-field col s12 m6">
                    <i class="material-icons prefix">account_circle</i>
                    <asp:TextBox ID="txtNombre" runat="server" ClientIDMode="Static"></asp:TextBox>
                    <label for="txtNombre">Nombre</label>

                    <div class="mensaje-error-validacion">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorNombre" runat="server"
                            ErrorMessage="Ingrese un nombre" ControlToValidate="txtNombre"
                            Display="Dynamic" ValidationGroup="3">
                        </asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidatorNombre" runat="server"
                            ErrorMessage="Ingrese en nombre solo letras" ControlToValidate="txtNombre"
                            ValidationExpression="^[a-zA-Z ]*$"
                            Display="Dynamic" ValidationGroup="3">
                        </asp:RegularExpressionValidator>

                    </div>
                </div>

                <div class="input-field col s12 m6">
                    <i class="material-icons prefix">account_circle</i>
                    <asp:TextBox ID="txtApellido" runat="server" ClientIDMode="Static"></asp:TextBox>
                    <label for="txtApellido">Apellido</label>

                    <div class="mensaje-error-validacion">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorApellido" runat="server"
                            ErrorMessage="Ingrese un apellido" ControlToValidate="txtApellido"
                            Display="Dynamic" ValidationGroup="3">
                        </asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidatorApellido" runat="server"
                            ErrorMessage="Ingrese en apellido solo letras"
                            ControlToValidate="txtApellido" ValidationExpression="^[a-zA-Z ]*$"
                            Display="Dynamic" ValidationGroup="3">
                        </asp:RegularExpressionValidator>
                    </div>

                </div>

                <div class="input-field col s12">
                    <i class="material-icons prefix">markunread</i>
                    <asp:TextBox ID="txtEmail" runat="server" ClientIDMode="Static" ReadOnly="true"></asp:TextBox>
                    <label for="txtEmail">E-mail</label>

                    <div class="mensaje-error-validacion">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorEmail" runat="server"
                            ErrorMessage="Ingrese un email" ControlToValidate="txtEmail"
                            Display="Dynamic" ValidationGroup="3">
                        </asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidatorEmail" runat="server"
                            ErrorMessage="Ingrese un email valido" ControlToValidate="txtEmail"
                            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" Display="Dynamic" ValidationGroup="3">
                        </asp:RegularExpressionValidator>
                    </div>
                </div>

                <div class="input-field col s12 m6">
                    <i class="material-icons prefix">fingerprint</i>
                    <asp:TextBox ID="txtContrasenia" runat="server" TextMode="Password" ClientIDMode="Static"></asp:TextBox>
                    <label for="txtContrasenia"></label>

                    <div class="mensaje-error-validacion">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorContrasenia" runat="server"
                            ErrorMessage="Ingrese una contraseña"
                            ControlToValidate="txtContrasenia" Display="Dynamic" ValidationGroup="3">
                        </asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator Display="Dynamic" ControlToValidate="txtContrasenia"
                            ID="RegularExpressionValidatorContrasenia"
                            ValidationExpression="^[A-Z].*(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,20}$"
                            runat="server"
                            ErrorMessage="Contraseña - Caracteres : 8 Minimo, 20 Maximo. Debe comenzar con una mayuscula y contener un numero " ValidationGroup="3">
                        </asp:RegularExpressionValidator>
                    </div>
                </div>

                <div class="input-field col s12 m6">
                    <i class="material-icons prefix">fingerprint</i>
                    <asp:TextBox ID="txtConfContrasenia" runat="server" TextMode="Password" ClientIDMode="Static"></asp:TextBox>
                    <label for="txtConfContrasenia"></label>

                    <div class="mensaje-error-validacion">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorConfContrasenia" runat="server"
                            ErrorMessage="Ingrese una contraseña" ControlToValidate="txtConfContrasenia"
                            Display="Dynamic" ValidationGroup="3">
                        </asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidatorConfContrasenia" runat="server"
                            ErrorMessage="Ingrese Contrasenias iguales" ControlToCompare="txtContrasenia"
                            ControlToValidate="txtConfContrasenia" Display="Dynamic" ValidationGroup="3">
                        </asp:CompareValidator>
                    </div>
                </div>

                <div class="input-field col s12">
                    <asp:RadioButtonList ID="rblPerfil" runat="server" ClientIDMode="Static">
                        <asp:ListItem Text="Cliente" Value="1" />
                        <asp:ListItem Text="Propietario" Value="2" />
                    </asp:RadioButtonList>
                    <div class="mensaje-error-validacion">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorPerfil" runat="server"
                            ErrorMessage="Ingrese una opcion" ControlToValidate="rblPerfil"
                            Display="Dynamic" ValidationGroup="3">
                        </asp:RequiredFieldValidator>
                    </div>
                </div>
            </div>

            <div class="row">
                <div class="col s12">
                    <asp:Label ID="lblResultado" runat="server"></asp:Label>
                </div>
            </div>
            <div class="row">
                <div class="col s12">
                    <div class="center-align">
                        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" ClientIDMode="Static" CssClass="btn" OnClick="btnCancelar_Click" />
                        <asp:Button ID="btnActualizar" runat="server" Text="Actualizar perfil" ClientIDMode="Static" OnClick="btnActualizar_Click" ValidationGroup="3" CssClass="btn" />
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
