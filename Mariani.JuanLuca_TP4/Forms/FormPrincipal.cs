using Entidades;
using System;
using System.Threading;
using System.Windows.Forms;

namespace Forms
{
    public partial class FormPrincipal : Form
    {
        private DepositoFabrica<Periferico> _almacenFabrica;

        private bool CentralGuardado;
        private bool CentralCargado;

        private bool formDepositoAbierto;
        private bool formDepositoCargado;

        private FormDeposito formDeposito;

        public FormPrincipal()
        {
            InitializeComponent();

            this.formDeposito = new FormDeposito(this);
            this._almacenFabrica = new DepositoFabrica<Periferico>("AlmacenCentral", 50);
            this.CentralGuardado = true;
            this.CentralCargado = false;

            CenterToScreen();
        }

 

        #region Botones y Eventos
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
        private void button_abrirDeposito_Click(object sender, EventArgs e)
        {
            if (!formDepositoAbierto)
            {
                formDepositoAbierto = true;
                Thread t = new Thread(new ThreadStart(AbrirDeposito));
                t.Start();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarDeposito();
        }
        private void btnCargar_Click(object sender, EventArgs e)
        {
            CargarDeposito();
        }

        private void richTextBox_deposito_TextChanged(object sender, EventArgs e)
        {
            CentralGuardado = false;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Salir();
        }

        int mouseX = 0;
        int mouseY = 0;
        bool mouseDown;

        private void pictureBox_mover_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void pictureBox_mover_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 900;
                mouseY = MousePosition.Y - 20;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void pictureBox_mover_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        #endregion

        #region Funciones

        private void Salir()
        {
            DialogResult resultado = DialogResult.None;

            try
            {

                if (CentralGuardado)
                {
                    Close();
                }
                else
                {
                    resultado = MessageBox.Show("Debes guardar la Central antes de salir.");
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void DepositoCargado()
        {
            formDepositoCargado = true;
        }

        private void GuardarDeposito()
        {
            try
            {
                if (CentralCargado)
                {
                    _almacenFabrica.GuardarFabrica(_almacenFabrica, "Deposito Fabrica Form");
                    CentralGuardado = true;
                    MessageBox.Show("Central guardada exitosamente.");
                }
                else
                {
                    MessageBox.Show("Primero debe cargar la central antes de podes guardarlo.");
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void CargarDeposito()
        {
            try
            {
                if (!CentralCargado)
                {
                    _almacenFabrica = _almacenFabrica.CargarFabrica(_almacenFabrica, "Deposito Fabrica Form");

                    foreach (Periferico producto in _almacenFabrica.Deposito)
                    {
                        listBox_almacenCentral.Items.Add(producto);
                    }

                    CentralCargado = true;

                    MessageBox.Show("Deposito cargado exitosamente.");
                }
                else
                {
                    MessageBox.Show("El almacen de la central ya fue cargado.");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


        }
        private void Fabricar()
        {
            if (CentralCargado)
            {
                if (listBox_almacenCentral.Items.Count < _almacenFabrica.CapacidadMaxima)
                {
                    FormFabricar fabricarForm = new FormFabricar(_almacenFabrica);

                    fabricarForm.ShowDialog();

                    listBox_almacenCentral.Items.Clear();

                    foreach (Periferico producto in _almacenFabrica.Deposito)
                    {
                        listBox_almacenCentral.Items.Add(producto);
                    }
                }
                else
                {

                }
            }
            else
            {
                MessageBox.Show("Debe cargar el deposito cetral antes de crear un producto");
            }



        }

        public void CerrarDeposito()
        {
            formDepositoAbierto = false;
        }
        private void AbrirDeposito()
        {

            formDeposito.ShowDialog();
        }

        private void EmpaquetarSeleccionado()
        {

            if (formDepositoAbierto)
            {
                if (formDepositoCargado)
                {
                    if (IndiceSeleccionado() != -1)
                    {

                        formDeposito.AgregarProducto((Periferico)listBox_almacenCentral.SelectedItem);

                        EliminarSeleccionado();

                    }
                    else
                    {
                        MessageBox.Show("Primero debe seleccionar un producto a empaquetar.");
                    }
                }
                else
                {
                    MessageBox.Show("Debe cargar el deposito antes de poder empaquetar algo.");
                }
            }
            else
            {
                MessageBox.Show("Debe abrir el deposito antes de poder empaquetar algo.");
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
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {

                listBox_almacenCentral.Refresh();
            }


        }

        #endregion
        private void button1_Click(object sender, EventArgs e)
        {
            _almacenFabrica.EventoImprimirTicket += ImprimirCentral;

        }

        private void ImprimirCentral(object sender, EventArgs e)
        {
            string rutaArchivo = "";

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            
            try
            {
                
                saveFileDialog.Title = "Seleccionar lugar donde guardar";
                saveFileDialog.DefaultExt = ".txt";
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                saveFileDialog.Filter = "(*.txt) | *.txt";


                DialogResult rta = saveFileDialog.ShowDialog();

                if (rta == DialogResult.OK)
                {
                    rutaArchivo = saveFileDialog.FileName;
                    _almacenFabrica.ImprimirDeposito(_almacenFabrica, rutaArchivo);

                }
            }
            catch(Exception exc)
            {
                throw exc;
            }
            finally
            {
                saveFileDialog.Dispose();
            }
            
        }


    }
}
