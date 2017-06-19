using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lec03.DATA;
using Lec03.BLL.Interfaces;

namespace Lec03.BLL.Metodos
{
    public class Mroll : Iroll
    {
        DAL.Interfaces.Iroll ro;

        public Mroll()
        {
            ro = new DAL.Metodos.Mroll();
        }

        public void ActualizarRoll(roll roll)
        {
            ro.ActualizarRoll(roll);
        }

        public roll BuscarRoll(int idroll)
        {
            return ro.BuscarRoll(idroll);
        }

        public void EliminarRoll(int idroll)
        {
            ro.EliminarRoll(idroll);
        }

        public void InsertarRoll(roll roll)
        {
            ro.InsertarRoll(roll);
        }

        public List<roll> ListarRoll()
        {
            return ro.ListarRoll();
        }
    }
}
