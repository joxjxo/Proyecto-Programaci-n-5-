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
    public partial class Mantenimiento : System.Web.UI.Page
    {
        Idatoscotizador prod = new Mdatoscotizador();
        protected void Page_Load(object sender, EventArgs e)
        {
            divMantenimiento.Visible = false;
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                var producto = prod.BuscarProducto(Convert.ToInt32(txtIdProducto.Text));
                if (producto != null)
                {
                    txtDescripcion.Text = producto.Descripcion;
                    txtPrecio.Text = producto.Precio.ToString();
                    txtCantidad.Text = producto.Cantidad.ToString();
                    txtImagen.Text = producto.Imagen;
                    txtNombre.Text = producto.Nombre;
                    divMantenimiento.Visible = true;
                    txtIdProducto.Enabled = false;
                }
                else
                {
                    MostarMensajeError("El producto no existe");
                }
            }
            catch (Exception)
            {
                MostarMensajeError("Ocurrio un error");
            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                datoscotizador producto = new datoscotizador
                {
                    IdProducto = Convert.ToInt32(txtIdProducto.Text),
                    Nombre = txtNombre.Text,
                    Descripcion = txtDescripcion.Text,
                    Precio = Convert.ToDouble(txtPrecio.Text),
                    Cantidad = Convert.ToInt32(txtCantidad.Text),
                    Imagen = txtImagen.Text
                };
                Idatoscotizador prod = new Mdatoscotizador();
                prod.ActualizarProducto(producto);
                MostarMensaje("Producto Modificado");
                divMantenimiento.Visible = false;
                txtIdProducto.Enabled= true;
                txtIdProducto.Text = string.Empty;
                txtIdProducto.Focus();
            }
            catch (Exception)
            {
                MostarMensajeError("Ocurrio un error");
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                prod.EliminarProducto(Convert.ToInt32(txtIdProducto.Text));
                MostarMensaje("Producto Eliminado");
                divMantenimiento.Visible = false;
                txtIdProducto.ReadOnly = false;
                txtIdProducto.Text = string.Empty;
                txtIdProducto.Focus();
                txtIdProducto.Enabled = true;
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