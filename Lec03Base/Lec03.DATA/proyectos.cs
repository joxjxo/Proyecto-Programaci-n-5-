using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace Lec03.DATA
{
    
    public class proyectos
    {
        
        public int IDP { get; set; }
        public int EncargadoDeProyecto { get; set; }
        public string archivo_Documentos{ get; set; }
        public string archivos_Planos{ get; set; }
        public int Cotizacion { get; set; }
    }
}
