using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lec03.DATA;

namespace Lec03.BLL.Interfaces
{
    public interface IUsuario
    {
        Usuario BuscarUsuario(string username, string password);
    }
}
