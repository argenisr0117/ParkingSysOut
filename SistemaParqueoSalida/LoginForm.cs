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
using System.Management;

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
            try
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
                    form.ShowDialog();
                    this.Dispose();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña no coinciden", "Sistema Parqueo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
            try
            {
                timer1.Enabled = true;
                panel1.Location = new Point(this.ClientSize.Width / 2 - panel1.Size.Width / 2, this.ClientSize.Height / 2 - panel1.Size.Height / 2);
                panel1.Anchor = AnchorStyles.None;
                Settings S = new Settings();
                S.EntSal = "sal";
                S.estacionNumero = Properties.Settings.Default.Estacion;
                S.GetSettings();

                Usuario_txt.Text = Properties.Settings.Default.userName;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           

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

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Program.adamOnline = Program.adam_func.connectAdam(Program.adam6060, Program.AdamIp, Convert.ToInt16(Program.AdamPort));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync(); // read adam
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Program.adam_func.AdamInputRead(Program.adam6060);
            Program.adam_func.AdamOutputRead(Program.adam6060);
        }

        

        private void LoginForm_Shown(object sender, EventArgs e)
        {
            Settings S = new Settings();
            bool mensaje = S.CheckIfSoftwareActivated();
            if (!mensaje)
            {
                MessageBox.Show("Este sistema no ha sido activado por los Administradores" + "\n" + "Nota: Software se cerrará al clickear OK o al cerrar esta ventana", "Sistema de Parqueo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                try { this.Close(); }
                catch { }
            }
        }
    }
}
