namespace Calculadora_Akak
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
            txtREsultado = new TextBox();
            btnUm = new Button();
            btnNove = new Button();
            btnDois = new Button();
            btnSete = new Button();
            btnOito = new Button();
            btnSeis = new Button();
            btnCinco = new Button();
            btnQuatro = new Button();
            btnTres = new Button();
            butnZero = new Button();
            btnPonto = new Button();
            btnIgual = new Button();
            btnSoma = new Button();
            btnLimpa = new Button();
            btnMultiplicacao = new Button();
            btnDivisao = new Button();
            btnSubtracao = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtREsultado
            // 
            txtREsultado.Location = new Point(12, 22);
            txtREsultado.Name = "txtREsultado";
            txtREsultado.ReadOnly = true;
            txtREsultado.Size = new Size(308, 23);
            txtREsultado.TabIndex = 0;
            txtREsultado.TextAlign = HorizontalAlignment.Right;
            txtREsultado.TextChanged += txtREsultado_TextChanged;
            // 
            // btnUm
            // 
            btnUm.Location = new Point(12, 240);
            btnUm.Name = "btnUm";
            btnUm.Size = new Size(75, 44);
            btnUm.TabIndex = 1;
            btnUm.Text = "1";
            btnUm.UseVisualStyleBackColor = true;
            btnUm.Click += btnUm_Click;
            // 
            // btnNove
            // 
            btnNove.Location = new Point(174, 140);
            btnNove.Name = "btnNove";
            btnNove.Size = new Size(75, 44);
            btnNove.TabIndex = 2;
            btnNove.Text = "9";
            btnNove.UseVisualStyleBackColor = true;
            btnNove.Click += btnNove_Click;
            // 
            // btnDois
            // 
            btnDois.Location = new Point(93, 240);
            btnDois.Name = "btnDois";
            btnDois.Size = new Size(75, 44);
            btnDois.TabIndex = 3;
            btnDois.Text = "2";
            btnDois.UseVisualStyleBackColor = true;
            btnDois.Click += btnDois_Click;
            // 
            // btnSete
            // 
            btnSete.Location = new Point(12, 140);
            btnSete.Name = "btnSete";
            btnSete.Size = new Size(75, 44);
            btnSete.TabIndex = 4;
            btnSete.Text = "7";
            btnSete.UseVisualStyleBackColor = true;
            btnSete.Click += btnSete_Click;
            // 
            // btnOito
            // 
            btnOito.Location = new Point(93, 140);
            btnOito.Name = "btnOito";
            btnOito.Size = new Size(75, 44);
            btnOito.TabIndex = 5;
            btnOito.Text = "8";
            btnOito.UseVisualStyleBackColor = true;
            btnOito.Click += btnOito_Click;
            // 
            // btnSeis
            // 
            btnSeis.Location = new Point(174, 190);
            btnSeis.Name = "btnSeis";
            btnSeis.Size = new Size(75, 44);
            btnSeis.TabIndex = 6;
            btnSeis.Text = "6";
            btnSeis.UseVisualStyleBackColor = true;
            btnSeis.Click += btnSeis_Click;
            // 
            // btnCinco
            // 
            btnCinco.Location = new Point(93, 190);
            btnCinco.Name = "btnCinco";
            btnCinco.Size = new Size(75, 44);
            btnCinco.TabIndex = 7;
            btnCinco.Text = "5";
            btnCinco.UseVisualStyleBackColor = true;
            btnCinco.Click += btnCinco_Click;
            // 
            // btnQuatro
            // 
            btnQuatro.Location = new Point(12, 190);
            btnQuatro.Name = "btnQuatro";
            btnQuatro.Size = new Size(75, 44);
            btnQuatro.TabIndex = 8;
            btnQuatro.Text = "4";
            btnQuatro.UseVisualStyleBackColor = true;
            btnQuatro.Click += btnQuatro_Click;
            // 
            // btnTres
            // 
            btnTres.Location = new Point(174, 240);
            btnTres.Name = "btnTres";
            btnTres.Size = new Size(75, 44);
            btnTres.TabIndex = 9;
            btnTres.Text = "3";
            btnTres.UseVisualStyleBackColor = true;
            btnTres.Click += btnTres_Click;
            // 
            // butnZero
            // 
            butnZero.Location = new Point(12, 290);
            butnZero.Name = "butnZero";
            butnZero.Size = new Size(75, 44);
            butnZero.TabIndex = 10;
            butnZero.Text = "0";
            butnZero.UseVisualStyleBackColor = true;
            butnZero.Click += butnZero_Click;
            // 
            // btnPonto
            // 
            btnPonto.ForeColor = Color.Black;
            btnPonto.Location = new Point(93, 290);
            btnPonto.Name = "btnPonto";
            btnPonto.Size = new Size(75, 44);
            btnPonto.TabIndex = 11;
            btnPonto.Text = ".";
            btnPonto.UseVisualStyleBackColor = true;
            btnPonto.Click += btnPonto_Click;
            // 
            // btnIgual
            // 
            btnIgual.Location = new Point(174, 290);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(75, 44);
            btnIgual.TabIndex = 12;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = true;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnSoma
            // 
            btnSoma.Location = new Point(255, 290);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(75, 44);
            btnSoma.TabIndex = 13;
            btnSoma.Text = "+";
            btnSoma.UseVisualStyleBackColor = true;
            btnSoma.Click += btnSoma_Click;
            // 
            // btnLimpa
            // 
            btnLimpa.Location = new Point(255, 100);
            btnLimpa.Name = "btnLimpa";
            btnLimpa.Size = new Size(75, 34);
            btnLimpa.TabIndex = 14;
            btnLimpa.Text = "AC";
            btnLimpa.UseVisualStyleBackColor = true;
            btnLimpa.Click += btnLimpa_Click;
            // 
            // btnMultiplicacao
            // 
            btnMultiplicacao.Location = new Point(255, 240);
            btnMultiplicacao.Name = "btnMultiplicacao";
            btnMultiplicacao.Size = new Size(75, 44);
            btnMultiplicacao.TabIndex = 15;
            btnMultiplicacao.Text = "X";
            btnMultiplicacao.UseVisualStyleBackColor = true;
            btnMultiplicacao.Click += btnMultiplicacao_Click;
            // 
            // btnDivisao
            // 
            btnDivisao.Location = new Point(255, 190);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(75, 44);
            btnDivisao.TabIndex = 16;
            btnDivisao.Text = "/";
            btnDivisao.UseVisualStyleBackColor = true;
            btnDivisao.Click += btnDivisao_Click;
            // 
            // btnSubtracao
            // 
            btnSubtracao.Location = new Point(255, 140);
            btnSubtracao.Name = "btnSubtracao";
            btnSubtracao.Size = new Size(75, 44);
            btnSubtracao.TabIndex = 17;
            btnSubtracao.Text = "-";
            btnSubtracao.UseVisualStyleBackColor = true;
            btnSubtracao.Click += btnSubtracao_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 25);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 345);
            Controls.Add(label1);
            Controls.Add(btnSubtracao);
            Controls.Add(btnDivisao);
            Controls.Add(btnMultiplicacao);
            Controls.Add(btnLimpa);
            Controls.Add(btnSoma);
            Controls.Add(btnIgual);
            Controls.Add(btnPonto);
            Controls.Add(butnZero);
            Controls.Add(btnTres);
            Controls.Add(btnQuatro);
            Controls.Add(btnCinco);
            Controls.Add(btnSeis);
            Controls.Add(btnOito);
            Controls.Add(btnSete);
            Controls.Add(btnDois);
            Controls.Add(btnNove);
            Controls.Add(btnUm);
            Controls.Add(txtREsultado);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AKAK Calculadora";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtREsultado;
        private Button btnUm;
        private Button btnNove;
        private Button btnDois;
        private Button btnSete;
        private Button btnOito;
        private Button btnSeis;
        private Button btnCinco;
        private Button btnQuatro;
        private Button btnTres;
        private Button butnZero;
        private Button btnPonto;
        private Button btnIgual;
        private Button btnSoma;
        private Button btnLimpa;
        private Button btnMultiplicacao;
        private Button btnDivisao;
        private Button btnSubtracao;
        private Label label1;
    }
}
