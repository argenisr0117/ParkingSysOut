﻿namespace SistemaParqueoSalida
{
    partial class ConfiguracionSalidaForm
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
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.EntradaSalida_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.baseDatosConexion_txt = new System.Windows.Forms.TextBox();
            this.labelBaseDatos = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.byPassAdam_chbox = new System.Windows.Forms.CheckBox();
            this.byPassLoopSalida_chbox = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.configuracionesToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.adamPort_txt = new SistemaParqueoSalida.Controles.textbox(this.components);
            this.adamIp_txt = new SistemaParqueoSalida.Controles.textbox(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.printerList_cb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.estacionNumero_txt = new SistemaParqueoSalida.Controles.textbox(this.components);
            this.estacionNombre_txt = new SistemaParqueoSalida.Controles.textbox(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.loadSetting_btn = new System.Windows.Forms.Button();
            this.saveSettings_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.estaciones_cb = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.abrirBrazo_cb = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.loopSalida_cb = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "NOMBRE ESTACIÓN: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(117, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "ESTACIÓN";
            // 
            // EntradaSalida_button
            // 
            this.EntradaSalida_button.BackColor = System.Drawing.SystemColors.Info;
            this.EntradaSalida_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.EntradaSalida_button.FlatAppearance.BorderSize = 2;
            this.EntradaSalida_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.EntradaSalida_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EntradaSalida_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntradaSalida_button.Location = new System.Drawing.Point(261, 77);
            this.EntradaSalida_button.Name = "EntradaSalida_button";
            this.EntradaSalida_button.Size = new System.Drawing.Size(104, 54);
            this.EntradaSalida_button.TabIndex = 12;
            this.EntradaSalida_button.Text = "ENTRADAS/SALIDAS";
            this.EntradaSalida_button.UseVisualStyleBackColor = false;
            this.EntradaSalida_button.Click += new System.EventHandler(this.EntradaSalida_button_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "PUERTO :";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.baseDatosConexion_txt);
            this.panel4.Controls.Add(this.labelBaseDatos);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Location = new System.Drawing.Point(12, 116);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(335, 150);
            this.panel4.TabIndex = 11;
            // 
            // baseDatosConexion_txt
            // 
            this.baseDatosConexion_txt.BackColor = System.Drawing.SystemColors.Info;
            this.baseDatosConexion_txt.Enabled = false;
            this.baseDatosConexion_txt.Location = new System.Drawing.Point(71, 44);
            this.baseDatosConexion_txt.Multiline = true;
            this.baseDatosConexion_txt.Name = "baseDatosConexion_txt";
            this.baseDatosConexion_txt.Size = new System.Drawing.Size(234, 67);
            this.baseDatosConexion_txt.TabIndex = 9;
            // 
            // labelBaseDatos
            // 
            this.labelBaseDatos.AutoSize = true;
            this.labelBaseDatos.Location = new System.Drawing.Point(-1, 44);
            this.labelBaseDatos.Name = "labelBaseDatos";
            this.labelBaseDatos.Size = new System.Drawing.Size(66, 13);
            this.labelBaseDatos.TabIndex = 8;
            this.labelBaseDatos.Text = "CONEXIÓN:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(90, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "BASE DE DATOS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "IP :";
            // 
            // byPassAdam_chbox
            // 
            this.byPassAdam_chbox.AutoSize = true;
            this.byPassAdam_chbox.Location = new System.Drawing.Point(179, 54);
            this.byPassAdam_chbox.Name = "byPassAdam_chbox";
            this.byPassAdam_chbox.Size = new System.Drawing.Size(95, 17);
            this.byPassAdam_chbox.TabIndex = 7;
            this.byPassAdam_chbox.Text = "ByPass ADAM";
            this.byPassAdam_chbox.UseVisualStyleBackColor = true;
            // 
            // byPassLoopSalida_chbox
            // 
            this.byPassLoopSalida_chbox.AutoSize = true;
            this.byPassLoopSalida_chbox.Location = new System.Drawing.Point(5, 54);
            this.byPassLoopSalida_chbox.Name = "byPassLoopSalida_chbox";
            this.byPassLoopSalida_chbox.Size = new System.Drawing.Size(134, 17);
            this.byPassLoopSalida_chbox.TabIndex = 5;
            this.byPassLoopSalida_chbox.Text = "ByPass LOOP SALIDA";
            this.byPassLoopSalida_chbox.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "# ESTACIÓN: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(155, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "ADAM";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.adamPort_txt);
            this.panel2.Controls.Add(this.adamIp_txt);
            this.panel2.Controls.Add(this.EntradaSalida_button);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.byPassAdam_chbox);
            this.panel2.Controls.Add(this.byPassLoopSalida_chbox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(353, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(373, 236);
            this.panel2.TabIndex = 8;
            // 
            // adamPort_txt
            // 
            this.adamPort_txt.BackColor = System.Drawing.SystemColors.Info;
            this.adamPort_txt.Location = new System.Drawing.Point(240, 26);
            this.adamPort_txt.Name = "adamPort_txt";
            this.adamPort_txt.Size = new System.Drawing.Size(73, 20);
            this.adamPort_txt.TabIndex = 14;
            this.adamPort_txt.Validar = true;
            // 
            // adamIp_txt
            // 
            this.adamIp_txt.BackColor = System.Drawing.SystemColors.Info;
            this.adamIp_txt.Location = new System.Drawing.Point(31, 26);
            this.adamIp_txt.Name = "adamIp_txt";
            this.adamIp_txt.Size = new System.Drawing.Size(73, 20);
            this.adamIp_txt.TabIndex = 13;
            this.adamIp_txt.Validar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(128, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "IMPRESORA";
            // 
            // printerList_cb
            // 
            this.printerList_cb.BackColor = System.Drawing.SystemColors.Info;
            this.printerList_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.printerList_cb.FormattingEnabled = true;
            this.printerList_cb.Location = new System.Drawing.Point(156, 46);
            this.printerList_cb.Name = "printerList_cb";
            this.printerList_cb.Size = new System.Drawing.Size(205, 21);
            this.printerList_cb.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "SELECCIONE IMPRESORA: ";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.estacionNumero_txt);
            this.panel3.Controls.Add(this.estacionNombre_txt);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(335, 98);
            this.panel3.TabIndex = 10;
            // 
            // estacionNumero_txt
            // 
            this.estacionNumero_txt.BackColor = System.Drawing.SystemColors.Info;
            this.estacionNumero_txt.Location = new System.Drawing.Point(127, 63);
            this.estacionNumero_txt.Name = "estacionNumero_txt";
            this.estacionNumero_txt.Size = new System.Drawing.Size(73, 20);
            this.estacionNumero_txt.TabIndex = 8;
            this.estacionNumero_txt.Validar = true;
            // 
            // estacionNombre_txt
            // 
            this.estacionNombre_txt.BackColor = System.Drawing.SystemColors.Info;
            this.estacionNombre_txt.Location = new System.Drawing.Point(127, 40);
            this.estacionNombre_txt.Name = "estacionNombre_txt";
            this.estacionNombre_txt.Size = new System.Drawing.Size(141, 20);
            this.estacionNombre_txt.TabIndex = 7;
            this.estacionNombre_txt.Validar = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.printerList_cb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(353, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 98);
            this.panel1.TabIndex = 7;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // loadSetting_btn
            // 
            this.loadSetting_btn.BackColor = System.Drawing.SystemColors.Info;
            this.loadSetting_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.loadSetting_btn.FlatAppearance.BorderSize = 2;
            this.loadSetting_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.loadSetting_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadSetting_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadSetting_btn.Image = global::SistemaParqueoSalida.Properties.Resources.download_load_file_512;
            this.loadSetting_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.loadSetting_btn.Location = new System.Drawing.Point(194, 19);
            this.loadSetting_btn.Name = "loadSetting_btn";
            this.loadSetting_btn.Size = new System.Drawing.Size(121, 50);
            this.loadSetting_btn.TabIndex = 13;
            this.loadSetting_btn.Text = "CARGAR ";
            this.loadSetting_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loadSetting_btn.UseVisualStyleBackColor = false;
            this.loadSetting_btn.Click += new System.EventHandler(this.loadSetting_btn_Click);
            // 
            // saveSettings_btn
            // 
            this.saveSettings_btn.BackColor = System.Drawing.SystemColors.Info;
            this.saveSettings_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.saveSettings_btn.FlatAppearance.BorderSize = 2;
            this.saveSettings_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.saveSettings_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveSettings_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveSettings_btn.Image = global::SistemaParqueoSalida.Properties.Resources.save;
            this.saveSettings_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveSettings_btn.Location = new System.Drawing.Point(299, 385);
            this.saveSettings_btn.Name = "saveSettings_btn";
            this.saveSettings_btn.Size = new System.Drawing.Size(132, 43);
            this.saveSettings_btn.TabIndex = 12;
            this.saveSettings_btn.Text = "GUARDAR";
            this.saveSettings_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveSettings_btn.UseVisualStyleBackColor = false;
            this.saveSettings_btn.Click += new System.EventHandler(this.saveSettings_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.estaciones_cb);
            this.groupBox1.Controls.Add(this.loadSetting_btn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 272);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 80);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CARGAR CONFIGURACION";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "ESTACION:";
            // 
            // estaciones_cb
            // 
            this.estaciones_cb.FormattingEnabled = true;
            this.estaciones_cb.Location = new System.Drawing.Point(86, 33);
            this.estaciones_cb.Name = "estaciones_cb";
            this.estaciones_cb.Size = new System.Drawing.Size(44, 21);
            this.estaciones_cb.TabIndex = 14;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.abrirBrazo_cb);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(194, 137);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(174, 94);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SALIDAS";
            // 
            // abrirBrazo_cb
            // 
            this.abrirBrazo_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.abrirBrazo_cb.FormattingEnabled = true;
            this.abrirBrazo_cb.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.abrirBrazo_cb.Location = new System.Drawing.Point(85, 41);
            this.abrirBrazo_cb.Name = "abrirBrazo_cb";
            this.abrirBrazo_cb.Size = new System.Drawing.Size(37, 21);
            this.abrirBrazo_cb.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 44);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "Abrir Brazo:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.loopSalida_cb);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(8, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(174, 94);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ENTRADAS";
            // 
            // loopSalida_cb
            // 
            this.loopSalida_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.loopSalida_cb.FormattingEnabled = true;
            this.loopSalida_cb.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.loopSalida_cb.Location = new System.Drawing.Point(105, 43);
            this.loopSalida_cb.Name = "loopSalida_cb";
            this.loopSalida_cb.Size = new System.Drawing.Size(37, 21);
            this.loopSalida_cb.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Loop Salida:";
            // 
            // ConfiguracionSalidaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(742, 438);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.saveSettings_btn);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "ConfiguracionSalidaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONFIGURACIÓN DE SISTEMA - ESTACIÓN SALIDA";
            this.Load += new System.EventHandler(this.ConfiguracionSalidaForm_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button EntradaSalida_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox baseDatosConexion_txt;
        private System.Windows.Forms.Label labelBaseDatos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox byPassAdam_chbox;
        private System.Windows.Forms.CheckBox byPassLoopSalida_chbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolTip configuracionesToolTip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox printerList_cb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button saveSettings_btn;
        private Controles.textbox estacionNumero_txt;
        private Controles.textbox estacionNombre_txt;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Controles.textbox adamPort_txt;
        private Controles.textbox adamIp_txt;
        private System.Windows.Forms.Button loadSetting_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox estaciones_cb;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox abrirBrazo_cb;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox loopSalida_cb;
        private System.Windows.Forms.Label label9;
    }
}