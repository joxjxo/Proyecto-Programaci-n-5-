using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace Lec03.DATA
{
    
    public class datoscotizador
    {
        
        public int IDD { get; set; }
        public int CantidadDeCuartos { get; set; }
        public int CantidadDeBaños { get; set; }
        public int acabado { get; set; }
        public int plantas { get; set; }
        
    }
}
