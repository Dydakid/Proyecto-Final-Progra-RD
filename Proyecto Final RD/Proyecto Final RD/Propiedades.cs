using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_RD
{
    class Propiedades
    {
        string tipo_de_propiedad;
        string codigo_de_propiedad;
        int metros_cuadrdos;
        string propietarios;
        List<string> gastos;

        public string Tipo_de_propiedad
        {
            get
            {
                return tipo_de_propiedad;
            }

            set
            {
                tipo_de_propiedad = value;
            }
        }

        public string Codigo_de_propiedad
        {
            get
            {
                return codigo_de_propiedad;
            }

            set
            {
                codigo_de_propiedad = value;
            }
        }

        public int Metros_cuadrdos
        {
            get
            {
                return metros_cuadrdos;
            }

            set
            {
                metros_cuadrdos = value;
            }
        }

        public string Propietarios
        {
            get
            {
                return propietarios;
            }

            set
            {
                propietarios = value;
            }
        }

        public List<string> Gastos
        {
            get
            {
                return gastos;
            }

            set
            {
                gastos = value;
            }
        }
    }
}
