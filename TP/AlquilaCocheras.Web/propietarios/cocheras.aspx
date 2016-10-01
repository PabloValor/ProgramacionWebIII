<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Propietarios.Master" AutoEventWireup="true" CodeBehind="cocheras.aspx.cs" Inherits="AlquilaCocheras.Web.propietarios.cocheras" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder_Head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder_Principal" runat="server">
   
    <asp:Label ID="label1" runat="server" Text="Ubicación: "></asp:Label>
    <asp:TextBox ID="txtUbicacion" runat="server" ClientIDMode="Static"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidatorUbicacion" runat="server" ErrorMessage="Ingrese una Ubicacion" ControlToValidate="txtUbicacion">*</asp:RequiredFieldValidator>
    
    <asp:Label ID="label2" runat="server" Text="Período Disponible: "></asp:Label>
    <asp:TextBox ID="txtFechaInicio" runat="server" ClientIDMode="Static"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidatorFechaInicio" runat="server" ErrorMessage="Ingrese una Fecha de Inicio" ControlToValidate="txtFechaInicio">*</asp:RequiredFieldValidator>
    <asp:CompareValidator ID="CompareValidatorFechaInicio" runat="server" ControlToValidate="txtFechaInicio" ErrorMessage="Entre una fecha de inicio valida - dd/mm/aaaa" Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
        
    <asp:TextBox ID="txtFechaFin" runat="server" ClientIDMode="Static"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidatorFechaFin" runat="server" ErrorMessage="Ingrese una Fecha de Fin" ControlToValidate="txtFechaFin">*</asp:RequiredFieldValidator>
    <asp:CompareValidator ID="CompareValidatorFechaFin" runat="server" ControlToValidate="txtFechaFin" ErrorMessage="Entre una fecha de fin valida - dd/mm/aaaa" Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>

    <asp:CompareValidator ID="CompareValidatorFecha" ControlToCompare="txtFechaInicio"  ControlToValidate="txtFechaFin" Type="Date" Operator="GreaterThanEqual" ErrorMessage="La fecha de inicio tiene que ser anterior a la fecha de fin" runat="server">*</asp:CompareValidator>

    <asp:Label ID="label3" runat="server" Text="Horario Diario Disponible: "></asp:Label>
    <asp:TextBox ID="txtHorarioInicio" runat="server" ClientIDMode="Static"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidatorHorarioInicio" runat="server" ErrorMessage="Ingrese un Horario de Inicio" ControlToValidate="txtHorarioInicio">*</asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="RegularExpressionValidatorHorarioInicio" runat="server" ErrorMessage="Entre un horario de inicio valido - hh:mm 24HS" ControlToValidate="txtHorarioInicio" ValidationExpression="^(?:[01]?[0-9]|2[0-3]):[0-5][0-9]$">*</asp:RegularExpressionValidator>
   
    <asp:TextBox ID="txtHorarioFin" runat="server" ClientIDMode="Static"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidatorHorarioFin" runat="server" ErrorMessage="Ingrese un Horario de Fin" ControlToValidate="txtHorarioFin">*</asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="RegularExpressionValidatorHorarioFin" runat="server" ErrorMessage="Entre un horario de fin valido - hh:mm 24HS" ControlToValidate="txtHorarioFin" ValidationExpression="^(?:[01]?[0-9]|2[0-3]):[0-5][0-9]$">*</asp:RegularExpressionValidator>

    <asp:CompareValidator ID="CompareValidatorHorario" ControlToCompare="txtHorarioInicio" ControlToValidate="txtHorarioFin" Operator="GreaterThanEqual" ErrorMessage="El Horario de inicio debe ser anterior al Horario de fin" runat="server">*</asp:CompareValidator>


    <asp:Label ID="label4" runat="server" Text="Descripción: "></asp:Label>
    <asp:TextBox ID="txtDescripcion" runat="server" ClientIDMode="Static"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidatorDescripcion" runat="server" ErrorMessage="Ingrese una Descripcion" ControlToValidate="txtDescripcion">*</asp:RequiredFieldValidator>


    <asp:Label ID="label5" runat="server" Text="Latitud: "></asp:Label>
    <asp:TextBox ID="txtLatitud" runat="server" ClientIDMode="Static"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidatorLatitud" runat="server" ErrorMessage="Ingrese una Latitud" ControlToValidate="txtLatitud">*</asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="RegularExpressionValidatorLatitud" runat="server" ErrorMessage="Entre una latitud valida - nn.n Decimal Max.5" ControlToValidate="txtLatitud" ValidationExpression="^(-?\d{0,5}\.\d{0,5}|\d{0,5})$">*</asp:RegularExpressionValidator>


    <asp:Label ID="label6" runat="server" Text="Longitud: "></asp:Label>
    <asp:TextBox ID="txtLongitud" runat="server" ClientIDMode="Static"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidatorLongitud" runat="server" ErrorMessage="Ingrese una Longitud" ControlToValidate="txtLongitud">*</asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="RegularExpressionValidatorLongitud" runat="server" ErrorMessage="Entre una longitud valida - nn.n Decimal Max.5" ControlToValidate="txtLongitud" ValidationExpression="^(-?\d{0,5}\.\d{0,5}|\d{0,5})$">*</asp:RegularExpressionValidator>


    <asp:Label ID="label7" runat="server" Text="Metros Cuadrados: "></asp:Label>
    <asp:TextBox ID="txtMetrosCuadrados" runat="server" ClientIDMode="Static"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidatorMetrosCuadrados" runat="server" ErrorMessage="Ingrese Metros Cuadrados" ControlToValidate="txtMetrosCuadrados">*</asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="RegularExpressionValidatorMetrosCuadrados" runat="server" ErrorMessage="Entre una medida valida - nn Entero Positivo" ControlToValidate="txtMetrosCuadrados" ValidationExpression="^(?!0\d)\d{1,7}$">*</asp:RegularExpressionValidator>
    <asp:RangeValidator ID="RangeValidatorMetroCuadrados" runat="server" ErrorMessage="Lo Metros Cuadrados deben ser mayores a 5 y menores que 5000" ControlToValidate="txtMetrosCuadrados" MaximumValue="5000" MinimumValue="5" Type="Integer">*</asp:RangeValidator>

    <asp:Label ID="label8" runat="server" Text="Tipo Vehículo: "></asp:Label>
    <asp:ListBox ID="lbTipoVehiculo" SelectionMode="Multiple" runat="server" ClientIDMode="Static">
        <asp:ListItem Value="0">Seleccione:</asp:ListItem>
        <asp:ListItem Value="1">Auto</asp:ListItem>
        <asp:ListItem Value="2">Pickup</asp:ListItem>
        <asp:ListItem Value="3">Camion</asp:ListItem>
        <asp:ListItem Value="4">Moto</asp:ListItem>
    </asp:ListBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidatorTipoVehiculo" runat="server" ErrorMessage="Ingrese un Tipo de Vehiculo" ControlToValidate="lbTipoVehiculo">*</asp:RequiredFieldValidator>


    <asp:Label ID="label9" runat="server" Text="Precio por Hora: "></asp:Label>
    <asp:TextBox ID="txtPrecioHora" runat="server" ClientIDMode="Static"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidatorPrecioHora" runat="server" ErrorMessage="Ingrese un Precio" ControlToValidate="txtPrecioHora">*</asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="RegularExpressionValidatorPrecioHora" runat="server" ErrorMessage="Ingrese un Precio valido - nn.n Decimal Positivo MAX.2" ControlToValidate="txtPrecioHora" ValidationExpression="^(?!0\d)\d{0,2}(\.\d{1,2})?$">*</asp:RegularExpressionValidator>
    <asp:CompareValidator ID="CompareValidatorPrecioHora" ErrorMessage="El precio tiene que ser mayor a 0" ControlToValidate="txtPrecioHora" runat="server" Operator="NotEqual" ValueToCompare="0" />
    

    <asp:Label ID="label10" runat="server" Text="Foto: "></asp:Label>
    <asp:FileUpload ID="fuFoto" runat="server" ClientIDMode="Static" />
    <asp:RequiredFieldValidator ID="RequiredFieldValidatorFoto" runat="server" ErrorMessage="Ingrese una Foto" ControlToValidate="fuFoto">*</asp:RequiredFieldValidator>

    <asp:Label ID="lblResultado" runat="server"></asp:Label>
    <asp:Button ID="btnCrearCochera" runat="server" Text="Crear Cochera" ClientIDMode="Static" OnClick="btnCrearCochera_Click"/>   

    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
</asp:Content>
