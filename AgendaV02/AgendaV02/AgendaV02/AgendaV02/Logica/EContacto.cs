using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public interface EContacto
    {

        string Add(ContactoEmpresarial contactoE);
        string Delete(ContactoEmpresarial contactoE);
        List<ContactoEmpresarial> GetAllE();
        ContactoEmpresarial GetByPhoneE(string phone);
        List<ContactoEmpresarial> GetByNameE(string name);
        string UpdateE(string contactoE);
        bool existsE(ContactoEmpresarial contactoE);



    }
}
