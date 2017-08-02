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
    public partial class TicketManualForm : Form
    {
        Configuraciones C = new Configuraciones();
        public TicketManualForm()
        {
            InitializeComponent();
        }

        private void TicketManualForm_Load(object sender, EventArgs e)
        {
            //SendKeys.Send("{TAB}");
            Program.Evento = 0;
            fechaEntrada_dtp.Focus();
            lblDuracionTotal.Text = "0Hr 0Min";
            fechaEntrada_dtp.Value = DateTime.Now;

            fechaActual_dtp.Value = DateTime.Now;
            Program.Evento = 1;
            
            
        }

        private void fechaEntrada_dtp_ValueChanged(object sender, EventArgs e)
        {   if (Program.Evento == 1)
            {
                CalculateTicketPrice();
            }
            
        }

        private void fechaActual_dtp_ValueChanged(object sender, EventArgs e)
        {
            if (Program.Evento == 1)
            {
                CalculateTicketPrice();
            }
        }

        public void CalculateTicketPrice()
        {
            if (fechaEntrada_dtp.Value > fechaActual_dtp.Value)
            {
                MessageBox.Show("Fecha de entrada debe ser menor o igual a fecha de salida", "Sistema de Parqueo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fechaEntrada_dtp.Value = fechaActual_dtp.Value;
            }
            else
            {
                TimeSpan duration = fechaActual_dtp.Value - fechaEntrada_dtp.Value;
                if (TimeSpan.FromMinutes(duration.TotalMinutes).Days > 0)
                {
                    lblDuracionTotal.Text = (TimeSpan.FromMinutes(duration.TotalMinutes).Days).ToString() + "d " + (TimeSpan.FromMinutes(duration.TotalMinutes).Hours).ToString() + "Hr " + (TimeSpan.FromMinutes(duration.TotalMinutes).Minutes).ToString() + "Min";

                }
                else
                {
                    lblDuracionTotal.Text = (TimeSpan.FromMinutes(duration.TotalMinutes).Hours).ToString() + "Hr " + (TimeSpan.FromMinutes(duration.TotalMinutes).Minutes).ToString() + "Min";

                }

                DataTable dt = new DataTable();
                dt = C.GetTimePriceSettings();
                int TimeInside = Convert.ToInt32(duration.TotalMinutes);
                int TotalTime = 0;
                int ActualTime = 0;
                double TotalToPay = 0;
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    ActualTime = Convert.ToInt32(dt.Rows[x][2]);
                    TotalTime = TotalTime + ActualTime;
                    if (TimeInside > TotalTime)
                    {
                        if (dt.Rows.Count == x + 1)
                        {
                            break;
                        }
                        else
                        {
                            TotalToPay = TotalToPay + Convert.ToInt32(dt.Rows[x + 1][3]);
                        }

                    }
                    else
                    {
                        txtTotalPagar.Text = TotalToPay.ToString();
                        break;
                    }
                }
                //if (TotalToPay == 0)
                //{
                //    Efectivo_txt.Enabled = false;
                //    MessageBox.Show("Ticket gratis", "Sistema de Parqueo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                txtTotalPagar.Text = TotalToPay.ToString("N2");
                Efectivo_txt.Text = TotalToPay.ToString("N2");
                fechaEntrada_dtp.Focus();
            }
        }

        private void Efectivo_txt_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter)
                {
                    double Total = Convert.ToDouble(txtTotalPagar.Text);
                    double Pagado = Convert.ToDouble(Efectivo_txt.Text);
                    if (Total > Pagado)
                    {
                        MessageBox.Show("Monto digitado no puede ser menor que valor a pagar", "Sistema de Parqueo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Efectivo_txt.Clear();
                        Efectivo_txt.Focus();
                    }
                    else
                    {
                        Devuelta_txt.Text = (Convert.ToDouble(Efectivo_txt.Text) - Convert.ToDouble(txtTotalPagar.Text)).ToString("N2");
                        Devuelta_txt.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sistema de Parqueo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
