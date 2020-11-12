using System;
using System.Collections.Generic;
using System.Linq;
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

        public bool DoesAnimalFit(int size)
        {
            if (CapacityWagon() + size > 10)
            {
                return false;
            }

            return true;
        }

        private int CapacityWagon()
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
