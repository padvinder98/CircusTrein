using CircusTrein.ApplicationCore.Enum;
using CircusTrein.ApplicationCore.Models;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CircusTrein.Test
{
    [TestClass]
    public class AnimalUnitTest
    {
        [TestMethod]
        public void Animal_IsAnimalLargeCarnivore_true()
        {
            // Arrange
            Animal animal = new Animal(AnimalSize.Large, AnimalDiet.Carnivore);

            // Act
            bool output = animal.IsAnimalLargeCarnivore();

            // Assert
            output.Should().BeTrue();
        }

        [TestMethod]
        public void Animal_IsAnimalLargeCarnivore_false()
        {
            // Arrange
            Animal animal = new Animal(AnimalSize.Large, AnimalDiet.Herbivore);

            // Act
            bool output = animal.IsAnimalLargeCarnivore();

            // Assert
            output.Should().BeFalse();
        }
    }
}
