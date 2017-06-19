using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lec03.DATA;

namespace Lec03.DAL.Interfaces
{
    public interface Iproyectos
    {
        List<proyectos>  Listarproyectos();
        proyectos Buscarproyectos(int idp);
        void Insertarproyectos(proyectos proyectos);
        void Actualizarproyectos(proyectos proyectos);
        void Eliminarproyectos(int idp);
    }
}
