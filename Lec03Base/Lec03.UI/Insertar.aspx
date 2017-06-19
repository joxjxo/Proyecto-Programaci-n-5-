<%@ Page Title="Insertar" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Insertar.aspx.cs" Inherits="Lec03.UI.Insertar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%= DateTime.Now.ToShortDateString() %></h2>
    <div class="form-group">
        <div class="alert alert-success" visible="false" id="mensaje" runat="server">
            <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
            <strong id="textoMensaje" runat="server"></strong>
        </div>
        <div class="alert alert-danger" visible="false" id="mensajeError" runat="server">
            <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
            <strong id="textoMensajeError" runat="server"></strong>
        </div>
        <asp:Label ID="lbNombre" runat="server" Text="Nombre"></asp:Label>
        <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
        <asp:Label ID="lbDescripcion" runat="server" Text="Descripcion"></asp:Label>
        <asp:TextBox ID="txtDescripcion" runat="server" CssClass="form-control"></asp:TextBox>
        <asp:Label ID="lbPrecio" runat="server" Text="Precio"></asp:Label>
        <asp:TextBox ID="txtPrecio" runat="server" CssClass="form-control"></asp:TextBox>
        <asp:Label ID="lbCantidad" runat="server" Text="Cantidad"></asp:Label>
        <asp:TextBox ID="txtCantidad" runat="server" CssClass="form-control"></asp:TextBox>
        <div class="form-inline">
            <asp:Label ID="lbImagen" runat="server" Text="Imagen"></asp:Label>
            <asp:TextBox ID="txtImagen" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:FileUpload ID="fileImagen" runat="server" style="display:none" />
            <input type="button" id="btnAdjuntar" runat="server" value="Adjuntar" class="btn btn-success" onclick="adjuntarImagen()" />
        </div>
        <br />
        <asp:Button ID="btnInsertar" runat="server" Text="Insertar" CssClass="btn btn-primary" OnClick="btnInsertar_Click" />
    </div>
    <script>
        function adjuntarImagen() {
            document.getElementById('MainContent_fileImagen').click();
            document.getElementById('MainContent_txtImagen').readOnly = true;
        }
    </script>

</asp:Content>
