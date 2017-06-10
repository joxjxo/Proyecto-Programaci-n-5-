using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lec03.DATA;
using Lec03.BLL.Interfaces;

namespace Lec03.BLL.Metodos
{
    public class MProducto : IProducto
    {
        DAL.Interfaces.IProducto prod;

        public MProducto()
        {
            prod = new DAL.Metodos.MProducto();
        }
        public List<Producto> ListarProductos()
        {
            return prod.ListarProductos();
        }

        public Producto BuscarProducto(int idProducto)
        {
            return prod.BuscarProducto(idProducto);
        }

        public void InsertarProducto(Producto producto)
        {
            prod.InsertarProducto(producto);
        }

        public void ActualizarProducto(Producto producto)
        {
            prod.ActualizarProducto(producto);
        }

        public void EliminarProducto(int idProducto)
        {
            prod.EliminarProducto(idProducto);
        }
    }
}
