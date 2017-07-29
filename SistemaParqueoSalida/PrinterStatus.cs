using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Printing;

namespace SistemaParqueoSalida
{
    class PrinterStatus
    {
        public void PrinterState(string printerName)
        {

            var server = new LocalPrintServer();


            PrintQueue queue = server.DefaultPrintQueue;
            

            if (queue.FullName.ToString() == printerName)
            {
                Program.printerOffline = queue.IsOffline;
                Program.printerOutOfPaper = queue.IsOutOfPaper;
                Program.printerPaperJammed = queue.IsPaperJammed;
                Program.printerQuequeStatus = queue.QueueStatus.ToString();
                Program.printerDoorOpened = queue.IsDoorOpened;
                Program.printerPrinting = queue.IsPrinting;
            }

            else
            {
                Program.printerOffline = true;
            }
        }

    }
}
