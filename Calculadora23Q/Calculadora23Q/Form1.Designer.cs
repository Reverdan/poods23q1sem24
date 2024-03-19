namespace Calculadora23Q
{
    partial class Form1
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
            lblPrimeiroNumero = new Label();
            txbPrimeiroNumero = new TextBox();
            lblSegundoNumero = new Label();
            txbSegundoNumero = new TextBox();
            btnSomar = new Button();
            lblResposta = new Label();
            btnSubtrair = new Button();
            btnMultiplicar = new Button();
            btnDividir = new Button();
            SuspendLayout();
            // 
            // lblPrimeiroNumero
            // 
            lblPrimeiroNumero.AutoSize = true;
            lblPrimeiroNumero.Location = new Point(28, 26);
            lblPrimeiroNumero.Name = "lblPrimeiroNumero";
            lblPrimeiroNumero.Size = new Size(141, 15);
            lblPrimeiroNumero.TabIndex = 0;
            lblPrimeiroNumero.Text = "Digite o primeiro número";
            // 
            // txbPrimeiroNumero
            // 
            txbPrimeiroNumero.Location = new Point(28, 44);
            txbPrimeiroNumero.Name = "txbPrimeiroNumero";
            txbPrimeiroNumero.Size = new Size(137, 23);
            txbPrimeiroNumero.TabIndex = 1;
            // 
            // lblSegundoNumero
            // 
            lblSegundoNumero.AutoSize = true;
            lblSegundoNumero.Location = new Point(28, 91);
            lblSegundoNumero.Name = "lblSegundoNumero";
            lblSegundoNumero.Size = new Size(142, 15);
            lblSegundoNumero.TabIndex = 2;
            lblSegundoNumero.Text = "Digite o segundo número";
            // 
            // txbSegundoNumero
            // 
            txbSegundoNumero.Location = new Point(28, 109);
            txbSegundoNumero.Name = "txbSegundoNumero";
            txbSegundoNumero.Size = new Size(137, 23);
            txbSegundoNumero.TabIndex = 3;
            // 
            // btnSomar
            // 
            btnSomar.Location = new Point(28, 148);
            btnSomar.Name = "btnSomar";
            btnSomar.Size = new Size(56, 23);
            btnSomar.TabIndex = 4;
            btnSomar.Text = "+";
            btnSomar.UseVisualStyleBackColor = true;
            btnSomar.Click += btnSomar_Click;
            // 
            // lblResposta
            // 
            lblResposta.AutoSize = true;
            lblResposta.Location = new Point(28, 212);
            lblResposta.Name = "lblResposta";
            lblResposta.Size = new Size(54, 15);
            lblResposta.TabIndex = 5;
            lblResposta.Text = "Resposta";
            // 
            // btnSubtrair
            // 
            btnSubtrair.Location = new Point(109, 148);
            btnSubtrair.Name = "btnSubtrair";
            btnSubtrair.Size = new Size(56, 23);
            btnSubtrair.TabIndex = 6;
            btnSubtrair.Text = "-";
            btnSubtrair.UseVisualStyleBackColor = true;
            btnSubtrair.Click += btnSubtrair_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Location = new Point(28, 177);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(56, 23);
            btnMultiplicar.TabIndex = 7;
            btnMultiplicar.Text = "x";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += btnMultiplicar_Click;
            // 
            // btnDividir
            // 
            btnDividir.Location = new Point(109, 177);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(56, 23);
            btnDividir.TabIndex = 8;
            btnDividir.Text = "/";
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += btnDividir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(202, 248);
            Controls.Add(btnDividir);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnSubtrair);
            Controls.Add(lblResposta);
            Controls.Add(btnSomar);
            Controls.Add(txbSegundoNumero);
            Controls.Add(lblSegundoNumero);
            Controls.Add(txbPrimeiroNumero);
            Controls.Add(lblPrimeiroNumero);
            Name = "Form1";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPrimeiroNumero;
        private TextBox txbPrimeiroNumero;
        private Label lblSegundoNumero;
        private TextBox txbSegundoNumero;
        private Button btnSomar;
        private Label lblResposta;
        private Button btnSubtrair;
        private Button btnMultiplicar;
        private Button btnDividir;
    }
}