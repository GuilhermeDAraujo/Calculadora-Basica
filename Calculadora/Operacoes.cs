using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    internal class Operacoes
    {
        static public double Operacao(string operacao, double n1, double n2)
        {
            double resultado = 0;
            if (operacao == "mais")
            {
                resultado = n1 + n2;
            }
            else if (operacao == "menos")
            {
                resultado = n1 - n2;
            }
            else if (operacao == "div")
            {
                resultado = n1 / n2;
            }
            else if (operacao == "mult")
            {
                resultado = n1 * n2;
            }
            else if (operacao == "porcen")
            {
                resultado = (n1 / n2) * 100; 
            }
            return resultado;
        }
    }
}
