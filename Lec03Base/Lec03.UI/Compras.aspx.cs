using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Lec03.DATA;
using Lec03.BLL.Interfaces;
using Lec03.BLL.Metodos;

namespace Lec03.UI
{
    public partial class Compras : System.Web.UI.Page
    {
        private int cantidad;
        IProducto prod = new MProducto();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if(!Page.IsPostBack)
                {
                    lvProductos.DataSource = prod.ListarProductos();
                    lvProductos.DataBind();
                }
            }
            catch (Exception)
            {
                MostarMensajeError("Ocurrio un error");
            }
        }

        protected void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            TextBox txtProducto = (TextBox)sender;
            cantidad = Convert.ToInt32(txtProducto.Text);
            txtProducto.Text = string.Empty;
            txtProducto.Focus();
        }

        protected void btnComprar_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = (Button)sender;
                int idProducto = Convert.ToInt32(btn.CommandArgument);
                var producto = prod.BuscarProducto(idProducto);
                int cantidadDisponibles = producto.Cantidad - cantidad;
                if (cantidadDisponibles < 0)
                {
                    MostarMensajeError("Cantidad excede disponible");
                }
                else
                {
                    producto.Cantidad = cantidadDisponibles;
                    prod.ActualizarProducto(producto);
                    MostarMensaje("Producto(s) comprado(s)");
                }
            }
            catch (Exception)
            {
                MostarMensajeError("Ocurrio un error");
            }
        }

        private void MostarMensaje(string texto)
        {
            mensaje.Visible = true;
            mensajeError.Visible = false;
            textoMensajeError.InnerHtml = string.Empty;
            textoMensaje.InnerHtml = texto;
        }

        private void MostarMensajeError(string texto)
        {
            mensaje.Visible = false;
            mensajeError.Visible = true;
            textoMensajeError.InnerHtml = texto;
            textoMensaje.InnerHtml = string.Empty;
        }
    }
}