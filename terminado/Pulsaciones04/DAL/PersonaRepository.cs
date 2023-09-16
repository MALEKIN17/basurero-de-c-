using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ENTITY;

namespace DAL
{
    public  class PersonaRepository
    {
        string fileName = "persona.txt";

        public string Guardar(Persona persona)
        {
            //1 abrimos el archivo
            var escritor = new StreamWriter(fileName,true );
            //2 opereacion deescritura
            escritor.WriteLine(persona.ToString());
            //3 cerrar - guardar los datos en el disco
            escritor.Close();


            return "todo bien";
        }
        public string Guardar(List<Persona> personas)
        {
          
            var escritor = new StreamWriter(fileName, false);
            foreach (var item in personas )
            {
                escritor.WriteLine(item.ToString());
            }
            escritor.Close();

            return "datos actalizados";
        }



         public List<Persona> ConsultarTodos()
        {
            List<Persona> personas = new List<Persona>();
            try
            {
                StreamReader lector = new StreamReader(fileName);
                while (!lector.EndOfStream)
                {
                    var linea = lector.ReadLine();
                    personas.Add(Map2(linea));

                }
                lector.Close();

                return personas;
            }
            catch (Exception)
            {
                return null;
            }
            
        }

        private Persona Map(string linea)
        {
            Persona persona = new Persona();
            persona.Identificacion = int.Parse(linea.Split(';')[0]);
            persona.Nombre = (linea.Split(';')[1]);
            persona.Edad = int.Parse(linea.Split(';')[2]);
            persona.Sexo = (linea.Split(';')[3]);
            persona.Pulsacion = decimal.Parse(linea.Split(';')[4]);
            return persona;
        }

        private Persona Map2(string linea)
        {
            Persona persona = new Persona();
            var datos = linea.Split(';');
            persona.Identificacion = int.Parse(datos[0]);
            persona.Nombre = (datos[1]);
            persona.Edad = int.Parse(datos[2]);
            persona.Sexo = (datos[3]);
            persona.Pulsacion = decimal.Parse(datos[4]);
            return persona;
        }
    }
}
