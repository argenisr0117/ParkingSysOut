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
        public string adamip = Program.AdamIp;
        public int adamport =  Program.AdamPort ;
        ChooseInputOuputAdam IO = new ChooseInputOuputAdam();
        PrinterStatus printer = new PrinterStatus();
        UpdateTicket U = new UpdateTicket();
        Login L = new Login();
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

                else if (Convert.ToBoolean(dt.Rows[0]["printerError"]))
                {
                    statusPrinter_entrada_pic.Image = Properties.Resources.circle_error;
                    toolTip1.SetToolTip(statusPrinter_entrada_pic, "Error En Printer");

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
                    statusVehiculoEntrada_pic.Image = Properties.Resources.circle_error;
                    toolTip1.SetToolTip(statusVehiculoEntrada_pic, "No hay vehículo en ventanilla");
                }
                DateTime horaactual = Convert.ToDateTime(dt.Rows[0]["actualDate"].ToString());
                DateTime horaregistro = Convert.ToDateTime(dt.Rows[0]["updateDate"].ToString());

                TimeSpan duration = horaactual - horaregistro;
                if (duration.TotalMinutes > 0.20)
                {
                    statusBasedatos_pic.Image = Properties.Resources.circle_error;
                    toolTip1.SetToolTip(statusBasedatos_pic, "Revise Conexión con BaseDatos Entrada");

                    statusAdamEntrada_pic.Image = Properties.Resources.circle_error;
                    toolTip1.SetToolTip(statusAdamEntrada_pic, "Perdida de comunicación con estación entrada");

                    statusVehiculoEntrada_pic.Image = Properties.Resources.circle_error;
                    toolTip1.SetToolTip(statusVehiculoEntrada_pic, "Perdida de comunicación con estación entrada");

                    statusPrinter_entrada_pic.Image = Properties.Resources.circle_error;
                    toolTip1.SetToolTip(statusPrinter_entrada_pic, "Perdida de comunicación con estación entrada");
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
            panel5.Location = new Point(this.ClientSize.Width / 2 - panel5.Size.Width / 2, this.ClientSize.Height / 2 - panel5.Size.Height / 2);
            panel5.Anchor = AnchorStyles.None;

            panel4.Location = new Point(this.ClientSize.Width / 2 - panel4.Size.Width / 2);
            panel4.Anchor = AnchorStyles.None;

            readStatusEntrada_timer.Enabled = true;
            readStatusEntrada_timer_Tick(1, e);
            readStatusSalida_timer.Enabled = true;
            readStatusSalida_timer_Tick(1, e);          

        }

        public void getIfUserOnBreak()
        {
            try
            {
                L.IdUsuario = Convert.ToInt16(Program.UserId);
                L.Estacion = Program.EstacionNumero;
                string mensaje = L.CheckIfUserOnBreak();
                if (mensaje == "1")
                {
                    DialogResult dialogResult = MessageBox.Show("Existe un turno abierto", "Sistema Parqueo", MessageBoxButtons.OK);
                    
                    
                    MessageBox.Show("Turno Continuado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    //else if (dialogResult == DialogResult.No)
                    //{
                    //    CerrarSesionAfterLogin();

                    //}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CerrarSesionAfterLogin()
        {
            try
            {          
                L.IdUsuario = Convert.ToInt16(Program.UserId);
                L.Estacion = Program.EstacionNumero;
                string mensaje = L.CloseUserSessionAfterLogin();
                if (mensaje == "1")
                {
                    MessageBox.Show("Nuevo Turno Creado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo cerrar el turno", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void configuraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SuperUserLoginForm form = new SuperUserLoginForm();
            form.ShowDialog();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Program.adamOnline = Program.adam_func.connectAdam(Program.adam6060, adamip, adamport);
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
                printer.PrinterState(Program.defaultprinter);  // Actualizar estatus printer

                if (Program.printerOffline)
                {
                    statusPrinterSalida_pic.Image = Properties.Resources.circle_error;
                    toolTip1.SetToolTip(statusPrinterSalida_pic, Program.defaultprinter + " No está conectado o No es Printer por defecto");


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
            Program.adam_func.AdamInputRead(Program.adam6060);
            Program.adam_func.AdamOutputRead(Program.adam6060);
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
            if(IO.CheckInputLoopSalida() || Program.byPassLoopSalida)
            {
                string barcodetxt = txtLecturaTicket.Text;
                try
                {
                    string mensaje = "";
                    if (barcodetxt.Length == 14)
                    {
                        key = 0;

                        U.barcode = txtLecturaTicket.Text.Trim();
                        mensaje = U.CheckTicket();
                        if (mensaje == "1")
                        {

                            timer1.Enabled = true;
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

            

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PermisosUsuario P = new PermisosUsuario();
            DataTable dt = new DataTable();
            P.UserId = Convert.ToInt16(Program.UserId);
            dt = P.GetPersmissions();

            if (Convert.ToBoolean(dt.Rows[0]["menu_sal_salir"]))
            {
                if (MessageBox.Show("¿Desea Salir?", "Sistema de Control de Parqueo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    CerrarSesion();
                    this.Dispose();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Usuario no tiene permiso", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 
            }
        }

        private void tIEMPOPRECIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PermisosUsuario P = new PermisosUsuario();
            DataTable dt = new DataTable();
            P.UserId = Convert.ToInt16(Program.UserId);
            dt = P.GetPersmissions();
            Console.WriteLine(dt.Rows[0]["menu_sal_tiempoprecio"]);
            if (Convert.ToBoolean(dt.Rows[0]["menu_sal_tiempoprecio"]))
            {
                configuracionTiempoPrecioForm obj = new configuracionTiempoPrecioForm();
                obj.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario no tiene permiso", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
      
        private void disableEnter_timer_Tick(object sender, EventArgs e)
        {
            disableEnter_timer.Enabled = false;
            MessageBox.Show("Ticket no existe", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);                       
        }

        private void btnTicketM_Click(object sender, EventArgs e)
        {
            if (IO.CheckInputLoopSalida() || Program.byPassLoopSalida)
            {
                PermisosUsuario P = new PermisosUsuario();
                DataTable dt = new DataTable();
                P.UserId = Convert.ToInt16(Program.UserId);
                dt = P.GetPersmissions();

                if (Convert.ToBoolean(dt.Rows[0]["btn_sal_ticketm"]))
                {
                    TicketManualForm form = new TicketManualForm();
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuario no tiene permiso", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

           
            
        }

        private void btnTicketP_Click(object sender, EventArgs e)
        {

            if (IO.CheckInputLoopSalida() || Program.byPassLoopSalida)
            {
                try
                {
                    PermisosUsuario P = new PermisosUsuario();
                    DataTable dt = new DataTable();
                    P.UserId = Convert.ToInt16(Program.UserId);
                    dt = P.GetPersmissions();

                    if (Convert.ToBoolean(dt.Rows[0]["btn_sal_ticketp"]))
                    {
                        TicketPerdidoForm form = new TicketPerdidoForm();
                        form.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Usuario no tiene permiso", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            


        }

        private void aGREGARUSUARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                PermisosUsuario P = new PermisosUsuario();
                DataTable dt = new DataTable();
                P.UserId = Convert.ToInt16(Program.UserId);
                dt = P.GetPersmissions();

                if (Convert.ToBoolean(dt.Rows[0]["agregar_usuario"]))
                {
                    RegistroUsuario form = new RegistroUsuario();
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuario no tiene permiso", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void gENERARREPORTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PermisosUsuario P = new PermisosUsuario();
            DataTable dt = new DataTable();
            P.UserId = Convert.ToInt16(Program.UserId);
            dt = P.GetPersmissions();

            if (Convert.ToBoolean(dt.Rows[0]["generar_reportes"]))
            {

            }
            else
            {
                MessageBox.Show("Usuario no tiene permiso", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void estacionSalidaMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Program.userLoggedIn)
            {

            
                PermisosUsuario P = new PermisosUsuario();
                DataTable dt = new DataTable();
                P.UserId = Convert.ToInt16(Program.UserId);
                dt = P.GetPersmissions();

                if (Convert.ToBoolean(dt.Rows[0]["menu_sal_salir"]))
                {
                    if (MessageBox.Show("¿Desea Salir?", "Sistema de Control de Parqueo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                    
                        CerrarSesion();
                        this.Close();


                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }
                else
                {
                    if (Program.userLoggedIn)
                    {
                        MessageBox.Show("Usuario no tiene permiso", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        e.Cancel = true;
                    }
                    
                }
            }
        }

        private void receso_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea poner turno en receso?", "Sistema de Control de Parqueo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                L.IdUsuario = Convert.ToInt16(Program.UserId);
                L.Estacion = Program.EstacionNumero;
                string mensaje = L.UserOnBreak();
                if (mensaje == "1")
                {
                    Program.userLoggedIn = false;
                    this.Hide();
                    LoginForm form = new LoginForm();
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No se pudo poner el turno en receso ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            
        }

        private void cerrarSesion_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Cerrar Sesión? "+ "\n" +" NOTA: Esta acción cerrará el turno actual.", "Sistema de Control de Parqueo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                CerrarSesion();
            }
               
        }

        public void CerrarSesion()
        {
            L.IdUsuario = Convert.ToInt16(Program.UserId);
            L.Estacion = Program.EstacionNumero;
            string mensaje = L.CloseSession();
            if (mensaje == "1")
            {
                Program.userLoggedIn = false;
                this.Hide();
                LoginForm form = new LoginForm();
                form.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("No se pudo cerrar el turno del usuario", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void estacionSalidaMainForm_Shown(object sender, EventArgs e)
        {
            try
            {
                usuario_lbl.Text = Program.UserName + " - " + Program.UserId;
                tipoUsuario_lbl.Text = Program.TipoUsuario;
                getIfUserOnBreak();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CobroAutomaticoPopUpForm form = new CobroAutomaticoPopUpForm();
            timer1.Enabled = false;
            form.barcode = txtLecturaTicket.Text;
            form.ShowDialog();

        }
    }
}   

