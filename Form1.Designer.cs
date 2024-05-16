namespace Ejercicio1ClaseProg2
{
    partial class Form1Notafinal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblIngreseUltimaNota = new System.Windows.Forms.Label();
            this.txtNotaFinal = new System.Windows.Forms.TextBox();
            this.btnResultado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIngreseUltimaNota
            // 
            this.lblIngreseUltimaNota.AutoSize = true;
            this.lblIngreseUltimaNota.Location = new System.Drawing.Point(222, 114);
            this.lblIngreseUltimaNota.Name = "lblIngreseUltimaNota";
            this.lblIngreseUltimaNota.Size = new System.Drawing.Size(109, 15);
            this.lblIngreseUltimaNota.TabIndex = 0;
            this.lblIngreseUltimaNota.Text = "Ingrese última nota";
            // 
            // txtNotaFinal
            // 
            this.txtNotaFinal.Location = new System.Drawing.Point(337, 111);
            this.txtNotaFinal.Name = "txtNotaFinal";
            this.txtNotaFinal.Size = new System.Drawing.Size(156, 23);
            this.txtNotaFinal.TabIndex = 1;
            // 
            // btnResultado
            // 
            this.btnResultado.Location = new System.Drawing.Point(418, 173);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(75, 23);
            this.btnResultado.TabIndex = 2;
            this.btnResultado.Text = "Resultado";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // Form1Notafinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.txtNotaFinal);
            this.Controls.Add(this.lblIngreseUltimaNota);
            this.Name = "Form1Notafinal";
            this.Text = "Ejercicio1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblIngreseUltimaNota;
        private TextBox txtNotaFinal;
        private Button btnResultado;
    }
}