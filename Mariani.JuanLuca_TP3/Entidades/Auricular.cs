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
    public class Auricular : Periferico
    {
        private bool _microfono;
        private Modelo _modelo;

        public Modelo Modelo { get => _modelo; set => _modelo = value; }
        public bool Microfono { get => _microfono; set => _microfono = value; }

        public Auricular() { }

        public Auricular(Color color, ColorLuces colorLuces, bool inalambrico, Modelo modelo, bool microfono) : base(color, colorLuces, inalambrico)
        {
            _microfono = microfono;
            _modelo = modelo;
            SetPrecio = CalcularPrecio(color, colorLuces, inalambrico, modelo);
            SetNumeroSerie = GenerarNumeroSerie();
        }

        public Auricular(Color color, bool inalambrico, Modelo modelo) : this(color, ColorLuces.SinLuces, inalambrico, modelo, false) { }



        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;

            if (obj is Auricular)
            {
                if (this == (Auricular)obj)
                {
                    retorno = true;
                }
            }

            return retorno;
        }


        public static bool operator ==(Auricular a, Auricular b)
        {
            return (a.GetNumeroSerie == b.GetNumeroSerie);
        }

        public static bool operator !=(Auricular a, Auricular b)
        {
            return !(a == b);
        }

        protected override int GenerarNumeroSerie()
        {
            FileManager<Auricular> archivo = new FileManager<Auricular>();

            int numeroSerie = -2;

            if (int.TryParse(archivo.TomarNumeroSerie("Teclado"), out numeroSerie))
            {
                if (numeroSerie != 1)
                {
                    numeroSerie++;

                    archivo.EscribirNumeroSerie(numeroSerie.ToString(), "Teclado");

                }
            }
            else
            {
                Console.WriteLine("ERROR AL PARSEAR");
            }

            return numeroSerie;
        }

        protected override string Ficha()
        {
            StringBuilder stringFicha = new StringBuilder();

            stringFicha.AppendLine("Auricular: " + _modelo);
            stringFicha.AppendLine("| Microfono: " + _microfono);

            stringFicha.AppendLine(DatosPeriferico());

            return stringFicha.ToString();
        }

        protected int CalcularPrecio(Color color, ColorLuces colorLuces, bool inalambrico, Modelo modelo)
        {
            int precioCalculado = 2000;

            if (!inalambrico)
            {
                precioCalculado += 1000;
            }

            switch (modelo)
            {
                case Modelo.SerieA:
                    precioCalculado += ((int)color * 6);
                    precioCalculado += ((int)colorLuces * 6);
                    break;
                case Modelo.SerieB:
                    precioCalculado += ((int)color * 7);
                    precioCalculado += ((int)colorLuces * 7);
                    break;
                case Modelo.SeriePremium:
                    precioCalculado += ((int)color * 9);
                    precioCalculado += ((int)colorLuces * 9);
                    break;
            }

            return precioCalculado;
        }

        public override string ToString()
        {
            return Ficha();
        }

    }

    public class Auricular1
    {
    }
}
