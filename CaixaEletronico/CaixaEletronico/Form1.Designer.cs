namespace CaixaEletronico
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
            this.textoTitular = new System.Windows.Forms.TextBox();
            this.textoSaldo = new System.Windows.Forms.TextBox();
            this.textoNumero = new System.Windows.Forms.TextBox();
            this.textoValor = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboContas = new System.Windows.Forms.ComboBox();
            this.buttonDeposito = new System.Windows.Forms.Button();
            this.buttonSaque = new System.Windows.Forms.Button();
            this.destinoDaTransferencia = new System.Windows.Forms.ComboBox();
            this.buttonTransferir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textoTitular
            // 
            this.textoTitular.Location = new System.Drawing.Point(12, 12);
            this.textoTitular.Name = "textoTitular";
            this.textoTitular.Size = new System.Drawing.Size(100, 22);
            this.textoTitular.TabIndex = 0;
            // 
            // textoSaldo
            // 
            this.textoSaldo.Location = new System.Drawing.Point(118, 12);
            this.textoSaldo.Name = "textoSaldo";
            this.textoSaldo.Size = new System.Drawing.Size(111, 22);
            this.textoSaldo.TabIndex = 1;
            // 
            // textoNumero
            // 
            this.textoNumero.Location = new System.Drawing.Point(235, 12);
            this.textoNumero.Name = "textoNumero";
            this.textoNumero.Size = new System.Drawing.Size(111, 22);
            this.textoNumero.TabIndex = 2;
            // 
            // textoValor
            // 
            this.textoValor.Location = new System.Drawing.Point(352, 12);
            this.textoValor.Name = "textoValor";
            this.textoValor.Size = new System.Drawing.Size(228, 22);
            this.textoValor.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(173, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 32);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboContas
            // 
            this.comboContas.FormattingEnabled = true;
            this.comboContas.Location = new System.Drawing.Point(12, 102);
            this.comboContas.Name = "comboContas";
            this.comboContas.Size = new System.Drawing.Size(265, 24);
            this.comboContas.TabIndex = 6;
            this.comboContas.SelectedIndexChanged += new System.EventHandler(this.comboContas_SelectedIndexChanged);
            // 
            // buttonDeposito
            // 
            this.buttonDeposito.Location = new System.Drawing.Point(352, 40);
            this.buttonDeposito.Name = "buttonDeposito";
            this.buttonDeposito.Size = new System.Drawing.Size(111, 32);
            this.buttonDeposito.TabIndex = 7;
            this.buttonDeposito.Text = "Deposito";
            this.buttonDeposito.UseVisualStyleBackColor = true;
            this.buttonDeposito.Click += new System.EventHandler(this.buttonDeposito_Click);
            // 
            // buttonSaque
            // 
            this.buttonSaque.Location = new System.Drawing.Point(469, 40);
            this.buttonSaque.Name = "buttonSaque";
            this.buttonSaque.Size = new System.Drawing.Size(111, 32);
            this.buttonSaque.TabIndex = 8;
            this.buttonSaque.Text = "Saque";
            this.buttonSaque.UseVisualStyleBackColor = true;
            this.buttonSaque.Click += new System.EventHandler(this.buttonSaque_Click);
            // 
            // destinoDaTransferencia
            // 
            this.destinoDaTransferencia.FormattingEnabled = true;
            this.destinoDaTransferencia.Location = new System.Drawing.Point(283, 102);
            this.destinoDaTransferencia.Name = "destinoDaTransferencia";
            this.destinoDaTransferencia.Size = new System.Drawing.Size(265, 24);
            this.destinoDaTransferencia.TabIndex = 9;
            // 
            // buttonTransferir
            // 
            this.buttonTransferir.Location = new System.Drawing.Point(225, 132);
            this.buttonTransferir.Name = "buttonTransferir";
            this.buttonTransferir.Size = new System.Drawing.Size(111, 31);
            this.buttonTransferir.TabIndex = 10;
            this.buttonTransferir.Text = "Transferir";
            this.buttonTransferir.UseVisualStyleBackColor = true;
            this.buttonTransferir.Click += new System.EventHandler(this.buttonTransferir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 450);
            this.Controls.Add(this.buttonTransferir);
            this.Controls.Add(this.destinoDaTransferencia);
            this.Controls.Add(this.buttonSaque);
            this.Controls.Add(this.buttonDeposito);
            this.Controls.Add(this.comboContas);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textoValor);
            this.Controls.Add(this.textoNumero);
            this.Controls.Add(this.textoSaldo);
            this.Controls.Add(this.textoTitular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textoTitular;
        private System.Windows.Forms.TextBox textoSaldo;
        private System.Windows.Forms.TextBox textoNumero;
        private System.Windows.Forms.TextBox textoValor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboContas;
        private System.Windows.Forms.Button buttonDeposito;
        private System.Windows.Forms.Button buttonSaque;
        private System.Windows.Forms.ComboBox destinoDaTransferencia;
        private System.Windows.Forms.Button buttonTransferir;
    }
}

