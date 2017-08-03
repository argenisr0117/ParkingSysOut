using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SistemaParqueoSalida
{
    class Settings
    {
        private Conexion C = new Conexion();

        string MentSal;
        string MdefaultPrinter;
        bool MbyPassLoop;
        bool MbyPassBrazo;
        bool MbyPassAdam;
        string MadamIp;
        int MadamPort;
        string MestacionNombre;
        string MestacionNumero;
        string MestacionAnterior;

       

        public string EntSal
        {
            get { return MentSal; }
            set { MentSal = value; }
        }
        public string defaultprinter
        {
            get { return MdefaultPrinter; }
            set { MdefaultPrinter = value; }
        }

        public bool byPassloop
        {
            get { return MbyPassLoop; }
            set { MbyPassLoop = value; }
        }

        public bool byPassBrazo
        {
            get { return MbyPassBrazo; }
            set { MbyPassBrazo = value; }
        }

        public bool byPassAdam
        {
            get { return MbyPassAdam; }
            set { MbyPassAdam = value; }
        }

        public string adamIp
        {
            get { return MadamIp; }
            set { MadamIp = value; }
        }

        public int adamPort
        {
            get { return MadamPort; }
            set { MadamPort = value; }
        }
        public string estacionNombre
        {
            get { return MestacionNombre; }
            set { MestacionNombre = value; }
        }

        public string estacionNumero
        {
            get { return MestacionNumero; }
            set { MestacionNumero = value; }
        }

        public string estacionAnterior
        {
            get { return MestacionAnterior; }
            set { MestacionAnterior = value; }
        }


        public bool SaveSettings()
        {
            
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.Bit, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@entrada_salida",MentSal));
            lst.Add(new clsParametros("@defaultPrinter", MdefaultPrinter));
            lst.Add(new clsParametros("@bypassAdam", MbyPassAdam));
            lst.Add(new clsParametros("@byPassLoop", MbyPassLoop));
            lst.Add(new clsParametros("@bypassBrazo", MbyPassBrazo));
            lst.Add(new clsParametros("@adamIp", MadamIp));
            lst.Add(new clsParametros("@adamPort", MadamPort));
            lst.Add(new clsParametros("@estacionNombre", MestacionNombre));
            lst.Add(new clsParametros("@estacionNumero", MestacionNumero));
            lst.Add(new clsParametros("@estacionAnterior", MestacionAnterior));
            
            C.EjecutarSP("SAVE_SETTINGS", ref lst);
            bool mensaje = Convert.ToBoolean(lst[0].Valor);
            return mensaje;
        }
        public void GetSettings()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@estacion", MestacionNumero));
            lst.Add(new clsParametros("@entrada_salida", MentSal));
            dt = C.Listado("GET_SETTINGS", lst);
            Program.defaultprinter = dt.Rows[0]["defaultPrinter"].ToString();
            Program.byPassLoopSalida = Convert.ToBoolean(dt.Rows[0]["byPassLoopSalida"]);
            Program.byPassAdam = Convert.ToBoolean(dt.Rows[0]["byPassAdam"]);
            Program.AdamIp = dt.Rows[0]["AdamIp"].ToString();
            Program.AdamPort = Convert.ToInt16(dt.Rows[0]["AdamPort"]);
            Program.EstacionNombre = dt.Rows[0]["EstacionNombre"].ToString();
            Program.EstacionNumero = dt.Rows[0]["EstacionNumero"].ToString();
            Properties.Settings.Default.Estacion = Program.EstacionNumero;
            Program.SuperUserPass = dt.Rows[0]["SuperUserPass"].ToString();
        }
    }
}
