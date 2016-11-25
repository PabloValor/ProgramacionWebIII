<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Clientes.Master" AutoEventWireup="true" CodeBehind="reservas.aspx.cs" Inherits="AlquilaCocheras.Web.clientes.reservas" %>

<%@ MasterType VirtualPath="../MasterPages/Clientes.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder_Head" runat="server">
    <title>Estacionalo | Mis Reservas</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder_Principal" runat="server">
    <div class="container container-padding-top">
        <h2 class="titulo-pagina center-align">Mis Reservas</h2>

        <div class="row">
            <asp:Repeater runat="server" ID="rpReservas">
                <ItemTemplate>
                    <div class="col s12 m6 l4">
                        <div class="card <%# (bool)Eval("EsReservaYaUtilizada") ? "reserva-utilizada" : ""%>">
                            <div class="card-content">
                                <p>Ubicacion: <%# Eval("Ubicacion") %></p>
                                <p>Fecha Inicio: <%# Eval("FechaInicio") %></p>
                                <p>Fecha Fin: <%# Eval("FechaFin") %></p>
                                <p>Horario Inicio: <%# Eval("HorarioInicio") %></p>
                                <p>Horario Fin: <%# Eval("HorarioFin") %></p>
                                <p>Precio Final: $<%# Eval("PrecioFinal") %></p>
                                <p>Puntuación Promedio: <%# Eval("Puntuacion") %></p>
                                <br />
                                <p class="center-align">
                                    <a href="#modal-puntuacion" class="btn blue white-text modal-trigger btn-reserva <%# (bool)Eval("EsReservaYaUtilizada") ? "" : "hide"%>" data-idreserva="<%# Eval("IdReserva") %>">Puntuar</a>
                                </p>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>

    <!-- Modal -->
    <div id="modal-puntuacion" class="modal">
        <div class="modal-content">
            <h3 class="center-align">Puntuación de cochera</h3>

            <asp:HiddenField ID="hdIdReserva" ClientIDMode="Static" runat="server"/>
            <div class="input-field col s12">
                <asp:DropDownList runat="server" ID="ddlPuntuacion" ClientIDMode="Static">
                    <asp:ListItem Text="1" Value="1" />
                    <asp:ListItem Text="2" Value="2" />
                    <asp:ListItem Text="3" Value="3" />
                    <asp:ListItem Text="4" Value="4" />
                    <asp:ListItem Text="5" Value="5" />
                </asp:DropDownList>
            </div>
            <p class="center-align">
                <asp:Button Text="Confirmar" runat="server" ID="btnConfirmarPuntuacion" ClientIDMode="Static" CssClass="btn blue white-text" OnClick="btnConfirmarPuntuacion_Click"/>
            </p>
        </div>
    </div>
    <!-- Fin Modal -->
</asp:Content>
