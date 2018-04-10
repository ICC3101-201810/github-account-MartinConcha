using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Vehiculos
    {
        public string modelo;
        public string marca;
        public string permiso;
        public int precio;

        public Vehiculos(string Nombre, string Marca, string Permiso, int Precio)
        {
            modelo = Nombre;
            marca = Marca;
            permiso = Permiso;
            precio = Precio;
        }
        
    }
    public class Auto:Vehiculos
    {
        public Auto(string Nombre, string Marca, string Permiso, int Precio)
        {
            modelo = Nombre;
            marca = Marca;
            permiso = Permiso;
            precio = Precio;
        }
    }
    public class Acuatico:Vehiculos
    {
        public Acuatico(string Nombre, string Marca, string Permiso, int Precio)
        {
            modelo = Nombre;
            marca = Marca;
            permiso = Permiso;
            precio = Precio;
        }
    }
    public class Moto:Vehiculos
    {
        public Moto(string Nombre, string Marca, string Permiso, int Precio)
        {
            modelo = Nombre;
            marca = Marca;
            permiso = Permiso;
            precio = Precio;
        }
    }
    public class Camion:Vehiculos
    {
        public Camion(string Nombre, string Marca, string Permiso, int Precio)
        {
            modelo = Nombre;
            marca = Marca;
            permiso = Permiso;
            precio = Precio;
        }
    }
    public class Bus:Vehiculos
    {
        public Bus(string Nombre, string Marca, string Permiso, int Precio)
        {
            modelo = Nombre;
            marca = Marca;
            permiso = Permiso;
            precio = Precio;
        }
    }
    public class Maquina:Vehiculos
    {
        public Maquina(string Nombre, string Marca, string Permiso, int Precio)
        {
            modelo = Nombre;
            marca = Marca;
            permiso = Permiso;
            precio = Precio;
        }
    }
}
