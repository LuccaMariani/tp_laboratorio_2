using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        /// <summary>
        /// Valida el operador tipo string ingresado y luego realiza la operacion aritmetica correspondiente.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operador"></param>
        /// <returns> Retorna el resultado de la operacion de tipo double. </returns>
        public double Operar(Numero num1, Numero num2, string operador)
        {
            double resultado;
            string auxOperador = "+";

            if (!string.IsNullOrEmpty(operador))
            {
                auxOperador = ValidarOperador(Convert.ToChar(operador));
            }

            switch (auxOperador)
            {
                case "/":
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                    }
                    else
                    {
                        resultado = double.MinValue;
                    }
                    break;
                case "-":
                    resultado = num1 - num2;
                    break;
                case "*":
                    resultado = num1 * num2;
                    break;
                default:
                    resultado = num1 + num2;
                    break;
            }

            return resultado;
        }

        /// <summary>
        /// Valida que el operador ingresado sea "+" "-" "*" "/".
        /// </summary>
        /// <param name="operador"></param>
        /// <returns> Retorna el operador ya validado. </returns>
        private static string ValidarOperador(char operador)
        {
            string operadorAux;

            if ((operador == '/') || (operador == '*') || (operador == '+') || (operador == '-'))
            {
                operadorAux = Char.ToString(operador);
            }
            else
            {
                operadorAux = "+";
            }
            return operadorAux;
        }

    }
}
