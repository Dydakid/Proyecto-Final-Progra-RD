using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_RD
{
    class Garaje: Propiedades
    {
        string ac;
        string bodega;

        public string Ac
        {
            get
            {
                return ac;
            }

            set
            {
                ac = value;
            }
        }

        public string Bodega
        {
            get
            {
                return bodega;
            }

            set
            {
                bodega = value;
            }
        }
    }
}
