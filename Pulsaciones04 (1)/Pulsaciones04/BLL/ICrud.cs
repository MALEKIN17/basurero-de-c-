using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface ICrud
    {
        string Guardar(Persona persona);
        List<Persona> ConsultarTodos();
        bool Eliminar(Persona persona); 
        bool Actualizar(Persona persona);   
        Persona BuscarId(int id);
    }
}
