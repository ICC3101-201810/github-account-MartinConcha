using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Arriendo
    {
        Vehiculos vehiculo;
        Cliente cliente;
        Persona persona;
        Sucursal sucursal;
        List<Accesorios> accesorios;
        string t;
        string fechainicio;
        string fechatermino;

        public Arriendo(string Fechainicio, string Fechatermino)
        {
            fechainicio = Fechainicio;
            fechatermino = Fechatermino;
        }
        public bool verificarArriendo()
        {
            Console.WriteLine("ingrese si es persona u otro");
            t = Console.ReadLine();
            if (t == "persona")
            {
                if (persona.licencia == vehiculo.permiso)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (cliente.autorizacion == vehiculo.permiso)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public void VerInfo()
        {
            int suma = 0;
            Console.WriteLine("Desea agregar accesorios? ");
            string i = Console.ReadLine();
            if (i == "si")
            {
                Console.WriteLine("Ingrese nombre del accesorio: ");
                string a = Console.ReadLine();
                foreach (Accesorios accesorio in accesorios)
                {
                    if (a == accesorio.nombre)
                    {
                        Console.WriteLine("cliente: " + cliente.nombre);
                        Console.WriteLine("vehiculo: " + vehiculo.modelo + " " + vehiculo.marca);
                        Console.WriteLine("accesorios: " + accesorio.nombre);
                        Console.WriteLine("sucursal: " + sucursal.nombre);
                        Console.WriteLine("fecha inicio: " + fechainicio);
                        Console.WriteLine("fecha termino: " + fechatermino);
                        Console.WriteLine("Total a pagar: " + (suma += vehiculo.precio += accesorio.precio));
                        break;
                    }
                }

            }
            else
            {
                Console.WriteLine("No agrego ningun accesorio");
                Console.WriteLine("cliente: " + cliente.nombre);
                Console.WriteLine("vehiculo: " + vehiculo.modelo + " " + vehiculo.marca);
                Console.WriteLine("sucursal: " + sucursal.nombre);
                Console.WriteLine("fecha inicio: " + fechainicio);
                Console.WriteLine("fecha termino: " + fechatermino);
                Console.WriteLine("Total a pagar: " + (suma += vehiculo.precio));
            }

        }
    }
}
