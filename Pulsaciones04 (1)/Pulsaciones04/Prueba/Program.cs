using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;

using BLL;
namespace Prueba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ENTITY.Persona  persona = new ENTITY.Persona(1,"JOHNP",33,"M",80);
            ENTITY.Persona persona2 = new ENTITY.Persona(1, "pedro", 44, "M", 80);
            var service = new PersonaService();
            //Console.WriteLine(service.Guardar (persona));
            //Console.WriteLine(service.Guardar(persona2));
            var listaPersonas = service.ConsultarTodos();

            Console.WriteLine("**************************");
            Console.WriteLine("identificacion \t\tnombre \t sexo");
            foreach (var item in listaPersonas)
            {
                Console.WriteLine($"\t{item.Identificacion}\t\t{item.Nombre}\t{item.Sexo}");

            }
            Console.WriteLine();
            Console.WriteLine(  );
            listaPersonas.RemoveAt(1);
            Console.WriteLine("**************************");
            Console.WriteLine("identificacion \t\tnombre \t sexo");
            foreach (var item in listaPersonas)
            {
                Console.WriteLine($"\t{item.Identificacion}\t\t{item.Nombre}\t{item.Sexo}");

            }
            Console.ReadKey();
        }
    }
}
