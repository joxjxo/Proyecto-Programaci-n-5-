using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Lec03.DATA;
using Lec03.BLL.Interfaces;
using Lec03.BLL.Metodos;
using System.IO;

namespace Lec03.UI
{
    public partial class Insertar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreArchivo = Path.GetFileName(fileImagen.FileName);
                fileImagen.SaveAs(Server.MapPath("~/Imagenes/") + nombreArchivo);
                Producto producto = new Producto
                {
                    Nombre = txtNombre.Text,
                    Descripcion = txtDescripcion.Text,
                    Precio = Convert.ToDouble(txtPrecio.Text),
                    Cantidad = Convert.ToInt32(txtCantidad.Text),
                    Imagen = "~/Imagenes/" + nombreArchivo
                };
                IProducto prod = new MProducto();
                prod.InsertarProducto(producto);
                MostarMensaje("Producto Insertado");
            }
            catch (Exception)
            {
                MostarMensajeError("Ocurrio un error");
                throw;
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