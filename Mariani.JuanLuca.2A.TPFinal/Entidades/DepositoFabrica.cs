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
    [XmlInclude(typeof(Auricular))]
    [XmlInclude(typeof(Teclado))]

    public class DepositoFabrica<T>
    {
        private List<T> _deposito;
        private string _nombre;
        private int _capacidadMaxima;

        public string Nombre { get => _nombre; set => _nombre = value; }
        public int CapacidadMaxima { get => _capacidadMaxima; set => _capacidadMaxima = value; }
        public List<T> Deposito { get => _deposito; set => _deposito = value; }
        
        public DepositoFabrica()
        {
            this._deposito = new List<T>();
            this._nombre = "sin nombre";
            this._capacidadMaxima = 10;
            //this._producto = default(T);
        }

        public DepositoFabrica(string nombre, int capacidadMaxima):this()
        {
            this._nombre = nombre;
            this._capacidadMaxima = capacidadMaxima;
        }


        public void GuardarFabrica(DepositoFabrica<T> objeto, string nombreArchivo)
        {
            FileManager<T> archivo = new FileManager<T>();

            archivo.EscribirXML(objeto, nombreArchivo);
        }



        public DepositoFabrica<T> CargarFabrica(DepositoFabrica<T> objeto, string nombreArchivo)
        {
            FileManager<T> archivo = new FileManager<T>();

            return archivo.CargarXMLDepositoFabrica(objeto, nombreArchivo);
        }


        public bool ImprimirDeposito(DepositoFabrica<T> objeto, string nombreArchivo)
        {
            FileManager<T> archivo = new FileManager<T>();

            return archivo.EscribirTXT(objeto, nombreArchivo);
        }

        public bool AgregarAlDeposito(T producto)
        {
            return this + producto;
        }
        public bool RemoverDelDeposito(T producto)
        {
            return this - producto;
        }

        public int GetEnumerator()
        {

            return 1;

        }

        private int GetIndiceProducto(T producto)
        {
            int retorno = -1;
            int flag = 0;
            foreach (T generico in _deposito)
            {
                
                if (producto.Equals(generico))
                {
                    retorno = flag;
                    break;
                }
                
                flag += 1;
            }
            return retorno;
        }

        public static implicit operator string(DepositoFabrica<T> deposito)
        {
            StringBuilder stringPaquete = new StringBuilder();

            stringPaquete.AppendLine("#  Deposito: " + deposito._nombre + "  #");

            stringPaquete.AppendLine("Cantidad de Productos: (" + deposito._deposito.Count() + ")\n");

            foreach (T producto in deposito._deposito)
            {
                stringPaquete.AppendLine(producto.ToString());
            }

            return stringPaquete.ToString();
        }
        public override string ToString()
        {
            return this;
        }

        public static bool operator +(DepositoFabrica<T> deposito, T producto)
        {
            bool SeAgrego = false;
            if (deposito.GetIndiceProducto(producto) == -1 && deposito._deposito.Count < deposito._capacidadMaxima)
            {
                deposito._deposito.Add(producto);
                SeAgrego = true;
            }
            else
            {
                Console.WriteLine("###########  Ya esta en el grupo: \n" + producto.ToString() + " \n########################");
            }

            return SeAgrego;
        }

        public static bool operator -(DepositoFabrica<T> deposito, T producto)
        {
            bool SeElimino = false;

            if (deposito.GetIndiceProducto(producto) != -1 && deposito._deposito.Count > 0 )
            {
                deposito._deposito.RemoveAt(deposito.GetIndiceProducto(producto));
                SeElimino = true;
            }
            else
            {
                //Console.WriteLine("Ya esta " + periferico.ToString() + " en el grupo");
            }

            return SeElimino;
        }

    }
}
