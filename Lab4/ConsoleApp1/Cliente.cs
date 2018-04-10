using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Cliente
    {
        public string nombre;
        public int rut;
        public string autorizacion;
        public Cliente(string Nombre,int Rut, string Autorizacion)
        {
            nombre = Nombre;
            rut = Rut;
            autorizacion = Autorizacion;
        }

    }
}
