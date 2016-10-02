<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Propietarios.Master" AutoEventWireup="true" CodeBehind="perfil.aspx.cs" Inherits="AlquilaCocheras.Web.propietarios.perfil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder_Head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder_Principal" runat="server">
    <asp:Label ID="label1" runat="server" Text="Nombre: "></asp:Label>
    <asp:TextBox ID="txtNombre" runat="server" ClientIDMode="Static"></asp:TextBox>

    <div class="perfil-validacion">
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorNombre" runat="server" 
            ErrorMessage="Ingrese un nombre" ControlToValidate="txtNombre"
             Display="Dynamic">
        </asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidatorNombre" runat="server" 
            ErrorMessage="Ingrese en nombre solo letras" ControlToValidate="txtNombre" 
            ValidationExpression="^[a-zA-Z ]*$"
             Display="Dynamic">
        </asp:RegularExpressionValidator>
    </div>

    <asp:Label ID="label2" runat="server" Text="Apellido: "></asp:Label>
    <asp:TextBox ID="txtApellido" runat="server" ClientIDMode="Static"></asp:TextBox>
    
    <div class="perfil-validacion">
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorApellido" runat="server"
             ErrorMessage="Ingrese un apellido" ControlToValidate="txtApellido"
             Display="Dynamic">
        </asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidatorApellido" runat="server" 
            ErrorMessage="Ingrese en apellido solo letras"
             ControlToValidate="txtApellido" ValidationExpression="^[a-zA-Z ]*$" 
            Display="Dynamic">
        </asp:RegularExpressionValidator>
    </div>

    <asp:Label ID="label3" runat="server" Text="Email: "></asp:Label>
    <asp:TextBox ID="txtEmail" runat="server" ClientIDMode="Static" ReadOnly="true"></asp:TextBox>
    
    <div class="perfil-validacion">
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorEmail" runat="server"
             ErrorMessage="Ingrese un email" ControlToValidate="txtEmail"
             Display="Dynamic">
        </asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidatorEmail" runat="server" 
            ErrorMessage="Ingrese un email valido" ControlToValidate="txtEmail" 
            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" Display="Dynamic">
        </asp:RegularExpressionValidator>
    </div>

    <asp:Label ID="label4" runat="server" Text="Contraseña: "></asp:Label>
    <asp:TextBox ID="txtContrasenia" runat="server" TextMode="Password" ClientIDMode="Static"></asp:TextBox>
    
    <div class="perfil-validacion">
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorContrasenia" runat="server"
             ErrorMessage="Ingrese una contraseña" 
            ControlToValidate="txtContrasenia" Display="Dynamic">
        </asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator Display = "Dynamic" ControlToValidate = "txtContrasenia"
             ID="RegularExpressionValidatorContrasenia"
             ValidationExpression = "^[A-Z].*(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,20}$" 
             runat="server" 
             ErrorMessage="Contraseña - Caracteres : 8 Minimo, 20 Maximo. Debe comenzar con una mayuscula y contener un numero ">
        </asp:RegularExpressionValidator>
    </div>

    <asp:Label ID="label5" runat="server" Text="Confirme Contraseña: "></asp:Label>
    <asp:TextBox ID="txtConfContrasenia" runat="server" TextMode="Password" ClientIDMode="Static"></asp:TextBox>
    
    <div class="perfil-validacion">
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorConfContrasenia" runat="server" 
            ErrorMessage="Ingrese una contraseña" ControlToValidate="txtConfContrasenia"
             Display="Dynamic">
        </asp:RequiredFieldValidator>
        <asp:CompareValidator ID="CompareValidatorConfContrasenia" runat="server"
             ErrorMessage="Ingrese Contrasenias iguales" ControlToCompare="txtContrasenia"
             ControlToValidate="txtConfContrasenia" Display="Dynamic">
        </asp:CompareValidator>
    </div>

    <asp:RadioButtonList ID="rblPerfil" runat="server" ClientIDMode="Static">
        <asp:ListItem Text="Cliente" Value="1" />
        <asp:ListItem Text="Propietario" Value="2" />
    </asp:RadioButtonList>
    
    <div class="perfil-validacion">
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorPerfil" runat="server" 
            ErrorMessage="Ingrese una opcion" ControlToValidate="rblPerfil" 
            Display="Dynamic">
        </asp:RequiredFieldValidator>
    </div>

    <asp:Label ID="lblResultado" runat="server"></asp:Label>
    <asp:Button ID="btnActualizar" runat="server" Text="Actualizar perfil" ClientIDMode="Static" OnClick="btnActualizar_Click" />
    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" ClientIDMode="Static" />
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
</asp:Content>
