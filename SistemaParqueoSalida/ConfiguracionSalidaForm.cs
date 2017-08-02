using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaParqueoSalida
{
    public partial class ConfiguracionSalidaForm : Form
    {
        Settings S = new Settings();
        public ConfiguracionSalidaForm()
        {
            InitializeComponent();
        }

        private void ConfiguracionSalidaForm_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                printerList_cb.Items.Add(printer.ToString());
            }

            printerList_cb.Text = Program.defaultprinter;

            byPassLoopSalida_chbox.Checked = Program.byPassLoopSalida;

            byPassAdam_chbox.Checked = Program.byPassAdam;

            adamIp_txt.Text = Program.AdamIp;
            adamPort_txt.Text = Program.AdamPort.ToString();

            estacionNombre_txt.Text = Program.EstacionNombre;
            estacionNumero_txt.Text = Program.EstacionNumero;

            baseDatosConexion_txt.Text = Properties.Settings.Default.Conexion;
            configuracionesToolTip.SetToolTip(labelBaseDatos, "Usar Siguiente Formato: Data Source=IPMACHINE;Initial Catalog=NOMBREBD;User ID=NOMBREUSER;Password=PASSWOORDBD;Encrypt=False;Column Encryption Setting=Disabled");

            if (Program.adamOnline)
            {
                EntradaSalida_button.Enabled = true;
            }
            else
            {
                EntradaSalida_button.Enabled = false;
            }

            timer1.Enabled = true;
            timer1_Tick(1, e);
        }


        private void EntradaSalida_button_Click(object sender, EventArgs e)
        {
            EntradasSalidasAdamForm form = new EntradasSalidasAdamForm();
            form.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            if (Program.adamOnline)
            {
                EntradaSalida_button.Enabled = true;
            }
            else
            {
                EntradaSalida_button.Enabled = false;
            }

            timer1.Enabled = true;
        }

        private void ConfiguracionSistemaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;
        }
        private void saveSettings_btn_Click(object sender, EventArgs e)
        {
            Program.defaultprinter = printerList_cb.SelectedItem.ToString();
            if (byPassLoopSalida_chbox.Checked)
            {
                Program.byPassLoopSalida = true;
            }
            else
            {
                Program.byPassLoopSalida = false;
            }

            if (byPassAdam_chbox.Checked)
            {
                Program.byPassAdam = true;
            }
            else
            {
                Program.byPassAdam = false;
            }
            Program.AdamIp = adamIp_txt.Text;
            Program.AdamPort = Convert.ToInt16( adamPort_txt.Text);
            Program.EstacionNombre = estacionNombre_txt.Text;
            S.EntSal = "sal";
            S.defaultprinter = Program.defaultprinter;
            S.byPassloop = Program.byPassLoopSalida;
            S.byPassBrazo = false;
            S.byPassAdam = Program.byPassAdam;
            S.adamIp = Program.AdamIp;
            S.adamPort = Program.AdamPort;
            S.estacionNombre = Program.EstacionNombre;
            S.estacionNumero = estacionNumero_txt.Text;
            S.estacionAnterior = Program.EstacionNumero;
            bool mensaje = S.SaveSettings();
            Program.EstacionNumero = estacionNumero_txt.Text;
            Properties.Settings.Default.Estacion = estacionNumero_txt.Text;
            Properties.Settings.Default.Save();
            if (mensaje)
            {
                MessageBox.Show("Configuración Guardada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Configuración No fue guardada en base de datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void EntradaSalida_button_Click_1(object sender, EventArgs e)
        {
            EntradasSalidasAdamForm form = new EntradasSalidasAdamForm();
            form.Show();
        }
    }

}
