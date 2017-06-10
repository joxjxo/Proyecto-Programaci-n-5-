using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lec03.DATA;
using Lec03.BLL.Interfaces;

namespace Lec03.BLL.Metodos
{
    public class MUsuario : IUsuario
    {
        DAL.Interfaces.IUsuario usu;
        public MUsuario()
        {
            usu = new DAL.Metodos.MUsuario();
        }

        public Usuario BuscarUsuario(string username, string password)
        {
            return usu.BuscarUsuario(username, password);
        }
    }
}
