using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_RD
{
    class Pagos
    {
        string id_gasto;
        string descripcion;
        int importe;
        string tipo_de_zona_de_reparto;

        public string Id_gasto
        {
            get
            {
                return id_gasto;
            }

            set
            {
                id_gasto = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

        public int Importe
        {
            get
            {
                return importe;
            }

            set
            {
                importe = value;
            }
        }

        public string Tipo_de_zona_de_reparto
        {
            get
            {
                return tipo_de_zona_de_reparto;
            }

            set
            {
                tipo_de_zona_de_reparto = value;
            }
        }
    }
}
