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
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Idatoscotizador prod = new Mdatoscotizador();
            List<datoscotizador> listaProductos = prod.ListarProductos();
            var lista = listaProductos.Select(x => new { x.IdProducto, x.Nombre, x.Descripcion, x.Precio, x.Cantidad });
            gvProductos.DataSource = lista;
            gvProductos.DataBind();
        }
    }
}