using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class TPExtension
    {
        public static string InformeExcepcion(this TPException exc)
        {
            return "Error al cargar los datos Xml. TP Exception.";
        }
    }
}
