namespace Ejercicio1ClaseProg2
{
    partial class Form2SumaPar
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
            this.lblIngreseNumero1 = new System.Windows.Forms.Label();
            this.lblIngreseNumero2 = new System.Windows.Forms.Label();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.btnSuma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIngreseNumero1
            // 
            this.lblIngreseNumero1.AutoSize = true;
            this.lblIngreseNumero1.Location = new System.Drawing.Point(186, 109);
            this.lblIngreseNumero1.Name = "lblIngreseNumero1";
            this.lblIngreseNumero1.Size = new System.Drawing.Size(60, 15);
            this.lblIngreseNumero1.TabIndex = 0;
            this.lblIngreseNumero1.Text = "Numero 1";
            // 
            // lblIngreseNumero2
            // 
            this.lblIngreseNumero2.AutoSize = true;
            this.lblIngreseNumero2.Location = new System.Drawing.Point(186, 163);
            this.lblIngreseNumero2.Name = "lblIngreseNumero2";
            this.lblIngreseNumero2.Size = new System.Drawing.Size(60, 15);
            this.lblIngreseNumero2.TabIndex = 1;
            this.lblIngreseNumero2.Text = "Numero 2";
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(273, 109);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(100, 23);
            this.txtNumero1.TabIndex = 2;
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(273, 160);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(100, 23);
            this.txtNumero2.TabIndex = 3;
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(401, 132);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(75, 23);
            this.btnSuma.TabIndex = 4;
            this.btnSuma.Text = "Suma";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // Form2SumaPar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.lblIngreseNumero2);
            this.Controls.Add(this.lblIngreseNumero1);
            this.Name = "Form2SumaPar";
            this.Text = "Ejercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblIngreseNumero1;
        private Label lblIngreseNumero2;
        private TextBox txtNumero1;
        private TextBox txtNumero2;
        private Button btnSuma;
    }
}