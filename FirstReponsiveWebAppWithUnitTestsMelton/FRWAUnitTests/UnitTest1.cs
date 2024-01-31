using FirstResponsiveWebAppMelton.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Xunit.Sdk;

namespace FRWAUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void CurrentYear()
        {
            // Arrange
            int birthYear = DateTime.Now.Year;

            int expected = 0;
            int actual;
            // Act
            actual = FirstReponsiveWebAppModel.AgeThisYear(birthYear);
            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void PastYear()
        {
            // Arrange
            int birthYear = 1990;
            int currentYear = DateTime.Now.Year;
            int expected = currentYear - birthYear;

            // Act
            int actual = FirstReponsiveWebAppModel.AgeThisYear(birthYear);

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void FutureYear()
        {
            // Arrange
            int birthYear = DateTime.Now.Year + 1;

            int expected = -1;
            int actual;
            // Act
            actual = FirstReponsiveWebAppModel.AgeThisYear(birthYear);
            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void InvalidYear()
        {
            // Arrange
            int birthYear = -1;

            int expected = -1;
            int actual;
            // Act
            actual = FirstReponsiveWebAppModel.AgeThisYear(birthYear);
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}