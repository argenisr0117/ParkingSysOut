namespace SistemaParqueoSalida
{
    partial class TicketManualForm
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
            this.fechaActual_dtp = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDuracionTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalPagar = new System.Windows.Forms.TextBox();
            this.fechaEntrada_dtp = new System.Windows.Forms.DateTimePicker();
            this.Devuelta_txt = new SistemaParqueoSalida.Controles.textboxN(this.components);
            this.Efectivo_txt = new SistemaParqueoSalida.Controles.textboxN(this.components);
            this.cancelarTransaccion_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // fechaActual_dtp
            // 
            this.fechaActual_dtp.CustomFormat = "hh:mm tt dd/MM/yyyy ";
            this.fechaActual_dtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaActual_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaActual_dtp.Location = new System.Drawing.Point(215, 52);
            this.fechaActual_dtp.Name = "fechaActual_dtp";
            this.fechaActual_dtp.ShowUpDown = true;
            this.fechaActual_dtp.Size = new System.Drawing.Size(235, 26);
            this.fechaActual_dtp.TabIndex = 2;
            this.fechaActual_dtp.Value = new System.DateTime(2017, 7, 27, 22, 31, 4, 0);
            this.fechaActual_dtp.ValueChanged += new System.EventHandler(this.fechaActual_dtp_ValueChanged);
            this.fechaActual_dtp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fechaActual_dtp_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblDuracionTotal);
            this.panel1.Location = new System.Drawing.Point(200, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 37);
            this.panel1.TabIndex = 10;
            // 
            // lblDuracionTotal
            // 
            this.lblDuracionTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDuracionTotal.AutoSize = true;
            this.lblDuracionTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuracionTotal.Location = new System.Drawing.Point(29, 8);
            this.lblDuracionTotal.Name = "lblDuracionTotal";
            this.lblDuracionTotal.Size = new System.Drawing.Size(52, 18);
            this.lblDuracionTotal.TabIndex = 0;
            this.lblDuracionTotal.Text = "label5";
            this.lblDuracionTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "DURACIÓN TOTAL: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "FECHA SALIDA: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "FECHA ENTRADA: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "DEVUELTA:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "EFECTIVO RECIBIDO:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "TOTAL A PAGAR:";
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.BackColor = System.Drawing.SystemColors.Info;
            this.txtTotalPagar.Enabled = false;
            this.txtTotalPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPagar.Location = new System.Drawing.Point(200, 53);
            this.txtTotalPagar.Multiline = true;
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.Size = new System.Drawing.Size(175, 37);
            this.txtTotalPagar.TabIndex = 18;
            // 
            // fechaEntrada_dtp
            // 
            this.fechaEntrada_dtp.CustomFormat = "hh:mm tt dd/MM/yyyy ";
            this.fechaEntrada_dtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaEntrada_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaEntrada_dtp.Location = new System.Drawing.Point(215, 99);
            this.fechaEntrada_dtp.Name = "fechaEntrada_dtp";
            this.fechaEntrada_dtp.ShowUpDown = true;
            this.fechaEntrada_dtp.Size = new System.Drawing.Size(235, 26);
            this.fechaEntrada_dtp.TabIndex = 0;
            this.fechaEntrada_dtp.Value = new System.DateTime(2017, 7, 27, 22, 31, 4, 0);
            this.fechaEntrada_dtp.ValueChanged += new System.EventHandler(this.fechaEntrada_dtp_ValueChanged);
            this.fechaEntrada_dtp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fechaEntrada_dtp_KeyDown);
            // 
            // Devuelta_txt
            // 
            this.Devuelta_txt.BackColor = System.Drawing.SystemColors.Info;
            this.Devuelta_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Devuelta_txt.Location = new System.Drawing.Point(200, 139);
            this.Devuelta_txt.Multiline = true;
            this.Devuelta_txt.Name = "Devuelta_txt";
            this.Devuelta_txt.ReadOnly = true;
            this.Devuelta_txt.Size = new System.Drawing.Size(175, 37);
            this.Devuelta_txt.TabIndex = 14;
            this.Devuelta_txt.Valor = SistemaParqueoSalida.Controles.textboxN.Tipo.Números;
            // 
            // Efectivo_txt
            // 
            this.Efectivo_txt.BackColor = System.Drawing.SystemColors.Info;
            this.Efectivo_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Efectivo_txt.Location = new System.Drawing.Point(200, 96);
            this.Efectivo_txt.Multiline = true;
            this.Efectivo_txt.Name = "Efectivo_txt";
            this.Efectivo_txt.Size = new System.Drawing.Size(175, 37);
            this.Efectivo_txt.TabIndex = 1;
            this.Efectivo_txt.Valor = SistemaParqueoSalida.Controles.textboxN.Tipo.Números;
            this.Efectivo_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Efectivo_txt_KeyDown);
            // 
            // cancelarTransaccion_btn
            // 
            this.cancelarTransaccion_btn.BackColor = System.Drawing.Color.IndianRed;
            this.cancelarTransaccion_btn.Location = new System.Drawing.Point(118, 194);
            this.cancelarTransaccion_btn.Name = "cancelarTransaccion_btn";
            this.cancelarTransaccion_btn.Size = new System.Drawing.Size(174, 72);
            this.cancelarTransaccion_btn.TabIndex = 19;
            this.cancelarTransaccion_btn.Text = "CANCELAR TRANSACCI0N";
            this.cancelarTransaccion_btn.UseVisualStyleBackColor = false;
            this.cancelarTransaccion_btn.Click += new System.EventHandler(this.cancelarTransaccion_btn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Efectivo_txt);
            this.panel2.Controls.Add(this.cancelarTransaccion_btn);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.Devuelta_txt);
            this.panel2.Controls.Add(this.txtTotalPagar);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(21, 141);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(429, 272);
            this.panel2.TabIndex = 20;
            this.panel2.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(142, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 24);
            this.label7.TabIndex = 21;
            this.label7.Text = "TICKET MANUAL";
            // 
            // TicketManualForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(462, 440);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.fechaEntrada_dtp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fechaActual_dtp);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TicketManualForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TICKET MANUAL";
            this.Load += new System.EventHandler(this.TicketManualForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker fechaActual_dtp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDuracionTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Controles.textboxN Devuelta_txt;
        private Controles.textboxN Efectivo_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotalPagar;
        private System.Windows.Forms.DateTimePicker fechaEntrada_dtp;
        private System.Windows.Forms.Button cancelarTransaccion_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
    }
}