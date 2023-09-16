using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ENTITY;

namespace DAL
{
    public class EstablecimientoRepository
    {
        string fileName = "Establecimiento.txt";
       
        
        public string Guardar(Establecimiento establecimiento)
        {
            var escritor = new StreamWriter(fileName, true);
            escritor.WriteLine(establecimiento.ToString());
            escritor.Close();
            return "establecimiento guardado correctamente";
        }
        public string Guardar(List<Establecimiento> Establecimientos)
        {

            var escritor = new StreamWriter(fileName, false);
            foreach (var item in Establecimientos)
            {
                escritor.WriteLine(item.ToString());
            }
            escritor.Close();

            return "datos actalizados";
        }

        public List<Establecimiento> ConsultarTodos()
        {
            List<Establecimiento> personas = new List<Establecimiento>();
            try
            {
                StreamReader lector = new StreamReader(fileName);
                while (!lector.EndOfStream)
                {
                    var linea = lector.ReadLine();
                    personas.Add(Map2(linea));

                }
                lector.Close();

                return personas;
            }
            catch (Exception)
            {
                return null;
            }

        }
         

        private Establecimiento Map2(string linea)
        {
            Establecimiento establecimiento = new Establecimiento();
            var datos = linea.Split(';');
            establecimiento.Identificacion = int.Parse(datos[0]);
            establecimiento.Nombre = (datos[1]);
            establecimiento.Ingresos_Anuales = double.Parse(datos[2]);
            establecimiento.Gastos_Anuales = double.Parse((datos[3]));
            establecimiento.Responsavilidad = (datos[4]);
            establecimiento.Tiempo_Funcionamiento = int.Parse(datos[5]);
            establecimiento.Impuestos = double.Parse(datos[6]);
            establecimiento.Valor_ganancias_obtenidas = double.Parse(datos[7]);
            establecimiento.Valor_ganancia_en_UVT = double.Parse(datos[8]);
            establecimiento.Tarifa_aplicada = double.Parse(datos[9]);
            establecimiento.Valor_impuesto = double.Parse(datos[10]);
            return establecimiento;
        }

    }
}
