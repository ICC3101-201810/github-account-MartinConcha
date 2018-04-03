using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Vehiculos
    {
        public string tipo;
        public string modelo;
        public string marca;
        public string permiso;
        public int precio;

        public Vehiculos(string Tipo, string Nombre, string Marca, string Permiso, int Precio)
        {
            tipo = Tipo;
            modelo = Nombre;
            marca = Marca;
            permiso = Permiso;
            precio = Precio;
        }
        
    }
}
