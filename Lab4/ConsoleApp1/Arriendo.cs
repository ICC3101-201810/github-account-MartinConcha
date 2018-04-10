using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Arriendo
    {
        Vehiculos vehiculo;
        Cliente cliente;
        Persona persona;
        Sucursal sucursal;
        Accesorios accesorios;
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
                    Console.WriteLine("No puede arrendar vehiculo");
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
                    Console.WriteLine("No puede arrendar vehiculo");
                    return false;
                }
            }
        }
        int suma = 0;
        public bool arriendoAccesorio()
        {
            Console.WriteLine("Desea agregar accesorios? ");
            string i = Console.ReadLine();
            if (i == "si")
            {
                Console.WriteLine("Estos son nuestros accesorios: ");
                sucursal.VerAccesorios();
                return true;

            }
            else
            {
                Console.WriteLine("No agrego ningun accesorio");
                return false;
            }
        }
        
        public void VerInfo()
        {
            Console.WriteLine("Desea agregar accesorios? ");
            string i = Console.ReadLine();
            if (i == "si")
            {
                
                Console.WriteLine("cliente: " + cliente.nombre);
                Console.WriteLine("vehiculo: " + vehiculo.modelo + " " + vehiculo.marca);
                Console.WriteLine("accesorios: " + accesorios.nombre);
                Console.WriteLine("sucursal: " + sucursal.nombre);
                Console.WriteLine("fecha inicio: " + fechainicio);
                Console.WriteLine("fecha termino: " + fechatermino);
                Console.WriteLine("Total a pagar: " + (suma += vehiculo.precio +=accesorios.precio));
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
