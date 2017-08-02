using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace SistemaParqueoSalida
{
    public partial class CobroAutomaticoPopUpForm : Form
    {
        Configuraciones C = new Configuraciones();
        public string barcode;
        
        public CobroAutomaticoPopUpForm()
        {
            InitializeComponent();
        }     
        private void CobroAutomaticoPopUpForm_Load(object sender, EventArgs e)
        {
            Calcular();
        }
       public void Calcular()
        {
            try
            {
                string year = barcode[2].ToString() + barcode[3].ToString();
                string month = barcode[4].ToString() + barcode[5].ToString();
                string day = barcode[6].ToString() + barcode[7].ToString();
                string hour = barcode[8].ToString() + barcode[9].ToString();
                string minutes = barcode[10].ToString() + barcode[11].ToString();
                string seconds = barcode[12].ToString() + barcode[13].ToString();
                string timeString = day + "/" + month + "/" + year + " " + hour + ":" + minutes + ":" + seconds;

                IFormatProvider culture = new CultureInfo("en-US", true);
                DateTime dateEntradaValue = DateTime.ParseExact(timeString, "dd/MM/yy HH:mm:ss", culture);
                DateTime dateActualValue = DateTime.Now;
                string hora = dateActualValue.ToString("HH:mm:ss");
                string fechasal = dateActualValue.ToString("yyyy/MM/dd");
                string horasal = dateActualValue.ToString("HH:mm:ss");
                TimeSpan duration = dateActualValue - dateEntradaValue;
                if(TimeSpan.FromMinutes(duration.TotalMinutes).Days > 0)
                {
                    lblDuracionTotal.Text = (TimeSpan.FromMinutes(duration.TotalMinutes).Days).ToString() + "d "+ (TimeSpan.FromMinutes(duration.TotalMinutes).Hours).ToString() + "Hr " + (TimeSpan.FromMinutes(duration.TotalMinutes).Minutes).ToString() + "Min";

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
                txtTotalPagar.Text = TotalToPay.ToString();
                Efectivo_txt.Text = TotalToPay.ToString();
                ActualizarTicket(Convert.ToDateTime(fechasal), Convert.ToDateTime(horasal), barcode, float.Parse(txtTotalPagar.Text), TimeInside, Properties.Settings.Default.idUsuario);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sistema de Parqueo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void Efectivo_txt_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter)
                {
                    int Total = Convert.ToInt32(txtTotalPagar.Text);
                    int Pagado = Convert.ToInt32(Efectivo_txt.Text);
                    if (Total > Pagado)
                    {
                        MessageBox.Show("Monto digitado no puede ser menor que valor a pagar", "Sistema de Parqueo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Efectivo_txt.Clear();
                        Efectivo_txt.Focus();
                    }
                    else
                    {
                        Devuelta_txt.Text = (Convert.ToInt32(Efectivo_txt.Text) - Convert.ToInt32(txtTotalPagar.Text)).ToString("N2");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Sistema de Parqueo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void ActualizarTicket(DateTime fechasal, DateTime horasal, string barcode, float monto, float tiempo, int idUsuario)
        {
            UpdateTicket u = new UpdateTicket( );
            u.fechaSalida = fechasal;
            u.horaSalida = horasal;
            u.barcode = barcode;
            u.monto = monto;
            u.tiempo = tiempo;
            u.idUsuario = idUsuario;
            u.estacionSal = Program.EstacionNumero;
            u.UpdateTicketToDB();
        }
    }
}
