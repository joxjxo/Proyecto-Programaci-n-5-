<%@ Page Title="Compras" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Compras.aspx.cs" Inherits="Lec03.UI.Compras" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="alert alert-success" visible="false" id="mensaje" runat="server">
        <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
        <strong id="textoMensaje" runat="server"></strong>
    </div>
    <div class="alert alert-danger" visible="false" id="mensajeError" runat="server">
        <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
        <strong id="textoMensajeError" runat="server"></strong>
    </div>
    <div class="form-group">
        <asp:ListView ID="lvProductos" runat="server"
            GroupItemCount="3"
            ItemType="Lec03.DATA.Producto" DataKeyNames="IdProducto">
            <EmptyDataTemplate>
                <table>
                    <tr>
                        <td>No data was returned.</td>
                    </tr>
                </table>
            </EmptyDataTemplate>
            <EmptyItemTemplate>
                <td />
            </EmptyItemTemplate>
            <GroupTemplate>
                <tr id="itemPlaceholderContainer" runat="server">
                    <td id="itemPlaceholder" runat="server"></td>
                </tr>
            </GroupTemplate>
            <ItemTemplate>
                <td runat="server">
                    <table align="center">
                        <tr>
                            <td>
                                <asp:Image ID="imgProd" runat="server" ImageUrl="<%# Item.Imagen %>" Height="100px" Width="100px" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <%#: Item.Nombre %>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <%#: Item.Precio %>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <%#: Item.Descripcion %>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:TextBox ID="txtCantidad" runat="server" placeholder="Cantidad" CssClass="form-control" OnTextChanged="txtCantidad_TextChanged" ></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="btnComprar" runat="server" Text="Comprar" CssClass="btn btn-primary" OnClick="btnComprar_Click" CommandArgument="<%# Item.IdProducto %>" />
                            </td>
                        </tr>
                    </table>
                    </p>
                </td>
            </ItemTemplate>
            <LayoutTemplate>
                <table style="width: 100%;">
                    <tbody>
                        <tr>
                            <td>
                                <table id="groupPlaceholderContainer" runat="server" style="width: 100%">
                                    <tr id="groupPlaceholder"></tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td></td>
                        </tr>
                        <tr></tr>
                    </tbody>
                </table>
            </LayoutTemplate>
        </asp:ListView>
    </div>
</asp:Content>
