using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lec03.DATA;

namespace Lec03.DAL.Interfaces
{
    public interface Itrabajadoreslogeo
    {
        List<trabajadoreslogeo> ListarTrabajadoresLogeo();
        trabajadoreslogeo BuscarTrabajadoresLogeo(int idtl);
        void InsertarTrabajadoresLogeo(trabajadoreslogeo trabajadoreslogeo);
        void ActualizarTrabajadoresLogeo(trabajadoreslogeo trabajadoreslogeo);
        void EliminarTrabajadoresLogeo(int idtl);
    }
}
