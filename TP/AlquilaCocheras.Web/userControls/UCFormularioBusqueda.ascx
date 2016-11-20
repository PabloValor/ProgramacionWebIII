<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCFormularioBusqueda.ascx.cs" Inherits="AlquilaCocheras.Web.userControls.UCFormularioBusqueda" %>

<div class="container" id="form-buscador-servicio">
    <div class="row">
        <div class="input-field col s12">
            <i class="material-icons prefix">pin_drop</i>
            <asp:TextBox ID="txtUbicacion" runat="server" ClientIDMode="Static"></asp:TextBox>
            <label for="txtUbicacion">Ubicación</label>
        </div>

        <div class="mensaje-error-validacion">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1"
                runat="server" ControlToValidate="txtUbicacion"
                ErrorMessage="(*) Por favor, seleccione una ubicación" ValidationGroup="1">
            </asp:RequiredFieldValidator>
        </div>

        <div class="input-field col s12 m6">
            <i class="material-icons prefix">date_range</i>
            <asp:TextBox ID="txtFechaInicio" runat="server" ClientIDMode="Static" CssClass="fecha"></asp:TextBox>
            <label for="txtFechaInicio">Período de inicio</label>

            <div class="mensaje-error-validacion">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2"
                    runat="server" ControlToValidate="txtFechaInicio"
                    ErrorMessage="(*) Por favor, seleccione una fecha de inicio" Display="Dynamic" ValidationGroup="1">
                </asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CompareValidatorFechaInicio" runat="server"
                    ControlToValidate="txtFechaInicio" ErrorMessage="(*) Entre una fecha de inicio valida - dd/mm/aaaa"
                    Operator="DataTypeCheck" Type="Date" Display="Dynamic" ValidationGroup="1">
                </asp:CompareValidator>
            </div>
        </div>

        <div class="input-field col s12 m6">
            <i class="material-icons prefix">date_range</i>
            <asp:TextBox ID="txtFechaFin" runat="server" ClientIDMode="Static" CssClass="fecha"></asp:TextBox>
            <label for="txtFechaFin">Período de fin</label>

            <div class="mensaje-error-validacion">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3"
                    runat="server" ControlToValidate="txtFechaFin"
                    ErrorMessage="(*) Por favor, seleccione una fecha de fin" Display="Dynamic" ValidationGroup="1">
                </asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CompareValidatorFechaFin" runat="server"
                    ControlToValidate="txtFechaFin" ErrorMessage="(*) Entre una fecha de fin valida - dd/mm/aaaa"
                    Operator="DataTypeCheck" Type="Date" Display="Dynamic" ValidationGroup="1">
                </asp:CompareValidator>
                <asp:CompareValidator ID="CompareValidatorFecha" ControlToCompare="txtFechaInicio" ControlToValidate="txtFechaFin"
                    Type="Date" Operator="GreaterThanEqual"
                    ErrorMessage="(*) La fecha de inicio tiene que ser anterior a la fecha de fin" runat="server" Display="Dynamic" ValidationGroup="1">
                </asp:CompareValidator>
            </div>
        </div>
    </div>
    <div class="input-field col s12 center-align">
        <asp:Button ID="btnFiltrar" runat="server" Text="Buscar" ClientIDMode="Static" ValidationGroup="1" CssClass="waves-effect waves-light btn-large " OnClick="btnFiltrar_Click" />
        <asp:Label ID="lblResultado" runat="server"></asp:Label>
    </div>

    <div class="row">
        <div class="col s12">
            <div class="listado-reservas">
                <div class="row">
                    <h3 class="center-align"><asp:Label runat="server" ID="CantidadCocherasDisponibles" ClientIDMode="Static"></asp:Label></h3>

                    <asp:Repeater runat="server" ID="rResultadoCocherasDisponiblesFiltradas">
                        <ItemTemplate>
                            <div class="col s12 m6 l4">
                                <div class="card cochera <%# (bool)Eval("NoDisponible") ? "no-disponible" : "" %>">
                                    <div class="card-image waves-effect waves-block waves-light">
                                        <img class="activator" src="<%# Eval("Imagen") ?? "/assets/img/cocheras/default.png" %>">
                                    </div>
                                    <div class="card-content">
                                        <p class="center-align">
                                            <a href="#!" class="activator">Ver info de cochera &raquo;</a>
                                        </p>
                                    </div>
                                    <div class="card-reveal">
                                        <span class="card-title grey-text text-darken-4"><i class="material-icons right">close</i></span>
                                        <br />
                                        <div class="fila-dato">
                                            <div class="cabecera">Ubicación</div>
                                            <div class="dato center-align"><%# Eval("Ubicacion") %></div>
                                        </div>
                                        <div class="fila-dato">
                                            <div class="cabecera">Propietario</div>
                                            <div class="dato center-align"><%# Eval("NombrePropietario") %> <%# Eval("ApellidoPropietario") %></div>
                                        </div>
                                        <div class="fila-dato">
                                            <div class="cabecera">Precio por hora</div>
                                            <div class="dato center-align"><%# Eval("PrecioPorHora", "${0}") %></div>
                                        </div>
                                        <div class="fila-dato">
                                            <div class="cabecera">Puntaje promedio</div>
                                            <div class="dato center-align"><%# Eval("PuntajePromedioCochera") %></div>
                                        </div>

                                        <p class="center-align botones">
                                            <a class="waves-effect waves-light btn modal-trigger btn-modal-mapa" href="#modal1"
                                                data-latitud="<%# Eval("Latitud") %>"
                                                data-longitud="<%# Eval("Longitud") %>">Ver mapa</a>
                                            <span class="<%# (bool) Eval("NoDisponible") ? "hide" : "" %>">
                                                <asp:HyperLink CssClass="btn blue white-text margin-top-5" ID="HyperLink1" runat="server" ClientIDMode="Static" NavigateUrl='<%# Eval("IdCochera","~/clientes/confirmar-reserva.aspx?idcochera={0}") %>'>Reservar</asp:HyperLink>
                                            </span>
                                        </p>
                                    </div>
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
        </div>
    </div>
</div>

<!-- Modal -->
<div id="modal1" class="modal">
    <div class="modal-content">
        <div id="modal-mapa-contenedor"></div>
    </div>
</div>
<!-- Fin Modal -->

<script type="text/javascript">
    document.addEventListener("DOMContentLoaded", function () {
        var mapas = new Mapas();
        mapas.cargar();
    });
</script>
