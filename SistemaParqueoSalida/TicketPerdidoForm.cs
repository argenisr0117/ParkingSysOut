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
    public partial class TicketPerdidoForm : Form
    {
        public TicketPerdidoForm()
        {
            InitializeComponent();
        }
        UpdateTicket U = new UpdateTicket();
        private void Efectivo_txt_KeyDown(object sender, KeyEventArgs e)
        {
            errorProvider1.Clear();
            if (Utilidades.ValidarForm(this, errorProvider1) == false)
            {
                return;
            }
            try
            {
                if (e.KeyData == Keys.Enter)
                {
                    double Total = Convert.ToDouble(ticketPerdido_txt.Text);
                    double Pagado = Convert.ToDouble(Efectivo_txt.Text);
                    if (Total > Pagado)
                    {
                        MessageBox.Show("Monto digitado no puede ser menor que valor a pagar", "Sistema de Parqueo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Efectivo_txt.Clear();
                        Efectivo_txt.Focus();
                    }
                    else
                    {
                        Devuelta_txt.Text = (Convert.ToDouble(Efectivo_txt.Text) - Convert.ToDouble(ticketPerdido_txt.Text)).ToString("N2");
                        U.Idlog = Program.Idlog;
                        U.idUsuario = Convert.ToInt16(Program.UserId);
                        U.Nombre = Nombre_txt.Text;
                        U.Cedula = Cedula_txt.Text;
                        U.monto =float.Parse(ticketPerdido_txt.Text);
                        U.estacionSal = Program.EstacionNumero;
                        U.RegLostTicket();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sistema de Parqueo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void Limpiar()
        {
            Cedula_txt.Clear();
            Nombre_txt.Clear();
        }
        public void LoadSettings()
        {
            try
            {
                DataTable dt = new DataTable();
                AdmSettings S = new AdmSettings();
                dt = S.GetSettings();
                ticketPerdido_txt.Text = (Convert.ToInt16(dt.Rows[0]["precioTicketPerdido"])).ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void TicketPerdidoForm_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }
    }
}
