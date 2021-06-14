using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;
using System.Windows;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public class FileManager<T>
    {
        
        public void EscribirXML(DepositoFabrica<T> objeto, string nombreArchivo)
        {
            XmlSerializer ser = null;
            XmlWriter writer = null;

            try
            {
                string rutaCompleta = AppDomain.CurrentDomain.BaseDirectory + "XML_" + nombreArchivo + ".xml";
                writer = new XmlTextWriter(rutaCompleta, Encoding.UTF8);
                ser = new XmlSerializer(typeof(DepositoFabrica<T>));

                ser.Serialize(writer, objeto);
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
            }

            Console.WriteLine("finalizo el xml escribir ...");
        }


        public bool EscribirTXT(DepositoFabrica<T> objeto, string nombreArchivo)
        {
            StreamWriter streamWriter = null;
            bool retorno = false;
            try
            {
                streamWriter = new StreamWriter(nombreArchivo + ".txt", false);
                streamWriter.WriteLine(objeto);
                retorno = true;
            }
            catch (Exception) { }
            finally
            {
                if (streamWriter != null)
                {
                    streamWriter.Close();
                }
            }

            return retorno;
        }



            public DepositoFabrica<T> CargarXMLDepositoFabrica(DepositoFabrica<T> deposito, string nombreArchivo)
        {
            XmlSerializer ser = null;
            XmlTextReader reader = null;

            try
            {
                string rutaCompleta = AppDomain.CurrentDomain.BaseDirectory + "XML_" + nombreArchivo + ".xml";
                reader = new XmlTextReader(rutaCompleta);
                ser = new XmlSerializer(typeof(DepositoFabrica<T>));

                deposito = (DepositoFabrica<T>)ser.Deserialize(reader);
            }
            catch (Exception e){ Console.WriteLine(e.Message); }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }

            return deposito;
        }


        public void EscribirNumeroSerie(string numeroSerie, string nombreProducto)
        {
            StreamWriter streamWriter = null;

            try
            { 
                string rutaNumeroSerie = AppDomain.CurrentDomain.BaseDirectory + "serial" + nombreProducto + ".txt";
                streamWriter = new StreamWriter(rutaNumeroSerie, false);

                streamWriter.WriteLine(numeroSerie);
            }
            catch (Exception) { }
            finally
            {
                if (streamWriter != null)
                {
                    streamWriter.Close();
                }
            }
        }

        public string TomarNumeroSerie(string nombreProducto)
        {
            StreamReader streamReader = null;

            string numeroSerie = "-1";

        
            try
            {
                string rutaNumeroSerie = AppDomain.CurrentDomain.BaseDirectory + "serial" + nombreProducto + ".txt";

                streamReader = new StreamReader(rutaNumeroSerie, false);
 
                numeroSerie = streamReader.ReadLine();

                //Console.WriteLine("termino el try");
            }
            catch(FileNotFoundException)
            {
                EscribirNumeroSerie("0", nombreProducto);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (streamReader != null)
                {
                    streamReader.Close();
                }
            }
            return numeroSerie;
        }

    }
}
