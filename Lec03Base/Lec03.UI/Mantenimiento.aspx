<%@ Page Title="Mantenimiento" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Mantenimiento.aspx.cs" Inherits="Lec03.UI.Mantenimiento" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<h2><%= DateTime.Now.ToShortDateString() %></h2>
    <div class="form-inline">
        <div class="alert alert-success" visible="false" id="mensaje" runat="server">
            <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
            <strong id="textoMensaje" runat="server"></strong>
        </div>
        <div class="alert alert-danger" visible="false" id="mensajeError" runat="server">
            <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
            <strong id="textoMensajeError" runat="server"></strong>
        </div>
        <asp:Label ID="lbIdProducto" runat="server" Text="IdProducto: "></asp:Label>
        <asp:TextBox ID="txtIdProducto" runat="server" CssClass="form-control"></asp:TextBox>
        <asp:Button ID="btnBuscar" runat="server" Text="Buscar" CssClass="btn btn-primary" OnClick="btnBuscar_Click" />
    </div>
    <div class="form-group" id="divMantenimiento" runat="server" visible="false">
        <asp:Label ID="lbNombre" runat="server" Text="Nombre"></asp:Label>
        <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
        <asp:Label ID="lbDescripcion" runat="server" Text="Descripcion"></asp:Label>
        <asp:TextBox ID="txtDescripcion" runat="server" CssClass="form-control"></asp:TextBox>
        <asp:Label ID="lbPrecio" runat="server" Text="Precio"></asp:Label>
        <asp:TextBox ID="txtPrecio" runat="server" CssClass="form-control"></asp:TextBox>
        <asp:Label ID="lbCantidad" runat="server" Text="Cantidad"></asp:Label>
        <asp:TextBox ID="txtCantidad" runat="server" CssClass="form-control"></asp:TextBox>
        <asp:Label ID="lbImagen" runat="server" Text="Imagen"></asp:Label>
        <asp:TextBox ID="txtImagen" runat="server" CssClass="form-control"></asp:TextBox>
        <div class="form-horizontal">
            <br />
            <asp:Button ID="btnModificar" runat="server" Text="Modificar" CssClass="btn btn-warning" OnClick="btnModificar_Click" />
            <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger" OnClick="btnEliminar_Click" />
        </div>
    </div>
</asp:Content>
