namespace SistemaParqueoSalida
{
    partial class configuracionTiempoPrecioForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbPosicion = new System.Windows.Forms.ComboBox();
            this.txtTiempo = new SistemaParqueoSalida.Controles.textboxN(this.components);
            this.txtPrecio = new SistemaParqueoSalida.Controles.textboxN(this.components);
            this.dtgTiempoPrecio = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.exit_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.saveSettings_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTiempoPrecio)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "POSICIÓN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "TIEMPO (MIN):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "PRECIO:";
            // 
            // cbPosicion
            // 
            this.cbPosicion.BackColor = System.Drawing.SystemColors.Info;
            this.cbPosicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPosicion.FormattingEnabled = true;
            this.cbPosicion.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbPosicion.Location = new System.Drawing.Point(83, 12);
            this.cbPosicion.Name = "cbPosicion";
            this.cbPosicion.Size = new System.Drawing.Size(56, 21);
            this.cbPosicion.TabIndex = 0;
            // 
            // txtTiempo
            // 
            this.txtTiempo.BackColor = System.Drawing.SystemColors.Info;
            this.txtTiempo.Location = new System.Drawing.Point(222, 12);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(66, 20);
            this.txtTiempo.TabIndex = 1;
            this.txtTiempo.Valor = SistemaParqueoSalida.Controles.textboxN.Tipo.Números;
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.SystemColors.Info;
            this.txtPrecio.Location = new System.Drawing.Point(350, 11);
            this.txtPrecio.Multiline = true;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(83, 23);
            this.txtPrecio.TabIndex = 2;
            this.txtPrecio.Valor = SistemaParqueoSalida.Controles.textboxN.Tipo.Números;
            // 
            // dtgTiempoPrecio
            // 
            this.dtgTiempoPrecio.AllowUserToAddRows = false;
            this.dtgTiempoPrecio.AllowUserToDeleteRows = false;
            this.dtgTiempoPrecio.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dtgTiempoPrecio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTiempoPrecio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.posicion,
            this.tiempo,
            this.precio});
            this.dtgTiempoPrecio.Location = new System.Drawing.Point(0, 61);
            this.dtgTiempoPrecio.MultiSelect = false;
            this.dtgTiempoPrecio.Name = "dtgTiempoPrecio";
            this.dtgTiempoPrecio.ReadOnly = true;
            this.dtgTiempoPrecio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgTiempoPrecio.Size = new System.Drawing.Size(344, 173);
            this.dtgTiempoPrecio.TabIndex = 3;
            this.dtgTiempoPrecio.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgTiempoPrecio_CellDoubleClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // posicion
            // 
            this.posicion.HeaderText = "POSICIÓN";
            this.posicion.Name = "posicion";
            this.posicion.ReadOnly = true;
            // 
            // tiempo
            // 
            this.tiempo.HeaderText = "TIEMPO(MIN)";
            this.tiempo.Name = "tiempo";
            this.tiempo.ReadOnly = true;
            // 
            // precio
            // 
            this.precio.HeaderText = "PRECIO";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 237);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 34);
            this.panel1.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(15, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "DOBLE CLICK PARA EDITAR";
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
            this.exit_btn.Location = new System.Drawing.Point(350, 177);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(83, 57);
            this.exit_btn.TabIndex = 16;
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
            this.cancel_btn.Location = new System.Drawing.Point(350, 119);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(83, 57);
            this.cancel_btn.TabIndex = 15;
            this.cancel_btn.Text = "CANCELAR";
            this.cancel_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
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
            this.saveSettings_btn.Location = new System.Drawing.Point(350, 61);
            this.saveSettings_btn.Name = "saveSettings_btn";
            this.saveSettings_btn.Size = new System.Drawing.Size(83, 57);
            this.saveSettings_btn.TabIndex = 13;
            this.saveSettings_btn.Text = "GUARDAR";
            this.saveSettings_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.saveSettings_btn.UseVisualStyleBackColor = false;
            this.saveSettings_btn.Click += new System.EventHandler(this.saveSettings_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-3, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(457, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "___________________________________________________________________________";
            // 
            // configuracionTiempoPrecioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(438, 271);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.saveSettings_btn);
            this.Controls.Add(this.dtgTiempoPrecio);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtTiempo);
            this.Controls.Add(this.cbPosicion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "configuracionTiempoPrecioForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CONFIGURACIÓN DE TIEMPO-PRECIO";
            this.Load += new System.EventHandler(this.configuracionTiempoPrecioForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTiempoPrecio)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbPosicion;
        private Controles.textboxN txtTiempo;
        private Controles.textboxN txtPrecio;
        private System.Windows.Forms.DataGridView dtgTiempoPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn posicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.Button saveSettings_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Label label5;
    }
}