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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Icategoriaacabado usu = new Mcategoriaacabado();
                var usuario = usu.BuscarUsuario(txtUsuario.Text, Encriptacion.Encriptar(txtContra.Text));
                if (usuario != null)
                {
                    Response.Redirect("Compras.aspx");
                }
                else
                {
                    MostarMensajeError("Usuario o contra incorrecto");
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