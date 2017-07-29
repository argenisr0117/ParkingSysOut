using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace SistemaParqueoSalida
{
    public class StatusEntrada
    {
        Conexion C = new Conexion();
        public DataTable GetStatusEntrada()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            return dt = C.Listado("getStatusEntrada", lst);
        }
    }
}
