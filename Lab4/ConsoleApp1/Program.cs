using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Sucursal> sucursales = new List<Sucursal>();
            Console.WriteLine("Bienvenido usuario");
            while (true)
            {
                Console.WriteLine("----Menu----");
                Console.WriteLine("1. Agregar sucursal(a)");
                Console.WriteLine("2. Seleccionar sucursal(b)");
                Console.WriteLine("3. Salir (c)");
                string respuesta = Console.ReadLine();
                if (respuesta == 'a')
                {
                    Console.WriteLine("Ingrese nombre: ");
                    string Nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese direccion: ");
                    string Direccion = Console.ReadLine();
                    Sucursal sucursal = new Sucursal(Nombre, Direccion);
                    sucursales.Add(sucursal);
                    Console.WriteLine("Sucursal creada");
                }
                else if (respuesta =='b')
                {
                    Console.WriteLine("Estas son las sucursales: ");
                    foreach (Sucursal sucursal in sucurales)
                    {
                        Console.WriteLine(sucursal.nombre+" "+sucursal.direccion);
                    }
                    Console.WriteLine("Escriba el nombre de la sucursal que quiere elegir: ");
                    string eleccion = Console.ReadLine();
                    foreach (Sucursal sucursal in sucurales)
                    {
                        if (eleccion==sucursal.nombre)
                        {
                            Console.WriteLine("Bienvenido a la sucursal "+eleccion);
                            while (true)
                            {
                                Console.WriteLine("---Menu---");
                                Console.WriteLine("1. Agregar Vehiculos(a)");
                                Console.WriteLine("2. Agregar Accesorios(b)");
                                Console.WriteLine("2. Ver Accesorios(c)");
                                Console.WriteLine("3. Salir(d)");
                                string respuesta1 = Console.ReadLine();
                                if (respuesta1 == "a")
                                {
                                    Console.WriteLine("Ingrese el tipo de vehiculo: ");
                                    Console.WriteLine("Ingrese el modelo: ");
                                    string Modelo = Console.ReadLine();
                                    Console.WriteLine("Ingrese la marca: ");
                                    string Marca = Console.ReadLine();
                                    Console.WriteLine("Ingrese la tipo de permiso: ");
                                    string Permiso = Console.ReadLine();
                                    Console.WriteLine("Ingrese precio del arriendo: ");
                                    string Precio = Console.ReadLine();
                                    Vehiculos vehiculos = new Vehiculos(Modelo, Marca, Permiso, Precio);
                                    sucursal.AgregarVehiculo();
                                }
                                else if (respuesta1 == "b")
                                {
                                    Console.WriteLine("Ingrese el nombre: ");
                                    string Nombre = Console.ReadLine();
                                    Console.WriteLine("Ingrese el precio: ");
                                    string Precio = Console.ReadLine();
                                    Accesorios accesorios = new Accesorios(Nombre, Precio);
                                    sucursal.AgregarAccesorios;
                                }
                                else if (respuesta1 == "c")
                                {
                                    sucursal.VerAccesorios();
                                }
                                else if (respuesta1 == "d")
                                {
                                    break;
                                }
                            }
                            break;
                        }
                        
                    }

                }
                else if (respuesta == "c")
                {
                    break;
                }
            }
        }
    }
}
