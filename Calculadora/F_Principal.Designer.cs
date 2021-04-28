namespace Calculadora
{
    partial class F_Principal
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
            this.bnt_adicionar = new System.Windows.Forms.Button();
            this.txt_adcionar = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rd_desconto = new System.Windows.Forms.RadioButton();
            this.rd_proventos = new System.Windows.Forms.RadioButton();
            this.Btn_remove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TotalProventos = new System.Windows.Forms.TextBox();
            this.txt_TotalDesconto = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Lb_qtdDepen = new System.Windows.Forms.Label();
            this.Btn_CalcInss = new System.Windows.Forms.Button();
            this.ListV_Inss = new System.Windows.Forms.ListView();
            this.col_faixas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_SalarioIn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_SalarioFim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_BaseFaixa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_InssFaixa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.lb_baseInssForm = new System.Windows.Forms.Label();
            this.lb_valorInssForm = new System.Windows.Forms.Label();
            this.Lb_inssForm = new System.Windows.Forms.Label();
            this.Lb__ValorBaseInssForm = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bnt_adicionar
            // 
            this.bnt_adicionar.Location = new System.Drawing.Point(178, 116);
            this.bnt_adicionar.Name = "bnt_adicionar";
            this.bnt_adicionar.Size = new System.Drawing.Size(111, 52);
            this.bnt_adicionar.TabIndex = 0;
            this.bnt_adicionar.Text = "ADICIONAR";
            this.bnt_adicionar.UseVisualStyleBackColor = true;
            this.bnt_adicionar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_adcionar
            // 
            this.txt_adcionar.Location = new System.Drawing.Point(12, 129);
            this.txt_adcionar.Name = "txt_adcionar";
            this.txt_adcionar.Size = new System.Drawing.Size(160, 26);
            this.txt_adcionar.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormatString = "C2";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(3, 174);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(400, 304);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rd_desconto);
            this.groupBox1.Controls.Add(this.rd_proventos);
            this.groupBox1.Location = new System.Drawing.Point(3, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 62);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Lançamento";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rd_desconto
            // 
            this.rd_desconto.AutoSize = true;
            this.rd_desconto.Location = new System.Drawing.Point(215, 25);
            this.rd_desconto.Name = "rd_desconto";
            this.rd_desconto.Size = new System.Drawing.Size(123, 24);
            this.rd_desconto.TabIndex = 4;
            this.rd_desconto.Text = "DESCONTO";
            this.rd_desconto.UseVisualStyleBackColor = true;
            this.rd_desconto.CheckedChanged += new System.EventHandler(this.rd_desconto_CheckedChanged);
            // 
            // rd_proventos
            // 
            this.rd_proventos.AutoSize = true;
            this.rd_proventos.Checked = true;
            this.rd_proventos.Location = new System.Drawing.Point(21, 26);
            this.rd_proventos.Name = "rd_proventos";
            this.rd_proventos.Size = new System.Drawing.Size(133, 24);
            this.rd_proventos.TabIndex = 0;
            this.rd_proventos.TabStop = true;
            this.rd_proventos.Text = "PROVENTOS";
            this.rd_proventos.UseVisualStyleBackColor = true;
            this.rd_proventos.CheckedChanged += new System.EventHandler(this.rd_proventos_CheckedChanged);
            // 
            // Btn_remove
            // 
            this.Btn_remove.Location = new System.Drawing.Point(295, 116);
            this.Btn_remove.Name = "Btn_remove";
            this.Btn_remove.Size = new System.Drawing.Size(108, 52);
            this.Btn_remove.TabIndex = 4;
            this.Btn_remove.Text = "REMOVER";
            this.Btn_remove.UseVisualStyleBackColor = true;
            this.Btn_remove.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 500);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total Proventos:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 500);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total Descontos";
            // 
            // txt_TotalProventos
            // 
            this.txt_TotalProventos.Location = new System.Drawing.Point(3, 523);
            this.txt_TotalProventos.Name = "txt_TotalProventos";
            this.txt_TotalProventos.Size = new System.Drawing.Size(147, 26);
            this.txt_TotalProventos.TabIndex = 7;
            // 
            // txt_TotalDesconto
            // 
            this.txt_TotalDesconto.Location = new System.Drawing.Point(218, 523);
            this.txt_TotalDesconto.Name = "txt_TotalDesconto";
            this.txt_TotalDesconto.Size = new System.Drawing.Size(163, 26);
            this.txt_TotalDesconto.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10\t"});
            this.comboBox1.Location = new System.Drawing.Point(3, 631);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(141, 28);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Lb_qtdDepen
            // 
            this.Lb_qtdDepen.AutoSize = true;
            this.Lb_qtdDepen.Location = new System.Drawing.Point(8, 595);
            this.Lb_qtdDepen.Name = "Lb_qtdDepen";
            this.Lb_qtdDepen.Size = new System.Drawing.Size(136, 20);
            this.Lb_qtdDepen.TabIndex = 10;
            this.Lb_qtdDepen.Text = "Qtd Dependentes";
            // 
            // Btn_CalcInss
            // 
            this.Btn_CalcInss.Location = new System.Drawing.Point(218, 570);
            this.Btn_CalcInss.Name = "Btn_CalcInss";
            this.Btn_CalcInss.Size = new System.Drawing.Size(163, 127);
            this.Btn_CalcInss.TabIndex = 11;
            this.Btn_CalcInss.Text = "Calcular Inss";
            this.Btn_CalcInss.UseVisualStyleBackColor = true;
            this.Btn_CalcInss.Click += new System.EventHandler(this.Btn_CalcInss_Click);
            // 
            // ListV_Inss
            // 
            this.ListV_Inss.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_faixas,
            this.col_SalarioIn,
            this.Col_SalarioFim,
            this.Col_BaseFaixa,
            this.col_InssFaixa});
            this.ListV_Inss.HideSelection = false;
            this.ListV_Inss.Location = new System.Drawing.Point(438, 62);
            this.ListV_Inss.MultiSelect = false;
            this.ListV_Inss.Name = "ListV_Inss";
            this.ListV_Inss.Size = new System.Drawing.Size(703, 291);
            this.ListV_Inss.TabIndex = 12;
            this.ListV_Inss.UseCompatibleStateImageBehavior = false;
            this.ListV_Inss.View = System.Windows.Forms.View.Details;
            // 
            // col_faixas
            // 
            this.col_faixas.Text = "Alíquotas";
            this.col_faixas.Width = 65;
            // 
            // col_SalarioIn
            // 
            this.col_SalarioIn.Text = "Salário De:";
            this.col_SalarioIn.Width = 120;
            // 
            // Col_SalarioFim
            // 
            this.Col_SalarioFim.Text = "Salário Até:";
            this.Col_SalarioFim.Width = 120;
            // 
            // Col_BaseFaixa
            // 
            this.Col_BaseFaixa.Text = "Base Faixa";
            this.Col_BaseFaixa.Width = 80;
            // 
            // col_InssFaixa
            // 
            this.col_InssFaixa.Text = "Inss Faixa";
            this.col_InssFaixa.Width = 80;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(971, 615);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 82);
            this.button1.TabIndex = 13;
            this.button1.Text = "RESET";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // lb_baseInssForm
            // 
            this.lb_baseInssForm.AutoSize = true;
            this.lb_baseInssForm.Font = new System.Drawing.Font("Verdana", 12F);
            this.lb_baseInssForm.Location = new System.Drawing.Point(28, 22);
            this.lb_baseInssForm.Name = "lb_baseInssForm";
            this.lb_baseInssForm.Size = new System.Drawing.Size(144, 29);
            this.lb_baseInssForm.TabIndex = 14;
            this.lb_baseInssForm.Text = "BASE INSS";
            // 
            // lb_valorInssForm
            // 
            this.lb_valorInssForm.AutoSize = true;
            this.lb_valorInssForm.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_valorInssForm.Location = new System.Drawing.Point(494, 75);
            this.lb_valorInssForm.Name = "lb_valorInssForm";
            this.lb_valorInssForm.Size = new System.Drawing.Size(135, 34);
            this.lb_valorInssForm.TabIndex = 15;
            this.lb_valorInssForm.Text = "******";
            // 
            // Lb_inssForm
            // 
            this.Lb_inssForm.AutoSize = true;
            this.Lb_inssForm.Font = new System.Drawing.Font("Verdana", 12F);
            this.Lb_inssForm.Location = new System.Drawing.Point(460, 22);
            this.Lb_inssForm.Name = "Lb_inssForm";
            this.Lb_inssForm.Size = new System.Drawing.Size(161, 29);
            this.Lb_inssForm.TabIndex = 16;
            this.Lb_inssForm.Text = "VALOR INSS";
            // 
            // Lb__ValorBaseInssForm
            // 
            this.Lb__ValorBaseInssForm.AutoSize = true;
            this.Lb__ValorBaseInssForm.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.Lb__ValorBaseInssForm.Location = new System.Drawing.Point(46, 75);
            this.Lb__ValorBaseInssForm.Name = "Lb__ValorBaseInssForm";
            this.Lb__ValorBaseInssForm.Size = new System.Drawing.Size(135, 34);
            this.Lb__ValorBaseInssForm.TabIndex = 17;
            this.Lb__ValorBaseInssForm.Text = "******";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Lb__ValorBaseInssForm);
            this.groupBox2.Controls.Add(this.Lb_inssForm);
            this.groupBox2.Controls.Add(this.lb_valorInssForm);
            this.groupBox2.Controls.Add(this.lb_baseInssForm);
            this.groupBox2.Location = new System.Drawing.Point(438, 369);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(703, 201);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Valores";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // F_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1182, 830);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ListV_Inss);
            this.Controls.Add(this.Btn_CalcInss);
            this.Controls.Add(this.Lb_qtdDepen);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txt_TotalDesconto);
            this.Controls.Add(this.txt_TotalProventos);
            this.Controls.Add(this.Btn_remove);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txt_adcionar);
            this.Controls.Add(this.bnt_adicionar);
            this.MaximizeBox = false;
            this.Name = "F_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora Inss";
            this.Load += new System.EventHandler(this.F_Principal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bnt_adicionar;
        private System.Windows.Forms.TextBox txt_adcionar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rd_proventos;
        private System.Windows.Forms.RadioButton rd_desconto;
        private System.Windows.Forms.Button Btn_remove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_TotalProventos;
        private System.Windows.Forms.TextBox txt_TotalDesconto;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Lb_qtdDepen;
        private System.Windows.Forms.Button Btn_CalcInss;
        private System.Windows.Forms.ListView ListV_Inss;
        private System.Windows.Forms.ColumnHeader col_faixas;
        private System.Windows.Forms.ColumnHeader col_SalarioIn;
        private System.Windows.Forms.ColumnHeader Col_SalarioFim;
        private System.Windows.Forms.ColumnHeader Col_BaseFaixa;
        private System.Windows.Forms.ColumnHeader col_InssFaixa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb_baseInssForm;
        private System.Windows.Forms.Label lb_valorInssForm;
        private System.Windows.Forms.Label Lb_inssForm;
        private System.Windows.Forms.Label Lb__ValorBaseInssForm;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

