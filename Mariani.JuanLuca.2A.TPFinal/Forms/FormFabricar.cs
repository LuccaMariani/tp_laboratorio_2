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

namespace Forms
{
    public partial class FormFabricar : Form
    {
        private enum Inalambrico {  Si, No};
        private enum Microfono { Si, No };

        protected EtipoProducto _tipoProducto;
        private Entidades.Color _color;
        private ColorLuces _colorLuces;
        private bool _inalambrico;
        private bool _microfono;
        private Modelo _modelo;
        private EtipoTeclado _tipoTeclado;


        private DepositoFabrica<Periferico> almacenCentral;

        public FormFabricar(DepositoFabrica<Periferico> almacenCentral)
        {
            InitializeComponent();
            this.almacenCentral = almacenCentral;
        }

        private void FormFabricar_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            comboBox_Color.DataSource = Enum.GetValues(typeof(Entidades.Color));
            comboBox_ColorLuces.DataSource = Enum.GetValues(typeof(ColorLuces));
            comboBox_Producto.DataSource = Enum.GetValues(typeof(EtipoProducto));
            comboBox_Inalambrico.DataSource = Enum.GetValues(typeof(Inalambrico));
            comboBox_auricularModelo.DataSource = Enum.GetValues(typeof(Modelo));
            comboBox_auricularMicrofono.DataSource = Enum.GetValues(typeof(Microfono));
            comboBox_tecladoTipo.DataSource = Enum.GetValues(typeof(EtipoTeclado));
        }

        private void label_salir_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void button_fabricar_Click(object sender, EventArgs e)
        {

            FabricarProducto();
            
        }

        private void FabricarProducto()
        {
            try
            {
                switch (_tipoProducto)
                {
                    case EtipoProducto.Auriculares:
                        Auricular auricularFabricado = new Auricular(_color, _colorLuces, _inalambrico, _modelo, _microfono);
                        if (almacenCentral.AgregarAlDeposito(auricularFabricado))
                        {
                            MessageBox.Show("Se fabrico exitosamente:\n\n" + auricularFabricado.ToString());
                        }
                        else
                        {
                            MessageBox.Show("El almacen de la central esta lleno, empaquete algunos productos.");
                        }
                        break;

                    case EtipoProducto.Teclado:
                        Teclado tecladito = new Teclado(_color, _colorLuces, _inalambrico, _modelo, EtipoTeclado.Cien);
                        if (almacenCentral.AgregarAlDeposito(tecladito))
                        {
                            MessageBox.Show("Se fabrico exitosamente:\n\n" + tecladito.ToString());
                        }
                        else
                        {
                            MessageBox.Show("El almacen de la central esta lleno, empaquete algunos productos.");
                        }
                        break;
                    default:
                        MessageBox.Show("Error, al fabricar. Proceso cancelado");
                        this.Close();
                        break;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            

            
        }

        private void comboBox_Producto_SelectedIndexChanged(object sender, EventArgs e)
        {
            Enum.TryParse(comboBox_Producto.SelectedValue.ToString(), out _tipoProducto);
            CambioProducto();
        }

        private void CambioProducto()
        {
            try
            {
                if (_tipoProducto == EtipoProducto.Auriculares)
                {
                    comboBox_tecladoTipo.Hide();
                    label_tecladoTipo.Hide();

                    comboBox_auricularMicrofono.Show();
                    label_auricularMicrofono.Show();
                }
                if (_tipoProducto == EtipoProducto.Teclado)
                {
                    comboBox_auricularMicrofono.Hide();
                    label_auricularMicrofono.Hide();

                    comboBox_tecladoTipo.Show();
                    label_tecladoTipo.Show();
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void comboBox_Color_SelectedIndexChanged(object sender, EventArgs e)
        {
            Enum.TryParse(comboBox_Color.SelectedValue.ToString(), out _color);
        }

        private void comboBox_ColorLuces_SelectedIndexChanged(object sender, EventArgs e)
        {
            Enum.TryParse(comboBox_ColorLuces.SelectedValue.ToString(), out _colorLuces);
        }

        private void comboBox_Inalambrico_SelectedIndexChanged(object sender, EventArgs e)
        {
            _inalambrico = ValidacionBooleanaComboBox(comboBox_Inalambrico);
        }

        private void comboBox_auricularMicrofono_SelectedIndexChanged(object sender, EventArgs e)
        {
            _microfono = ValidacionBooleanaComboBox(comboBox_auricularMicrofono);
        }

        private bool ValidacionBooleanaComboBox(ComboBox combo)
        {
            bool resultado = false;

            try
            {
                if (combo.SelectedValue.ToString() == "Si")
                {
                    resultado = true;
                }
                else
                {
                    resultado = false;
                }
            }
            catch (Exception e) { MessageBox.Show(e.Message); }

            return resultado;

        }

        private void comboBox_auricularModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Enum.TryParse(comboBox_auricularModelo.SelectedValue.ToString(), out _modelo);
        }

        private void comboBox_tecladoTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Enum.TryParse(comboBox_tecladoTipo.SelectedValue.ToString(), out _tipoTeclado);
        }
    }
}
