using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lec03.DATA;

namespace Lec03.DAL.Interfaces
{
    public interface Idatoscotizador
    {
        List<datoscotizador> ListarDatosCotizador();
        datoscotizador BuscarDatosCotizador(int idDatoCoti);
        void InsertarDatoCotizador(datoscotizador datoscotizador);
        void ActualizarDatoCotizador(datoscotizador datoscotizador);
        void EliminarDatosCotizador(int idDatoCoti);
    }
}
