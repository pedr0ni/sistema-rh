using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SistemaRH
{
    class Utils
    {

        public static string MESSAGE_INVALIDO = "Os campos em vermelho precisam ter números maiores que 0.";

        public static bool isValido(string valor)
        {
            try
            {
                return double.Parse(valor) > 0; // Verifica se o numero é positivo
            }
            catch
            {
                return false;
            }
        }

        public static bool verificaCampos(List<TextBox> campos)
        {

            bool res = true;

            foreach (TextBox verificar in campos)
            {
                if (verificar.Enabled && !isValido(verificar.Text))
                {
                    verificar.BackColor = Color.Red;
                    res = false;
                    verificar.Clear();
                }
            }

            return res;
        }

        public static double getINSS(double valor)
        {
            double aliquota = 0;

            if (valor <= 1693.72)
            {
                aliquota = 8;
            } else if (valor > 1693.72 && valor <= 2822.90)
            {
                aliquota = 9;
            } else if (valor > 2822.90 && valor <= 5645.80)
            {
                aliquota = 11;
            }

            return aliquota;
        }

        public static double getIRRF(double valor)
        {
            double aliquota = 0;

            if (valor <= 1903.98)
            {
                aliquota = 0;
            } else if (valor > 1903.98 && valor <= 2826.65)
            {
                aliquota = 7.5;
            } else if (valor > 2826.65 && valor <= 3751.05)
            {
                aliquota = 15;
            } else if (valor > 3751.05 && valor <= 4664.68)
            {
                aliquota = 22.5;
            } else if (valor > 4664.68)
            {
                aliquota = 27.5;
            }

            return aliquota;
        }

        public static double getDeducao(double valor)
        {
            double ded = 0;

            if (valor <= 1903.98)
            {
                ded = 0;
            }
            else if (valor > 1903.98 && valor <= 2826.65)
            {
                ded = 142.80;
            }
            else if (valor > 2826.65 && valor <= 3751.05)
            {
                ded = 354.80;
            }
            else if (valor > 3751.05 && valor <= 4664.68)
            {
                ded = 636.13;
            }
            else if (valor > 4664.68)
            {
                ded = 869.36;
            }

            return ded;
        }

    }
}
