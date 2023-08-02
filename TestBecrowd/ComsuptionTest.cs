using BeeCrowd.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBecrowd
{
    public class ComsuptionTest
    {
        [Fact]
        public void ItsShouldBeSame()
        {
            // arrange
            var TotalDistance = 500;
            var SpentFuel = "35.0";
            var expectedResult = "14.286";

            // act
            Consumption consumption = new Consumption(TotalDistance, SpentFuel);
            var resultGenerated = consumption.calculeConsumption();

            // assert
            Assert.Same(resultGenerated, expectedResult);
        }

        [Fact]
        public void ItsShouldBeIdentic()
        {
            // arrange
            var TotalDistance = 2254;
            var SpentFuel = "124.4";
            var expectedResult = "18.119";

            // act
            Consumption consumption = new Consumption(TotalDistance, SpentFuel);
            var resultGenerated = consumption.calculeConsumption();

            // assert
            Assert.Same(resultGenerated, expectedResult);
        }

        [Fact]
        public void ItsShouldBeEqual()
        {
            // arrange
            var TotalDistance = 4554;
            var SpentFuel = "464.6";
            var expectedResult = "9.802";

            // act
            Consumption consumption = new Consumption(TotalDistance, SpentFuel);
            var resultGenerated = consumption.calculeConsumption();

            // assert
            Assert.Same(resultGenerated, expectedResult);
        }

    }
}
