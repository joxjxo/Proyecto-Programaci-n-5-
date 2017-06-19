using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lec03.DATA;
using Lec03.BLL.Interfaces;

namespace Lec03.BLL.Metodos
{
    public class Mtrabajadoreslogeo : Itrabajadoreslogeo
    {
        DAL.Interfaces.Itrabajadoreslogeo trl;

        public Mtrabajadoreslogeo()
        {
            trl = new DAL.Metodos.Mtrabajadoreslogeo();
        }

        public void ActualizarTrabajadoresLogeo(trabajadoreslogeo trabajadoreslogeo)
        {
            trl.ActualizarTrabajadoresLogeo(trabajadoreslogeo);
        }

        public trabajadoreslogeo BuscarTrabajadoresLogeo(int idtl)
        {
            return trl.BuscarTrabajadoresLogeo(idtl);
        }

        public void EliminarTrabajadoresLogeo(int idtl)
        {
            trl.EliminarTrabajadoresLogeo(idtl);
        }

        public void InsertarTrabajadoresLogeo(trabajadoreslogeo trabajadoreslogeo)
        {
            trl.InsertarTrabajadoresLogeo(trabajadoreslogeo);
        }

        public List<trabajadoreslogeo> ListarTrabajadoresLogeo()
        {
            return trl.ListarTrabajadoresLogeo();
        }
    }
}
