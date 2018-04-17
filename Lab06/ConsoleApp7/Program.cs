using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                List<Sucursal> sucursales = new List<Sucursal>();
                List<Vehiculos> vehiculos = new List<Vehiculos>();
                List<Accesorios> accesorios = new List<Accesorios>();
                Console.WriteLine("Bienvenido usuario");
                Console.WriteLine("Es usted...?");
                Console.WriteLine("1. Administrador(a)");
                Console.WriteLine("2. Usuario(b)");
                Console.WriteLine("3. Salir(c)");
                string respuesta0 = Console.ReadLine();
                if (respuesta0 == "a")
                {
                    while (true)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("----Menu----");
                        Console.WriteLine("1. Agregar sucursal(a)");
                        Console.WriteLine("2. Seleccionar sucursal(b)");
                        Console.WriteLine("3. Salir (c)");
                        string respuesta = Console.ReadLine();
                        if (respuesta == "a")
                        {
                            Console.WriteLine("Ingrese nombre: ");
                            string Nombre = Console.ReadLine();
                            Console.WriteLine("Ingrese direccion: ");
                            string Direccion = Console.ReadLine();
                            Sucursal sucursal = new Sucursal(Nombre, Direccion);
                            sucursales.Add(sucursal);
                            Console.Beep();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Sucursal creada");
                        }
                        else if (respuesta == "b")
                        {
                            Console.WriteLine("Estas son las sucursales: ");
                            foreach (Sucursal sucursal in sucursales)
                            {
                                Console.WriteLine(sucursal.nombre + ", " + sucursal.direccion);
                            }
                            Console.WriteLine("Escriba el nombre de la sucursal que quiere elegir: ");
                            string eleccion = Console.ReadLine();
                            foreach (Sucursal sucursal in sucursales)
                            {
                                if (eleccion == sucursal.nombre)
                                {
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("Bienvenido a la sucursal " + eleccion);
                                    while (true)
                                    {
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("---Menu---");
                                        Console.WriteLine("1. Agregar Vehiculos(a)");
                                        Console.WriteLine("2. Agregar Accesorios(b)");
                                        Console.WriteLine("2. Ver Accesorios(c)");
                                        Console.WriteLine("3. Salir(d)");
                                        string respuesta1 = Console.ReadLine();
                                        if (respuesta1 == "a")
                                        {
                                            Console.WriteLine("Ingrese el tipo de vehiculo: ");
                                            string tipo = Console.ReadLine();
                                            if (tipo == "auto")
                                            {
                                                Console.WriteLine("Ingrese el modelo: ");
                                                string Modelo = Console.ReadLine();
                                                Console.WriteLine("Ingrese la marca: ");
                                                string Marca = Console.ReadLine();
                                                Console.WriteLine("Ingrese la tipo de permiso: ");
                                                string Permiso = Console.ReadLine();
                                                Console.WriteLine("Ingrese precio del arriendo: ");
                                                string Precio1 = Console.ReadLine();
                                                int Precio = Int32.Parse(Precio1);
                                                Auto autos = new Auto(Modelo, Marca, Permiso, Precio);
                                                sucursal.AgregarVehiculo(autos);
                                                Console.Beep();
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine("Auto creado");
                                            }
                                            else if (tipo == "acuatico")
                                            {
                                                Console.WriteLine("Ingrese el modelo: ");
                                                string Modelo = Console.ReadLine();
                                                Console.WriteLine("Ingrese la marca: ");
                                                string Marca = Console.ReadLine();
                                                Console.WriteLine("Ingrese la tipo de permiso: ");
                                                string Permiso = Console.ReadLine();
                                                Console.WriteLine("Ingrese precio del arriendo: ");
                                                string Precio1 = Console.ReadLine();
                                                int Precio = Int32.Parse(Precio1);
                                                Acuatico acuaticos = new Acuatico(Modelo, Marca, Permiso, Precio);
                                                sucursal.AgregarVehiculo(acuaticos);
                                                Console.Beep();
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine("Acuatico creado");
                                            }
                                            else if (tipo == "moto")
                                            {
                                                Console.WriteLine("Ingrese el modelo: ");
                                                string Modelo = Console.ReadLine();
                                                Console.WriteLine("Ingrese la marca: ");
                                                string Marca = Console.ReadLine();
                                                Console.WriteLine("Ingrese la tipo de permiso: ");
                                                string Permiso = Console.ReadLine();
                                                Console.WriteLine("Ingrese precio del arriendo: ");
                                                string Precio1 = Console.ReadLine();
                                                int Precio = Int32.Parse(Precio1);
                                                Moto motos = new Moto(Modelo, Marca, Permiso, Precio);
                                                sucursal.AgregarVehiculo(motos);
                                                Console.Beep();
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine("Moto creada");
                                            }
                                            else if (tipo == "camion")
                                            {
                                                Console.WriteLine("Ingrese el modelo: ");
                                                string Modelo = Console.ReadLine();
                                                Console.WriteLine("Ingrese la marca: ");
                                                string Marca = Console.ReadLine();
                                                Console.WriteLine("Ingrese la tipo de permiso: ");
                                                string Permiso = Console.ReadLine();
                                                Console.WriteLine("Ingrese precio del arriendo: ");
                                                string Precio1 = Console.ReadLine();
                                                int Precio = Int32.Parse(Precio1);
                                                Camion camiones = new Camion(Modelo, Marca, Permiso, Precio);
                                                sucursal.AgregarVehiculo(camiones);
                                                Console.Beep();
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine("Camion creado");
                                            }
                                            else if (tipo == "bus")
                                            {
                                                Console.WriteLine("Ingrese el modelo: ");
                                                string Modelo = Console.ReadLine();
                                                Console.WriteLine("Ingrese la marca: ");
                                                string Marca = Console.ReadLine();
                                                Console.WriteLine("Ingrese la tipo de permiso: ");
                                                string Permiso = Console.ReadLine();
                                                Console.WriteLine("Ingrese precio del arriendo: ");
                                                string Precio1 = Console.ReadLine();
                                                int Precio = Int32.Parse(Precio1);
                                                Bus buses = new Bus(Modelo, Marca, Permiso, Precio);
                                                sucursal.AgregarVehiculo(buses);
                                                Console.Beep();
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine("Bus creado");
                                            }
                                            else if (tipo == "maquina")
                                            {
                                                Console.WriteLine("Ingrese el modelo: ");
                                                string Modelo = Console.ReadLine();
                                                Console.WriteLine("Ingrese la marca: ");
                                                string Marca = Console.ReadLine();
                                                Console.WriteLine("Ingrese la tipo de permiso: ");
                                                string Permiso = Console.ReadLine();
                                                Console.WriteLine("Ingrese precio del arriendo: ");
                                                string Precio1 = Console.ReadLine();
                                                int Precio = Int32.Parse(Precio1);
                                                Maquina maquinas = new Maquina(Modelo, Marca, Permiso, Precio);
                                                sucursal.AgregarVehiculo(maquinas);
                                                Console.Beep();
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine("Maquina creada");
                                            }

                                        }
                                        else if (respuesta1 == "b")
                                        {
                                            Console.WriteLine("Ingrese el nombre: ");
                                            string Nombre = Console.ReadLine();
                                            Console.WriteLine("Ingrese el precio: ");
                                            string Precio1 = Console.ReadLine();
                                            int Precio = Int32.Parse(Precio1);
                                            Accesorios accesorio = new Accesorios(Nombre, Precio);
                                            sucursal.AgregarAccesorios(accesorio);
                                            Console.Beep();
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.WriteLine("Accesorio creado");
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
                else if (respuesta0 == "b")
                {
                    Console.WriteLine("Es usted una persona o una empresa?");
                    string respuesta = Console.ReadLine();
                    while (respuesta == "persona")
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Ingrese nombre: ");
                        string Nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese rut (sin punto y sin guion): ");
                        string Rut1 = Console.ReadLine();
                        int Rut = Int32.Parse(Rut1);
                        Console.WriteLine("Ingrese edad: ");
                        string Edad1 = Console.ReadLine();
                        int Edad = Int32.Parse(Edad1);
                        Console.WriteLine("Ingrese licencia: ");
                        string Licencia = Console.ReadLine();
                        Persona persona = new Persona(Nombre, Rut, Edad, Licencia);
                        Console.Beep();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Persona ingresada");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("----Menu----");
                        Console.WriteLine("1. Arrendar vehiculo(a)");
                        Console.WriteLine("2. Recibir vehiculo(b)");
                        Console.WriteLine("3. Salir (c)");
                        string respuesta1 = Console.ReadLine();
                        if (respuesta1 == "a")
                        {
                            Console.WriteLine("Que vehículo desea arrendar (modelo)?");
                            string vehiculo1 = Console.ReadLine();
                            foreach (Sucursal sucursal in sucursales)
                            {
                                foreach (Vehiculos vehiculo in vehiculos)
                                {
                                    if (vehiculo1 == vehiculo.modelo)
                                    {
                                        Console.WriteLine("Se ha encontrado el vehiculo " + vehiculo.modelo + " en la sucursal " + sucursal.nombre);
                                        Console.WriteLine("Agregue fecha de inicio");
                                        string Fechainicio = Console.ReadLine();
                                        Console.WriteLine("Agregue fecha de termino");
                                        string Fechatermino = Console.ReadLine();
                                        Arriendo arriendo = new Arriendo(Fechainicio, Fechatermino);
                                        if (arriendo.verificarArriendo() == true)
                                        {
                                            arriendo.VerInfo();
                                            Console.Beep();
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.WriteLine("Se ha concretado la compra");
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Black;
                                            Console.WriteLine("No puede arrendar vehiculo");
                                        }
                                        break;
                                    }
                                }
                            }
                        }
                        else if (respuesta1 == "c")
                        {
                            break;
                        }
                    }
                    while (respuesta == "empresa")
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Ingrese nombre: ");
                        string Nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese rut (sin punto y sin guion): ");
                        string Rut1 = Console.ReadLine();
                        int Rut = Int32.Parse(Rut1);
                        Console.WriteLine("Ingrese permiso: ");
                        string Permiso = Console.ReadLine();
                        Console.Beep();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Empresa ingresada");
                        Cliente cliente = new Cliente(Nombre, Rut, Permiso);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("----Menu----");
                        Console.WriteLine("1. Arrendar vehiculo(a)");
                        Console.WriteLine("2. Recibir vehiculo(b)");
                        Console.WriteLine("3. Salir (c)");
                        string respuesta1 = Console.ReadLine();
                        if (respuesta1 == "a")
                        {
                            Console.WriteLine("Que vehículo desea arrendar (modelo)?");
                            string vehiculo1 = Console.ReadLine();
                            foreach (Sucursal sucursal in sucursales)
                            {
                                foreach (Vehiculos vehiculo in vehiculos)
                                {
                                    if (vehiculo1 == vehiculo.modelo)
                                    {
                                        Console.WriteLine("Se ha encontrado el vehiculo " + vehiculo.modelo + " en la sucursal " + sucursal.nombre);
                                        Console.WriteLine("Agregue fecha de inicio");
                                        string Fechainicio = Console.ReadLine();
                                        Console.WriteLine("Agregue fecha de termino");
                                        string Fechatermino = Console.ReadLine();
                                        Arriendo arriendo = new Arriendo(Fechainicio, Fechatermino);
                                        if (arriendo.verificarArriendo() == true)
                                        {
                                            arriendo.VerInfo();
                                            Console.Beep();
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.WriteLine("Se ha concretado la compra");
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Black;
                                            Console.WriteLine("No puede arrendar vehiculo");
                                        }
                                        break;
                                    }
                                }
                            }
                        }
                        else if (respuesta1 == "c")
                        {
                            break;
                        }

                    }
                }
                else if (respuesta0 == "c")
                {
                    break;
                }

            }
        }
    }
}
