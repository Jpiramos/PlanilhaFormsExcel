namespace PlanilhaFormsExcel
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
            groupBox1 = new GroupBox();
            lblStatus = new Label();
            btnSalvar = new Button();
            btnAbrir = new Button();
            lblResultadoOperacional = new Label();
            lblTotalDespesas = new Label();
            lblDespesasAdmnistrativas = new Label();
            lblImpostos = new Label();
            lblCustoDosProdutos = new Label();
            lblComissoes = new Label();
            lblTotalReceitas = new Label();
            lblDevolucoes = new Label();
            txtFaturamento = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSalvar);
            groupBox1.Controls.Add(btnAbrir);
            groupBox1.Controls.Add(lblResultadoOperacional);
            groupBox1.Controls.Add(lblTotalDespesas);
            groupBox1.Controls.Add(lblDespesasAdmnistrativas);
            groupBox1.Controls.Add(lblImpostos);
            groupBox1.Controls.Add(lblCustoDosProdutos);
            groupBox1.Controls.Add(lblComissoes);
            groupBox1.Controls.Add(lblTotalReceitas);
            groupBox1.Controls.Add(lblDevolucoes);
            groupBox1.Controls.Add(txtFaturamento);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(900, 388);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Resultado Operacional de Janeiro de 2024";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // lblStatus
            // 
            lblStatus.Location = new Point(64, 380);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(641, 23);
            lblStatus.TabIndex = 20;
            // 
            // btnSalvar
            // 
            btnSalvar.Enabled = false;
            btnSalvar.Location = new Point(778, 336);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 19;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnAbrir
            // 
            btnAbrir.Location = new Point(669, 336);
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(75, 23);
            btnAbrir.TabIndex = 18;
            btnAbrir.Text = "Abrir";
            btnAbrir.UseVisualStyleBackColor = true;
            btnAbrir.Click += btnAbrir_Click;
            // 
            // lblResultadoOperacional
            // 
            lblResultadoOperacional.BorderStyle = BorderStyle.Fixed3D;
            lblResultadoOperacional.Location = new Point(161, 349);
            lblResultadoOperacional.Name = "lblResultadoOperacional";
            lblResultadoOperacional.Size = new Size(415, 23);
            lblResultadoOperacional.TabIndex = 17;
            lblResultadoOperacional.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTotalDespesas
            // 
            lblTotalDespesas.BorderStyle = BorderStyle.Fixed3D;
            lblTotalDespesas.Location = new Point(129, 303);
            lblTotalDespesas.Name = "lblTotalDespesas";
            lblTotalDespesas.Size = new Size(415, 23);
            lblTotalDespesas.TabIndex = 16;
            lblTotalDespesas.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDespesasAdmnistrativas
            // 
            lblDespesasAdmnistrativas.BorderStyle = BorderStyle.Fixed3D;
            lblDespesasAdmnistrativas.Location = new Point(162, 258);
            lblDespesasAdmnistrativas.Name = "lblDespesasAdmnistrativas";
            lblDespesasAdmnistrativas.Size = new Size(415, 23);
            lblDespesasAdmnistrativas.TabIndex = 15;
            lblDespesasAdmnistrativas.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblImpostos
            // 
            lblImpostos.BorderStyle = BorderStyle.Fixed3D;
            lblImpostos.Location = new Point(94, 223);
            lblImpostos.Name = "lblImpostos";
            lblImpostos.Size = new Size(415, 23);
            lblImpostos.TabIndex = 14;
            lblImpostos.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCustoDosProdutos
            // 
            lblCustoDosProdutos.BorderStyle = BorderStyle.Fixed3D;
            lblCustoDosProdutos.Location = new Point(143, 182);
            lblCustoDosProdutos.Name = "lblCustoDosProdutos";
            lblCustoDosProdutos.Size = new Size(415, 23);
            lblCustoDosProdutos.TabIndex = 13;
            lblCustoDosProdutos.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblComissoes
            // 
            lblComissoes.BorderStyle = BorderStyle.Fixed3D;
            lblComissoes.Location = new Point(94, 144);
            lblComissoes.Name = "lblComissoes";
            lblComissoes.Size = new Size(415, 23);
            lblComissoes.TabIndex = 12;
            lblComissoes.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTotalReceitas
            // 
            lblTotalReceitas.BorderStyle = BorderStyle.Fixed3D;
            lblTotalReceitas.Location = new Point(131, 107);
            lblTotalReceitas.Name = "lblTotalReceitas";
            lblTotalReceitas.Size = new Size(415, 23);
            lblTotalReceitas.TabIndex = 11;
            lblTotalReceitas.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDevolucoes
            // 
            lblDevolucoes.BorderStyle = BorderStyle.Fixed3D;
            lblDevolucoes.Location = new Point(93, 69);
            lblDevolucoes.Name = "lblDevolucoes";
            lblDevolucoes.Size = new Size(415, 23);
            lblDevolucoes.TabIndex = 10;
            lblDevolucoes.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtFaturamento
            // 
            txtFaturamento.Enabled = false;
            txtFaturamento.Location = new Point(100, 29);
            txtFaturamento.MaxLength = 15;
            txtFaturamento.Name = "txtFaturamento";
            txtFaturamento.Size = new Size(417, 23);
            txtFaturamento.TabIndex = 9;
            txtFaturamento.TextAlign = HorizontalAlignment.Right;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(26, 353);
            label9.Name = "label9";
            label9.Size = new Size(131, 15);
            label9.TabIndex = 8;
            label9.Text = "Resultado Operacional";
            label9.Click += label9_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(19, 303);
            label8.Name = "label8";
            label8.Size = new Size(109, 15);
            label8.TabIndex = 7;
            label8.Text = "Total das Despesas";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 258);
            label7.Name = "label7";
            label7.Size = new Size(137, 15);
            label7.TabIndex = 6;
            label7.Text = "Despesas Admnistrativas";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 223);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 5;
            label6.Text = "Impostos";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 186);
            label5.Name = "label5";
            label5.Size = new Size(111, 15);
            label5.TabIndex = 4;
            label5.Text = "Custo dos Produtos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 148);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 3;
            label4.Text = "Comissões";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(19, 111);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 2;
            label3.Text = "Total das Receitas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 69);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 1;
            label2.Text = "Devoluções";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            label1.Location = new Point(19, 32);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 0;
            label1.Text = "Faturamento";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(924, 412);
            Controls.Add(lblStatus);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Integração Windows Forms com Excel";
            FormClosing += Form1_FormClosing;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblDevolucoes;
        private TextBox txtFaturamento;
        private Label lblComissoes;
        private Label lblTotalReceitas;
        private Label lblStatus;
        private Button btnSalvar;
        private Button btnAbrir;
        private Label lblResultadoOperacional;
        private Label lblTotalDespesas;
        private Label lblDespesasAdmnistrativas;
        private Label lblImpostos;
        private Label lblCustoDosProdutos;
    }
}
