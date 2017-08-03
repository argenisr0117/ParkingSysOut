using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;


namespace SistemaParqueoSalida
{
    public partial class LoginForm : Form
    {
        Login L = new Login();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void entrar_btn_Click(object sender, EventArgs e)
        {
            Login();
        }

        public void Login()
        {
            L.Usuario = Usuario_txt.Text;
            L.Clave = Utilidades.EncodePassword(Usuario_txt.Text + Password_txt.Text);
            string[] mensaje = L.UserLogin();
            if (mensaje[0] == "1")
            {
                Program.userLoggedIn = true;
                Program.UserId = mensaje[1].ToString();
                Program.UserName = Usuario_txt.Text;
                Properties.Settings.Default.userName = Program.UserName;
                Properties.Settings.Default.Save();
                PermisosUsuario P = new PermisosUsuario();
                P.UserId = Convert.ToInt16(Program.UserId);
                DataTable dt = new DataTable();
                dt = P.GetPersmissions();
                Program.TipoUsuario = dt.Rows[0]["descripcion"].ToString();
                this.Hide();
                estacionSalidaMainForm form = new estacionSalidaMainForm();
                form.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña no coinciden", "Sistema Parqueo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            panel1.Location = new Point(this.ClientSize.Width / 2 - panel1.Size.Width / 2, this.ClientSize.Height / 2 - panel1.Size.Height / 2);
            panel1.Anchor = AnchorStyles.None;
            Settings S = new Settings();
            S.EntSal = "sal";
            S.estacionNumero = Properties.Settings.Default.Estacion;
            S.GetSettings();

            Usuario_txt.Text = Properties.Settings.Default.userName;
        }

        private void salir_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void cONFIGURACIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SuperUserLoginForm form = new SuperUserLoginForm();
            form.ShowDialog();
        }
    }
}
