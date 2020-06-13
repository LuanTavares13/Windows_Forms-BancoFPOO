namespace WF_BancoPOO
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.txtValorSacar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValorDepositar = new System.Windows.Forms.TextBox();
            this.btnExibirSaldo = new System.Windows.Forms.Button();
            this.lblValorSaldo = new System.Windows.Forms.Label();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.btnSacar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Digite o valor a sacar:";
            // 
            // txtValorSacar
            // 
            this.txtValorSacar.Location = new System.Drawing.Point(195, 85);
            this.txtValorSacar.Name = "txtValorSacar";
            this.txtValorSacar.Size = new System.Drawing.Size(100, 20);
            this.txtValorSacar.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Digite o valor para depositar:";
            // 
            // txtValorDepositar
            // 
            this.txtValorDepositar.Location = new System.Drawing.Point(195, 52);
            this.txtValorDepositar.Name = "txtValorDepositar";
            this.txtValorDepositar.Size = new System.Drawing.Size(100, 20);
            this.txtValorDepositar.TabIndex = 1;
            this.txtValorDepositar.TextChanged += new System.EventHandler(this.txtValorDepositar_TextChanged);
            // 
            // btnExibirSaldo
            // 
            this.btnExibirSaldo.Location = new System.Drawing.Point(48, 119);
            this.btnExibirSaldo.Name = "btnExibirSaldo";
            this.btnExibirSaldo.Size = new System.Drawing.Size(75, 23);
            this.btnExibirSaldo.TabIndex = 5;
            this.btnExibirSaldo.Text = "Exibir saldo";
            this.btnExibirSaldo.UseVisualStyleBackColor = true;
            this.btnExibirSaldo.Click += new System.EventHandler(this.btnExibirSaldo_Click);
            // 
            // lblValorSaldo
            // 
            this.lblValorSaldo.AutoSize = true;
            this.lblValorSaldo.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblValorSaldo.Location = new System.Drawing.Point(48, 154);
            this.lblValorSaldo.MaximumSize = new System.Drawing.Size(200, 0);
            this.lblValorSaldo.Name = "lblValorSaldo";
            this.lblValorSaldo.Size = new System.Drawing.Size(0, 13);
            this.lblValorSaldo.TabIndex = 7;
            this.lblValorSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDepositar
            // 
            this.btnDepositar.Location = new System.Drawing.Point(302, 52);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(75, 23);
            this.btnDepositar.TabIndex = 2;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // btnSacar
            // 
            this.btnSacar.Location = new System.Drawing.Point(302, 85);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(75, 23);
            this.btnSacar.TabIndex = 4;
            this.btnSacar.Text = "Sacar";
            this.btnSacar.UseVisualStyleBackColor = true;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(130, 119);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 191);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSacar);
            this.Controls.Add(this.btnDepositar);
            this.Controls.Add(this.lblValorSaldo);
            this.Controls.Add(this.btnExibirSaldo);
            this.Controls.Add(this.txtValorDepositar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtValorSacar);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Banco ACME ...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValorSacar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValorDepositar;
        private System.Windows.Forms.Button btnExibirSaldo;
        private System.Windows.Forms.Label lblValorSaldo;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.Button btnLimpar;
    }
}

