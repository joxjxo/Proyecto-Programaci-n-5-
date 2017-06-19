using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lec03.DATA;

namespace Lec03.BLL.Interfaces
{
    public interface Iroll
    {
        List<roll> ListarRoll();
        roll BuscarRoll(int idroll);
        void InsertarRoll(roll roll);
        void ActualizarRoll(roll roll);
        void EliminarRoll(int idroll);
    }
}
