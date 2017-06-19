using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lec03.DATA;
using Lec03.DAL.Interfaces;
using ServiceStack.OrmLite;
using System.Data;

namespace Lec03.DAL.Metodos
{
    public class Mroll : Iroll
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;
        public Mroll()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion,
                SqlServerDialect.Provider);
            _db = _conexion.Open();
        }

        public void ActualizarRoll(roll roll)
        {
            _db.Update(roll);
        }

        public roll BuscarRoll(int idroll)
        {
            return _db.Select<roll>(x => x.IDR == idroll).FirstOrDefault();
        }

        public void EliminarRoll(int idroll)
        {
            _db.Delete<roll>(x => x.IDR == idroll);
        }

        public void InsertarRoll(roll roll)
        {
            _db.Insert<roll>();
        }

        public List<roll> ListarRoll()
        {
            return _db.Select<roll>();
        }
    }
}
