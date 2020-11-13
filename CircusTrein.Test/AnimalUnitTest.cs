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
        public void Animal_IsHerbivore_true()
        {
            // Arrange
            Animal animal = new Animal(AnimalSize.Large, AnimalDiet.Herbivore);

            // Act
            bool output = animal.IsHerbivore();

            // Assert
            output.Should().BeTrue();
        }

        [TestMethod]
        public void Animal_IsHerbivore_false()
        {
            // Arrange
            Animal animal = new Animal(AnimalSize.Large, AnimalDiet.Carnivore);

            // Act
            bool output = animal.IsHerbivore();

            // Assert
            output.Should().BeFalse();
        }
    }
}
