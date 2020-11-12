using System;
using System.Collections.Generic;
using System.Text;

namespace CircusTrein.ApplicationCore.Models
{
    public class Train
    {
        public List<Wagon> Wagons { get; private set; }

        public Train()
        {
            Wagons = new List<Wagon>();
        }

        public Wagon CreateNewWagon()
        {
            var newWagon = new Wagon();

            Wagons.Add(newWagon);

            return newWagon;
        }

        public void PlaceAllAnimals(List<Animal> animals)
        {
            foreach (var animal in animals)
            {
                if (animal.IsAnimalLargeCarnivore())
                {
                    var wagon = CreateNewWagon();

                    wagon.AddAnimalToWagon(animal);

                    break;
                }
            }
        }
    }
}
