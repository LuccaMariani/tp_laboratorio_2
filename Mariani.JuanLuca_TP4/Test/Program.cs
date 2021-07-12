using Entidades;
using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            Auricular auri1 = new Auricular(Color.Dorado, false, Modelo.SeriePremium);

            Teclado tecladito1 = new Teclado(Color.Negro, ColorLuces.RGB, true, Modelo.SeriePremium, EtipoTeclado.Ochenta);

            DepositoFabrica<Periferico> deposito = new DepositoFabrica<Periferico>("nombreDeposito 2", 10);


            // Carga el deposito desde un archivo XML
            try 
            {
                deposito.CargarFabrica(deposito, "Deposito1");
            }
            catch(TPException exc)
            {
                Console.WriteLine(exc.InformeExcepcion());
            }
            catch (Exception exc)
            {
                throw exc;
            }

            // Agrega a el deposito los perifericos/productos
            try
            {
                deposito.AgregarAlDeposito(auri1);
                deposito.AgregarAlDeposito(tecladito1);
            }
            catch (Exception exc)
            {
                throw exc;
            }


            // Imprime la lista de productos
            Console.WriteLine(deposito);


            // Guarda el deposito en un archivo XML
            deposito.GuardarFabrica(deposito, "Deposito1");


            try
            {
                // Crea un manejador sql con sus Data Adapter y Data Table configurados.
                ManagerSQL sql = new ManagerSQL();
                sql.ObtenerBase();

                // Agrega auricular y teclado al Data Table.
                sql.AgregarAuricular(auri1);
                sql.AgregarTeclado(tecladito1);


                // Sincroniza el Data Table con la base de datos.
                sql.SincronizarDatos();
            }
            catch(Exception exc)
            {
                Console.WriteLine("Error en SQL Manager" + exc.Message);
            }
            

            Console.ReadKey();
        }
    }
}
