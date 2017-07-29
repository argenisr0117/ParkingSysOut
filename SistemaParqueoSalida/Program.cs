using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaParqueoSalida
{
    static class Program
    {
        public static int Evento;
        public static int id = 0;

        public static bool printerPrinting;
        public static bool printerBusy;
        public static bool printerPaperJammed;
        public static bool printerOutOfPaper;
        public static bool printerDoorOpened;
        public static bool printerOffline;
        public static string printerQuequeStatus;

        public static bool adamOnline;
        public static bool AdamInput1; 
        public static bool AdamInput2; 
        public static bool AdamInput3;
        public static bool AdamInput4;
        public static bool AdamInput5;
        public static bool AdamInput6;
        public static bool AdamInputErrorRead;

        public static bool AdamOutput1; 
        public static bool AdamOutput2;
        public static bool AdamOutput3;
        public static bool AdamOutput4;
        public static bool AdamOutput5;
        public static bool AdamOutput6;
        public static bool AdamOutputErrorRead;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new estacionSalidaMainForm());
        }
    }
}
