using FirstResponsiveWebAppBurgett;
using System;
using Xunit;

namespace FirstResponsiveTestBurgett
{
    public class UnitTest1
    {
        [Fact]
        public void TestAvg()
        {
            // This test checks for a normal input age.
            // Arange
            int birthYear = 1977;
            int expectedAge = 44;
            int actualAge;
            var instance = new FirstResponsiveWebAppBurgett.Models.FirstResponsiveModel();
            

            // Act
            actualAge = instance.AgeThisYear(birthYear);

            // Assert
            Assert.Equal(expectedAge, actualAge);
        }

        [Fact]
        public void TestLow()
        {
            // This test checks the low end of the age limit.
            // Arange
            int birthYear = 1900;
            int expectedAge = 121;
            int actualAge;
            var instance = new FirstResponsiveWebAppBurgett.Models.FirstResponsiveModel();


            // Act
            actualAge = instance.AgeThisYear(birthYear);

            // Assert
            Assert.Equal(expectedAge, actualAge);
        }
        [Fact]
        public void TestHigh()
        {
            // This test checks the high end of the age limit.
            // Arange
            int birthYear = 2020;
            int expectedAge = 1;
            int actualAge;
            var instance = new FirstResponsiveWebAppBurgett.Models.FirstResponsiveModel();


            // Act
            actualAge = instance.AgeThisYear(birthYear);

            // Assert
            Assert.Equal(expectedAge, actualAge);
        }
    }
}
