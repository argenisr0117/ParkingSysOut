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
    public partial class SuperUserLoginForm : Form
    {
        public SuperUserLoginForm()
        {
            InitializeComponent();
        }

        private void entrar_btn_Click(object sender, EventArgs e)
        {
            SuperUserLogin();
        }

        private void salir_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void entrar_btn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SuperUserLogin();
            }
        }
        public void SuperUserLogin()
        {
            if (Password_txt.Text == Program.SuperUserPass)
            {
                this.Hide();
                ConfiguracionSalidaForm form = new ConfiguracionSalidaForm();
                form.Show();
            }
            else
            {
                MessageBox.Show("Acceso negado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
