using Entidades;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Forms
{
    public partial class FormDeposito : Form
    {

        protected EtipoProducto _tipoProducto;

        public ManagerSQL sql;
        private FormPrincipal formPrincipal;

        private bool baseCargada;

        public FormDeposito(FormPrincipal formP)
        {
            this.formPrincipal = formP;
            this.sql = new ManagerSQL();

            InitializeComponent();

            dataGridView_base.ReadOnly = true;
            dataGridView_base.Enabled = false;

            baseCargada = false;

            dataGridView_base.Font = new Font("", 10);
            dataGridView_base.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            dataGridView_base.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            dataGridView_base.RowHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.Black;
        }

        #region Botones y Eventos

        private void label_salir_Click(object sender, EventArgs e)
        {
            formPrincipal.CerrarDeposito();
            //FormPrincipal.FormDepositoAbierto = false;
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                sql.SincronizarDatos();
                MessageBox.Show("Datos sincronizados exitosamente.");
            }

            catch (Exception exc)
            {
                MessageBox.Show("Error al sincronizar datos. \n" + exc.Message);
                throw exc;
            }

        }


        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (!baseCargada)
            {
                formPrincipal.DepositoCargado();
                dataGridView_base.DataSource = sql.ObtenerBase();
                baseCargada = true;
            }
            else
            {
                MessageBox.Show("La base de datos ya fue cargada.");
            }

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
                mouseX = MousePosition.X - 1100;
                mouseY = MousePosition.Y - 20;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void pictureBox_mover_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void FormDeposito_Activated(object sender, EventArgs e)
        {
            dataGridView_base.Refresh();
        }
        #endregion

        #region Funciones
        public bool AgregarProducto(Periferico periferico)
        {
            bool retorno = false;

            if (periferico is Auricular)
            {
                dataGridView_base.DataSource = sql.AgregarAuricular((Auricular)periferico);
                retorno = true;
            }

            if (periferico is Teclado)
            {
                dataGridView_base.DataSource = sql.AgregarTeclado((Teclado)periferico);
                retorno = true;
            }

            return retorno;
        }
        #endregion




    }
}
