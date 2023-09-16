using BLL;
using ENTITY;
using System;

namespace Presentacion
{
    internal class PersonaGUI
    {
        private EstablecimientoService establecimientoService = new EstablecimientoService();

       

        public void Menu()
        {
            int op = 0;
            do
            {
                Console.Clear();
                Console.SetCursorPosition(20, 2); Console.Write("MENU PRINCIPAL");
                Console.SetCursorPosition(10, 5); Console.Write("1. Agregar establecimiento");
                Console.SetCursorPosition(10, 7); Console.Write("2. Mostrar establecimientos");
                Console.SetCursorPosition(10, 9); Console.Write("3. Eliminar establecimiento");
                Console.SetCursorPosition(10, 11); Console.Write("4. Salir");
                Console.SetCursorPosition(20, 13); Console.Write("Seleccione una opción:");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        AgregarEstablecimiento();
                        break;
                    case 2:
                        MostrarEstablecimientos();
                        break;
                    case 3:
                        EliminarEstablecimiento();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }

            } while (op != 4);
        }

        private void EliminarEstablecimiento()
        {
            Console.WriteLine("Ingrese el numero de la persona a borrar");
            int Borrar = int.Parse(Console.ReadLine());
            Establecimiento personaborrar = establecimientoService.ObtenerIdentificacion(Borrar);
            var msg = establecimientoService.Eliminar(personaborrar);
            Console.WriteLine(msg);
            Console.ReadKey();
        }

        private void MostrarEstablecimientos()
        {
            Console.Clear();
            Console.SetCursorPosition(15, 2); Console.Write("Listado General");
            Console.SetCursorPosition(10, 4); Console.Write("Identificacion");
            Console.SetCursorPosition(28, 4); Console.Write("Ingresos Anuales");
            Console.SetCursorPosition(40, 4); Console.Write("Gastos Anuales");
            Console.SetCursorPosition(46, 4); Console.Write("Responsabilidad");
            Console.SetCursorPosition(60, 4); Console.Write("Tiempo Funcionamiento");
            Console.SetCursorPosition(70, 4); Console.Write("Impuestos");
            Console.SetCursorPosition(75, 4); Console.Write("Valor Ganancias Obtenidas");
            Console.SetCursorPosition(80, 4); Console.Write("Valor Ganancia en UVT");
            Console.SetCursorPosition(85, 4); Console.Write("Tarifa Aplicada");
            Console.SetCursorPosition(90, 4); Console.Write("Valor Impuesto");

            int posicion = 2;
            foreach (var item in establecimientoService.ConsultarTodos())
            {
                Console.SetCursorPosition(15, 4 + posicion); Console.Write(item.Identificacion);
                Console.SetCursorPosition(29, 4 + posicion); Console.Write(item.Nombre);
                Console.SetCursorPosition(42, 4 + posicion); Console.Write(item.Ingresos_Anuales);
                Console.SetCursorPosition(48, 4 + posicion); Console.Write(item.Gastos_Anuales);
                Console.SetCursorPosition(59, 4 + posicion); Console.Write(item.Responsavilidad);
                Console.SetCursorPosition(65, 4 + posicion); Console.Write(item.Tiempo_Funcionamiento);
                Console.SetCursorPosition(70, 4 + posicion); Console.Write(item.Impuestos);
                Console.SetCursorPosition(75, 4 + posicion); Console.Write(item.Valor_ganancias_obtenidas);
                Console.SetCursorPosition(80, 4 + posicion); Console.Write(item.Valor_ganancia_en_UVT);
                Console.SetCursorPosition(85, 4 + posicion); Console.Write(item.Tarifa_aplicada);
                Console.SetCursorPosition(90, 4 + posicion); Console.Write(item.Valor_impuesto);
                posicion++;
            }
            Console.ReadKey();
        }

        private void AgregarEstablecimiento()
        {
            Console.Clear();
            Console.WriteLine("Ingrese la identificacion del Establecimiento:");
            int identificacion = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el nombre del Establecimiento:");
            string nombre = Console.ReadLine();

            Console.WriteLine("Digite los ingresos Anuales del Establecimiento:");
            double ingresos_Anuales = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese los gastos Anuales del Establecimiento:");
            double gastos_Anuales = double.Parse(Console.ReadLine());

            Console.WriteLine("El establecimiento es responsable de IVA, RST o ninguno?.:");
            string responsabilidad = Console.ReadLine().ToUpper();

            Console.WriteLine("Ingrese los años en funcionamiento del Establecimiento:");
            int tiempo_funcionamiento = int.Parse(Console.ReadLine());

            double tarifa = establecimientoService.ObtenerTarifa(responsabilidad, ingresos_Anuales);
            double impuestos = ingresos_Anuales * tarifa;
            double valor_ganancias_obtenidas = ingresos_Anuales - gastos_Anuales;
            double valor_ganancia_en_UVT = establecimientoService.CalcularGananciasEnUVT(valor_ganancias_obtenidas);
            double valor_impuesto = establecimientoService.CalcularImpuesto(responsabilidad, ingresos_Anuales, tiempo_funcionamiento);

            Establecimiento establecimiento = new Establecimiento(identificacion, nombre, ingresos_Anuales,
                gastos_Anuales, responsabilidad, tiempo_funcionamiento, impuestos, valor_ganancias_obtenidas,
                valor_ganancia_en_UVT, tarifa, valor_impuesto);

            Console.Write(establecimientoService.Guardar(establecimiento));
            Console.ReadKey();
        }
    }
}


