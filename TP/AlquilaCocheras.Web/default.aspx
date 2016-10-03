﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Anonimo.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="AlquilaCocheras.Web._default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder_Head" runat="server">
    <title>EstacionaLo - Home</title>
    <meta name="description" content="Estacionalo es una plataforma donde podes publicar tu cochera cuando quieras, el tiempo que quieras, o también encontrar tu cochera ideal">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder_Principal" runat="server">
    <header id="home-header">
        <div class="contenido">
            <h1 class="logo">Estaciona<span>lo</span></h1>
            <h2>Conseguí cochera o alquilá la que ya tenes</h2>
            <div class="container" id="form-buscador-servicio-anonimo">
                <div class="row">
                    <div class="input-field col s12">
                        <i class="material-icons prefix">pin_drop</i>
                        <asp:TextBox ID="txtUbicacion" runat="server" ClientIDMode="Static"></asp:TextBox>
                        <label for="txtUbicacion">Ubicación</label>
                    </div>

                    <div class="mensaje-error-validacion">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1"
                            runat="server" ControlToValidate="txtUbicacion"
                            ErrorMessage="(*) Por favor, seleccione una ubicación">
                        </asp:RequiredFieldValidator>
                    </div>

                    <div class="input-field col s12 m6">
                        <i class="material-icons prefix">date_range</i>
                        <asp:TextBox ID="txtFechaInicio" runat="server" ClientIDMode="Static"></asp:TextBox>
                        <label for="txtFechaInicio">Período de inicio</label>

                        <div class="mensaje-error-validacion">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2"
                                runat="server" ControlToValidate="txtFechaInicio"
                                ErrorMessage="(*) Por favor, seleccione una fecha de inicio" Display="Dynamic">
                            </asp:RequiredFieldValidator>
                            <asp:CompareValidator ID="CompareValidatorFechaInicio" runat="server"
                                ControlToValidate="txtFechaInicio" ErrorMessage="(*) Entre una fecha de inicio valida - dd/mm/aaaa"
                                Operator="DataTypeCheck" Type="Date" Display="Dynamic">
                            </asp:CompareValidator>
                        </div>
                    </div>

                    <div class="input-field col s12 m6">
                        <i class="material-icons prefix">date_range</i>
                        <asp:TextBox ID="txtFechaFin" runat="server" ClientIDMode="Static"></asp:TextBox>
                        <label for="txtFechaFin">Período de fin</label>

                        <div class="mensaje-error-validacion">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3"
                                runat="server" ControlToValidate="txtFechaFin"
                                ErrorMessage="(*) Por favor, seleccione una fecha de fin" Display="Dynamic">
                            </asp:RequiredFieldValidator>
                            <asp:CompareValidator ID="CompareValidatorFechaFin" runat="server"
                                ControlToValidate="txtFechaFin" ErrorMessage="(*) Entre una fecha de fin valida - dd/mm/aaaa"
                                Operator="DataTypeCheck" Type="Date" Display="Dynamic">
                            </asp:CompareValidator>
                            <asp:CompareValidator ID="CompareValidatorFecha" ControlToCompare="txtFechaInicio" ControlToValidate="txtFechaFin"
                                Type="Date" Operator="GreaterThanEqual"
                                ErrorMessage="(*) La fecha de inicio tiene que ser anterior a la fecha de fin" runat="server" Display="Dynamic">
                            </asp:CompareValidator>
                        </div>
                    </div>
                </div>
                <div class="input-field col s12 center-align">
                    <asp:Button ID="btnFiltrar" runat="server" Text="Buscar" ClientIDMode="Static" CssClass="btn" OnClick="btnFiltrar_Click" />
                    <asp:Label ID="lblResultado" runat="server"></asp:Label>
                </div>

                <div class="row">
                    <div class="col s12">
                        <div class="listado-reservas">
                            <div class="row">
                                <% if (CantidadCocherasDisponibles > 0)
                                   { 
                                %>
                                <h3>Se encontraron <%= CantidadCocherasDisponibles %> cocheras disponibles</h3>
                                <%    
                                   }
                                   else
                                   {
                                %>
                                <h3>No se encontraron cocheras disponibles para esta búsqueda</h3>
                                <%
                                   }
                                %>
                                <asp:Repeater runat="server" ID="rResultadoCocherasDisponiblesFiltradas">
                                    <ItemTemplate>
                                        <div class="col s12 m6 l4">
                                            <div class="card">
                                                <div class="card-image waves-effect waves-block waves-light">
                                                    <img class="activator" src="<%# Eval("Imagen") %>">
                                                </div>
                                                <div class="card-content">
                                                    <span class="card-title activator grey-text text-darken-4">Disponible<i class="material-icons right">more_vert</i></span>
                                                    <p>
                                                        <%--<asp:HyperLink ID="HyperLink1" runat="server" ClientIDMode="Static" NavigateUrl="/clientes/confirmar-reserva.aspx?idcochera=123" Click="ConfirmarReserva">Reservar</asp:HyperLink>--%>
                                                        <asp:LinkButton runat="server" ID="HyperLink1" OnClick="ConfirmarReserva">Reservar</asp:LinkButton>
                                                    </p>
                                                </div>
                                                <div class="card-reveal">
                                                    <span class="card-title grey-text text-darken-4">Card Title<i class="material-icons right">close</i></span>
                                                    <%# Eval("NombrePropietario") %>
                                                    <%# Eval("ApellidoPropietario") %>
                                                    <%# Eval("PrecioPorHora") %>
                                                    <%# Eval("Latitud") %>
                                                    <%# Eval("Longitud") %>
                                                </div>
                                            </div>
                                        </div>
                                    </ItemTemplate>
                                </asp:Repeater>
                            </div>
                        </div>
                    </div>
                </div>


                <%--    LISTADO  (gridview, repeater o datalist)
    Por cada disponibilidad se deberá mostrar la siguiente información:
    precio, 
    nombre y 
    apellido del propietario, 
    precio total por las horas que se desean reservar, 
    la foto, 
    el mapa del lugar donde está ubicado (utilizar la API de Google Maps) 
    la puntuación promedio        
    y el link a confirmar reserva que esta agregado abajo como asp:HyperLink, 
        donde deberán cambiarle dinamicamente el link y ponerle el idcochera correspondiente
                --%>
                <div class="input-field col s12">
                </div>
            </div>
        </div>
    </header>
    <%--    <section id="quienes-somos">
        <div class="container">
            <h2>Quienes somos</h2>
            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.</p>
            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.</p>
            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.</p>
        </div>
    </section>--%>

    <script type="text/javascript">
        document.addEventListener("DOMContentLoaded", function () {
            var layoutBase = new LayoutBase();
            layoutBase.cargar();
        });
    </script>

</asp:Content>
