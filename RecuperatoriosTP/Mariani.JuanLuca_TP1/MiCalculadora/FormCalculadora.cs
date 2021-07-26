using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {

        #region %% CONSTRUCTOR %%

        /// <summary>
        /// Inicializa la Calculadora, en este caso con el Combo Operador deafult ¨+¨.
        /// </summary>
        public FormCalculadora()
        {
            InitializeComponent();
            cmbOperador.Text = "+";
        }
        #endregion

        #region Label
        /// <summary>
        /// Muestra el resultado en el cuadro de texto LabelResutlado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LblResultado_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Buttons


        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }


        private void BtnOperar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Convert.ToString(Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text));
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnConvertirABinario_Click(object sender, EventArgs e)
        {
            Numero auxResultado = new Numero();
            lblResultado.Text = auxResultado.DecimalBinario(lblResultado.Text);
        }

        private void BtnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Numero auxResultado = new Numero();
            lblResultado.Text = auxResultado.BinaroDecimal(lblResultado.Text);
        }

        #endregion

        #region TextBox y ComboBox

        private void TxtNumero1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtNumero2_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        /// <summary>
        /// Limpia los cuadros de Texto, el combo box operar y el label del resultado.
        /// </summary>
        private void Limpiar()
        {
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            cmbOperador.Text = "";
            lblResultado.Text = "";
        }

        /// <summary>
        /// Crea dos nuevas entidades de tipo Numero, y ejecuta el metodo Operar con estos y el operador recibido.
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        /// <returns> Retorna el resultado de tipo double. </returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            Numero num1 = new Numero(numero1);
            Numero num2 = new Numero(numero2);

            Calculadora calc = new Calculadora();

            return calc.Operar(num1, num2, operador);
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esta segudo de cerrar la calculadora?", "Aviso", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }

        }
    }

}
