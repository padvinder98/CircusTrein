using CircusTrein.ApplicationCore.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;

namespace CircusTrein.ApplicationCore.Models
{
    public class Wagon
    {
        public List<Animal> Animals { get; set; }

        private int maxCapacity = 10;

        public Wagon()
        {
            Animals = new List<Animal>();
        }

        public void AddAnimalToWagon(Animal animal)
        {
            Animals.Add(animal);
        }

        public bool CanAnimalBePlacedInWagon(Animal animal) 
        {
            bool doesFit = DoesAnimalFitInWagon((int)animal.AnimalSize);
            bool doesSurvive = DoesNewAnimalGetEaten(animal);
            bool doesEatOtherAnimal = DoesNewAnimalEatOtherAnimalsInWagon(animal);

            if (doesFit == true && doesSurvive == true && doesEatOtherAnimal == false)
            {
                return true;
            }

            return false;
        }

        private bool DoesNewAnimalEatOtherAnimalsInWagon(Animal animal)
        {
            if (animal.IsHerbivore()) return false;

            bool doesEatOtherAnimals = Animals.Any(a => a.AnimalSize >= animal.AnimalSize);

            if (doesEatOtherAnimals == true) return true;

            return false;
        }

        private bool DoesNewAnimalGetEaten(Animal animal)
        {
            bool dangerousAnimal = Animals.Any(a => a.AnimalDiet == AnimalDiet.Carnivore && a.AnimalSize >= animal.AnimalSize);

            if (dangerousAnimal == true)
            {
                return false;
            }

            return true;
        }

        private bool DoesAnimalFitInWagon(int size)
        {
            int currentCapacity = GetCurrentWagonCapacity();

            if (currentCapacity + size > maxCapacity)
            {
                return false;
            }

            return true;
        }

        private int GetCurrentWagonCapacity()
        {
            int count = 0;

            foreach (var animal in Animals)
            {
                count += (int)animal.AnimalSize;
            }

            return count;
        }
    }
}
