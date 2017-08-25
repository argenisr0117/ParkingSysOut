using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SistemaParqueoSalida
{
    class Usuario
    {
        private Conexion C = new Conexion();

        int Midusuario;
        string Mnombre;
        string Musuario;
        string Mclave;
        int Midtipo;
        bool Mestado;
        int Mvalor;


        public int Idusuario
        {
            get { return Midusuario; }
            set { Midusuario = value; }
        }

        public int Valor
        {
            get { return Mvalor; }
            set { Mvalor = value; }
        }
        public int Idtipo
        {
            get { return Midtipo; }
            set { Midtipo = value; }
        }
        public string Nombre
        {
            get { return Mnombre; }
            set { Mnombre = value; }
        }
        public string User
        {
            get { return Musuario; }
            set { Musuario = value; }
        }
        public string Clave
        {
            get { return Mclave; }
            set { Mclave = value; }
        }

        public bool Estado
        {
            get { return Mestado; }
            set { Mestado = value; }
        }
        public string Registrar()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@nombre", Mnombre));
            lst.Add(new clsParametros("@usuario", Musuario));
            lst.Add(new clsParametros("@clave", Mclave));
            lst.Add(new clsParametros("@idtipo", Midtipo));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            C.EjecutarSP("REG_USUARIO", ref lst);
            mensaje = lst[4].Valor.ToString();
            return mensaje;
        }
        public string Actualizar()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idusuario", Midusuario));
            lst.Add(new clsParametros("@nombre", Mnombre));
            lst.Add(new clsParametros("@usuario", Musuario));
            lst.Add(new clsParametros("@clave", Mclave));
            lst.Add(new clsParametros("@idtipo", Midtipo));
            lst.Add(new clsParametros("@value", Mvalor));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            C.EjecutarSP("UPD_USUARIO", ref lst);
            mensaje = lst[6].Valor.ToString();
            return mensaje;
        }
        public string Activar()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@id", Midusuario));
            lst.Add(new clsParametros("@valor", Mestado));
            lst.Add(new clsParametros("@table", "USUARIO"));
            lst.Add(new clsParametros("@campo", "id_usuario"));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            C.EjecutarSP("ACT_DESCT", ref lst);
            mensaje = lst[4].Valor.ToString();
            return mensaje;
        }
        public DataTable GetUsuario()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@estado", Mestado));
            return dt = C.Listado("GET_USUARIO", lst);
        }
    }
}
