using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lec03.DATA;

namespace Lec03.DAL.Interfaces
{
    public interface Icategoriaacabado
    {
        List<categoriaacabado> ListarCategoriaAcabado();
        categoriaacabado BuscarCategoriaAcabado(int idCatAcab);
        void InsertarCategoriaAcabador(categoriaacabado categoriaacabado);
        void ActualizarCategoriaAcabado(categoriaacabado categoriaacabado);
        void EliminarCategoriaAcabado(int idCatAcab);
    }
}
