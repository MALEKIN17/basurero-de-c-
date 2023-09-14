using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ContactoFamiliar : Persona
    {
        public ContactoFamiliar()
        {
        }

        public ContactoFamiliar(int id, string nombre, string telefono, DateTime fechaNacimiento) : base(id, nombre, telefono)
        {
            FechaNacimiento = fechaNacimiento;
        }
        public DateTime FechaNacimiento { get; set; }



        public int Edad()
        {
            return DateTime.Now.Year - FechaNacimiento.Year;
        }

        public override string ToString()
        {
            return $"{Id};{Nombre};{Telefono};{FechaNacimiento.ToShortDateString()}";

        }

    }
}
