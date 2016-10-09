<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Clientes.Master" AutoEventWireup="true" CodeBehind="reservas.aspx.cs" Inherits="AlquilaCocheras.Web.clientes.reservas" %>

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
                        <div class="card <%# Eval("EsReservaYaUtilizada") %>">
                            <div class="card-content">
                                <p>Fecha Inicio: <%# Eval("FechaInicio") %></p>
                                <p>Fecha Fin: <%# Eval("FechaFin") %></p>
                                <p>Horario: <%# Eval("Horario") %></p>
                                <p>Precio Final: <%# Eval("PrecioFinal") %></p>
                                <p>Puntuación: <%# Eval("Puntuacion") %></p>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
    <%--    LISTADO DE RESERVAS (gridview, repeater o datalist)
        
            fecha inicio.
            fecha fin
            horario
            precio total.
            puntuación 
        
    --%>
    <asp:HyperLink ID="aConfirmar" runat="server" ClientIDMode="Static" NavigateUrl="/clientes/confirmar-reserva.aspx?idcochera=123">Reservar</asp:HyperLink>


    <!-- Modal -->
    <div id="miModal" class="modal">
        <!-- Contenido Modal -->
        <div class="modal-content">
            <span class="close">x</span>
            <div>
                <%--hidden donde se guarda el id de la reserva elegida para que desde el codebehind se pueda identificar--%>
                <input type="hidden" id="hdIdReserva" />
                <asp:DropDownList runat="server" ID="ddlPuntuacion" ClientIDMode="Static">
                    <asp:ListItem Text="1" Value="1" />
                    <asp:ListItem Text="2" Value="2" />
                    <asp:ListItem Text="3" Value="3" />
                    <asp:ListItem Text="4" Value="4" />
                    <asp:ListItem Text="5" Value="5" />
                </asp:DropDownList>

                <asp:Button Text="Confirmar" runat="server" ID="btnConfirmar" ClientIDMode="Static" />
                <button class="cerrar">Cerrar</button>
            </div>
        </div>
    </div>
</asp:Content>
