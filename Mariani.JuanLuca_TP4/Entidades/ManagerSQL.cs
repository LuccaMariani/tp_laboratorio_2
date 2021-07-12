using System;
using System.Data;
using System.Data.SqlClient;

namespace Entidades
{
    public class ManagerSQL
    {
        private SqlConnection cn;
        private SqlDataAdapter da;
        private DataTable dt;

        public ManagerSQL()
        {
            try
            {
                this.cn = new SqlConnection(Properties.Settings.Default.conexion);
 
                this.da = new SqlDataAdapter();

                this.da.SelectCommand = new SqlCommand("SELECT id,marca,producto,modelo,color,colorLuces,inalambrico,microfono_A,tipo_T,precio FROM deposito_perifericos_empaquetados", this.cn);

                this.dt = new DataTable();
                ConfigurarInsertCommand();
            }
            catch(Exception exc)
            {
                throw exc;
            }
        }

        public DataTable ObtenerBase()
        {
            try
            {
                this.da.Fill(this.dt);
            }
            catch (Exception exc)
            {

                throw exc;
            }

            return this.dt;
        }

        // Configuracion del insertCommand del SqlDataAdapter
        private void ConfigurarInsertCommand()
        {
            try
            {
                
                this.da.InsertCommand = new SqlCommand("INSERT INTO deposito_perifericos_empaquetados (id,marca,producto,modelo,color,colorLuces,inalambrico,microfono_A,tipo_T,precio) VALUES (@id,@marca,@producto,@modelo,@color,@colorLuces,@inalambrico,@microfono_A,@tipo_T,@precio)", this.cn);

                this.da.InsertCommand.Parameters.Add("@precio", SqlDbType.Int, 50, "precio");

                this.da.InsertCommand.Parameters.Add("@id", SqlDbType.Int, 50, "id");
                this.da.InsertCommand.Parameters.Add("@marca", SqlDbType.VarChar, 50, "marca");
                this.da.InsertCommand.Parameters.Add("@producto", SqlDbType.Char, 10, "producto");
                this.da.InsertCommand.Parameters.Add("@modelo", SqlDbType.VarChar, 50, "modelo");
                this.da.InsertCommand.Parameters.Add("@color", SqlDbType.VarChar, 50, "color");
                this.da.InsertCommand.Parameters.Add("@colorLuces", SqlDbType.VarChar, 50, "colorLuces");
                this.da.InsertCommand.Parameters.Add("@inalambrico", SqlDbType.Bit, 50, "inalambrico");
                this.da.InsertCommand.Parameters.Add("@microfono_A", SqlDbType.Bit, 50, "microfono_A");
                this.da.InsertCommand.Parameters.Add("@tipo_T", SqlDbType.VarChar, 50, "tipo_T");
            }
            catch (Exception exc)
            {
                throw exc;
            }

        }

        public DataTable AgregarAuricular(Auricular auricular)
        {
            try
            {
                DataRow filaAuricular = this.dt.NewRow();

                DataColumnCollection dataColumn = this.dt.Columns;

                filaAuricular[dataColumn["id"]] = auricular.Serie;
                filaAuricular[dataColumn["marca"]] = auricular.Marca;
                filaAuricular[dataColumn["producto"]] = "Auricular";
                filaAuricular[dataColumn["modelo"]] = auricular.Modelo;
                filaAuricular[dataColumn["color"]] = auricular.Color;
                filaAuricular[dataColumn["colorLuces"]] = auricular.ColorLuces;
                filaAuricular[dataColumn["inalambrico"]] = auricular.Inalambrico;
                filaAuricular[dataColumn["microfono_A"]] = auricular.Microfono;
                filaAuricular[dataColumn["tipo_T"]] = DBNull.Value;
                filaAuricular[dataColumn["precio"]] = auricular.Precio;

                this.dt.Rows.Add(filaAuricular);
            }
            catch (Exception exc)
            {
                throw exc;
            }
            return this.dt;
        }

        public DataTable AgregarTeclado(Teclado tecladito)
        {
            try
            {
                DataRow filaTecladito = this.dt.NewRow();

                DataColumnCollection dataColumn = this.dt.Columns;

                filaTecladito[dataColumn["id"]] = tecladito.Serie;
                filaTecladito[dataColumn["marca"]] = tecladito.Marca;
                filaTecladito[dataColumn["producto"]] = "Teclado";
                filaTecladito[dataColumn["modelo"]] = tecladito.Modelo;
                filaTecladito[dataColumn["color"]] = tecladito.Color;
                filaTecladito[dataColumn["colorLuces"]] = tecladito.ColorLuces;
                filaTecladito[dataColumn["inalambrico"]] = tecladito.Inalambrico;
                filaTecladito[dataColumn["microfono_A"]] = DBNull.Value;
                filaTecladito[dataColumn["tipo_T"]] = tecladito.Tipo;
                filaTecladito[dataColumn["precio"]] = tecladito.Precio;

                this.dt.Rows.Add(filaTecladito);
            }
            catch (Exception exc)
            {
                throw exc;
            }
            return this.dt;
        }


        //Sincronizar los cambios con la base de datos
        public void SincronizarDatos()
        {
            try
            {
                try
                {
                    this.da.Update(this.dt);
                }
                catch (Exception exc)
                {
                    throw exc;
                }
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }




    }
}
