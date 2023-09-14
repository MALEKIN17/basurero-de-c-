using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public interface IContacto
    {
        string Add(ContactoFamiliar contacto);
        string Delete(string contacto);
        List<ContactoFamiliar> GetAll();
        ContactoFamiliar GetByPhone(string phone);
        List<ContactoFamiliar> GetByName(string name);
        string Update(string contacto);
        bool exists(ContactoFamiliar contacto);



    }


}
