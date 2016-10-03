<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Clientes.Master" AutoEventWireup="true" CodeBehind="confirmar-reserva.aspx.cs" Inherits="AlquilaCocheras.Web.clientes.confirmar_reserva" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder_Head" runat="server">
    <title>Estacionalo | Confirmación de Reserva</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder_Principal" runat="server">
    <div class="container">
        <h2 class="titulo-pagina">Confirmación de reserva</h2>

        <asp:Label ID="label2" runat="server" Text="Fecha Inicio"></asp:Label>
        <asp:TextBox ID="txtFechaInicio" runat="server" ClientIDMode="Static" Text="05/10/2016"></asp:TextBox>

        <div class="cocheras-validacion">
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorFechaInicio" runat="server" ErrorMessage="Ingrese una Fecha de Inicio"
                 ControlToValidate="txtFechaInicio" Display="Dynamic">
            </asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidatorFechaInicio" runat="server" ControlToValidate="txtFechaInicio" 
                ErrorMessage="Entre una fecha de inicio valida - dd/mm/aaaa" Operator="DataTypeCheck" 
                Type="Date" Display="Dynamic">
            </asp:CompareValidator>
        </div>

        <asp:Label ID="label4" runat="server" Text="Fecha Fin"></asp:Label>
        <asp:TextBox ID="txtFechaFin" runat="server" ClientIDMode="Static" Text="07/10/2016"></asp:TextBox>

        <div class="cocheras-validacion">
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorFechaFin" runat="server" ErrorMessage="Ingrese una Fecha de Fin"
                 ControlToValidate="txtFechaFin" Display="Dynamic">
            </asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidatorFechaFin" runat="server" ControlToValidate="txtFechaFin" 
                ErrorMessage="Entre una fecha de fin valida - dd/mm/aaaa" Operator="DataTypeCheck" Type="Date" 
                Display="Dynamic">
            </asp:CompareValidator>
            <asp:CompareValidator ID="CompareValidatorFecha" ControlToCompare="txtFechaInicio"  ControlToValidate="txtFechaFin"
                 Type="Date" Operator="GreaterThanEqual" ErrorMessage="La fecha de inicio tiene que ser anterior a la fecha de fin"
                 runat="server" Display="Dynamic">
            </asp:CompareValidator>
        </div>

        <asp:Label ID="label3" runat="server" Text="Hora de Entrada"></asp:Label>
        <asp:TextBox ID="txtHorarioInicio" runat="server" ClientIDMode="Static" Text="13:40"></asp:TextBox>

        <div class="cocheras-validacion">
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorHorarioInicio" runat="server" ErrorMessage="Ingrese un Horario de Inicio" 
                ControlToValidate="txtHorarioInicio" Display="Dynamic">
            </asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidatorHorarioInicio" runat="server"
                 ErrorMessage="Entre un horario de inicio valido - hh:mm 24HS" ControlToValidate="txtHorarioInicio"
                 ValidationExpression="^(?:[01]?[0-9]|2[0-3]):[0-5][0-9]$" Display="Dynamic">
            </asp:RegularExpressionValidator>
        </div>

        <asp:Label ID="label1" runat="server" Text="Hora de Salida"></asp:Label>
        <asp:TextBox ID="txtHorarioFin" runat="server" ClientIDMode="Static" Text="10:00"></asp:TextBox>

        <div class="cocheras-validacion">
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorHorarioFin" runat="server" 
                ErrorMessage="Ingrese un Horario de Fin" ControlToValidate="txtHorarioFin" 
                Display="Dynamic">
            </asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidatorHorarioFin" runat="server" 
                ErrorMessage="Entre un horario de fin valido - hh:mm 24HS" ControlToValidate="txtHorarioFin"
                 ValidationExpression="^(?:[01]?[0-9]|2[0-3]):[0-5][0-9]$" Display="Dynamic">
            </asp:RegularExpressionValidator>
            <asp:CompareValidator ID="CompareValidatorHorario" ControlToCompare="txtHorarioInicio" ControlToValidate="txtHorarioFin"
                 Operator="GreaterThanEqual" ErrorMessage="El Horario de inicio debe ser anterior al Horario de fin"
                 runat="server" Display="Dynamic">
            </asp:CompareValidator>
        </div>

        <asp:Label ID="lblUbicacion" ClientIDMode="Static" runat="server"></asp:Label>
        <asp:Image ID="imgFoto" ClientIDMode="Static" runat="server" />
        <asp:Label ID="lblPrecioHora" ClientIDMode="Static" runat="server"></asp:Label>
        <asp:Label ID="lblPrecioTotal" ClientIDMode="Static" runat="server"></asp:Label>

        <asp:Label ID="lblResultado" runat="server">
            <%= MensajeError %>
            <%= MensajeExito %>
        </asp:Label>
        <asp:Button ID="btnConfirmar" runat="server" Text="Confirmar Reserva" ClientIDMode="Static" OnClick="btnConfirmar_Click" />
        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" ClientIDMode="Static" OnClick="btnCancelar_Click"/>
    </div>
</asp:Content>
