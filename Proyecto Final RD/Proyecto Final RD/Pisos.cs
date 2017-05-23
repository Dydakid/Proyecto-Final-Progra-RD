using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_RD
{
    class Pisos: Propiedades
    {
        string vhhn;
        int habitaciones;

        public string Vhhn
        {
            get
            {
                return vhhn;
            }

            set
            {
                vhhn = value;
            }
        }

        public int Habitaciones
        {
            get
            {
                return habitaciones;
            }

            set
            {
                habitaciones = value;
            }
        }
    }
}
