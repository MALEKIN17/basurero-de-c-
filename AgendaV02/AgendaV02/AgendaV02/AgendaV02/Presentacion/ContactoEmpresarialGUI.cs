using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{

    
    public  class ContactoEmpresarialGUI
    {
        public int i = 2;
        ServicioContactoEmpresarial servicioContactoEmpresarial = new ServicioContactoEmpresarial();
        public void CapturarDatosE()
        {
            var contacto = new ContactoEmpresarial();

            Console.Clear();
            Console.WriteLine("Datos de contactos Empresarial");
            contacto.Id = new Random().Next(1, 40);
            Console.WriteLine("Nombre: "); contacto.Nombre = Console.ReadLine();
            Console.WriteLine("Telefono: "); contacto.Telefono = Console.ReadLine();
            Console.WriteLine("Datos Empresariales");
            Console.WriteLine("Nombre de la empresa: "); contacto.NombreEmpresa = Console.ReadLine();
            Console.WriteLine("Correo de la empresa: "); contacto.Correo = Console.ReadLine();
            var msg = servicioContactoEmpresarial.Add(contacto);
            Console.WriteLine(msg);
            Console.ReadKey();  

        }

        public void ConsultarE()
        {
            if(servicioContactoEmpresarial.GetAllE() == null)
            {
                Console.WriteLine("Error no hay datos");
            }
            else 
            {

                Console.Clear();
                Console.SetCursorPosition(35, 5); Console.WriteLine("Listado de contactos familiares");
                Console.SetCursorPosition(30, 8); Console.Write("ID");
                Console.SetCursorPosition(35, 8); Console.Write("NOMBRE");
                Console.SetCursorPosition(50, 8); Console.Write("TELEFONO");
                Console.SetCursorPosition(63, 8); Console.Write("FECHA");



                foreach (var item in servicioContactoEmpresarial.GetAllE())
                {
                    Console.SetCursorPosition(30, 8 + i); Console.Write(item.Id);
                    Console.SetCursorPosition(35, 8 + i); Console.Write(item.Nombre);
                    Console.SetCursorPosition(50, 8 + i); Console.Write(item.Telefono);
                    Console.SetCursorPosition(63, 8 + i); Console.Write(item.NombreEmpresa);
                    Console.SetCursorPosition(63, 8 + i); Console.Write(item.Correo);
                    i++;
                }
                Console.ReadKey();


            }

        }
        public void Eliminar()
        {

            Console.WriteLine("Ingrese el numero de la persona empresaria a borrar");
            String Borrar = Console.ReadLine();
            ContactoEmpresarial ContacDele = servicioContactoEmpresarial.GetByPhoneE(Borrar);
            var msg = servicioContactoEmpresarial.Delete(ContacDele);
            Console.WriteLine(msg);
            Console.ReadKey();

        }

        public void Actailizar()
        {
            Console.WriteLine("Ingrese la persona a actualizar");
            String Actualizar = Console.ReadLine();
            var msg = servicioContactoEmpresarial.UpdateE(Actualizar);
            Console.WriteLine(msg);
            Console.ReadKey();

        }
    }
}
