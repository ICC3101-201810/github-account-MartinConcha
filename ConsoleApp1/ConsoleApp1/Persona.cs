using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Persona
    {
        public string nombre;
        public int rut;
        public int edad;
        public string licencia;

        public Persona(string Nombre, int Rut, int Edad, string Licencia)
        {
            nombre = Nombre;
            rut = Rut;
            edad = Edad;
            licencia = Licencia;
        }
    }
}
