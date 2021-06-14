using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            Auricular auri2 = new Auricular(Color.Dorado, false, Modelo.SeriePremium);
            Auricular auri3 = new Auricular(Color.Rosa, true, Modelo.SerieA);

            Teclado tecladito1 = new Teclado(Color.Negro, ColorLuces.RGB, true, Modelo.SeriePremium, EtipoTeclado.Ochenta);
            Teclado tecladito2 = new Teclado(Color.Negro, ColorLuces.RGB, false, Modelo.SeriePremium, EtipoTeclado.Ochenta);

            DepositoFabrica<Periferico> deposito = new DepositoFabrica<Periferico>("nombreDeposito 2", 10);

            deposito.CargarFabrica(deposito, "Deposito1");

            if(deposito.AgregarAlDeposito(auri2))
            {
                Console.WriteLine("Se agrego al deposito correctamente");
            }

            if (deposito.AgregarAlDeposito(auri2))
            {
                Console.WriteLine("Se agrego al deposito correctamente");
            }

            if (deposito.AgregarAlDeposito(auri3))
            {
                Console.WriteLine("Se agrego al deposito correctamente");
            }

            if (deposito.AgregarAlDeposito(tecladito1))
            {
                Console.WriteLine("Se agrego al deposito correctamente");
            }

            if (deposito.RemoverDelDeposito(auri2))
            {
                Console.WriteLine("Se removio del deposito correctamente");
            }

            if (deposito.RemoverDelDeposito(auri2))
            {
                Console.WriteLine("Se removio del deposito correctamente");
            }


            Console.WriteLine(deposito);

            deposito.GuardarFabrica(deposito, "Deposito1");

            Console.ReadKey();
        }
    }
}
