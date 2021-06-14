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
    [XmlInclude(typeof(Teclado))]
    [XmlInclude(typeof(Auricular))]
    public abstract class Periferico : IProducto
    {
        private string _marca;
        private int _serie;
        private int _precio;
        private Color _color;
        private ColorLuces _colorLuces;
        private bool _inalambrico;

        public Periferico() { }

        protected Periferico(Color color, ColorLuces colorLuces, bool inalambrico)
        {
            _marca = "Razer";
            _color = color;
            _colorLuces = colorLuces;
            _inalambrico = inalambrico;
        }

        protected int SetPrecio
        {
            set
            {
                _precio = value;
            }
        }
        public int GetNumeroSerie
        {
            get
            {
                return _serie;
            }
        }

        protected int SetNumeroSerie
        {
            set
            {
                _serie = value;
            }
        }


        public string Marca { get => _marca; set => _marca = value; }
        public int Serie { get => _serie; set => _serie = value; }
        public int Precio { get => _precio; set => _precio = value; }
        public Color Color { get => _color; set => _color = value; }
        public ColorLuces ColorLuces { get => _colorLuces; set => _colorLuces = value; }
        public bool Inalambrico { get => _inalambrico; set => _inalambrico = value; }


        protected abstract string Ficha();
        protected abstract int GenerarNumeroSerie();
        protected string DatosPeriferico()
        {
            StringBuilder stringPeriferico = new StringBuilder();

            stringPeriferico.AppendLine("| Marca: " + _marca);
            stringPeriferico.AppendLine("| Color: " + _color);
            stringPeriferico.AppendLine("| Color de luces: " + _colorLuces);
            stringPeriferico.AppendLine("| Inalambrico: " + _inalambrico);
            stringPeriferico.AppendLine("| PRECIO: " + _precio);
            stringPeriferico.AppendLine("| NUMERO SERIE: " + _serie);

            return stringPeriferico.ToString();
        }
    }
}
