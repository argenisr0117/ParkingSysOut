using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SistemaParqueoSalida
{
    class Login
    {
        private Conexion C = new Conexion();

        string Mnombre;
        string Musuario;
        string Mclave;
        string Mestacion;
        int MidUsuario;



        public string Nombre
        {
            get { return Mnombre; }
            set { Mnombre = value; }
        }

        public string Usuario
        {
            get { return Musuario; }
            set { Musuario = value; }
        }

        public string Clave
        {
            get { return Mclave; }
            set { Mclave = value; }
        }

        public string Estacion
        {
            get { return Mestacion; }
            set { Mestacion = value; }
        }

        public int IdUsuario
        {
            get { return MidUsuario; }
            set { MidUsuario = value; }
        }





        public string TipoLogin()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            C.EjecutarSP("FIRST_LOGIN", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public string[] PrimerLogin()
        {
            string[] mensaje = new string[2];
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@nombre", Mnombre));
            lst.Add(new clsParametros("@usuario", Musuario));
            lst.Add(new clsParametros("@clave", Mclave));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@idUser", "", SqlDbType.Int, ParameterDirection.Output, 50));
            C.EjecutarSP("REG_FIRST_USER", ref lst);
            mensaje[0] = lst[3].Valor.ToString();
            mensaje[1] = lst[4].Valor.ToString();
            return mensaje;
        }

        public string[] UserLogin()
        {
            string[] mensaje = new string[2];
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@usuario", Musuario));
            lst.Add(new clsParametros("@clave", Mclave));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@idUser", "", SqlDbType.Int, ParameterDirection.Output, 50));
            C.EjecutarSP("USER_LOGIN", ref lst);
            mensaje[0] = lst[2].Valor.ToString();
            mensaje[1] = lst[3].Valor.ToString();
            return mensaje;

        }

        public string CheckIfUserOnBreak()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@userId", MidUsuario));
            lst.Add(new clsParametros("@estacion", Mestacion));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            C.EjecutarSP("GET_IF_USER_ON_BREAK", ref lst);
            mensaje = lst[2].Valor.ToString();
            return mensaje;
        }

        public string CloseUserSessionAfterLogin()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idUser", MidUsuario));
            lst.Add(new clsParametros("@estacion", Mestacion));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            C.EjecutarSP("CLOSE_USER_SESSION_AFTER_LOGIN", ref lst);
            mensaje = lst[2].Valor.ToString();
            return mensaje;
        }

        public string UserOnBreak()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@userId", MidUsuario));
            lst.Add(new clsParametros("@estacion", Mestacion));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            C.EjecutarSP("SET_USER_ON_BREAK", ref lst);
            mensaje = lst[2].Valor.ToString();
            return mensaje;
        }

        public string CloseSession()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idUser", MidUsuario));
            lst.Add(new clsParametros("@estacion", Mestacion));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            C.EjecutarSP("CLOSE_SESSION", ref lst);
            mensaje = lst[2].Valor.ToString();
            return mensaje;
        }
    }
}
