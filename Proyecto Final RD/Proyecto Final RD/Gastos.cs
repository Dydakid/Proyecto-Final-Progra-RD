using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_RD
{
    class Gastos
    {
        string identificacion;
        string nombre;
        string tipoDeReparto;

        public string Identificacion
        {
            get
            {
                return identificacion;
            }

            set
            {
                identificacion = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string TipoDeReparto
        {
            get
            {
                return tipoDeReparto;
            }

            set
            {
                tipoDeReparto = value;
            }
        }
    }
}
