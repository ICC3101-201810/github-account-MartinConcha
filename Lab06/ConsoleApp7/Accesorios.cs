using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Accesorios
    {
        public string nombre;
        public int precio;

        public Accesorios(string Nombre, int Precio)
        {
            nombre = Nombre;
            precio = Precio;
        }

        public String InfoAccesorio()
        {
            return (nombre + " $" + precio);
        }
    }
}
