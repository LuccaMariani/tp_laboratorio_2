using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{


    [Serializable]
    public class Teclado : Periferico
    {

        private Modelo _modelo;
        private EtipoTeclado _tipo;

        public Teclado()
        { }

        public Teclado(Color color, ColorLuces colorLuces, bool inalambrico, Modelo modelo, EtipoTeclado tipo) : base(color, colorLuces, inalambrico)
        {
            _modelo = modelo;
            _tipo = tipo;
            SetNumeroSerie = GenerarNumeroSerie();
            SetPrecio = CalcularPrecio(color, colorLuces, inalambrico, modelo, tipo);
        }

        #region propXML
        public EtipoTeclado Tipo { get => _tipo; set => _tipo = value; }
        public Modelo Modelo { get => _modelo; set => _modelo = value; }
        #endregion

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;
            if(obj is Teclado)
            {
                if(this == (Teclado)obj)
                {
                    retorno = true;
                }
            }

            return retorno;
        }

        public static bool operator ==(Teclado a, Teclado b)
        {
            return (a.GetNumeroSerie == b.GetNumeroSerie);
        }

        public static bool operator !=(Teclado a, Teclado b)
        {
            return !(a == b);
        }

        protected override int GenerarNumeroSerie()
        {

            FileManager<Teclado> archivo = new FileManager<Teclado>();

            int numeroSerie = -2;

            if(int.TryParse(archivo.TomarNumeroSerie("Teclado"), out numeroSerie))
            {
                if(numeroSerie != -1)
                {
                    numeroSerie++;
                    archivo.EscribirNumeroSerie(numeroSerie.ToString(), "Teclado");
                }
                else
                {
                    /////////////Console.WriteLine("Error Numero de serie es: " + numeroSerie);
                    numeroSerie = 0;
                }
            }
            else
            {
                //////////Console.WriteLine("Eror al parsear numero de serie.");
            }



            return numeroSerie;
        }
        protected override string Ficha()
        {
            StringBuilder stringFicha = new StringBuilder();

            stringFicha.AppendLine("Teclado: " + _modelo);

            if(_tipo == EtipoTeclado.Cien)
            {

                stringFicha.AppendLine("| Tipo: 100%");
            }
            else if (_tipo == EtipoTeclado.Ochenta)
            {

                stringFicha.AppendLine("| Tipo: 80%");
            }
            else
            {

                stringFicha.AppendLine("| Tipo: 60%");
            }

            stringFicha.AppendLine(DatosPeriferico());

            return stringFicha.ToString();
        }

        protected int CalcularPrecio(Color color, ColorLuces colorLuces, bool inalambrico, Modelo modelo, EtipoTeclado tipo)
        {
            int precioCalculado = 1000;

            if (!inalambrico)
            {
                precioCalculado += 500;
            }

            switch (modelo)
            {
                case Modelo.SerieA:
                    precioCalculado += ((int)color * 5);
                    precioCalculado += ((int)colorLuces * 5);
                    precioCalculado += ((int)tipo * 4);
                    break;
                case Modelo.SerieB:
                    precioCalculado += ((int)color * 7);
                    precioCalculado += ((int)colorLuces * 7);
                    precioCalculado += ((int)tipo * 6);
                    break;
                case Modelo.SeriePremium:
                    precioCalculado += ((int)color * 9);
                    precioCalculado += ((int)colorLuces * 9);
                    precioCalculado += ((int)tipo * 9);
                    break;
            }

            return precioCalculado;
        }

        public override string ToString()
        {
            return Ficha();
        }

    }
}
