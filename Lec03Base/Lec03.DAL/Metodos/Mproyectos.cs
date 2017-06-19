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
    public class Mproyectos : Iproyectos
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;
        public Mproyectos()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion,
                SqlServerDialect.Provider);
            _db = _conexion.Open();
        }
        public void Actualizarproyectos(proyectos proyectos)
        {
            throw new NotImplementedException();
        }

        public proyectos Buscarproyectos(int IDP)
        {
            throw new NotImplementedException();
        }

        public void Eliminarproyectos(int IDP)
        {
            throw new NotImplementedException();
        }

        public void Insertarproyectos(proyectos proyectos)
        {
            throw new NotImplementedException();
        }

        public List<proyectos> Listarproyectos()
        {
            throw new NotImplementedException();
        }
    }
}
