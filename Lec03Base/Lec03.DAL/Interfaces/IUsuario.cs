using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lec03.DATA;

namespace Lec03.DAL.Interfaces
{
    public interface IUsuario
    {
        DATA.Usuario BuscarUsuario(string usuario, string contra);
    }
}
