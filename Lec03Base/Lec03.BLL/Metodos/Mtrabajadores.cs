using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lec03.DATA;
using Lec03.BLL.Interfaces;

namespace Lec03.BLL.Metodos
{
    public class Mtrabajadores : Itrabajadores
    {
        DAL.Interfaces.Itrabajadores tr;

        public Mtrabajadores()
        {
            tr = new DAL.Metodos.Mtrabajadores();
        }

        public void ActualizarTrabajadores(trabajadores trabajadores)
        {
            tr.ActualizarTrabajadores(trabajadores);
        }

        public trabajadores BuscarTrabajadores(int idtrabaj)
        {
            return tr.BuscarTrabajadores(idtrabaj);
        }

        public void EliminarTrabajadores(int idtrabaj)
        {
            tr.EliminarTrabajadores(idtrabaj);
        }

        public void InsertarTrabajadores(trabajadores trabajadores)
        {
            tr.InsertarTrabajadores(trabajadores);
        }

        public List<trabajadores> ListarTrabajadores()
        {
            return tr.ListarTrabajadores();
        }
    }
}
