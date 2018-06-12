namespace SistemaParqueoSalida
{
    partial class TicketPerdidoForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Cedula_txt = new SistemaParqueoSalida.Controles.textbox(this.components);
            this.Nombre_txt = new SistemaParqueoSalida.Controles.textbox(this.components);
            this.ticketPerdido_txt = new SistemaParqueoSalida.Controles.textboxN(this.components);
            this.Devuelta_txt = new SistemaParqueoSalida.Controles.textboxN(this.components);
            this.Efectivo_txt = new SistemaParqueoSalida.Controles.textboxN(this.components);
            this.Placa_txt = new SistemaParqueoSalida.Controles.textbox(this.components);
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRECIO TICKET ($RD):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "NOMBRE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "CEDULA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "DEVUELTA:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "EFECTIVO RECIBIDO:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(63, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(237, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "REGISTRO TICKET PERDIDO";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Cedula_txt
            // 
            this.Cedula_txt.BackColor = System.Drawing.SystemColors.Info;
            this.Cedula_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cedula_txt.Location = new System.Drawing.Point(128, 140);
            this.Cedula_txt.Multiline = true;
            this.Cedula_txt.Name = "Cedula_txt";
            this.Cedula_txt.Size = new System.Drawing.Size(223, 37);
            this.Cedula_txt.TabIndex = 1;
            this.Cedula_txt.Validar = true;
            // 
            // Nombre_txt
            // 
            this.Nombre_txt.BackColor = System.Drawing.SystemColors.Info;
            this.Nombre_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre_txt.Location = new System.Drawing.Point(128, 97);
            this.Nombre_txt.Multiline = true;
            this.Nombre_txt.Name = "Nombre_txt";
            this.Nombre_txt.Size = new System.Drawing.Size(223, 37);
            this.Nombre_txt.TabIndex = 0;
            this.Nombre_txt.Validar = true;
            // 
            // ticketPerdido_txt
            // 
            this.ticketPerdido_txt.BackColor = System.Drawing.SystemColors.Info;
            this.ticketPerdido_txt.Enabled = false;
            this.ticketPerdido_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketPerdido_txt.Location = new System.Drawing.Point(200, 54);
            this.ticketPerdido_txt.Multiline = true;
            this.ticketPerdido_txt.Name = "ticketPerdido_txt";
            this.ticketPerdido_txt.Size = new System.Drawing.Size(151, 37);
            this.ticketPerdido_txt.TabIndex = 12;
            this.ticketPerdido_txt.Valor = SistemaParqueoSalida.Controles.textboxN.Tipo.Números;
            // 
            // Devuelta_txt
            // 
            this.Devuelta_txt.BackColor = System.Drawing.SystemColors.Info;
            this.Devuelta_txt.Enabled = false;
            this.Devuelta_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Devuelta_txt.Location = new System.Drawing.Point(181, 269);
            this.Devuelta_txt.Multiline = true;
            this.Devuelta_txt.Name = "Devuelta_txt";
            this.Devuelta_txt.ReadOnly = true;
            this.Devuelta_txt.Size = new System.Drawing.Size(170, 37);
            this.Devuelta_txt.TabIndex = 9;
            this.Devuelta_txt.Valor = SistemaParqueoSalida.Controles.textboxN.Tipo.Números;
            // 
            // Efectivo_txt
            // 
            this.Efectivo_txt.BackColor = System.Drawing.SystemColors.Info;
            this.Efectivo_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Efectivo_txt.Location = new System.Drawing.Point(181, 226);
            this.Efectivo_txt.Multiline = true;
            this.Efectivo_txt.Name = "Efectivo_txt";
            this.Efectivo_txt.Size = new System.Drawing.Size(170, 37);
            this.Efectivo_txt.TabIndex = 3;
            this.Efectivo_txt.Valor = SistemaParqueoSalida.Controles.textboxN.Tipo.Números;
            this.Efectivo_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Efectivo_txt_KeyDown);
            // 
            // Placa_txt
            // 
            this.Placa_txt.BackColor = System.Drawing.SystemColors.Info;
            this.Placa_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Placa_txt.Location = new System.Drawing.Point(128, 183);
            this.Placa_txt.Multiline = true;
            this.Placa_txt.Name = "Placa_txt";
            this.Placa_txt.Size = new System.Drawing.Size(223, 37);
            this.Placa_txt.TabIndex = 2;
            this.Placa_txt.Validar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "PLACA:";
            // 
            // TicketPerdidoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(363, 340);
            this.Controls.Add(this.Placa_txt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Cedula_txt);
            this.Controls.Add(this.Nombre_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ticketPerdido_txt);
            this.Controls.Add(this.Devuelta_txt);
            this.Controls.Add(this.Efectivo_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TicketPerdidoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TICKET PERDIDO";
            this.Load += new System.EventHandler(this.TicketPerdidoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Controles.textboxN Devuelta_txt;
        private Controles.textboxN Efectivo_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Controles.textboxN ticketPerdido_txt;
        private System.Windows.Forms.Label label6;
        private Controles.textbox Nombre_txt;
        private Controles.textbox Cedula_txt;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Controles.textbox Placa_txt;
        private System.Windows.Forms.Label label7;
    }
}