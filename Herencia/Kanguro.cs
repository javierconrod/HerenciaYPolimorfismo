using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Kanguro : AnimalTerrestre
    {

        public Kanguro()
        {
            Nombre = "Kanguro";
        }

        public void SaltarAlto()
        {
            Console.WriteLine("Hey estoy saltando bien altooooo aaaaaaaaa, soy " + Nombre);
        }
    }
}
