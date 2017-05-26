using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Proyecto_Final_RD
{
    public partial class Form1 : Form
    {
        List<Comunidad> Listcomunidad = new List<Comunidad>();
        List<Gastos> Listgastos = new List<Gastos>();
        List<Propietarios> Listpropietarios = new List<Propietarios>();
        List<Propiedades> Listpropiedades = new List<Propiedades>();
        List<Pagos> Listpagos = new List<Pagos>();
        List<Pisos> Listpisos = new List<Pisos>();
        List<Local> Listlocal = new List<Local>();
        List<Garaje> Listgaraje = new List<Garaje>();

        public Form1()
        {
            InitializeComponent();
        }

        private void bttAbrir_Click(object sender, EventArgs e)
        {
            //Se abren los 5 archivos con la información.
            string fileName = "C:\\Users\\kike\\Source\\Repos\\Proyecto-Final-Progra-RD\\Proyecto Final RD\\Comunidad.txt";

            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Comunidad comunidadtemp = new Comunidad();
                comunidadtemp.Indetificacion = Convert.ToInt16(reader.ReadLine());
                comunidadtemp.Nombre = reader.ReadLine();
                comunidadtemp.Poblacion = reader.ReadLine();

                Listcomunidad.Add(comunidadtemp);
            }
            reader.Close();

            string fileName1 = "C:\\Users\\kike\\Source\\Repos\\Proyecto-Final-Progra-RD\\Proyecto Final RD\\Gastos.txt";

            FileStream stream1 = new FileStream(fileName1, FileMode.Open, FileAccess.Read);
            StreamReader reader1 = new StreamReader(stream1);

            while (reader1.Peek() > -1)
            {
                Gastos Gastostemp = new Gastos();
                Gastostemp.Identificacion = reader1.ReadLine();
                Gastostemp.Nombre = reader1.ReadLine();
                Gastostemp.TipoDeReparto = reader1.ReadLine();

                Listgastos.Add(Gastostemp);
            }
            reader1.Close();

            string fileName2 = "C:\\Users\\kike\\Source\\Repos\\Proyecto-Final-Progra-RD\\Proyecto Final RD\\Propiedades.txt";

            FileStream stream2 = new FileStream(fileName2, FileMode.Open, FileAccess.Read);
            StreamReader reader2 = new StreamReader(stream2);

            while (reader2.Peek() > -1)
            {
                Propiedades propiedadestemp = new Propiedades();
                Pisos pisostemp = new Pisos();
                Local localtemp = new Local();
                Garaje garajetemp = new Garaje();
                List<string> gastostemp = new List<string>();

                propiedadestemp.Tipo_de_propiedad = reader2.ReadLine();
                if (propiedadestemp.Tipo_de_propiedad == "P")
                {
                    propiedadestemp.Codigo_de_propiedad = reader2.ReadLine();
                    propiedadestemp.Metros_cuadrdos = Convert.ToInt32(reader2.ReadLine());
                    propiedadestemp.Propietarios = reader2.ReadLine();
                    string gastospr = "";
                    while(gastospr != "---")
                    {
                        gastospr = reader2.ReadLine();
                        if (gastospr != "---")
                            gastostemp.Add(gastospr);
                    }
                    pisostemp.Gastos = gastostemp;
                    pisostemp.Vhvn = reader2.ReadLine();
                    pisostemp.Habitaciones = Convert.ToInt32(reader2.ReadLine());
                    //propiedadestemp.Gastos = reader2.ReadLine();

                    Listpisos.Add(pisostemp);
                }
                else
                    if (propiedadestemp.Tipo_de_propiedad == "L")
                {
                    propiedadestemp.Codigo_de_propiedad = reader2.ReadLine();
                    propiedadestemp.Metros_cuadrdos = Convert.ToInt32(reader2.ReadLine());
                    propiedadestemp.Propietarios = reader2.ReadLine();
                    string gastospr = "";
                    while (gastospr != "---")
                    {
                        gastospr = reader2.ReadLine();
                        if (gastospr != "---")
                            gastostemp.Add(gastospr);
                    }
                    localtemp.Gastos = gastostemp;
                   // lablgasto1.Text = gastostemp;
                    localtemp.Nombre_comercial = reader2.ReadLine();
                    localtemp.Nombre_comercial = reader2.ReadLine();

                    Listlocal.Add(localtemp);
                }
                else
                    if (propiedadestemp.Tipo_de_propiedad == "G")
                {
                    propiedadestemp.Codigo_de_propiedad = reader2.ReadLine();
                    propiedadestemp.Metros_cuadrdos = Convert.ToInt32(reader2.ReadLine());
                    propiedadestemp.Propietarios = reader2.ReadLine();
                    string gastospr = "";
                    while (gastospr != "---")
                    {
                        gastospr = reader2.ReadLine();
                        if (gastospr != "---")
                            gastostemp.Add(gastospr);
                    }
                    garajetemp.Gastos = gastostemp;
                    garajetemp.Ac = reader2.ReadLine();
                    garajetemp.Bodega = reader2.ReadLine();

                    Listgaraje.Add(garajetemp);
                }
                Listpropiedades.Add(propiedadestemp);
            }
            reader2.Close();

            string fileName3 = "C:\\Users\\kike\\Source\\Repos\\Proyecto-Final-Progra-RD\\Proyecto Final RD\\Propietarios.txt";

            FileStream stream3 = new FileStream(fileName3, FileMode.Open, FileAccess.Read);
            StreamReader reader3 = new StreamReader(stream3);

            while (reader3.Peek() > -1)
            {
                Propietarios propietariostemp = new Propietarios();
                propietariostemp.Nombre = reader3.ReadLine();
                propietariostemp.Nit = Convert.ToInt32(reader3.ReadLine());
                propietariostemp.Email = reader3.ReadLine();

                Listpropietarios.Add(propietariostemp);
            }
            reader3.Close();

            string fileName4 = "C:\\Users\\kike\\Source\\Repos\\Proyecto-Final-Progra-RD\\Proyecto Final RD\\Pagos.txt";

            FileStream stream4 = new FileStream(fileName4, FileMode.Open, FileAccess.Read);
            StreamReader reader4 = new StreamReader(stream4);

            while (reader4.Peek() > -1)
            {
                Pagos pagostemp = new Pagos();
                pagostemp.Id_gasto = reader4.ReadLine();
                pagostemp.Descripcion = reader4.ReadLine();
                pagostemp.Importe = Convert.ToInt16(reader4.ReadLine());
                pagostemp.Tipo_de_zona_de_reparto = reader4.ReadLine();

                Listpagos.Add(pagostemp);
            }
            reader4.Close();
            //Muestra en el dataGridview
            dataGridView1.DataSource = Listpropiedades;
            dataGridView1.Refresh();
        }
    }
}
