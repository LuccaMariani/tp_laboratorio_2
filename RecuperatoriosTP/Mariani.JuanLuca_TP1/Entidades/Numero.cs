using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        #region %% ATRIBUTOS / CAMPOS %%
        private double numero;
        #endregion

        #region %% CONSTRUCTOR / PROPIEDADES %%

        /// <summary>
        /// Valida el numero y lo guarda en el atribuno numero de la clase.
        /// </summary>
        private string SetNumero
        {
            set
            {
                this.numero = ValidarNumero(value);
            }
        }

        /// <summary>
        /// Asigna 0, por defecto al atributo numero.
        /// </summary>
        public Numero()
        {
            this.numero = 0;
        }

        /// <summary>
        /// Realiza el SetNumero al string ingresado y luego lo ingresa.
        /// </summary>
        /// <param name="strNumero"></param>
        public Numero(string strNumero)
        {
            this.SetNumero = strNumero;
        }
        /// <summary>
        /// Asigna al atributo numero, el numero double recibido.
        /// </summary>
        /// <param name="numero"></param>
        public Numero(double numero)
        {
            this.numero = numero;
        }

        #endregion

        #region %% METODOS %%

        /// <summary>
        /// Valida si el string recibido es un numero binario o no.
        /// </summary>
        /// <param name="binario"></param>
        /// <returns> Retorna True o False dependiendo del numero recibido. </returns>
        private bool EsBinario(string binario)
        {
            bool retorno = true;

            foreach (char a in binario)
            {
                if (a != '1' && a != '0')
                {
                    retorno = false;
                    break;
                }
            }
            return retorno;
        }

        /// <summary>
        /// Recibe un binario de tipo string y lo convierte en decimal.
        /// </summary>
        /// <param name="binario"></param>
        /// <returns> Retorna un numero decimal de tipo string, o "Valor inválido" si no recibe un binario. </returns>
        public string BinaroDecimal(string binario)
        {
            string retorno;

            if (EsBinario(binario))
            {
                char[] arrayBinario = binario.ToCharArray();
                Array.Reverse(arrayBinario);
                double numero = 0;
                for (int i = 0; i < arrayBinario.Length; i++)
                {
                    if (arrayBinario[i] == '1')
                    {
                        if (i == 0)
                        {
                            numero += 1;
                        }
                        else
                        {
                            numero += (int)Math.Pow(2, i);
                        }
                    }
                }
                retorno = numero.ToString();
            }
            else
            {
                retorno = "Valor inválido";
            }

            return retorno;
        }

        /// <summary>
        /// Recibe un decimal de tipo double y lo convierte en binario.
        /// </summary>
        /// <param name="numero"></param>
        /// <returns> Retorna un numero binario en tipo string. </returns>
        public string DecimalBinario(double numero)
        {
            // - Aca va el conversor de Decimal a Binario -
            string binario = "";

            while (numero > 0)
            {
                if (numero % 2 == 0)
                {
                    binario = "0" + binario;
                }
                else
                {
                    binario = "1" + binario;
                }
                numero = (int)numero / 2;
            }
            binario = '0' + binario;
            return binario;

        }

        /// <summary>
        /// Recibe un string y lo convierte a binario.
        /// </summary>
        /// <param name="numero"></param>
        /// <returns> Retorna un binario como string.</returns>
        public string DecimalBinario(string numero)
        {
            string retorno;

            if (double.TryParse(numero, out double numeroParseado))
            {
                if (!EsBinario(numero))
                {
                    retorno = DecimalBinario(numeroParseado);
                }
                else
                {
                    retorno = numero;
                }
                if (numeroParseado < 0)
                {
                    retorno = "Valor inválido";
                }
            }
            else
            {

                retorno = "Valor inválido";
            }

            return retorno;
        }

        /// <summary>
        /// Valida si el string que recibe es un numero o no.
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns> Retorna true o false, dependiendo de lo que reciba.</returns>
        private double ValidarNumero(string strNumero)
        {
            bool retorno = int.TryParse(strNumero, out int numeroValidado);

            if (!retorno)
            {
                numeroValidado = 0;
            }

            return numeroValidado;
        }

        #endregion

        #region %% SOBRECARGAS %%

        /// <summary>
        /// Realiza la suma de dos Clases Numero.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns> Devuelve el resultado de la suma en formato double. </returns>
        public static double operator +(Numero num1, Numero num2)
        {
            return num1.numero + num2.numero;
        }


        /// <summary>
        /// Realiza la resta de dos Clases Numero.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns> Devuelve el resultado de la resta en formato double. </returns>
        public static double operator -(Numero num1, Numero num2)
        {
            return num1.numero - num2.numero;
        }


        /// <summary>
        /// Realiza la multiplicacion de dos Clases Numero.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns> Devuelve el resultado de la multiplicacion en formato double. </returns>
        public static double operator *(Numero num1, Numero num2)
        {
            return num1.numero * num2.numero;
        }


        /// <summary>
        /// Realiza la divison de dos Clases Numero.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns> Devuelve el resultado de la division en formato double. </returns>
        public static double operator /(Numero num1, Numero num2)
        {
            return num1.numero / num2.numero;
        }


        /// <summary>
        /// Realiza la igualacion entre el numero de la Clases Numero, y un entero.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns> Devuelve True o False dependiendo del resultado de la igualacion. </returns>
        public static bool operator ==(Numero num1, int num2)
        {
            return num1.numero == num2;
        }

        /// <summary>
        /// Realiza la igualacion entre el numero de la Clases Numero, y un entero.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns> Devuelve True o False dependiendo del resultado de la igualacion. </returns>
        public static bool operator !=(Numero num1, int num2)
        {
            return !(num1.numero == num2);
        }

        #endregion


    }
}
