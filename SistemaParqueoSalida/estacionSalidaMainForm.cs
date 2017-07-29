using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Advantech.Adam;

namespace SistemaParqueoSalida
{
    public partial class estacionSalidaMainForm : Form
    {
        AdamSocket adam6060 = new AdamSocket();
        AdamDevice adam_func = new AdamDevice();
        public string adamip = Properties.Settings.Default.AdamIp;
        public int adamport = Convert.ToInt16(Properties.Settings.Default.AdamPort);
        PrinterStatus printer = new PrinterStatus();
        UpdateTicket U = new UpdateTicket();
        public static int key = 0;
        public estacionSalidaMainForm()
        {
            InitializeComponent();
        }

        private void readStatusEntrada_timer_Tick(object sender, EventArgs e)
        {
            readStatusEntrada_timer.Enabled = false;
            try
            {
                StatusEntrada SE = new StatusEntrada();
                DataTable dt = new DataTable();
                dt = SE.GetStatusEntrada();
                if (Convert.ToBoolean(dt.Rows[0]["printerOffline"]))
                {
                    statusPrinter_entrada_pic.Image = Properties.Resources.circle_error;
                    toolTip1.SetToolTip(statusPrinter_entrada_pic, "Printer Offline");

                }
                else if (Convert.ToBoolean(dt.Rows[0]["printerPaperJammed"]))
                {
                    statusPrinter_entrada_pic.Image = Properties.Resources.circle_error;
                    toolTip1.SetToolTip(statusPrinter_entrada_pic, "Papel Atascado");

                }

                else if (Convert.ToBoolean(dt.Rows[0]["printerOutOfPaper"]))
                {
                    statusPrinter_entrada_pic.Image = Properties.Resources.circle_error;
                    toolTip1.SetToolTip(statusPrinter_entrada_pic, "Printer sin Papel");

                }

                else if (Convert.ToBoolean(dt.Rows[0]["printerPrinting"]))
                {
                    statusPrinter_entrada_pic.Image = Properties.Resources.circle_ok;
                    toolTip1.SetToolTip(statusPrinter_entrada_pic, "Imprimiendo Ticket");

                }
                else
                {
                    statusPrinter_entrada_pic.Image = Properties.Resources.circle_ok;
                    toolTip1.SetToolTip(statusPrinter_entrada_pic, "Printer Ok");
                }

                if (!Convert.ToBoolean(dt.Rows[0]["adamOnline"]))
                {
                    statusAdamEntrada_pic.Image = Properties.Resources.circle_error;
                    toolTip1.SetToolTip(statusAdamEntrada_pic, "Adam Offline");

                }
                else
                {
                    statusAdamEntrada_pic.Image = Properties.Resources.circle_ok;
                    toolTip1.SetToolTip(statusAdamEntrada_pic, "Adam Online");
                }


                if (Convert.ToBoolean(dt.Rows[0]["adamInput2"]))
                {
                    statusVehiculoEntrada_pic.Image = Properties.Resources.circle_ok;
                    toolTip1.SetToolTip(statusVehiculoEntrada_pic, "Vehículo en ventanilla");

                }
                else
                {
                    statusAdamEntrada_pic.Image = Properties.Resources.circle_error;
                    toolTip1.SetToolTip(statusVehiculoEntrada_pic, "No hay vehículo en ventanilla");
                }
                DateTime horaactual = Convert.ToDateTime(dt.Rows[0]["actualDate"].ToString());
                DateTime horaregistro = Convert.ToDateTime(dt.Rows[0]["updateDate"].ToString());

                TimeSpan duration = horaactual - horaregistro;
                if (duration.TotalMinutes > 1)
                {
                    statusBasedatos_pic.Image = Properties.Resources.circle_error;
                    toolTip1.SetToolTip(statusBasedatos_pic, "Revise Conexión con BaseDatos Entrada");
                }

                else
                {
                    statusBasedatos_pic.Image = Properties.Resources.circle_ok;
                    toolTip1.SetToolTip(statusBasedatos_pic, "Sincronización Ok");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            readStatusEntrada_timer.Enabled = true;
        }

        private void estacionSalidaMainForm_Load(object sender, EventArgs e)
        {
            readStatusEntrada_timer.Enabled = true;
            readStatusEntrada_timer_Tick(1, e);

            readStatusSalida_timer.Enabled = true;
            readStatusSalida_timer_Tick(1, e);
        }

        private void configuraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfiguracionSalidaForm form = new ConfiguracionSalidaForm();
            form.Show();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Program.adamOnline = adam_func.connectAdam(adam6060, adamip, adamport);
        }

        private void readStatusSalida_timer_Tick(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync(); // read adam
            }
            ReadPrinterStatus(); // upadate printer status
        }

        private void ReadPrinterStatus()
        {
            try
            {
                printer.PrinterState(Properties.Settings.Default.DefaultPrinter);  // Actualizar estatus printer

                if (Program.printerOffline)
                {
                    statusPrinterSalida_pic.Image = Properties.Resources.circle_error;
                    toolTip1.SetToolTip(statusPrinterSalida_pic, Properties.Settings.Default.DefaultPrinter + " No está conectado o No es Printer por defecto");


                }

                else if (Program.printerDoorOpened)
                {
                    statusPrinterSalida_pic.Image = Properties.Resources.circle_error;
                    toolTip1.SetToolTip(statusPrinterSalida_pic, "Tapa del Printer Está abierta");
                }

                else if (Program.printerOutOfPaper)
                {
                    statusPrinterSalida_pic.Image = Properties.Resources.circle_error;
                    toolTip1.SetToolTip(statusPrinterSalida_pic, "Printer No tiene Papel");
                }

                else if (Program.printerPaperJammed)
                {
                    statusPrinterSalida_pic.Image = Properties.Resources.circle_error;
                    toolTip1.SetToolTip(statusPrinterSalida_pic, "Papel Atascado");
                }
                else
                {
                    statusPrinterSalida_pic.Image = Properties.Resources.circle_ok;
                    toolTip1.SetToolTip(statusPrinterSalida_pic, "Printer Online");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void readAdamStatus()
        {
            adam_func.AdamInputRead(adam6060);
            adam_func.AdamOutputRead(adam6060);
            if (!Program.adamOnline)
            {

                statusAdamSalida.Image = Properties.Resources.circle_error;
                toolTip1.SetToolTip(statusAdamSalida, "Adam Offline");
            }
            else if (Program.AdamInputErrorRead)
            {

                statusAdamSalida.Image = Properties.Resources.circle_error;
                toolTip1.SetToolTip(statusAdamSalida, "Error al leer Entradas Adam");
            }
            else if (Program.AdamOutputErrorRead)
            {
                statusAdamSalida.Image = Properties.Resources.circle_error;
                toolTip1.SetToolTip(statusAdamSalida, "Error al leer Salidas Adam");
            }
            else if (Program.AdamOutputErrorRead)
            {
                statusAdamSalida.Image = Properties.Resources.circle_error;
                toolTip1.SetToolTip(statusAdamSalida, "Error al leer Salidas Adam");
            }
            else
            {
                statusAdamSalida.Image = Properties.Resources.circle_ok;
                toolTip1.SetToolTip(statusAdamSalida, "Adam OK");
            }
          
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
            readAdamStatus();
        }

        private void txtLecturaTicket_TextChanged(object sender, EventArgs e)
        {
            string barcodetxt = txtLecturaTicket.Text;
            try
            {
                string mensaje = "";
                if (barcodetxt.Length == 14)
                {
                    key = 0;

                    
                    CobroAutomaticoPopUpForm form = new CobroAutomaticoPopUpForm();
                    U.barcode = txtLecturaTicket.Text.Trim();
                    mensaje = U.CheckTicket();
                    if (mensaje == "1")
                    {
                        form.barcode = txtLecturaTicket.Text;
                        form.ShowDialog();
                    }
                    else

                    {
                        disableEnter_timer.Enabled = true;
                        txtLecturaTicket.Clear();
                        txtLecturaTicket.Focus();

                        ////*********identificar si se presiono ENTER o no//////
                        //if (key == 1)
                        //{

                        //    MessageBox.Show("Ticket no existe", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //    txtLecturaTicket.Clear();
                        //    txtLecturaTicket.Focus();
                        //    key = 0;

                        //}
                        //else if (key == 0)
                        //{
                        //    MessageBox.Show("Ticket no existe", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //    txtLecturaTicket.Clear();
                        //    txtLecturaTicket.Focus();
                        //}
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Sistema de Control de Parqueo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Dispose();
                this.Close();
            }
        }

        private void tIEMPOPRECIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            configuracionTiempoPrecioForm obj = new configuracionTiempoPrecioForm();
            obj.ShowDialog();
        }

        

        private void disableEnter_timer_Tick(object sender, EventArgs e)
        {
            disableEnter_timer.Enabled = false;
            MessageBox.Show("Ticket no existe", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
        }

        private void btnTicketM_Click(object sender, EventArgs e)
        {
            TicketManualForm form = new TicketManualForm();
            form.ShowDialog();
        }
    }
}   

