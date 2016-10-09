<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Propietarios.Master" AutoEventWireup="true" CodeBehind="reservas.aspx.cs" Inherits="AlquilaCocheras.Web.propietarios.reservas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder_Head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder_Principal" runat="server">
<div class="contenido container-padding-top cliente-reservar">
    <h2 class="titulo-pagina center-align">Reservas</h2>
    <div class="container" id="form-buscador-servicio">
        <div class="row">

            <div class="input-field col s12 m6">       
                <i class="material-icons prefix">date_range</i>
                <asp:TextBox ID="txtFechaInicio" runat="server" ClientIDMode="Static"></asp:TextBox>
                <label for="txtFechaInicio">Período de inicio</label>

                 <div class="mensaje-error-validacion">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorFechaInicio" runat="server" ErrorMessage="Ingrese una Fecha de Inicio"
                         ControlToValidate="txtFechaInicio" Display="Dynamic" ValidationGroup="3">
                    </asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidatorFechaInicio" runat="server" ControlToValidate="txtFechaInicio" 
                        ErrorMessage="Entre una fecha de inicio valida - dd/mm/aaaa" Operator="DataTypeCheck" 
                        Type="Date" Display="Dynamic" ValidationGroup="3">
                    </asp:CompareValidator>
                </div>
            </div>


            <div class="input-field col s12 m6">
                <i class="material-icons prefix">date_range</i>
                <asp:TextBox ID="txtFechaFin" runat="server" ClientIDMode="Static"></asp:TextBox>
                <label for="txtFechaFin">Período de fin</label>
        

                <div class="mensaje-error-validacion">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorFechaFin" runat="server" ErrorMessage="Ingrese una Fecha de Fin"
                         ControlToValidate="txtFechaFin" Display="Dynamic" ValidationGroup="3">
                    </asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidatorFechaFin" runat="server" ControlToValidate="txtFechaFin" 
                        ErrorMessage="Entre una fecha de fin valida - dd/mm/aaaa" Operator="DataTypeCheck" Type="Date" 
                        Display="Dynamic" ValidationGroup="3">
                    </asp:CompareValidator>
                    <asp:CompareValidator ID="CompareValidatorFecha" ControlToCompare="txtFechaInicio"  ControlToValidate="txtFechaFin"
                         Type="Date" Operator="GreaterThanEqual" ErrorMessage="La fecha de inicio tiene que ser anterior a la fecha de fin"
                         runat="server" Display="Dynamic" ValidationGroup="3">
                    </asp:CompareValidator>
                    <asp:CustomValidator ID="CustomValidatorFecha" runat="server" 
                        ErrorMessage="La diferencia entre la fecha de inicio y fin no debe ser mayor a 90 dias" OnServerValidate="CustomValidatorFecha_ServerValidate" ValidationGroup="3">
                    </asp:CustomValidator>
                </div>
            </div>
        </div>

        <div class="input-field col s12 center-align">
            <asp:Button ID="btnFiltrar" runat="server" Text="Filtrar" ClientIDMode="Static" ValidationGroup="3" CssClass="waves-effect waves-light btn-large " OnClick="btnFiltrar_Click"/> 
        </div>

        <div class="row">
            <div class="col s12">
                <div class="listado-reservas">
                    <div class="row">
                        <!--Logica de reservas -->
                    </div>
                </div>
            </div>
        </div>
    </div>
</div> 
</asp:Content>
