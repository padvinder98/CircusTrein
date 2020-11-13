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

        public void PlaceAllAnimals(List<Animal> animals)
        {
            foreach (var animal in animals)
            {
                PlaceAnimalInWagon(animal);
            }
        }

        public void PlaceAnimalInWagon(Animal animal)
        {
            foreach (var wagon in Wagons)
            {
                if (wagon.CanAnimalBePlacedInWagon(animal))
                {
                    wagon.AddAnimalToWagon(animal);
                }
            }
        }
    }
}
