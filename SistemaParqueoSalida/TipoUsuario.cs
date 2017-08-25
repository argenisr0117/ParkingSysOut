using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SistemaParqueoSalida
{
    class TipoUsuario
    {
        private Conexion C = new Conexion();

        int MidTipo;
        string Mdescripcion;
        bool MentradaStatus;
        bool McerrarEntrada;
        bool MtiempoPrecio;
        bool MticketPerdido;
        bool MticketManual;
        bool MgenerarReportes;
        bool MagregarUsuario;
        bool MsalirSalida;

        public int idTipo
        {
            get { return MidTipo; }
            set { MidTipo = value; }
        }

        public string Descripcion
        {
            get { return Mdescripcion; }
            set { Mdescripcion = value; }
        }
        public bool entradaStatus
        {
            get { return MentradaStatus; }
            set { MentradaStatus = value; }
        }

        public bool cerrarEntrada
        {
            get { return McerrarEntrada; }
            set { McerrarEntrada = value; }
        }

        public bool tiempoPrecio
        {
            get { return MtiempoPrecio; }
            set { MtiempoPrecio = value; }
        }

        public bool ticketPerdido
        {
            get { return MticketPerdido; }
            set { MticketPerdido = value; }
        }

        public bool ticketManual
        {
            get { return MticketManual; }
            set { MticketManual = value; }
        }

        public bool generarReportes
        {
            get { return MgenerarReportes; }
            set { MgenerarReportes = value; }
        }

        public bool salirSalida
        {
            get { return MsalirSalida; }
            set { MsalirSalida = value; }
        }

        public bool agregarUsuario
        {
            get { return MagregarUsuario; }
            set { MagregarUsuario = value; }
        }

        public string Registrar()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@description", Mdescripcion));
            lst.Add(new clsParametros("@men_ent_status", MentradaStatus));
            lst.Add(new clsParametros("@men_ent_salir", McerrarEntrada));
            lst.Add(new clsParametros("@men_tiempo_precio", MtiempoPrecio));
            lst.Add(new clsParametros("@men_sal_salir", MsalirSalida));
            lst.Add(new clsParametros("@ticket_perdido", MticketPerdido));
            lst.Add(new clsParametros("@ticket_manual", MticketManual));
            lst.Add(new clsParametros("@reportes", MgenerarReportes));
            lst.Add(new clsParametros("@agregar_usuario", MagregarUsuario));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            C.EjecutarSP("REG_TIPO_USUARIO", ref lst);
            mensaje = lst[9].Valor.ToString();
            return mensaje;
        }
        public string Actualizar()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@id", MidTipo));
            lst.Add(new clsParametros("@description", Mdescripcion));
            lst.Add(new clsParametros("@men_ent_status", MentradaStatus));
            lst.Add(new clsParametros("@men_ent_salir", McerrarEntrada));
            lst.Add(new clsParametros("@men_tiempo_precio", MtiempoPrecio));
            lst.Add(new clsParametros("@men_sal_salir", MsalirSalida));
            lst.Add(new clsParametros("@ticket_perdido", MticketPerdido));
            lst.Add(new clsParametros("@ticket_manual", MticketManual));
            lst.Add(new clsParametros("@reportes", MgenerarReportes));
            lst.Add(new clsParametros("@agregar_usuario", MagregarUsuario));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            C.EjecutarSP("UPD_TIPO_USUARIO", ref lst);
            mensaje = lst[10].Valor.ToString();
            return mensaje;
        }
        public DataTable GetTipoUsuario()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            return dt = C.Listado("GET_TIPO_USUARIO", lst);
        }
    }
}
