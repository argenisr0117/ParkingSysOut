using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SistemaParqueoSalida
{
    class UpdateTicket
    {
        private Conexion C = new Conexion();

        DateTime MfechaSalida;
        DateTime MhoraSalida;
        string Mbarcode;
        float Mmonto;
        int Mtiempo;
        int MidUsuario;
        string MestacionSal;
        string Mnombre;
        string Mcedula;
        string Mplaca;
        int Midlog;

        public DateTime fechaSalida
        {
            get { return MfechaSalida; }
            set { MfechaSalida = value; }
        }
        public DateTime horaSalida
        {
            get { return MhoraSalida; }
            set { MhoraSalida = value; }
        }

        public string barcode
        {
            get { return Mbarcode; }
            set { Mbarcode = value; }
        }

        public float monto
        {
            get { return Mmonto; }
            set { Mmonto = value; }
        }

        public int tiempo
        {
            get { return Mtiempo; }
            set { Mtiempo = value; }
        }

        public int idUsuario
        {
            get { return MidUsuario; }
            set { MidUsuario = value; }
        }

        public int Idlog
        {
            get { return Midlog; }
            set { Midlog = value; }
        }

        public string estacionSal
        {
            get { return MestacionSal; }
            set { MestacionSal = value; }
        }
        public string Nombre
        {
            get { return Mnombre; }
            set { Mnombre = value; }
        }
        public string Cedula
        {
            get { return Mcedula; }
            set { Mcedula = value; }
        }
        public string Placa
        {
            get { return Mplaca; }
            set { Mplaca = value; }
        }
        public void UpdateTicketToDB()
        {
            //string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@fechasal", MfechaSalida));
            lst.Add(new clsParametros("@horasal", MhoraSalida));
            lst.Add(new clsParametros("@barcode", Mbarcode));
            lst.Add(new clsParametros("@monto", Mmonto));
            lst.Add(new clsParametros("@tiempo", Mtiempo));
            lst.Add(new clsParametros("@idusuario", MidUsuario));
            lst.Add(new clsParametros("@estacion", MestacionSal));
            lst.Add(new clsParametros("@idlog", Midlog));

            //lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            C.EjecutarSP("UPD_TICKET", ref lst);
            //mensaje = lst[2].Valor.ToString();
            //return mensaje;
        }
        public void RegLostTicket()
        {
            //string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@nombre", Mnombre));
            lst.Add(new clsParametros("@cedula", Mcedula));
            lst.Add(new clsParametros("@monto", Mmonto));
            lst.Add(new clsParametros("@iduser", MidUsuario));
            lst.Add(new clsParametros("@estacion", MestacionSal));
            lst.Add(new clsParametros("@idturno", Midlog));
            lst.Add(new clsParametros("@placa", Mplaca));
            //lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            C.EjecutarSP("REG_LOST_TICKET", ref lst);
            //mensaje = lst[2].Valor.ToString();
            //return mensaje;
        }
        public string CheckTicket()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@barcode", Mbarcode));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 1));
            C.EjecutarSP("CHECK_TICKET", ref lst);
            mensaje = lst[1].Valor.ToString();
            return mensaje;
        }
    }
}
