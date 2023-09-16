using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Establecimiento
    {
        public int Identificacion { get; set; }
        public string Nombre { get; set; }
        public double Ingresos_Anuales { get; set; }
        public double Gastos_Anuales { get; set; }
        public string Responsavilidad { get; set; }
        public int Tiempo_Funcionamiento { get; set; }
        public double Impuestos { get; set; }
        public double Valor_ganancias_obtenidas { get; set; }
        public double Valor_ganancia_en_UVT { get; set; }
        public double Tarifa_aplicada { get; set; }
        public double Valor_impuesto { get; set; }





        public Establecimiento()
        {

        }

        public Establecimiento(int identificacion, string nombre, double ingresos_Anuales, 
                                double gastos_Anuales,string responsavilidad, int Tiempo_Funcionamiento,    
                                double impuestos, double valor_ganancias_obtenidas, double valor_ganancia_en_UVT,
                                double tarifa_aplicada, double valor_impuesto)
        {
            this.Identificacion = identificacion;
            this.Nombre = nombre;
            this.Ingresos_Anuales = ingresos_Anuales;
            this.Gastos_Anuales = gastos_Anuales;
            this.Responsavilidad = responsavilidad;
            this.Tiempo_Funcionamiento= Tiempo_Funcionamiento;
            this.Impuestos = impuestos;
            this.Valor_ganancias_obtenidas = valor_ganancias_obtenidas;
            this.Valor_ganancia_en_UVT = valor_ganancia_en_UVT;
            this.Tarifa_aplicada = tarifa_aplicada;
            this.Valor_impuesto = valor_impuesto;

        }


         
       public override string ToString()
        {
            return $"{Identificacion};{Nombre};{Ingresos_Anuales};{Gastos_Anuales};{Responsavilidad};" +
                   $"{Tiempo_Funcionamiento};{Impuestos};{Valor_ganancias_obtenidas};{Valor_ganancia_en_UVT};" +
                   $"{Tarifa_aplicada};{Valor_impuesto}";
        }

        
    }
}
