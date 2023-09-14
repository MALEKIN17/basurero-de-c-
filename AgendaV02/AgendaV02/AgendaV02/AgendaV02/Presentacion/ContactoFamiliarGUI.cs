using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logica;
using Entidades;

namespace Presentacion
{
    public class ContactoFamiliarGUI
    {
        ServicioContactoFamiliar servicioContactoFamiliar= new ServicioContactoFamiliar();
        public void CapturarDatosF()
        {
            int d, m, a;
            var contacto = new ContactoFamiliar();

            Console.Clear();
            Console.WriteLine("Datos de contactos familiares");
            contacto.Id= new Random().Next(1,40);
            Console.WriteLine("Nombre: "); contacto.Nombre= Console.ReadLine();
            Console.WriteLine("Telefono: "); contacto.Telefono = Console.ReadLine();
            Console.WriteLine("Fecha");
            Console.WriteLine("dia: "); d=int.Parse(Console.ReadLine());
            Console.WriteLine("mes: "); m = int.Parse(Console.ReadLine());
            Console.WriteLine("año: "); a = int.Parse(Console.ReadLine());
            contacto.FechaNacimiento = new DateTime(a, m, d);
            var msg=servicioContactoFamiliar.Add(contacto);
            Console.WriteLine(msg);
            Console.ReadKey();

        }

        public   void ConsultarF()
        {

            if (servicioContactoFamiliar.GetAll() == null)
            {
                Console.WriteLine("Error no hay datos");
            }
            else
            {
                int i = 2;
                Console.Clear();
                Console.SetCursorPosition(35, 5); Console.WriteLine("Listado de contactos familiares");
                Console.SetCursorPosition(30, 8); Console.Write("ID");
                Console.SetCursorPosition(35, 8); Console.Write("NOMBRE");
                Console.SetCursorPosition(50, 8); Console.Write("TELEFONO");
                Console.SetCursorPosition(63, 8); Console.Write("FECHA");
                foreach (var item in servicioContactoFamiliar.GetAll())
                {
                    Console.SetCursorPosition(30, 8 + i); Console.Write(item.Id);
                    Console.SetCursorPosition(35, 8 + i); Console.Write(item.Nombre);
                    Console.SetCursorPosition(50, 8 + i); Console.Write(item.Telefono);
                    Console.SetCursorPosition(63, 8 + i); Console.Write(item.FechaNacimiento.ToShortDateString());
                    i++;
                }
                Console.ReadKey();
            }

        }

        public void Eliminar()
        {

            Console.WriteLine("Ingrese la persona a borrar");
            String Borrar = Console.ReadLine();
            var msg = servicioContactoFamiliar.Delete(Borrar);
            Console.WriteLine(msg);
            Console.ReadKey();

        }
        public void Actailizar()
        {
            Console.WriteLine("Ingrese la persona a actualizar");
            String Actualizar = Console.ReadLine();
            var msg = servicioContactoFamiliar.Update(Actualizar);
            Console.WriteLine(msg);
            Console.ReadKey();

        }
    }
}                 
