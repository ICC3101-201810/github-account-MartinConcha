using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Sucursal
    {
        public string nombre;
        public string direccion;
        List<Vehiculos> vehiculos = new List<Vehiculos>();
        List<Accesorios> accesorios = new List<Accesorios>();

        public Sucursal(string Nombre, string Direccion)
        {
            nombre = Nombre;
            direccion = Direccion;
        }

        public bool AgregarVehiculo(Vehiculos vehiculo)
        {
            vehiculos.Add(vehiculo);
            return true;
        }
        public bool AgregarAccesorios(Accesorios accesorio)
        {
            accesorios.Add(accesorio);
            return true;
        }
        public void VerAccesorios()
        {
            foreach (Accesorios accesorio in accesorios)
            {
                Console.WriteLine(accesorio.InfoAccesorio());
            }
        }
    }
}
