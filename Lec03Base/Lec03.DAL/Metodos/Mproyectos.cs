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
            _db.Update(proyectos);
        }

        public proyectos Buscarproyectos(int idp)
        {
            return _db.Select<proyectos>(x => x.IDP == idp).FirstOrDefault(); 
        }

        public void Eliminarproyectos(int idp)
        {
            _db.Delete<proyectos>(x => x.IDP == idp);
        }

        public void Insertarproyectos(proyectos proyectos)
        {
            _db.Insert<proyectos>();
        }

        public List<proyectos> Listarproyectos()
        {
            return _db.Select<proyectos>();
        }
    }
}
