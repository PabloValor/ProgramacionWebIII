<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Anonimo.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="AlquilaCocheras.Web._default" %>
<%@ Register Src="~/userControls/UCFormularioBusqueda.ascx" TagPrefix="uc" TagName="UCFormularioBusqueda" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder_Head" runat="server">
    <title>EstacionaLo - Home</title>
    <meta name="description" content="Estacionalo es una plataforma donde podes publicar tu cochera cuando quieras, el tiempo que quieras, o también encontrar tu cochera ideal">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder_Principal" runat="server">
    <header id="home-header">
        <div class="contenido">
            <h1 class="logo">Estaciona<span>lo</span></h1>
            <h2>Conseguí cochera o alquilá la que ya tenes</h2>
            <uc:UCFormularioBusqueda runat="server" ID="UCFormularioBusqueda" />
        </div>
    </header>

    <script type="text/javascript">
        document.addEventListener("DOMContentLoaded", function () {
            var layoutBase = new LayoutBase();
            layoutBase.cargar();
        });
    </script>

</asp:Content>
