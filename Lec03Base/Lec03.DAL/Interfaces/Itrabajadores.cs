using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lec03.DATA;

namespace Lec03.DAL.Interfaces
{
    public interface Itrabajadores
    {
        List<trabajadores> ListarTrabajadores();
        trabajadores BuscarTrabajadores(int idtrabaj);
        void InsertarTrabajadores(trabajadores trabajadores);
        void ActualizarTrabajadores(trabajadores trabajadores);
        void EliminarTrabajadores(int idtrabaj);
    }
}
