using BeeCrowd.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBecrowd
{
    public class SphereTest
    {
        [Fact]
        public void ItsShouldbeEquals()
        {
            // arrange
            string volume = "3";
            var expectedResult = "VOLUME = 113.097";

            // fact
            Sphere sphere = new Sphere(volume);
            var result = sphere.calcularVolume();

            // assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void ItsShouldbeEqualsV2()
        {
            // arrange
            string volume = "15";
            var expectedResult = "VOLUME = 14137.155";

            // fact
            Sphere sphere = new Sphere(volume);
            var result = sphere.calcularVolume();

            // assert
            Assert.Equal(expectedResult, result);
        }


        [Fact]
        public void ItsShouldbeEqualsV3()
        {
            // arrange
            string volume = "1523";
            var expectedResult = "VOLUME = 14797486501.627";

            // fact
            Sphere sphere = new Sphere(volume);
            var result = sphere.calcularVolume();

            // assert
            Assert.Equal(expectedResult, result);
        }

    }


}
