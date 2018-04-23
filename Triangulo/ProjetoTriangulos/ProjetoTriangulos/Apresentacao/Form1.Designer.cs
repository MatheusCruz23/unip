namespace ProjetoTriangulos
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
            this.lblPrimeiroLado = new System.Windows.Forms.Label();
            this.lblSegundoLado = new System.Windows.Forms.Label();
            this.lblTerceiroLado = new System.Windows.Forms.Label();
            this.lblResposta = new System.Windows.Forms.Label();
            this.txtPrimeiroLado = new System.Windows.Forms.TextBox();
            this.txtSegundoLado = new System.Windows.Forms.TextBox();
            this.txtTerceiroLado = new System.Windows.Forms.TextBox();
            this.btnVerificar_Click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPrimeiroLado
            // 
            this.lblPrimeiroLado.AutoSize = true;
            this.lblPrimeiroLado.Location = new System.Drawing.Point(33, 25);
            this.lblPrimeiroLado.Name = "lblPrimeiroLado";
            this.lblPrimeiroLado.Size = new System.Drawing.Size(40, 13);
            this.lblPrimeiroLado.TabIndex = 0;
            this.lblPrimeiroLado.Text = "Lado 1";
            // 
            // lblSegundoLado
            // 
            this.lblSegundoLado.AutoSize = true;
            this.lblSegundoLado.Location = new System.Drawing.Point(36, 76);
            this.lblSegundoLado.Name = "lblSegundoLado";
            this.lblSegundoLado.Size = new System.Drawing.Size(40, 13);
            this.lblSegundoLado.TabIndex = 1;
            this.lblSegundoLado.Text = "Lado 2";
            // 
            // lblTerceiroLado
            // 
            this.lblTerceiroLado.AutoSize = true;
            this.lblTerceiroLado.Location = new System.Drawing.Point(39, 128);
            this.lblTerceiroLado.Name = "lblTerceiroLado";
            this.lblTerceiroLado.Size = new System.Drawing.Size(40, 13);
            this.lblTerceiroLado.TabIndex = 2;
            this.lblTerceiroLado.Text = "Lado 3";
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Location = new System.Drawing.Point(36, 224);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(52, 13);
            this.lblResposta.TabIndex = 3;
            this.lblResposta.Text = "Resposta";
            // 
            // txtPrimeiroLado
            // 
            this.txtPrimeiroLado.Location = new System.Drawing.Point(36, 41);
            this.txtPrimeiroLado.Name = "txtPrimeiroLado";
            this.txtPrimeiroLado.Size = new System.Drawing.Size(199, 20);
            this.txtPrimeiroLado.TabIndex = 4;
            // 
            // txtSegundoLado
            // 
            this.txtSegundoLado.Location = new System.Drawing.Point(39, 93);
            this.txtSegundoLado.Name = "txtSegundoLado";
            this.txtSegundoLado.Size = new System.Drawing.Size(196, 20);
            this.txtSegundoLado.TabIndex = 5;
            // 
            // txtTerceiroLado
            // 
            this.txtTerceiroLado.Location = new System.Drawing.Point(42, 145);
            this.txtTerceiroLado.Name = "txtTerceiroLado";
            this.txtTerceiroLado.Size = new System.Drawing.Size(193, 20);
            this.txtTerceiroLado.TabIndex = 6;
            // 
            // btnVerificar_Click
            // 
            this.btnVerificar_Click.Location = new System.Drawing.Point(68, 182);
            this.btnVerificar_Click.Name = "btnVerificar_Click";
            this.btnVerificar_Click.Size = new System.Drawing.Size(134, 23);
            this.btnVerificar_Click.TabIndex = 7;
            this.btnVerificar_Click.Text = "Verificar";
            this.btnVerificar_Click.UseVisualStyleBackColor = true;
            this.btnVerificar_Click.Click += new System.EventHandler(this.btnVerificar_Click_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnVerificar_Click);
            this.Controls.Add(this.txtTerceiroLado);
            this.Controls.Add(this.txtSegundoLado);
            this.Controls.Add(this.txtPrimeiroLado);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.lblTerceiroLado);
            this.Controls.Add(this.lblSegundoLado);
            this.Controls.Add(this.lblPrimeiroLado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrimeiroLado;
        private System.Windows.Forms.Label lblSegundoLado;
        private System.Windows.Forms.Label lblTerceiroLado;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.TextBox txtPrimeiroLado;
        private System.Windows.Forms.TextBox txtSegundoLado;
        private System.Windows.Forms.TextBox txtTerceiroLado;
        private System.Windows.Forms.Button btnVerificar_Click;
    }
}

