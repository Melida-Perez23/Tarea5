using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class TelefonoInteligente : Telefono
    {
        public string SistemaOperativo { get; set; }
        public int MemoriaRAM { get; set; }

        public void MostrarInformacionInteligente()
        {
            {
                MostrarInformacion();
                Console.WriteLine($"SistemaOperativo: {SistemaOperativo}, Memoria RAM: {MemoriaRAM}");
            }
        }
    }
}