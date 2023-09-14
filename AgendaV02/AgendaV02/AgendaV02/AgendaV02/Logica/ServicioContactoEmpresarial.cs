using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Logica
{
    public class ServicioContactoEmpresarial : EContacto
    {
        List<ContactoEmpresarial> ContactoEmpresarials = null;
        List<ContactoEmpresarial> SubListN = null;
        public ServicioContactoEmpresarial()
        {
            ContactoEmpresarials = new List<ContactoEmpresarial>();
            SubListN = new List<ContactoEmpresarial>();
        }

        public string Add(ContactoEmpresarial contacto)
        {
            try
            {
                //validar
                if (contacto == null)
                {
                    return "error al guardar el contacto ";
                }

                ContactoEmpresarials.Add(contacto);
                return $"se guardo el contacto --> {contacto.Nombre}";
            }
            catch (Exception)
            {
                return "error al guardar el contacto ";
            }


        }

        public string Delete(ContactoEmpresarial contacto)
        {
            try
            {
                if (contacto == null)
                {
                    return "error al Borrar el contacto ";
                }
                else
                {
                    ContactoEmpresarial ContactoEmpre = GetByPhoneE(contacto.Telefono);

                    ContactoEmpresarials.Remove(ContactoEmpre);

                    return $"se Elimino el contacto --> {contacto}";
                }


            }
            catch (Exception)
            {
                return "error al Borrar el contacto ";
            }
        }

        public bool existsE(ContactoEmpresarial contacto)
        {
            String Existe = "No";
            try
            {
                if (contacto == null)
                {
                    return false;
                }
                else
                {
                    foreach(ContactoEmpresarial  Item in ContactoEmpresarials) 
                    {

                        if (Item.Telefono == ContactoEmpresarials[i].Telefono)
                        {

                            Existe = "Si";

                        }
                    }
                    if (Existe == "Si")
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                    
                    
                }


            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<ContactoEmpresarial> GetAllE()
        {
            if (ContactoEmpresarials.Count == 0) { return null; }

            return ContactoEmpresarials;
        }

        public List<ContactoEmpresarial> GetByNameE(string name)
        {

            try
            {
                if (ContactoEmpresarials == null)
                {
                    return null;
                }
                else
                {
                    foreach (var Nomb in ContactoEmpresarials)
                    {
                        // .contains(name) - wich
                        if (name == Nomb.Nombre)
                        {
                            SubListN.Add(Nomb);
                            return SubListN;
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

        public ContactoEmpresarial GetByPhoneE(string phone)
        {
            
            try
            {
                if (ContactoEmpresarials == null)
                {
                    return null;
                }
                else
                {
                    foreach (var Obj in ContactoEmpresarials)
                    {
                        if (Obj.Telefono == phone)
                        {
                            return Obj;
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

        public string UpdateE(String contacto)
        {
            try
            {
                if (contacto == null)
                {
                    return "error al actualizar el contacto ";
                }
                else
                {
                    for (int i = 0; i < ContactoEmpresarials.Count; i++)
                    {

                        if (ContactoEmpresarials[i].Nombre == contacto)
                        {
                            
                            Console.WriteLine("Nombre: ");
                            ContactoEmpresarials[i].Nombre = Console.ReadLine();
                            Console.WriteLine("Telefono: ");
                            ContactoEmpresarials[i].Telefono = Console.ReadLine();
                            Console.WriteLine("Nombre de la empresa: ");
                            ContactoEmpresarials[i].NombreEmpresa = Console.ReadLine();
                            Console.WriteLine("Correo: ");
                            ContactoEmpresarials[i].Correo = Console.ReadLine();


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
