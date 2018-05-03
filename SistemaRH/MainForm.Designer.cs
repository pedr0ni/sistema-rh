namespace SistemaRH
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_calcsl = new System.Windows.Forms.Button();
            this.btn_calcferias = new System.Windows.Forms.Button();
            this.btn_calc13 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_salariobruto = new System.Windows.Forms.TextBox();
            this.txt_bonus = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_mesestrab = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_diasferias = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_inss = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_13liquido = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_feriasliquido = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_salarioliquido = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_irrf = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_basecalc = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel_txts = new System.Windows.Forms.Panel();
            this.panel_btns = new System.Windows.Forms.Panel();
            this.panel_txts.SuspendLayout();
            this.panel_btns.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_sair
            // 
            this.btn_sair.Image = ((System.Drawing.Image)(resources.GetObject("btn_sair.Image")));
            this.btn_sair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_sair.Location = new System.Drawing.Point(364, 301);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(82, 59);
            this.btn_sair.TabIndex = 1;
            this.btn_sair.Text = "SAIR";
            this.btn_sair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Image = ((System.Drawing.Image)(resources.GetObject("btn_limpar.Image")));
            this.btn_limpar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_limpar.Location = new System.Drawing.Point(276, 301);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(82, 59);
            this.btn_limpar.TabIndex = 2;
            this.btn_limpar.Text = "LIMPAR";
            this.btn_limpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_calcsl
            // 
            this.btn_calcsl.Image = ((System.Drawing.Image)(resources.GetObject("btn_calcsl.Image")));
            this.btn_calcsl.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_calcsl.Location = new System.Drawing.Point(16, 15);
            this.btn_calcsl.Name = "btn_calcsl";
            this.btn_calcsl.Size = new System.Drawing.Size(170, 62);
            this.btn_calcsl.TabIndex = 3;
            this.btn_calcsl.Text = "Calcular Salário Líquido";
            this.btn_calcsl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_calcsl.UseVisualStyleBackColor = true;
            this.btn_calcsl.Click += new System.EventHandler(this.btn_calcsl_Click);
            // 
            // btn_calcferias
            // 
            this.btn_calcferias.Image = ((System.Drawing.Image)(resources.GetObject("btn_calcferias.Image")));
            this.btn_calcferias.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_calcferias.Location = new System.Drawing.Point(11, 109);
            this.btn_calcferias.Name = "btn_calcferias";
            this.btn_calcferias.Size = new System.Drawing.Size(170, 62);
            this.btn_calcferias.TabIndex = 4;
            this.btn_calcferias.Text = "Calcular Férias Líquido";
            this.btn_calcferias.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_calcferias.UseVisualStyleBackColor = true;
            this.btn_calcferias.Click += new System.EventHandler(this.btn_calcferias_Click);
            // 
            // btn_calc13
            // 
            this.btn_calc13.Image = ((System.Drawing.Image)(resources.GetObject("btn_calc13.Image")));
            this.btn_calc13.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_calc13.Location = new System.Drawing.Point(11, 203);
            this.btn_calc13.Name = "btn_calc13";
            this.btn_calc13.Size = new System.Drawing.Size(170, 62);
            this.btn_calc13.TabIndex = 5;
            this.btn_calc13.Text = "Calcular 13º Salário Líquido";
            this.btn_calc13.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_calc13.UseVisualStyleBackColor = true;
            this.btn_calc13.Click += new System.EventHandler(this.btn_calc13_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Salário Bruto :";
            // 
            // txt_salariobruto
            // 
            this.txt_salariobruto.Location = new System.Drawing.Point(146, 12);
            this.txt_salariobruto.MaxLength = 10;
            this.txt_salariobruto.Name = "txt_salariobruto";
            this.txt_salariobruto.Size = new System.Drawing.Size(100, 20);
            this.txt_salariobruto.TabIndex = 7;
            this.txt_salariobruto.Enter += new System.EventHandler(this.txt_salariobruto_Enter);
            // 
            // txt_bonus
            // 
            this.txt_bonus.Location = new System.Drawing.Point(146, 38);
            this.txt_bonus.MaxLength = 10;
            this.txt_bonus.Name = "txt_bonus";
            this.txt_bonus.Size = new System.Drawing.Size(100, 20);
            this.txt_bonus.TabIndex = 9;
            this.txt_bonus.Enter += new System.EventHandler(this.txt_bonus_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Bônus :";
            // 
            // txt_mesestrab
            // 
            this.txt_mesestrab.Location = new System.Drawing.Point(146, 64);
            this.txt_mesestrab.MaxLength = 2;
            this.txt_mesestrab.Name = "txt_mesestrab";
            this.txt_mesestrab.Size = new System.Drawing.Size(100, 20);
            this.txt_mesestrab.TabIndex = 11;
            this.txt_mesestrab.Enter += new System.EventHandler(this.txt_mesestrab_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nº Meses Trabalhados :";
            // 
            // txt_diasferias
            // 
            this.txt_diasferias.Location = new System.Drawing.Point(146, 90);
            this.txt_diasferias.MaxLength = 2;
            this.txt_diasferias.Name = "txt_diasferias";
            this.txt_diasferias.Size = new System.Drawing.Size(100, 20);
            this.txt_diasferias.TabIndex = 13;
            this.txt_diasferias.Enter += new System.EventHandler(this.txt_diasferias_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Dias de Férias :";
            // 
            // txt_inss
            // 
            this.txt_inss.Enabled = false;
            this.txt_inss.Location = new System.Drawing.Point(146, 116);
            this.txt_inss.Name = "txt_inss";
            this.txt_inss.ReadOnly = true;
            this.txt_inss.Size = new System.Drawing.Size(100, 20);
            this.txt_inss.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "INSS :";
            // 
            // txt_13liquido
            // 
            this.txt_13liquido.Enabled = false;
            this.txt_13liquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_13liquido.Location = new System.Drawing.Point(146, 245);
            this.txt_13liquido.Name = "txt_13liquido";
            this.txt_13liquido.ReadOnly = true;
            this.txt_13liquido.Size = new System.Drawing.Size(100, 20);
            this.txt_13liquido.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "13º Salário Líquido :";
            // 
            // txt_feriasliquido
            // 
            this.txt_feriasliquido.Enabled = false;
            this.txt_feriasliquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_feriasliquido.Location = new System.Drawing.Point(146, 219);
            this.txt_feriasliquido.Name = "txt_feriasliquido";
            this.txt_feriasliquido.ReadOnly = true;
            this.txt_feriasliquido.Size = new System.Drawing.Size(100, 20);
            this.txt_feriasliquido.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Férias Líquido :";
            // 
            // txt_salarioliquido
            // 
            this.txt_salarioliquido.Enabled = false;
            this.txt_salarioliquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_salarioliquido.Location = new System.Drawing.Point(146, 193);
            this.txt_salarioliquido.Name = "txt_salarioliquido";
            this.txt_salarioliquido.ReadOnly = true;
            this.txt_salarioliquido.Size = new System.Drawing.Size(100, 20);
            this.txt_salarioliquido.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Salário Líquido :";
            // 
            // txt_irrf
            // 
            this.txt_irrf.Enabled = false;
            this.txt_irrf.Location = new System.Drawing.Point(146, 167);
            this.txt_irrf.Name = "txt_irrf";
            this.txt_irrf.ReadOnly = true;
            this.txt_irrf.Size = new System.Drawing.Size(100, 20);
            this.txt_irrf.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "IRRF :";
            // 
            // txt_basecalc
            // 
            this.txt_basecalc.Enabled = false;
            this.txt_basecalc.Location = new System.Drawing.Point(146, 141);
            this.txt_basecalc.Name = "txt_basecalc";
            this.txt_basecalc.ReadOnly = true;
            this.txt_basecalc.Size = new System.Drawing.Size(100, 20);
            this.txt_basecalc.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Base de Cálculo :";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Image = ((System.Drawing.Image)(resources.GetObject("label11.Image")));
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label11.Location = new System.Drawing.Point(9, 283);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(250, 101);
            this.label11.TabIndex = 26;
            this.label11.Text = "SistemaRH";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_txts
            // 
            this.panel_txts.Controls.Add(this.label1);
            this.panel_txts.Controls.Add(this.txt_salariobruto);
            this.panel_txts.Controls.Add(this.txt_13liquido);
            this.panel_txts.Controls.Add(this.label2);
            this.panel_txts.Controls.Add(this.label6);
            this.panel_txts.Controls.Add(this.txt_bonus);
            this.panel_txts.Controls.Add(this.txt_feriasliquido);
            this.panel_txts.Controls.Add(this.label3);
            this.panel_txts.Controls.Add(this.label7);
            this.panel_txts.Controls.Add(this.txt_mesestrab);
            this.panel_txts.Controls.Add(this.txt_salarioliquido);
            this.panel_txts.Controls.Add(this.label4);
            this.panel_txts.Controls.Add(this.label8);
            this.panel_txts.Controls.Add(this.txt_diasferias);
            this.panel_txts.Controls.Add(this.txt_irrf);
            this.panel_txts.Controls.Add(this.label5);
            this.panel_txts.Controls.Add(this.label9);
            this.panel_txts.Controls.Add(this.txt_inss);
            this.panel_txts.Controls.Add(this.txt_basecalc);
            this.panel_txts.Controls.Add(this.label10);
            this.panel_txts.Location = new System.Drawing.Point(-1, 0);
            this.panel_txts.Name = "panel_txts";
            this.panel_txts.Size = new System.Drawing.Size(260, 280);
            this.panel_txts.TabIndex = 27;
            // 
            // panel_btns
            // 
            this.panel_btns.Controls.Add(this.btn_calcsl);
            this.panel_btns.Controls.Add(this.btn_calcferias);
            this.panel_btns.Controls.Add(this.btn_calc13);
            this.panel_btns.Location = new System.Drawing.Point(265, 0);
            this.panel_btns.Name = "panel_btns";
            this.panel_btns.Size = new System.Drawing.Size(200, 280);
            this.panel_btns.TabIndex = 28;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 372);
            this.Controls.Add(this.panel_btns);
            this.Controls.Add(this.panel_txts);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_sair);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SistemaRH";
            this.panel_txts.ResumeLayout(false);
            this.panel_txts.PerformLayout();
            this.panel_btns.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_calcsl;
        private System.Windows.Forms.Button btn_calcferias;
        private System.Windows.Forms.Button btn_calc13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_salariobruto;
        private System.Windows.Forms.TextBox txt_bonus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_mesestrab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_diasferias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_inss;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_13liquido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_feriasliquido;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_salarioliquido;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_irrf;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_basecalc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel_txts;
        private System.Windows.Forms.Panel panel_btns;
    }
}

