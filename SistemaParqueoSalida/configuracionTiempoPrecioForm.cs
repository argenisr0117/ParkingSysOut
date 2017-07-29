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
    public partial class configuracionTiempoPrecioForm : Form
    {
        Configuraciones C = new Configuraciones();

        public configuracionTiempoPrecioForm()
        {
            InitializeComponent();
        }
        private void LlenarGrid()
        {
            DataTable dt = new DataTable();
            dt = C.GetTimePriceSettings();
            try
            {
                dtgTiempoPrecio.Rows.Clear();
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    dtgTiempoPrecio.Rows.Add(dt.Rows[x][0]);
                    dtgTiempoPrecio.Rows[x].Cells[0].Value = dt.Rows[x][0].ToString();
                    dtgTiempoPrecio.Rows[x].Cells[1].Value = dt.Rows[x][1].ToString();
                    dtgTiempoPrecio.Rows[x].Cells[2].Value = dt.Rows[x][2].ToString();
                    dtgTiempoPrecio.Rows[x].Cells[3].Value = dt.Rows[x][3].ToString();
                }
                dtgTiempoPrecio.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sistema de Parqueo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void saveSettings_btn_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            try
            {
                if (!string.IsNullOrEmpty(txtPrecio.Text) && txtTiempo.Text != "")
                {
                if (Program.Evento==0)
                {
                    C.Posicion =Convert.ToInt32(cbPosicion.SelectedItem);
                    C.Precio =Convert.ToDouble(txtPrecio.Text);
                    C.Tiempo = Convert.ToInt32(txtTiempo.Text);
                    mensaje = C.Registrar();
                    if(mensaje=="1")
                    {
                        MessageBox.Show("Registrado", "Sistema de Parqueo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LlenarGrid();
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error", "Sistema de Parqueo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Limpiar();
                    }
                }
                else if(Program.Evento==1)
                {
                    C.Id = Program.id;
                    C.Posicion = Convert.ToInt32(cbPosicion.SelectedItem);
                    C.Precio = Convert.ToDouble(txtPrecio.Text);
                    C.Tiempo = Convert.ToInt32(txtTiempo.Text);
                    mensaje = C.Actualizar();
                    if (mensaje == "1")
                    {
                        MessageBox.Show("Actualizado", "Sistema de Parqueo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LlenarGrid();
                        Limpiar();
                        Program.Evento = 0;
                        Program.id = 0;
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error", "Sistema de Parqueo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Limpiar();
                    }
                }
            }
                else
                {
                    MessageBox.Show("Existen campos vacios", "Sistema de Parqueo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTiempo.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sistema de Parqueo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Limpiar()
        {
            txtPrecio.Clear();
            txtTiempo.Clear();
            cbPosicion.SelectedIndex = -1;
            txtTiempo.Focus();
        }

        private void configuracionTiempoPrecioForm_Load(object sender, EventArgs e)
        {
            Limpiar();
            Program.Evento = 0;
            LlenarGrid();
        }

        private void dtgTiempoPrecio_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Program.Evento = 1;
            Program.id = Convert.ToInt32(dtgTiempoPrecio.CurrentRow.Cells[0].Value);
            cbPosicion.SelectedItem = dtgTiempoPrecio.CurrentRow.Cells[1].Value.ToString();
            txtTiempo.Text = dtgTiempoPrecio.CurrentRow.Cells[2].Value.ToString();
            txtPrecio.Text = dtgTiempoPrecio.CurrentRow.Cells[3].Value.ToString();
            txtPrecio.Focus();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Limpiar();
            Program.Evento = 0;
            Program.id = 0;
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Sistema de Control de Parqueo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Dispose();
                this.Close();
            }
        }
    }
}
