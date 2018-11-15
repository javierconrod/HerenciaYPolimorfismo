using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalAcuatico delfin = new AnimalAcuatico();
            AnimalTerrestre elefante = new AnimalTerrestre();
            Kanguro kanguro = new Kanguro();

            List<Animal> animales = new List<Animal>();

            Animal tiburon = new AnimalAcuatico();
            tiburon.Nombre = "Tiburon Bebé";

            delfin.Nombre = "Delfin";
            elefante.Nombre = "Elefante";

            ((AnimalAcuatico)tiburon).Nadar();




            delfin.Comer();

            delfin.Nadar();

            elefante.Caminar();

            kanguro.Caminar();
            kanguro.SaltarAlto();
            kanguro.Comer();

            animales.Add(delfin);
            animales.Add(tiburon);
            animales.Add(elefante);
            animales.Add(kanguro);

            foreach(var animal in animales)
            {
                Console.WriteLine(animal.Nombre);
                if (animal.GetType() == typeof(AnimalAcuatico))
                {
                    ((AnimalAcuatico)animal).Nadar();
                }
                if(animal.GetType() == typeof(AnimalTerrestre))
                {
                    ((AnimalTerrestre)animal).Caminar();
                }
            }


            Console.ReadLine();
        }
    }
}
