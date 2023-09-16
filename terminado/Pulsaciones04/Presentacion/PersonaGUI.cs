using BLL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    internal class PersonaGUI
    {
         PersonaService personaService = new PersonaService();
        public void Menu()
        {
            int op = 0;
            do
            {
                Console.Clear();
                Console.SetCursorPosition(20, 2); Console.Write("MENU PRINCIPAL");
                Console.SetCursorPosition(10, 5); Console.Write("1. Agregar usuario");
                Console.SetCursorPosition(10, 7); Console.Write("2. Mostrar usuarios");
                Console.SetCursorPosition(10, 9); Console.Write("3. Actualizar usuario");
                Console.SetCursorPosition(10, 11); Console.Write("4. Eliminar usuario");
                Console.SetCursorPosition(10, 13); Console.Write("5. Salir");
                Console.SetCursorPosition(20, 13); Console.Write("Seleccione una opción:");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        AgregarUsuario();
                        break;
                    case 2:
                        MostrarUsuarios();
                        break;
                    case 3:
                        ActualizarUsuario();
                        break;
                    case 4:
                        EliminarUsuario();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
            } while (op != 5);
        }

        private void EliminarUsuario()
        {
            Console.WriteLine("Ingrese el numero de la persona  a borrar");
            int Borrar = int.Parse(Console.ReadLine());
            Persona personaborrar = personaService.BuscarIdentificacion(Borrar);
            var msg = personaService.Eliminar(personaborrar);
            Console.WriteLine(msg);
            Console.ReadKey();
        }

        private void ActualizarUsuario()
        {
            Console.WriteLine("Ingrese la persona a actualizar");
            String Actualizar = Console.ReadLine();
            var msg = personaService.Actualizar(Actualizar);
            Console.WriteLine(msg);
            Console.ReadKey();

        }

        private void MostrarUsuarios()
        {
            Console.Clear();
            Console.SetCursorPosition(15, 2); Console.Write("Listado General");
            Console.SetCursorPosition(10, 4); Console.Write("identificacion");
            Console.SetCursorPosition(28, 4); Console.Write("NOmbre");
            Console.SetCursorPosition(40, 4); Console.Write("Edad");
            Console.SetCursorPosition(46, 4); Console.Write("Sexo");
            Console.SetCursorPosition(56, 4); Console.Write("Pulsacion");
            int posicion = 2;
            foreach (var item in personaService.ConsultarTodos())
            {

                Console.SetCursorPosition(15, 4 + posicion); Console.Write(item.Identificacion);
                Console.SetCursorPosition(29, 4 + posicion); Console.Write(item.Nombre);
                Console.SetCursorPosition(42, 4 + posicion); Console.Write(item.Edad);
                Console.SetCursorPosition(48, 4 + posicion); Console.Write(item.Sexo);
                Console.SetCursorPosition(59, 4 + posicion); Console.Write(item.Pulsacion);
                posicion++;
            }
            Console.ReadKey();
        }

        private void AgregarUsuario()
        {
            Console.Clear();
            Console.WriteLine("Ingrese la identificacion del usuario:");
            int identificacion = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el nombre del usuario:");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese la edad del usuario:");
            int edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el sexo del usuario (f/m):");
            string sexo = Console.ReadLine();
            Persona persona = new Persona(identificacion, nombre, edad, sexo, 10);

            Console.Write(personaService.Guardar(persona));
            Console.ReadKey();
        }
    }
}
