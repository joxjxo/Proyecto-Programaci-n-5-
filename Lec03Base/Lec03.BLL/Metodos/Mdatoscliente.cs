using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lec03.DATA;
using Lec03.BLL.Interfaces;

namespace Lec03.BLL.Metodos
{
    public class Mdatoscliente : Idatosclientecs
    {
        DAL.Interfaces.Idatoscliente dc;

        public Mdatoscliente()
        {
            dc = new DAL.Metodos.Mdatoscliente();
        }

        public void ActualizarDatosCliente(datoscliente datoscliente)
        {
            dc.ActualizarDatosCliente(datoscliente);
        }

        public datoscliente BuscarDatosCliente(int idDatosClien)
        {
           return dc.BuscarDatosCliente(idDatosClien);
        }

        public void EliminarDatosCliente(int idDatosClien)
        {
            dc.EliminarDatosCliente(idDatosClien);
        }

        public void InsertarDatosClienter(datoscliente datoscliente)
        {
            dc.InsertarDatosClienter(datoscliente);
        }

        public List<datoscliente> ListarDatosCliente()
        {
            return dc.ListarDatosCliente();
        }
    }
}
