using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using Entidades;

namespace Forms
{
    public partial class FormPrincipal : Form
    {
        private DepositoFabrica<Periferico> _almacenFabrica;

        private DepositoFabrica<Periferico> _depositoFabrica;

        private bool DepositoGuardado;
        private bool DepositoCargado;

        private enum Deposito { Periferico, Ventilador };
        public FormPrincipal()
        {
            InitializeComponent();

            this._almacenFabrica = new DepositoFabrica<Periferico>("AlmacenCentral", 10);
            this._depositoFabrica = new DepositoFabrica<Periferico>("Deposito San Isidro", 100);
            this.DepositoGuardado = true;
            this.DepositoCargado = false;

            //CargarDeposito();
            CenterToScreen();
        }


        #region Panel Central

        // Botones
        private void btn_fabricar_Click(object sender, EventArgs e)
        {
            Fabricar();
        }
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            EliminarSeleccionado();
        }

        private void btn_empaquetar_Click(object sender, EventArgs e)
        {
            EmpaquetarSeleccionado();
        }


        //Funciones
        private void Fabricar()
        {
            if (listBox_almacenCentral.Items.Count < _almacenFabrica.CapacidadMaxima)
            {
                FormFabricar fabricar = new FormFabricar(_almacenFabrica);

                fabricar.ShowDialog();

                listBox_almacenCentral.Items.Clear();

                foreach (Periferico producto in _almacenFabrica.Deposito)
                {
                    listBox_almacenCentral.Items.Add(producto);
                }
            }
            else
            {
                MessageBox.Show("El almacen de la central esta lleno, empaquete algunos productos.");
            }
        }

        private void EmpaquetarSeleccionado()
        {
            if(DepositoCargado)
            {
                if (IndiceSeleccionado() != -1)
                {
                    if (_depositoFabrica.AgregarAlDeposito((Periferico)listBox_almacenCentral.SelectedItem))
                    {
                        EliminarSeleccionado();
                    }
                    else
                    {
                        MessageBox.Show("Error al empaquetar el producto.");

                    }
                    richTextBox_deposito.Text = _depositoFabrica.ToString();
                }
                else
                {
                    MessageBox.Show("Primero debe seleccionar un producto a empaquetar.");
                }
            }
            else
            {
                MessageBox.Show("Debe cargar el deposito antes de podes empaquetar algo.");
            }

        }

        private int IndiceSeleccionado()
        {
            int indice = -1;
            indice = listBox_almacenCentral.SelectedIndex;
            
            return indice;
        }

        private void EliminarSeleccionado()
        {
            try
            {
                if (IndiceSeleccionado() != -1)
                {
                    if (_almacenFabrica.RemoverDelDeposito((Periferico)listBox_almacenCentral.SelectedItem))
                    {

                        listBox_almacenCentral.Items.RemoveAt(listBox_almacenCentral.SelectedIndex);
                    }
                    else
                    {
                        MessageBox.Show("Error al remover el producto");
                    }

                }
                else
                {
                    MessageBox.Show("Seleccione un producto a eliminar.");
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            

        }
        #endregion

        #region Panel Deposito
        //Botones
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarDeposito();
        }
        private void btnCargar_Click(object sender, EventArgs e)
        {
            CargarDeposito();
        }
        //Funciones
        private void GuardarDeposito()
        {
            try
            {
                if(DepositoCargado)
                {
                    _depositoFabrica.GuardarFabrica(_depositoFabrica, "Deposito Fabrica Form");
                    DepositoGuardado = true;
                    MessageBox.Show("Deposito guardado exitosamente.");
                }
                else
                {
                    MessageBox.Show("Primero debe cargar el deposito antes de podes guardarlo.");
                }
                
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
        }

        private void CargarDeposito()
        {
            try 
            { 
                if (DepositoGuardado)
                {
                    _depositoFabrica = _depositoFabrica.CargarFabrica(_depositoFabrica, "Deposito Fabrica Form");
                    richTextBox_deposito.Text = _depositoFabrica.ToString();
                    DepositoCargado = true;
                    MessageBox.Show("Deposito cargado exitosamente.");
                }
                else
                {
                    MessageBox.Show("No puede cargar el deposito si este no fue guardado.");
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        
        }
        #endregion

        #region Panel Superior

        //Botones
        private void btn_salir_Click(object sender, EventArgs e)
        {
            Salir();
        }

        //Funciones
        private void Salir()
        {
            DialogResult resultado = DialogResult.None;

            try
            {

                if (listBox_almacenCentral.Items.Count != 0)
                {
                    resultado = MessageBox.Show("El almacen de la central todavía tiene productos, si sale de la fabrica seran eliminados.\n\nSeguro que desea salir ?", "Salir", MessageBoxButtons.YesNo);

                    if (resultado == DialogResult.Yes)
                    {
                        Close();
                    }
                }
                else
                {
                    if (DepositoGuardado)
                    {
                        Close();
                    }
                    else
                    {
                        resultado = MessageBox.Show("Debes guardar el deposito antes de salir.");
                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void richTextBox_deposito_TextChanged(object sender, EventArgs e)
        {
            DepositoGuardado = false;
        }

        private void btn_ImprimirDeposito_Click(object sender, EventArgs e)
        {
            
            string rutaArchivo = string.Empty;
            if (DepositoGuardado && DepositoCargado)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    rutaArchivo = saveFileDialog.FileName;
                }

                _depositoFabrica.ImprimirDeposito(_depositoFabrica, rutaArchivo);
            }
            else
            {
                MessageBox.Show("Debe guardar el deposito antes de poder imprimirlo en un .txt");
            }
        }

        #endregion

    }
}
