namespace SistemaParqueoSalida
{
    partial class estacionSalidaMainForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.statusBasedatos_pic = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.statusVehiculoEntrada_pic = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.statusAdamEntrada_pic = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.statusPrinter_entrada_pic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menúToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirTicketAnteriorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tIEMPOPRECIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aGREGARUSUARIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gENERARREPORTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.statusAdamSalida = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.statusPrinterSalida_pic = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.readStatusEntrada_timer = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnTicketM = new System.Windows.Forms.Button();
            this.btnTicketP = new System.Windows.Forms.Button();
            this.txtLecturaTicket = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.readStatusSalida_timer = new System.Windows.Forms.Timer(this.components);
            this.disableEnter_timer = new System.Windows.Forms.Timer(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.tipoUsuario_lbl = new System.Windows.Forms.Label();
            this.receso_btn = new System.Windows.Forms.Button();
            this.cerrarSesion_btn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.usuario_lbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBasedatos_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusVehiculoEntrada_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusAdamEntrada_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusPrinter_entrada_pic)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusAdamSalida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusPrinterSalida_pic)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.statusBasedatos_pic);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.statusVehiculoEntrada_pic);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.statusAdamEntrada_pic);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.statusPrinter_entrada_pic);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(31, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 216);
            this.panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "STATUS BASEDATOS";
            // 
            // statusBasedatos_pic
            // 
            this.statusBasedatos_pic.Image = global::SistemaParqueoSalida.Properties.Resources.circle_error;
            this.statusBasedatos_pic.Location = new System.Drawing.Point(20, 86);
            this.statusBasedatos_pic.Name = "statusBasedatos_pic";
            this.statusBasedatos_pic.Size = new System.Drawing.Size(35, 35);
            this.statusBasedatos_pic.TabIndex = 7;
            this.statusBasedatos_pic.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "VEHICULO EN VENTANILLA";
            // 
            // statusVehiculoEntrada_pic
            // 
            this.statusVehiculoEntrada_pic.Image = global::SistemaParqueoSalida.Properties.Resources.circle_error;
            this.statusVehiculoEntrada_pic.Location = new System.Drawing.Point(20, 174);
            this.statusVehiculoEntrada_pic.Name = "statusVehiculoEntrada_pic";
            this.statusVehiculoEntrada_pic.Size = new System.Drawing.Size(35, 35);
            this.statusVehiculoEntrada_pic.TabIndex = 5;
            this.statusVehiculoEntrada_pic.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "STATUS ADAM";
            // 
            // statusAdamEntrada_pic
            // 
            this.statusAdamEntrada_pic.Image = global::SistemaParqueoSalida.Properties.Resources.circle_error;
            this.statusAdamEntrada_pic.Location = new System.Drawing.Point(20, 133);
            this.statusAdamEntrada_pic.Name = "statusAdamEntrada_pic";
            this.statusAdamEntrada_pic.Size = new System.Drawing.Size(35, 35);
            this.statusAdamEntrada_pic.TabIndex = 3;
            this.statusAdamEntrada_pic.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "STATUS PRINTER";
            // 
            // statusPrinter_entrada_pic
            // 
            this.statusPrinter_entrada_pic.Image = global::SistemaParqueoSalida.Properties.Resources.circle_error;
            this.statusPrinter_entrada_pic.Location = new System.Drawing.Point(20, 45);
            this.statusPrinter_entrada_pic.Name = "statusPrinter_entrada_pic";
            this.statusPrinter_entrada_pic.Size = new System.Drawing.Size(35, 35);
            this.statusPrinter_entrada_pic.TabIndex = 1;
            this.statusPrinter_entrada_pic.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(39, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "STATUS ESTACIÓN ENTRADA";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.AliceBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menúToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1111, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menúToolStripMenuItem
            // 
            this.menúToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imprimirTicketAnteriorToolStripMenuItem,
            this.configuraciónToolStripMenuItem,
            this.tIEMPOPRECIOToolStripMenuItem,
            this.aGREGARUSUARIOToolStripMenuItem,
            this.gENERARREPORTESToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menúToolStripMenuItem.Image = global::SistemaParqueoSalida.Properties.Resources.menu;
            this.menúToolStripMenuItem.Name = "menúToolStripMenuItem";
            this.menúToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.menúToolStripMenuItem.Text = "MENÚ";
            // 
            // imprimirTicketAnteriorToolStripMenuItem
            // 
            this.imprimirTicketAnteriorToolStripMenuItem.Name = "imprimirTicketAnteriorToolStripMenuItem";
            this.imprimirTicketAnteriorToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.imprimirTicketAnteriorToolStripMenuItem.Text = "IMPRIMIR TICKET ANTERIOR";
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.Image = global::SistemaParqueoSalida.Properties.Resources.configure;
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.configuraciónToolStripMenuItem.Text = "CONFIGURACIÓN";
            this.configuraciónToolStripMenuItem.Click += new System.EventHandler(this.configuraciónToolStripMenuItem_Click);
            // 
            // tIEMPOPRECIOToolStripMenuItem
            // 
            this.tIEMPOPRECIOToolStripMenuItem.Image = global::SistemaParqueoSalida.Properties.Resources.clock;
            this.tIEMPOPRECIOToolStripMenuItem.Name = "tIEMPOPRECIOToolStripMenuItem";
            this.tIEMPOPRECIOToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.tIEMPOPRECIOToolStripMenuItem.Text = "TIEMPO-PRECIO";
            this.tIEMPOPRECIOToolStripMenuItem.Click += new System.EventHandler(this.tIEMPOPRECIOToolStripMenuItem_Click);
            // 
            // aGREGARUSUARIOToolStripMenuItem
            // 
            this.aGREGARUSUARIOToolStripMenuItem.Name = "aGREGARUSUARIOToolStripMenuItem";
            this.aGREGARUSUARIOToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.aGREGARUSUARIOToolStripMenuItem.Text = "AGREGAR USUARIO";
            this.aGREGARUSUARIOToolStripMenuItem.Click += new System.EventHandler(this.aGREGARUSUARIOToolStripMenuItem_Click);
            // 
            // gENERARREPORTESToolStripMenuItem
            // 
            this.gENERARREPORTESToolStripMenuItem.Name = "gENERARREPORTESToolStripMenuItem";
            this.gENERARREPORTESToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.gENERARREPORTESToolStripMenuItem.Text = "GENERAR REPORTES";
            this.gENERARREPORTESToolStripMenuItem.Click += new System.EventHandler(this.gENERARREPORTESToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = global::SistemaParqueoSalida.Properties.Resources.exit;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.salirToolStripMenuItem.Text = "SALIR";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.statusAdamSalida);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.statusPrinterSalida_pic);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(31, 248);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(295, 153);
            this.panel2.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "STATUS ADAM";
            // 
            // statusAdamSalida
            // 
            this.statusAdamSalida.Image = global::SistemaParqueoSalida.Properties.Resources.circle_error;
            this.statusAdamSalida.Location = new System.Drawing.Point(20, 95);
            this.statusAdamSalida.Name = "statusAdamSalida";
            this.statusAdamSalida.Size = new System.Drawing.Size(35, 35);
            this.statusAdamSalida.TabIndex = 3;
            this.statusAdamSalida.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "STATUS PRINTER";
            // 
            // statusPrinterSalida_pic
            // 
            this.statusPrinterSalida_pic.Image = global::SistemaParqueoSalida.Properties.Resources.circle_error;
            this.statusPrinterSalida_pic.Location = new System.Drawing.Point(20, 45);
            this.statusPrinterSalida_pic.Name = "statusPrinterSalida_pic";
            this.statusPrinterSalida_pic.Size = new System.Drawing.Size(35, 35);
            this.statusPrinterSalida_pic.TabIndex = 1;
            this.statusPrinterSalida_pic.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(36, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(221, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "STATUS ESTACIÓN SALIDA";
            // 
            // readStatusEntrada_timer
            // 
            this.readStatusEntrada_timer.Interval = 500;
            this.readStatusEntrada_timer.Tick += new System.EventHandler(this.readStatusEntrada_timer_Tick);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btnTicketM);
            this.panel3.Controls.Add(this.btnTicketP);
            this.panel3.Controls.Add(this.txtLecturaTicket);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(367, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(340, 202);
            this.panel3.TabIndex = 3;
            // 
            // btnTicketM
            // 
            this.btnTicketM.BackColor = System.Drawing.SystemColors.Info;
            this.btnTicketM.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTicketM.FlatAppearance.BorderSize = 2;
            this.btnTicketM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.btnTicketM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTicketM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTicketM.Location = new System.Drawing.Point(191, 141);
            this.btnTicketM.Name = "btnTicketM";
            this.btnTicketM.Size = new System.Drawing.Size(112, 54);
            this.btnTicketM.TabIndex = 3;
            this.btnTicketM.Text = "TICKET MANUAL";
            this.btnTicketM.UseVisualStyleBackColor = false;
            this.btnTicketM.Click += new System.EventHandler(this.btnTicketM_Click);
            // 
            // btnTicketP
            // 
            this.btnTicketP.BackColor = System.Drawing.SystemColors.Info;
            this.btnTicketP.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTicketP.FlatAppearance.BorderSize = 2;
            this.btnTicketP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.btnTicketP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTicketP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTicketP.Location = new System.Drawing.Point(26, 141);
            this.btnTicketP.Name = "btnTicketP";
            this.btnTicketP.Size = new System.Drawing.Size(112, 54);
            this.btnTicketP.TabIndex = 2;
            this.btnTicketP.Text = "TICKET PERDIDO";
            this.btnTicketP.UseVisualStyleBackColor = false;
            this.btnTicketP.Click += new System.EventHandler(this.btnTicketP_Click);
            // 
            // txtLecturaTicket
            // 
            this.txtLecturaTicket.BackColor = System.Drawing.SystemColors.Info;
            this.txtLecturaTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLecturaTicket.Location = new System.Drawing.Point(76, 40);
            this.txtLecturaTicket.Multiline = true;
            this.txtLecturaTicket.Name = "txtLecturaTicket";
            this.txtLecturaTicket.Size = new System.Drawing.Size(185, 42);
            this.txtLecturaTicket.TabIndex = 0;
            this.txtLecturaTicket.TextChanged += new System.EventHandler(this.txtLecturaTicket_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(111, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 18);
            this.label9.TabIndex = 1;
            this.label9.Text = "LEER TICKET";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // readStatusSalida_timer
            // 
            this.readStatusSalida_timer.Interval = 500;
            this.readStatusSalida_timer.Tick += new System.EventHandler(this.readStatusSalida_timer_Tick);
            // 
            // disableEnter_timer
            // 
            this.disableEnter_timer.Interval = 200;
            this.disableEnter_timer.Tick += new System.EventHandler(this.disableEnter_timer_Tick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tipoUsuario_lbl);
            this.panel4.Controls.Add(this.receso_btn);
            this.panel4.Controls.Add(this.cerrarSesion_btn);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.usuario_lbl);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Location = new System.Drawing.Point(141, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(798, 50);
            this.panel4.TabIndex = 4;
            // 
            // tipoUsuario_lbl
            // 
            this.tipoUsuario_lbl.AutoSize = true;
            this.tipoUsuario_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoUsuario_lbl.Location = new System.Drawing.Point(366, 17);
            this.tipoUsuario_lbl.Name = "tipoUsuario_lbl";
            this.tipoUsuario_lbl.Size = new System.Drawing.Size(11, 13);
            this.tipoUsuario_lbl.TabIndex = 9;
            this.tipoUsuario_lbl.Text = "t";
            // 
            // receso_btn
            // 
            this.receso_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receso_btn.Location = new System.Drawing.Point(446, 3);
            this.receso_btn.Name = "receso_btn";
            this.receso_btn.Size = new System.Drawing.Size(95, 39);
            this.receso_btn.TabIndex = 8;
            this.receso_btn.Text = "Receso";
            this.receso_btn.UseVisualStyleBackColor = true;
            this.receso_btn.Click += new System.EventHandler(this.receso_btn_Click);
            // 
            // cerrarSesion_btn
            // 
            this.cerrarSesion_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrarSesion_btn.Location = new System.Drawing.Point(655, 3);
            this.cerrarSesion_btn.Name = "cerrarSesion_btn";
            this.cerrarSesion_btn.Size = new System.Drawing.Size(96, 39);
            this.cerrarSesion_btn.TabIndex = 7;
            this.cerrarSesion_btn.Text = "Cerrar Sesión";
            this.cerrarSesion_btn.UseVisualStyleBackColor = true;
            this.cerrarSesion_btn.Click += new System.EventHandler(this.cerrarSesion_btn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(265, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "TIPO USUARIO: ";
            // 
            // usuario_lbl
            // 
            this.usuario_lbl.AutoSize = true;
            this.usuario_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario_lbl.Location = new System.Drawing.Point(106, 17);
            this.usuario_lbl.Name = "usuario_lbl";
            this.usuario_lbl.Size = new System.Drawing.Size(14, 13);
            this.usuario_lbl.TabIndex = 5;
            this.usuario_lbl.Text = "u";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(29, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "USUARIO: ";
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Location = new System.Drawing.Point(217, 107);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(722, 404);
            this.panel5.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.panel4);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 24);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1111, 60);
            this.panel6.TabIndex = 6;
            // 
            // estacionSalidaMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1111, 514);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "estacionSalidaMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ESTACION SALIDA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.estacionSalidaMainForm_FormClosing);
            this.Load += new System.EventHandler(this.estacionSalidaMainForm_Load);
            this.Shown += new System.EventHandler(this.estacionSalidaMainForm_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBasedatos_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusVehiculoEntrada_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusAdamEntrada_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusPrinter_entrada_pic)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusAdamSalida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusPrinterSalida_pic)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox statusVehiculoEntrada_pic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox statusAdamEntrada_pic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox statusPrinter_entrada_pic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox statusAdamSalida;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox statusPrinterSalida_pic;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripMenuItem menúToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirTicketAnteriorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Timer readStatusEntrada_timer;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox statusBasedatos_pic;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtLecturaTicket;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnTicketM;
        private System.Windows.Forms.Button btnTicketP;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer readStatusSalida_timer;
        private System.Windows.Forms.ToolStripMenuItem tIEMPOPRECIOToolStripMenuItem;
        private System.Windows.Forms.Timer disableEnter_timer;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label usuario_lbl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolStripMenuItem aGREGARUSUARIOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gENERARREPORTESToolStripMenuItem;
        private System.Windows.Forms.Label tipoUsuario_lbl;
        private System.Windows.Forms.Button receso_btn;
        private System.Windows.Forms.Button cerrarSesion_btn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
    }
}

