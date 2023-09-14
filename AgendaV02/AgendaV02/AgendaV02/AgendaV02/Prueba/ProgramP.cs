using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    internal class ProgramP
    {
        static void Main(string[] args)
        {
            Repositorio repositorio= new Repositorio();
            Console.WriteLine("Capa de Prueba");

            var contacto= new Entidades.ContactoFamiliar(new Random().Next(1,20),"johnp","64646464",new DateTime(200,11,8) );
            var contacto1 = new Entidades.ContactoFamiliar(
                new Random().Next(1, 20), "maria", "64646464", new DateTime(200, 11, 8)
                );

            /*var servicio = new Logica.ServicioContactoFamiliar();
            var msg = servicio.Add(contacto);
            servicio.Add(contacto1);

            Console.WriteLine(msg);
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("lista de contactos");
            Console.WriteLine("Nombre -->Telefono");
            foreach (var item in servicio.GetAll())
            {
                Console.WriteLine(item.Nombre + "-->" + item.Telefono);
            }*/
            repositorio.GuardarContacto(contacto);
            repositorio.GuardarContacto(contacto1);

            Console.ReadKey();

             
        }
    }
}
