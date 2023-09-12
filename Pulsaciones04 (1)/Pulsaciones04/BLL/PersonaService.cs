using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
using DAL;
using System.Net.Http.Headers;

namespace BLL
{
    public class PersonaService : ICrud
    {
        List<Persona> listaPersona;
        PersonaRepository personaRepository= new PersonaRepository();
        public PersonaService()
        {
            listaPersona = personaRepository.ConsultarTodos();
        }

        public List<Persona> ConsultarTodos()
        {
            return listaPersona;
        }
        public string Guardar(Persona persona)
        {
            // validacion 
           var msg=  personaRepository.Guardar(persona);
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
            if (persona==null)
            {
                return false;
            }
            var buscado = BuscarId(persona.Identificacion);
            if (buscado != null)
            {
                listaPersona.Remove(buscado);
                Actualizar(listaPersona);
                return true;
            }
            return false;
        }
      
        public bool Actualizar(Persona persona)
        {
            throw new NotImplementedException();
        }

        public Persona BuscarId(int id)
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
