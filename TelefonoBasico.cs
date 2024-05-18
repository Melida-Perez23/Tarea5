using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class TelefonoBasico : Telefono
    {
        public bool TieneRadioFM {  get; set; }
        public bool Tienelinterna { get; set; }


        public void MostrarInformacionBasico()
        {
            MostrarInformacion();
            Console.WriteLine($"Tiene radioFM: {TieneRadioFM}, Tiene linterma: {Tienelinterna}");
        }
    }
}
