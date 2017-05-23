using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_RD
{
    class Local: Propiedades
    {
        string nombre_comercial;
        string actividad;

        public string Nombre_comercial
        {
            get
            {
                return nombre_comercial;
            }

            set
            {
                nombre_comercial = value;
            }
        }

        public string Actividad
        {
            get
            {
                return actividad;
            }

            set
            {
                actividad = value;
            }
        }
    }
}
