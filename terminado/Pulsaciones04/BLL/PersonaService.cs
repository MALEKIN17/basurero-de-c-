using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
using DAL;
namespace BLL
{
    public class PersonaService
    {
        List<Persona> listaPersona;
        PersonaRepository personaRepository= new PersonaRepository();
        public PersonaService()
        {
            listaPersona= personaRepository.ConsultarTodos();
        }

        public List<Persona> ConsultarTodos()
        {
            return listaPersona;
        }
        public string Guardar(Persona persona)
        {
            var msg = personaRepository.Guardar(persona);
            listaPersona = personaRepository.ConsultarTodos();
            return msg;
        }


        public string Actualizar(List<Persona> personas)
        {
            var msg= personaRepository.Guardar(personas);
            listaPersona = personaRepository.ConsultarTodos();
            return msg;
        }

        public bool Eliminar(Persona persona)
        {
            if (persona == null)
            {
                return false;
            }
            var buscado = BuscarIdentificacion(persona.Identificacion);
            if (buscado != null)
            {
                listaPersona.Remove(buscado);
                Actualizar(listaPersona);
                return true;
            }
            return false;
        }

        public Persona obteneridentificacion(string identificacion)
        {

            try
            {
                if (listaPersona == null)
                {
                    return null;
                }
                else
                {
                    foreach (var personatemporal in listaPersona)
                    {
                        if (personatemporal.Identificacion == int.Parse(identificacion))
                        {
                            return personatemporal;
                        }
                    }
                    return null;

                }


            }
            catch (Exception)
            {
                return null;
            }
        }

        public string Actualizar(String NOMBRE)
        {
            try
            {
                if (NOMBRE == null)
                {
                    return "error al actualizar el contacto ";
                }
                else
                {
                    for (int i = 0; i < listaPersona.Count; i++)
                    {

                        if (listaPersona[i].Nombre == NOMBRE)
                        {

                            Console.WriteLine("Identificacion: ");
                            listaPersona[i].Identificacion = int.Parse(Console.ReadLine());
                            Console.WriteLine("Nombre: ");
                            listaPersona[i].Nombre = Console.ReadLine();
                            Console.WriteLine("Edad: ");
                            listaPersona[i].Edad = int.Parse(Console.ReadLine());
                            Console.WriteLine("Sexo: ");
                            listaPersona[i].Sexo = Console.ReadLine();


                        }
                    }
                    return $"se actualizo el contacto --> {NOMBRE}";
                }


            }
            catch (Exception)
            {
                return "error al actualizar el contacto ";
            }
        }


        public Persona BuscarIdentificacion(int id)
        {
            foreach (var item in listaPersona)
            {
                if (item.Identificacion == id)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
