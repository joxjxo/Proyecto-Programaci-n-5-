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
    public class Mcategoriaacabado : Icategoriaacabado
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;
        public Mcategoriaacabado()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion,
                SqlServerDialect.Provider);
            _db = _conexion.Open();
        }

        public void ActualizarCategoriaAcabado(categoriaacabado categoriaacabado)
        {
            _db.Update<categoriaacabado>();
        }

        public categoriaacabado BuscarCategoriaAcabado(int idCatAcab)
        {
            return _db.Select<categoriaacabado>(x => x.IDAcabado== idCatAcab).FirstOrDefault();
        }

        public void EliminarCategoriaAcabado(int idCatAcab)
        {
            _db.Delete<categoriaacabado>(x => x.IDAcabado == idCatAcab);
        }

        public void InsertarCategoriaAcabador(categoriaacabado categoriaacabado)
        {
            _db.Insert<categoriaacabado>();
        }

        public List<categoriaacabado> ListarCategoriaAcabado()
        {
            return _db.Select<categoriaacabado>();
        }
    }
}
