using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SistemaParqueoSalida
{
    class PermisosUsuario
    {
        private Conexion C = new Conexion();

        int MuserId;
        



        public int UserId
        {
            get { return MuserId; }
            set { MuserId= value; }
        }



        
        public DataTable GetPersmissions()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@user_id", MuserId));
            return dt = C.Listado("GET_USER_PERMISSIONS", lst);
        }
    }
}
