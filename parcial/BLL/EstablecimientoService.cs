using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class EstablecimientoService
    {
        List<Establecimiento> listaEstablecimientos;

        EstablecimientoRepository establecimientoRepository = new EstablecimientoRepository();
        public EstablecimientoService()
        {
            listaEstablecimientos = establecimientoRepository.ConsultarTodos();
        }

        public List<Establecimiento> ConsultarTodos()
        {
            return listaEstablecimientos;
        }
        public string Guardar(Establecimiento establecimiento)
        {
            var msg = establecimientoRepository.Guardar(establecimiento);
            listaEstablecimientos = establecimientoRepository.ConsultarTodos();
            return msg;
        }


        public string Actualizar(List<Establecimiento> personas)
        {
            var msg = establecimientoRepository.Guardar(personas);
            listaEstablecimientos = establecimientoRepository.ConsultarTodos();
            return msg;
        }

        public bool Eliminar(Establecimiento establecimiento)
        {
            if (establecimiento == null)
            {
                return false;
            }
            var buscado = ObtenerIdentificacion(establecimiento.Identificacion);
            if (buscado != null)
            {
                listaEstablecimientos.Remove(buscado);
                Actualizar(listaEstablecimientos);
                return true;
            }
            return false;
        }

        public Establecimiento ObtenerIdentificacion(int id)
        {
            foreach (var item in listaEstablecimientos)
            {
                if (item.Identificacion == id)
                {
                    return item;
                }
            }
            return null;
        }


        public double CalcularImpuesto(string responsabilidad, double ganancias, int tiempoFuncionamiento)
        {
            double impuesto = 0;

            if (responsabilidad == "IVA")
            {
                impuesto = CalcularImpuestoIVA(ganancias);
            }
            else if (responsabilidad == "RST")
            {
                impuesto = CalcularImpuestoRST(ganancias);
            }
            else if (responsabilidad == "ninguno")
            {
                impuesto = CalcularImpuestoNinguno(ganancias);
            }
            else
            {
                return 0; // Si la responsabilidad no es ninguna de las mencionadas, se devuelve 0.
            }

            return impuesto;
        }

        private double CalcularImpuestoIVA(double ganancias)
        {
            double tarifa = 0;
            if (ganancias < 100)
            {
                tarifa = 0.05;
            }
            else if (ganancias >= 100 && ganancias < 200)
            {
                tarifa = 0.1;
            }
            else if (ganancias >= 200)
            {
                tarifa = 0.15;
            }

            double impuesto = ganancias * tarifa;

            return impuesto;
        }

        private double CalcularImpuestoRST(double ganancias)
        {
            double tarifa = 0;
            if (ganancias > 50)
            {
                tarifa = 0.05;
            }

            double impuesto = ganancias * tarifa;

            return impuesto;
        }

        private double CalcularImpuestoNinguno(double ganancias)
        {
            double tarifa = 0;
            if (ganancias < 6)
            {
                tarifa = 0.01;
            }
            else if (ganancias >= 6 && ganancias < 10)
            {
                tarifa = 0.02;
            }
            else if (ganancias >= 10)
            {
                tarifa = 0.03;
            }

            double impuesto = ganancias * tarifa;

            return impuesto;
        }

        
        public double CalcularGananciasEnUVT(double ganancias)
        {
            double valorUVT = 30000; 
            return ganancias / valorUVT;
        }

        
        public double ObtenerTarifa(string responsabilidad, double ganancias)
        {
            double tarifa = 0;
            if (responsabilidad == "IVA")
            {
                tarifa = CalcularImpuestoIVA(ganancias) / ganancias;
            }
            else if (responsabilidad == "RST")
            {
                tarifa = CalcularImpuestoRST(ganancias) / ganancias;
            }
            else if (responsabilidad == "ninguno")
            {
                tarifa = CalcularImpuestoNinguno(ganancias) / ganancias;
            }

            return tarifa;
        }



        public Establecimiento obteneridentificacion(string identificacion)
        {

            try
            {
                if (listaEstablecimientos == null)
                {
                    return null;
                }
                else
                {
                    foreach (var personatemporal in listaEstablecimientos)
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
    }
}
