using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Persona
    {
        public int Identificacion { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public decimal Pulsacion { get; set; }

        public Persona()
        {

        }

        public Persona(int identificacion, string nombre, int edad, string sexo, decimal pulsacion)
        {
            Identificacion = identificacion;
            Nombre = nombre;
            Edad = edad;
            Sexo = sexo;
            Pulsacion = pulsacion;
        }
        public override string ToString()
        {
            return $"{Identificacion};{Nombre};{Edad};{Sexo};{Pulsacion}";
        }
    }
}
