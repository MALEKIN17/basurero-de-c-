using Entidades;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServicioContactoFamiliar : IContacto
    {
        List<ContactoFamiliar> ContactoFamiliars= null;
        List<ContactoFamiliar> SubListN = null;
        public ServicioContactoFamiliar()
        {
            ContactoFamiliars = new List<ContactoFamiliar>();
        }

        public string Add(ContactoFamiliar contacto)
        {
            try
            {
                //validar
                if (contacto == null)
                {
                    return "error al guardar el contacto ";
                }
               
                ContactoFamiliars.Add(contacto);
                return $"se guardo el contacto --> {contacto.Nombre}";
            }
            catch (Exception)
            {
                return "error al guardar el contacto ";
            }
           

        }

        public string Delete(String contacto)
        {
            try
            {
                if (contacto == null)
                {
                    return "error al Borrar el contacto ";
                }
                else
                {
                    for (int i =0;i< ContactoFamiliars.Count;i++)
                    {
                        
                        if (ContactoFamiliars[i].Nombre == contacto)
                        {
                            ContactoFamiliars.Remove(ContactoFamiliars[i]);

                        }
                    }
                    return $"se Elimino el contacto --> {contacto}";
                }


            }
            catch (Exception)
            {
                return "error al Borrar el contacto ";
            }
        }

        public bool exists(ContactoFamiliar contacto)
        {
            throw new NotImplementedException();
        }

        public List<ContactoFamiliar> GetAll()
        {
           if (ContactoFamiliars.Count == 0) { return null; }
           
            return ContactoFamiliars;
        }

        public List<ContactoFamiliar> GetByName(string name)
        {

            try
            {
                if (ContactoFamiliars == null)
                {
                    return null;
                }
                else
                {
                    for(int i = 0;i< ContactoFamiliars.Count; i++)
                    {
                        if (name == ContactoFamiliars[i].Nombre)
                        {
                            SubListN.Add(ContactoFamiliars[i]);
                        }
                    }
                    return SubListN;
                }


            }
            catch (Exception)
            {
                return null;
            }
        }

        public ContactoFamiliar GetByPhone(string phone)
        {
            throw new NotImplementedException();
        }

        public string Update(String contacto)
        {
            try
            {
                if (contacto == null)
                {
                    return "error al actualizar el contacto ";
                }
                else
                {
                    for (int i = 0; i < ContactoFamiliars.Count; i++)
                    {

                        if (ContactoFamiliars[i].Nombre == contacto)
                        {
                            int d, m, a;
                            Console.WriteLine("Nombre: ");
                            ContactoFamiliars[i].Nombre = Console.ReadLine();
                            Console.WriteLine("Telefono: ");
                            ContactoFamiliars[i].Telefono = Console.ReadLine();
                            Console.WriteLine("fecha ");
                            Console.WriteLine("dia: "); d = int.Parse(Console.ReadLine());
                            Console.WriteLine("mes: "); m = int.Parse(Console.ReadLine());
                            Console.WriteLine("año: "); a = int.Parse(Console.ReadLine());
                            var contac = new ContactoFamiliar();
                            contac.FechaNacimiento = new DateTime(a, m, d);
                            ContactoFamiliars[i].FechaNacimiento = contac.FechaNacimiento ;

                        }
                    }
                    return $"se actualizo el contacto --> {contacto}";
                }


            }
            catch (Exception)
            {
                return "error al actualizar el contacto ";
            }
        }
    }
}
