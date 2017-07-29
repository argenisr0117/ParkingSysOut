namespace SistemaParqueoSalida
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Usuario_txt = new System.Windows.Forms.TextBox();
            this.Password_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTicketP = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Usuario_txt
            // 
            this.Usuario_txt.BackColor = System.Drawing.SystemColors.Info;
            this.Usuario_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario_txt.Location = new System.Drawing.Point(90, 90);
            this.Usuario_txt.Multiline = true;
            this.Usuario_txt.Name = "Usuario_txt";
            this.Usuario_txt.Size = new System.Drawing.Size(186, 34);
            this.Usuario_txt.TabIndex = 0;
            this.toolTip1.SetToolTip(this.Usuario_txt, "USUARIO");
            // 
            // Password_txt
            // 
            this.Password_txt.BackColor = System.Drawing.SystemColors.Info;
            this.Password_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_txt.Location = new System.Drawing.Point(90, 130);
            this.Password_txt.Multiline = true;
            this.Password_txt.Name = "Password_txt";
            this.Password_txt.Size = new System.Drawing.Size(186, 34);
            this.Password_txt.TabIndex = 1;
            this.toolTip1.SetToolTip(this.Password_txt, "CONTRASEÑA");
            this.Password_txt.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(0, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(308, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "___________________________________________";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(108, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "LOGIN";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SistemaParqueoSalida.Properties.Resources.key;
            this.pictureBox2.Location = new System.Drawing.Point(33, 130);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "CONTRASEÑA");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaParqueoSalida.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(33, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "USUARIO");
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Image = global::SistemaParqueoSalida.Properties.Resources.exit;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(184, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 63);
            this.button1.TabIndex = 5;
            this.button1.Text = "SALIR";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.button1, "CERRAR LOGIN");
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnTicketP
            // 
            this.btnTicketP.BackColor = System.Drawing.SystemColors.Info;
            this.btnTicketP.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTicketP.FlatAppearance.BorderSize = 2;
            this.btnTicketP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.btnTicketP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTicketP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTicketP.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnTicketP.Image = global::SistemaParqueoSalida.Properties.Resources.forward;
            this.btnTicketP.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTicketP.Location = new System.Drawing.Point(53, 199);
            this.btnTicketP.Name = "btnTicketP";
            this.btnTicketP.Size = new System.Drawing.Size(72, 63);
            this.btnTicketP.TabIndex = 4;
            this.btnTicketP.Text = "ENTRAR";
            this.btnTicketP.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btnTicketP, "INICIAR SESIÓN");
            this.btnTicketP.UseVisualStyleBackColor = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(308, 274);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTicketP);
            this.Controls.Add(this.Password_txt);
            this.Controls.Add(this.Usuario_txt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Usuario_txt;
        private System.Windows.Forms.TextBox Password_txt;
        private System.Windows.Forms.Button btnTicketP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}