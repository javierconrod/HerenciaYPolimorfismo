using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class AnimalTerrestre : Animal
    {
        public void Caminar()
        {
            Console.WriteLine("Soy un " + Nombre + " y estoy caminando con mis tennis del rayo Macuin");
        }
    }
}
