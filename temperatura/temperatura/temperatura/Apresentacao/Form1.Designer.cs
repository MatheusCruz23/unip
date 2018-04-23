namespace temperatura
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbTemperatura = new System.Windows.Forms.TextBox();
            this.rdbCF = new System.Windows.Forms.RadioButton();
            this.rdbFC = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insira a Temperatura";
            // 
            // txbTemperatura
            // 
            this.txbTemperatura.Location = new System.Drawing.Point(31, 49);
            this.txbTemperatura.Name = "txbTemperatura";
            this.txbTemperatura.Size = new System.Drawing.Size(241, 20);
            this.txbTemperatura.TabIndex = 1;
            // 
            // rdbCF
            // 
            this.rdbCF.AutoSize = true;
            this.rdbCF.Location = new System.Drawing.Point(31, 93);
            this.rdbCF.Name = "rdbCF";
            this.rdbCF.Size = new System.Drawing.Size(117, 17);
            this.rdbCF.TabIndex = 2;
            this.rdbCF.TabStop = true;
            this.rdbCF.Text = "Celsius - Fahrenheit";
            this.rdbCF.UseVisualStyleBackColor = true;
            // 
            // rdbFC
            // 
            this.rdbFC.AutoSize = true;
            this.rdbFC.Location = new System.Drawing.Point(31, 125);
            this.rdbFC.Name = "rdbFC";
            this.rdbFC.Size = new System.Drawing.Size(117, 17);
            this.rdbFC.TabIndex = 3;
            this.rdbFC.TabStop = true;
            this.rdbFC.Text = "Fahrenheit - Celsius";
            this.rdbFC.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(31, 172);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(241, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(31, 216);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(52, 13);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "Resposta";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.rdbFC);
            this.Controls.Add(this.rdbCF);
            this.Controls.Add(this.txbTemperatura);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbTemperatura;
        private System.Windows.Forms.RadioButton rdbCF;
        private System.Windows.Forms.RadioButton rdbFC;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResultado;
    }
}

