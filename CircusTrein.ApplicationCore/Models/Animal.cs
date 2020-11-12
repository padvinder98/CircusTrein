using CircusTrein.ApplicationCore.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace CircusTrein.ApplicationCore.Models
{
    public class Animal
    {
        public AnimalSize AnimalSize { get; }
        public AnimalDiet AnimalDiet { get; }

        public Animal(AnimalSize animalSize, AnimalDiet animalDiet)
        {
            AnimalSize = animalSize;
            AnimalDiet = animalDiet;
        }

        public bool IsAnimalLargeCarnivore()
        {
            if (AnimalSize == AnimalSize.Large && AnimalDiet == AnimalDiet.Carnivore)
            {
                return true;
            }

            return false;
        }
    }
}
