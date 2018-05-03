using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaRH
{
    public partial class MainForm : Form
    {

        private List<TextBox> campos = new List<TextBox>();

        public MainForm()
        {
            InitializeComponent();

            this.MaximizeBox = false; // Desativa o botão maximizar
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Desativa o resize da borda

            foreach (Control ctrls in panel_txts.Controls)
            {
                if (!(ctrls is TextBox)) continue;

                TextBox txt = (TextBox)ctrls;
                campos.Add(txt); // Adiciona todos campos de texto na lista campospara facilitar
                txt.Click += new System.EventHandler(this.txt_todos_Enter);
                if (txt.Enabled) txt.Text = "0";                
            }

            
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseja sair do programa de RH ?", "SistemaRH", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit(); // Finaliza a aplicação
            }
            
        }

        private void btn_calcsl_Click(object sender, EventArgs e)
        {
            if (!Utils.verificaCampos(campos))
            {
                MessageBox.Show(Utils.MESSAGE_INVALIDO, "SistemaRH", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double salarioBruto = double.Parse(txt_salariobruto.Text);
            double bonus = double.Parse(txt_bonus.Text);
            double salarioTotal = salarioBruto + bonus;

            double INSS = (salarioTotal) * (Utils.getINSS(salarioTotal) / 100);
            if (salarioTotal > 5645.80)
            {
                INSS = 621.04;
            }
            txt_inss.Text = "R$ " + INSS.ToString("0.00");

            double salarioLiquido = salarioTotal - INSS;
            txt_basecalc.Text = "R$ " + salarioLiquido.ToString("0.00");

            double IRRF = (salarioLiquido * (Utils.getIRRF(salarioLiquido) / 100)) - Utils.getDeducao(salarioLiquido);
            txt_irrf.Text = "R$ " + IRRF.ToString("0.00");

            salarioLiquido = salarioLiquido - IRRF;

            txt_salarioliquido.Text = "R$ " + salarioLiquido.ToString("0.00");
        }

        private void btn_calcferias_Click(object sender, EventArgs e)
        {
            if (!Utils.verificaCampos(campos))
            {
                MessageBox.Show(Utils.MESSAGE_INVALIDO, "SistemaRH", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int ferias = int.Parse(txt_diasferias.Text);

            if (ferias < 10 || ferias > 30)
            {
                MessageBox.Show("A quantidade de dias de férias precisa ser entre 10 e 30", "SistemaRH", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double salarioBruto = double.Parse(txt_salariobruto.Text);
            double valorTotalFerias = (salarioBruto * ferias) / 30;

            double INSS = (valorTotalFerias) * (Utils.getINSS(valorTotalFerias) / 100);
            if (valorTotalFerias > 5645.80)
            {
                INSS = 621.04;
            }
            txt_inss.Text = "R$ " + INSS.ToString("0.00");

            double baseCalc = valorTotalFerias - INSS;
            txt_basecalc.Text = "R$ " + baseCalc.ToString("0.00");

            double IRRF = (baseCalc * (Utils.getIRRF(baseCalc) / 100)) - Utils.getDeducao(baseCalc);
            txt_irrf.Text = "R$ " + IRRF.ToString("0.00");

            double feriasLiquido = baseCalc - IRRF;
            txt_feriasliquido.Text = "R$ " + feriasLiquido.ToString("0.00");

        }

        private void btn_calc13_Click(object sender, EventArgs e)
        {
            if (!Utils.verificaCampos(campos))
            {
                MessageBox.Show(Utils.MESSAGE_INVALIDO, "SistemaRH", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int mesestrab = int.Parse(txt_mesestrab.Text);
            if (mesestrab < 1 || mesestrab > 12)
            {
                MessageBox.Show("A quantidade de meses trabalhados precisa ser entre 1 e 12", "SistemaRH", MessageBoxButtons.OK, MessageBoxIcon.Error);


                return;
             }
            double salarioBruto = double.Parse(txt_salariobruto.Text);
            double valorTotalTrab = (salarioBruto * int.Parse(txt_mesestrab.Text)) / 12;

            double INSS = (valorTotalTrab) * (Utils.getINSS(valorTotalTrab) / 100);
            if (valorTotalTrab > 5645.80)
            {
                INSS = 621.04;
            }
            txt_inss.Text = "R$ " + INSS.ToString("0.00");

            double baseCalc = valorTotalTrab - INSS;
            txt_basecalc.Text = "R$ " + baseCalc.ToString("0.00");

            double IRRF = (baseCalc * (Utils.getIRRF(baseCalc) / 100)) - Utils.getDeducao(baseCalc);
            txt_irrf.Text = "R$ " + IRRF.ToString("0.00");

            double salario13 = baseCalc - IRRF;
            txt_13liquido.Text = "R$ " + salario13.ToString("0.00");
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            foreach (TextBox all in campos)
            {
                all.Clear(); // Limpa todas textbox de uma vez
                if (all.Enabled) all.BackColor = Color.White; // O Enabled é para campos que podem ser digitados (4 primeiros)
            }
        }

        /*
         * 
         * Resta os campos para branco ao entrar
         * 
         */

        private void txt_salariobruto_Enter(object sender, EventArgs e)
        {
            txt_salariobruto.BackColor = Color.White; 
        }

        private void txt_bonus_Enter(object sender, EventArgs e)
        {
            txt_bonus.BackColor = Color.White;
        }

        private void txt_mesestrab_Enter(object sender, EventArgs e)
        {
            txt_mesestrab.BackColor = Color.White;
        }

        private void txt_diasferias_Enter(object sender, EventArgs e)
        {
            txt_diasferias.BackColor = Color.White;
        }

        private void txt_todos_Enter(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            try
            {
                if (double.Parse(txt.Text) == 0) txt.Clear(); 
            } catch
            {
                txt.Clear();
            }
        }
        

    }
}
