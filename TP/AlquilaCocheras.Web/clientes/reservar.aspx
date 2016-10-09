<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Clientes.Master" AutoEventWireup="true" CodeBehind="reservar.aspx.cs" Inherits="AlquilaCocheras.Web.clientes.reservar" %>

<%@ Register Src="~/userControls/UCFormularioBusqueda.ascx" TagPrefix="uc" TagName="UCFormularioBusqueda" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder_Head" runat="server">
    <title>Estacionalo | Reservar Cochera</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder_Principal" runat="server">
    <div class="contenido container-padding-top cliente-reservar">
        <h2 class="titulo-pagina center-align">Reservar Cochera</h2>
        <uc:UCFormularioBusqueda runat="server" ID="UCFormularioBusqueda" />
    </div>
</asp:Content>
