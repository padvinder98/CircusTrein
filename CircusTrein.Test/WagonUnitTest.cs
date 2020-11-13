using CircusTrein.ApplicationCore.Enum;
using CircusTrein.ApplicationCore.Models;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CircusTrein.Test
{
    [TestClass]
    public class WagonUnitTest
    {
        [TestMethod]
        public void Wagon_AddAnimalToWagon()
        {
            // Arrange
            Wagon wagon = new Wagon();
            Animal animal = new Animal(AnimalSize.Large, AnimalDiet.Carnivore);

            // Act
            wagon.AddAnimalToWagon(animal);

            // Assert
            wagon.Animals.Should().Contain(animal);
        }

        [TestMethod]
        public void Wagon_CanAnimalBePlacedInWagon_true()
        {
            // Arrange
            Wagon wagon = new Wagon();

            Animal animalInWagon = new Animal(AnimalSize.Large, AnimalDiet.Herbivore);
            Animal animalToAdd = new Animal(AnimalSize.Small, AnimalDiet.Herbivore);

            wagon.AddAnimalToWagon(animalInWagon);

            // Act
            bool output = wagon.CanAnimalBePlacedInWagon(animalToAdd);

            // Assert
            output.Should().BeTrue();
        }

        [TestMethod]
        public void Wagon_CanAnimalBePlacedInWagon_false()
        {
            // Arrange
            Wagon wagon = new Wagon();

            Animal animalInWagon = new Animal(AnimalSize.Large, AnimalDiet.Carnivore);
            Animal animalToAdd = new Animal(AnimalSize.Small, AnimalDiet.Herbivore);

            wagon.AddAnimalToWagon(animalInWagon);

            // Act
            bool output = wagon.CanAnimalBePlacedInWagon(animalToAdd);

            // Assert
            output.Should().BeFalse();
        }
    }
}
