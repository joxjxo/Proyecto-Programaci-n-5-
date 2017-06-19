using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lec03.DATA;
using Lec03.DAL.Interfaces;
using System.Data;
using ServiceStack.OrmLite;

namespace Lec03.DAL.Metodos
{
    public class MUsuario : IUsuario
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;
        public MUsuario()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion,
                SqlServerDialect.Provider);
            _db = _conexion.Open();
        }
        public Usuario BuscarUsuario(string usuario, string contra)
        {
            return _db.Select<Usuario>(x => x.Username == usuario && x.Password == contra).FirstOrDefault();
        }
    }
}
