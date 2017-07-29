namespace SistemaParqueoSalida
{
    partial class CobroAutomaticoPopUpForm
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
            this.txtTotalPagar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDuracionTotal = new System.Windows.Forms.Label();
            this.Devuelta_txt = new SistemaParqueoSalida.Controles.textboxN(this.components);
            this.Efectivo_txt = new SistemaParqueoSalida.Controles.textboxN(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.BackColor = System.Drawing.SystemColors.Info;
            this.txtTotalPagar.Enabled = false;
            this.txtTotalPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPagar.Location = new System.Drawing.Point(177, 57);
            this.txtTotalPagar.Multiline = true;
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.Size = new System.Drawing.Size(151, 37);
            this.txtTotalPagar.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "TOTAL A PAGAR:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "EFECTIVO RECIBIDO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "DEVUELTA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "DURACIÓN TOTAL: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblDuracionTotal);
            this.panel1.Location = new System.Drawing.Point(177, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(151, 37);
            this.panel1.TabIndex = 8;
            // 
            // lblDuracionTotal
            // 
            this.lblDuracionTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDuracionTotal.AutoSize = true;
            this.lblDuracionTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuracionTotal.Location = new System.Drawing.Point(24, 8);
            this.lblDuracionTotal.Name = "lblDuracionTotal";
            this.lblDuracionTotal.Size = new System.Drawing.Size(52, 18);
            this.lblDuracionTotal.TabIndex = 0;
            this.lblDuracionTotal.Text = "label5";
            this.lblDuracionTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Devuelta_txt
            // 
            this.Devuelta_txt.BackColor = System.Drawing.SystemColors.Info;
            this.Devuelta_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Devuelta_txt.Location = new System.Drawing.Point(177, 143);
            this.Devuelta_txt.Multiline = true;
            this.Devuelta_txt.Name = "Devuelta_txt";
            this.Devuelta_txt.ReadOnly = true;
            this.Devuelta_txt.Size = new System.Drawing.Size(151, 37);
            this.Devuelta_txt.TabIndex = 1;
            this.Devuelta_txt.Valor = SistemaParqueoSalida.Controles.textboxN.Tipo.Números;
            // 
            // Efectivo_txt
            // 
            this.Efectivo_txt.BackColor = System.Drawing.SystemColors.Info;
            this.Efectivo_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Efectivo_txt.Location = new System.Drawing.Point(177, 100);
            this.Efectivo_txt.Multiline = true;
            this.Efectivo_txt.Name = "Efectivo_txt";
            this.Efectivo_txt.Size = new System.Drawing.Size(151, 37);
            this.Efectivo_txt.TabIndex = 0;
            this.Efectivo_txt.Valor = SistemaParqueoSalida.Controles.textboxN.Tipo.Números;
            this.Efectivo_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Efectivo_txt_KeyDown);
            // 
            // CobroAutomaticoPopUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(360, 200);
            this.Controls.Add(this.Devuelta_txt);
            this.Controls.Add(this.Efectivo_txt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotalPagar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CobroAutomaticoPopUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.CobroAutomaticoPopUpForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTotalPagar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDuracionTotal;
        private Controles.textboxN Efectivo_txt;
        private Controles.textboxN Devuelta_txt;
    }
}