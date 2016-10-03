<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Clientes.Master" AutoEventWireup="true" CodeBehind="confirmar-reserva.aspx.cs" Inherits="AlquilaCocheras.Web.clientes.confirmar_reserva" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder_Head" runat="server">
    <title>Estacionalo | Confirmación de Reserva</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder_Principal" runat="server">
    <div class="container">
        <h2 class="titulo-pagina">Confirmación de reserva</h2>

        <asp:Label ID="label2" runat="server" Text="Fecha Inicio"></asp:Label>
        <asp:TextBox ID="txtFechaInicio" runat="server" ClientIDMode="Static" Text="05/10/2016"></asp:TextBox>

        <asp:Label ID="label4" runat="server" Text="Fecha Fin"></asp:Label>
        <asp:TextBox ID="txtFechaFin" runat="server" ClientIDMode="Static" Text="07/10/2016"></asp:TextBox>

        <asp:Label ID="label3" runat="server" Text="Hora de Entrada"></asp:Label>
        <asp:TextBox ID="txtHorarioInicio" runat="server" ClientIDMode="Static" Text="13:40"></asp:TextBox>

        <asp:Label ID="label1" runat="server" Text="Hora de Salida"></asp:Label>
        <asp:TextBox ID="txtHorarioFin" runat="server" ClientIDMode="Static" Text="10:00"></asp:TextBox>

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
