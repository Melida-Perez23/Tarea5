using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Telefono
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Marca: {Marca}, modelo:{Modelo}, precio: {Precio}, stock: {Stock}");
        }
    }
}
