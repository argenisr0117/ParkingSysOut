namespace SistemaParqueoSalida
{
    partial class RegistroUsuario
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbInactivo = new System.Windows.Forms.RadioButton();
            this.rbActivo = new System.Windows.Forms.RadioButton();
            this.Users_dtg = new System.Windows.Forms.DataGridView();
            this.idusuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.tipoUsuario_cb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.registrar_panel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.exit_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.inactivate_btn = new System.Windows.Forms.Button();
            this.saveSettings_btn = new System.Windows.Forms.Button();
            this.update_panel = new System.Windows.Forms.Panel();
            this.changePass_chbox = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Usuario_txt = new SistemaParqueoSalida.Controles.textbox(this.components);
            this.Nombre_txt = new SistemaParqueoSalida.Controles.textbox(this.components);
            this.confirmarClaveUpd_txt = new SistemaParqueoSalida.Controles.textbox(this.components);
            this.claveNuevaUpd_txt = new SistemaParqueoSalida.Controles.textbox(this.components);
            this.clave_anterior = new SistemaParqueoSalida.Controles.textbox(this.components);
            this.confirmarClave_txt = new SistemaParqueoSalida.Controles.textbox(this.components);
            this.clave_txt = new SistemaParqueoSalida.Controles.textbox(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Users_dtg)).BeginInit();
            this.registrar_panel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.update_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.rbInactivo);
            this.panel1.Controls.Add(this.rbActivo);
            this.panel1.Location = new System.Drawing.Point(652, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(94, 50);
            this.panel1.TabIndex = 171;
            // 
            // rbInactivo
            // 
            this.rbInactivo.AutoSize = true;
            this.rbInactivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbInactivo.Location = new System.Drawing.Point(3, 27);
            this.rbInactivo.Name = "rbInactivo";
            this.rbInactivo.Size = new System.Drawing.Size(75, 16);
            this.rbInactivo.TabIndex = 1;
            this.rbInactivo.TabStop = true;
            this.rbInactivo.Text = "INACTIVOS";
            this.rbInactivo.UseVisualStyleBackColor = true;
            this.rbInactivo.CheckedChanged += new System.EventHandler(this.rbInactivo_CheckedChanged);
            // 
            // rbActivo
            // 
            this.rbActivo.AutoSize = true;
            this.rbActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbActivo.Location = new System.Drawing.Point(4, 4);
            this.rbActivo.Name = "rbActivo";
            this.rbActivo.Size = new System.Drawing.Size(65, 16);
            this.rbActivo.TabIndex = 0;
            this.rbActivo.TabStop = true;
            this.rbActivo.Text = "ACTIVOS";
            this.rbActivo.UseVisualStyleBackColor = true;
            this.rbActivo.CheckedChanged += new System.EventHandler(this.rbActivo_CheckedChanged);
            // 
            // Users_dtg
            // 
            this.Users_dtg.AllowUserToAddRows = false;
            this.Users_dtg.AllowUserToDeleteRows = false;
            this.Users_dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Users_dtg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idusuario,
            this.nombre,
            this.usuario,
            this.clave,
            this.tipo,
            this.estado});
            this.Users_dtg.Location = new System.Drawing.Point(387, 56);
            this.Users_dtg.MultiSelect = false;
            this.Users_dtg.Name = "Users_dtg";
            this.Users_dtg.ReadOnly = true;
            this.Users_dtg.RowHeadersWidth = 10;
            this.Users_dtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Users_dtg.Size = new System.Drawing.Size(360, 172);
            this.Users_dtg.TabIndex = 170;
            this.Users_dtg.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Users_dtg_CellDoubleClick);
            // 
            // idusuario
            // 
            this.idusuario.HeaderText = "IDUSUARIO";
            this.idusuario.Name = "idusuario";
            this.idusuario.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // usuario
            // 
            this.usuario.HeaderText = "USUARIO";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            // 
            // clave
            // 
            this.clave.HeaderText = "CLAVE";
            this.clave.Name = "clave";
            this.clave.ReadOnly = true;
            // 
            // tipo
            // 
            this.tipo.HeaderText = "TIPO";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.HeaderText = "ESTADO";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 16);
            this.label5.TabIndex = 169;
            this.label5.Text = "TIPO USUARIO:";
            // 
            // tipoUsuario_cb
            // 
            this.tipoUsuario_cb.BackColor = System.Drawing.SystemColors.Info;
            this.tipoUsuario_cb.DropDownHeight = 80;
            this.tipoUsuario_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoUsuario_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoUsuario_cb.ForeColor = System.Drawing.Color.Black;
            this.tipoUsuario_cb.FormattingEnabled = true;
            this.tipoUsuario_cb.IntegralHeight = false;
            this.tipoUsuario_cb.Location = new System.Drawing.Point(157, 93);
            this.tipoUsuario_cb.Name = "tipoUsuario_cb";
            this.tipoUsuario_cb.Size = new System.Drawing.Size(198, 24);
            this.tipoUsuario_cb.TabIndex = 168;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 167;
            this.label2.Text = "USUARIO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 18);
            this.label1.TabIndex = 166;
            this.label1.Text = "REGISTRO DE USUARIO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 165;
            this.label6.Text = "NOMBRE:";
            // 
            // registrar_panel
            // 
            this.registrar_panel.Controls.Add(this.confirmarClave_txt);
            this.registrar_panel.Controls.Add(this.clave_txt);
            this.registrar_panel.Controls.Add(this.label4);
            this.registrar_panel.Controls.Add(this.label3);
            this.registrar_panel.Location = new System.Drawing.Point(0, 153);
            this.registrar_panel.Name = "registrar_panel";
            this.registrar_panel.Size = new System.Drawing.Size(359, 79);
            this.registrar_panel.TabIndex = 172;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "CONFIRMAR CLAVE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "CLAVE:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 352);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(801, 34);
            this.panel2.TabIndex = 177;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label7.Location = new System.Drawing.Point(272, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(220, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "DOBLE CLICK A REGISTRO PARA EDITAR";
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.SystemColors.Info;
            this.exit_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.exit_btn.FlatAppearance.BorderSize = 2;
            this.exit_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.Image = global::SistemaParqueoSalida.Properties.Resources.exit;
            this.exit_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.exit_btn.Location = new System.Drawing.Point(508, 289);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(83, 57);
            this.exit_btn.TabIndex = 175;
            this.exit_btn.Text = "SALIR";
            this.exit_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.SystemColors.Info;
            this.cancel_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cancel_btn.FlatAppearance.BorderSize = 2;
            this.cancel_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.Image = global::SistemaParqueoSalida.Properties.Resources.cancel;
            this.cancel_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cancel_btn.Location = new System.Drawing.Point(419, 289);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(83, 57);
            this.cancel_btn.TabIndex = 174;
            this.cancel_btn.Text = "CANCELAR";
            this.cancel_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // inactivate_btn
            // 
            this.inactivate_btn.BackColor = System.Drawing.SystemColors.Info;
            this.inactivate_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.inactivate_btn.FlatAppearance.BorderSize = 2;
            this.inactivate_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.inactivate_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inactivate_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inactivate_btn.Image = global::SistemaParqueoSalida.Properties.Resources.refresh;
            this.inactivate_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.inactivate_btn.Location = new System.Drawing.Point(330, 289);
            this.inactivate_btn.Name = "inactivate_btn";
            this.inactivate_btn.Size = new System.Drawing.Size(83, 57);
            this.inactivate_btn.TabIndex = 176;
            this.inactivate_btn.Text = "INACTIVAR";
            this.inactivate_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.inactivate_btn.UseVisualStyleBackColor = false;
            this.inactivate_btn.Click += new System.EventHandler(this.inactivate_btn_Click);
            // 
            // saveSettings_btn
            // 
            this.saveSettings_btn.BackColor = System.Drawing.SystemColors.Info;
            this.saveSettings_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.saveSettings_btn.FlatAppearance.BorderSize = 2;
            this.saveSettings_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.saveSettings_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveSettings_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveSettings_btn.Image = global::SistemaParqueoSalida.Properties.Resources.save;
            this.saveSettings_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.saveSettings_btn.Location = new System.Drawing.Point(241, 289);
            this.saveSettings_btn.Name = "saveSettings_btn";
            this.saveSettings_btn.Size = new System.Drawing.Size(83, 57);
            this.saveSettings_btn.TabIndex = 173;
            this.saveSettings_btn.Text = "GUARDAR";
            this.saveSettings_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.saveSettings_btn.UseVisualStyleBackColor = false;
            // 
            // update_panel
            // 
            this.update_panel.Controls.Add(this.confirmarClaveUpd_txt);
            this.update_panel.Controls.Add(this.claveNuevaUpd_txt);
            this.update_panel.Controls.Add(this.clave_anterior);
            this.update_panel.Controls.Add(this.changePass_chbox);
            this.update_panel.Controls.Add(this.label10);
            this.update_panel.Controls.Add(this.label9);
            this.update_panel.Controls.Add(this.label8);
            this.update_panel.Location = new System.Drawing.Point(0, 153);
            this.update_panel.Name = "update_panel";
            this.update_panel.Size = new System.Drawing.Size(376, 128);
            this.update_panel.TabIndex = 179;
            this.update_panel.Visible = false;
            // 
            // changePass_chbox
            // 
            this.changePass_chbox.AutoSize = true;
            this.changePass_chbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePass_chbox.Location = new System.Drawing.Point(10, 10);
            this.changePass_chbox.Name = "changePass_chbox";
            this.changePass_chbox.Size = new System.Drawing.Size(104, 16);
            this.changePass_chbox.TabIndex = 178;
            this.changePass_chbox.Text = "CAMBIAR CLAVE";
            this.changePass_chbox.UseVisualStyleBackColor = true;
            this.changePass_chbox.CheckedChanged += new System.EventHandler(this.changePass_chbox_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(5, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 16);
            this.label10.TabIndex = 177;
            this.label10.Text = "CLAVE NUEVA:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(5, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 16);
            this.label9.TabIndex = 176;
            this.label9.Text = "CONFIRMAR CLAVE:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 16);
            this.label8.TabIndex = 175;
            this.label8.Text = "CLAVE ANTERIOR:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Usuario_txt
            // 
            this.Usuario_txt.Location = new System.Drawing.Point(157, 123);
            this.Usuario_txt.Multiline = true;
            this.Usuario_txt.Name = "Usuario_txt";
            this.Usuario_txt.Size = new System.Drawing.Size(198, 24);
            this.Usuario_txt.TabIndex = 181;
            this.Usuario_txt.Validar = false;
            // 
            // Nombre_txt
            // 
            this.Nombre_txt.Location = new System.Drawing.Point(157, 62);
            this.Nombre_txt.Multiline = true;
            this.Nombre_txt.Name = "Nombre_txt";
            this.Nombre_txt.Size = new System.Drawing.Size(198, 25);
            this.Nombre_txt.TabIndex = 180;
            this.Nombre_txt.Validar = false;
            // 
            // confirmarClaveUpd_txt
            // 
            this.confirmarClaveUpd_txt.Enabled = false;
            this.confirmarClaveUpd_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmarClaveUpd_txt.Location = new System.Drawing.Point(159, 104);
            this.confirmarClaveUpd_txt.Name = "confirmarClaveUpd_txt";
            this.confirmarClaveUpd_txt.Size = new System.Drawing.Size(198, 21);
            this.confirmarClaveUpd_txt.TabIndex = 181;
            this.confirmarClaveUpd_txt.Validar = false;
            // 
            // claveNuevaUpd_txt
            // 
            this.claveNuevaUpd_txt.Enabled = false;
            this.claveNuevaUpd_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.claveNuevaUpd_txt.Location = new System.Drawing.Point(158, 74);
            this.claveNuevaUpd_txt.Name = "claveNuevaUpd_txt";
            this.claveNuevaUpd_txt.Size = new System.Drawing.Size(198, 21);
            this.claveNuevaUpd_txt.TabIndex = 180;
            this.claveNuevaUpd_txt.Validar = false;
            // 
            // clave_anterior
            // 
            this.clave_anterior.Enabled = false;
            this.clave_anterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clave_anterior.Location = new System.Drawing.Point(159, 46);
            this.clave_anterior.Name = "clave_anterior";
            this.clave_anterior.Size = new System.Drawing.Size(198, 21);
            this.clave_anterior.TabIndex = 179;
            this.clave_anterior.Validar = false;
            // 
            // confirmarClave_txt
            // 
            this.confirmarClave_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmarClave_txt.Location = new System.Drawing.Point(157, 42);
            this.confirmarClave_txt.Name = "confirmarClave_txt";
            this.confirmarClave_txt.PasswordChar = '*';
            this.confirmarClave_txt.Size = new System.Drawing.Size(195, 22);
            this.confirmarClave_txt.TabIndex = 178;
            this.confirmarClave_txt.Validar = false;
            // 
            // clave_txt
            // 
            this.clave_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clave_txt.Location = new System.Drawing.Point(157, 3);
            this.clave_txt.Name = "clave_txt";
            this.clave_txt.PasswordChar = '*';
            this.clave_txt.Size = new System.Drawing.Size(198, 22);
            this.clave_txt.TabIndex = 31;
            this.clave_txt.Validar = false;
            // 
            // RegistroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 386);
            this.Controls.Add(this.Usuario_txt);
            this.Controls.Add(this.Nombre_txt);
            this.Controls.Add(this.update_panel);
            this.Controls.Add(this.registrar_panel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.inactivate_btn);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.saveSettings_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Users_dtg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tipoUsuario_cb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Name = "RegistroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RegistroUsuario";
            this.Load += new System.EventHandler(this.RegistroUsuario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Users_dtg)).EndInit();
            this.registrar_panel.ResumeLayout(false);
            this.registrar_panel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.update_panel.ResumeLayout(false);
            this.update_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbInactivo;
        private System.Windows.Forms.RadioButton rbActivo;
        private System.Windows.Forms.DataGridView Users_dtg;
        private System.Windows.Forms.DataGridViewTextBoxColumn idusuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox tipoUsuario_cb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel registrar_panel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button inactivate_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button saveSettings_btn;
        private Controles.textbox clave_txt;
        private Controles.textbox confirmarClave_txt;
        private System.Windows.Forms.Panel update_panel;
        private Controles.textbox confirmarClaveUpd_txt;
        private Controles.textbox claveNuevaUpd_txt;
        private Controles.textbox clave_anterior;
        private System.Windows.Forms.CheckBox changePass_chbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private Controles.textbox Nombre_txt;
        private Controles.textbox Usuario_txt;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}