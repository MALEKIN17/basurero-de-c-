using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    public class Menu
    {
        ContactoFamiliarGUI familiarGUI = new ContactoFamiliarGUI();
        ContactoEmpresarialGUI EmpresarialGUI = new ContactoEmpresarialGUI();

        public void verMenu()
        {
            int op;
            do
            {
                Console.Clear();
                Console.SetCursorPosition(28, 5); Console.WriteLine("Menu Principal");
                Console.SetCursorPosition(28, 7); Console.WriteLine("1. Gestion Contacto Familiar");
                Console.SetCursorPosition(28, 8); Console.WriteLine("2.Gestion Contacto Empresarial");
                Console.SetCursorPosition(28, 9); Console.WriteLine("3.Salir");
                Console.SetCursorPosition(28, 10); Console.WriteLine("Que Quieres Hacer: ");
                Console.SetCursorPosition(48, 10); op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Menu_Familiar();
                        break;
                    case 2:
                        Menu_Empresarial();
                        break;
                }

            } while (op != 3);


        }
        public void Menu_Familiar()
        {
            int opFamiliar;
            do
            {
                Console.Clear();
                Console.SetCursorPosition(28, 5); Console.WriteLine("Menu Familiar");
                Console.SetCursorPosition(28, 7); Console.WriteLine("1.Registrar Familiar");
                Console.SetCursorPosition(28, 8); Console.WriteLine("2.Consultar Farmiliar");
                Console.SetCursorPosition(28, 9); Console.WriteLine("3.Modificar Familiar");
                Console.SetCursorPosition(28, 10); Console.WriteLine("4.Eliminar Familiar ");
                Console.SetCursorPosition(28, 11); Console.WriteLine("5.Salir ");
                Console.SetCursorPosition(28, 12); Console.WriteLine("Que Quieres Hacer: ");
                Console.SetCursorPosition(48, 12); opFamiliar = int.Parse(Console.ReadLine());

                switch (opFamiliar)
                {
                    case 1:
                        familiarGUI.CapturarDatosF();
                        break;
                    case 2:
                        familiarGUI.ConsultarF();
                        Console.ReadKey();
                        break;
                    case 3:
                        familiarGUI.Actailizar();
                        Console.ReadKey();
                        break;
                    case 4:
                        familiarGUI.Eliminar();
                        Console.ReadKey();
                        break;
                    case 5:
                        verMenu();
                        break;
                }

            } while (opFamiliar != 5);

        }
        public void Menu_Empresarial()
        {
            int opFamiliar;
            do
            {
                Console.Clear();
                Console.SetCursorPosition(28, 5); Console.WriteLine("Menu Empresarial");
                Console.SetCursorPosition(28, 7); Console.WriteLine("1.Registrar Contacto Empresarial");
                Console.SetCursorPosition(28, 8); Console.WriteLine("2.Consultar Contacto Empresarial");
                Console.SetCursorPosition(28, 9); Console.WriteLine("3.Modificar Contacto Empresarial");
                Console.SetCursorPosition(28, 10); Console.WriteLine("4.Eliminar Contacto Empresarial ");
                Console.SetCursorPosition(28, 11); Console.WriteLine("5.Salir ");
                Console.SetCursorPosition(28, 12); Console.WriteLine("Que Quieres Hacer: ");
                Console.SetCursorPosition(48, 12); opFamiliar = int.Parse(Console.ReadLine());

                switch (opFamiliar)
                {
                    case 1:
                        EmpresarialGUI.CapturarDatosE();
                        Console.ReadKey();
                        break;
                    case 2:
                        EmpresarialGUI.ConsultarE();
                        Console.ReadKey();
                        break;
                    case 3:
                        EmpresarialGUI.Actailizar();
                        Console.ReadKey();
                        break;
                    case 4:
                        EmpresarialGUI.Eliminar();
                        Console.ReadKey();
                        break;
                    case 5:
                        verMenu();
                        break;
                }

            } while (opFamiliar != 5);


        }
    }


}

