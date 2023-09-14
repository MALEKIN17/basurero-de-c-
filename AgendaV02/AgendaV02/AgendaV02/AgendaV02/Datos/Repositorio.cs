using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entidades;

namespace Datos
{
    public class Repositorio
    {

        String Ruta = "C:\\Users\\santa\\Desktop\\AgendaV02\\AgendaV02\\AgendaV02\\AgendaV02\\Datos\\bin\\Debug\\Contactos.txt";

        public String GuardarContacto(ContactoFamiliar Contacto) {
            StreamWriter Sw = new StreamWriter(Ruta, true);
            Sw.WriteLine(Contacto.ToString());
            Sw.Close();

            return "Ok Contacto Guardado";
        }

        private ContactoFamiliar Mapeador(String Linea)
        {
            var Contacto = new ContactoFamiliar
            {

                Id = int.Parse(Linea.Split(';')[0]),
                Nombre = Linea.Split(';')[1],
                Telefono = Linea.Split(';')[2],
                FechaNacimiento = DateTime.Parse(Linea.Split(';')[3])

            };

            return Contacto;
        }

        public List<ContactoFamiliar> GetFamiliarList() {

            var Lista = new List<ContactoFamiliar>();
            var sr = new StreamReader(Ruta);
            while (!sr.EndOfStream) { 
                var line = sr.ReadLine();
               
            }
           
            return Lista;
        }

    }


}
