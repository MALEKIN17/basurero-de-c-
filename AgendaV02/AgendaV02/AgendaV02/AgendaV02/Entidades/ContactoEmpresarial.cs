using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ContactoEmpresarial : Persona
    {

        public ContactoEmpresarial()
        {
        }

        public ContactoEmpresarial(int id, string nombre, string telefono, String nombreenmpresa, String correo) : base(id, nombre, telefono)
        {
            nombreenmpresa = NombreEmpresa;
            correo = Correo;
        }
        public String NombreEmpresa { get; set; }
        public String Correo { get; set; }

        
    }
}
