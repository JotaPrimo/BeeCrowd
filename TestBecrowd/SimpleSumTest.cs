using BeeCrowd.Entities;
using Xunit;

namespace TestBecrowd
{
    
    public class SimpleSumTest
    {
        [Fact]
        public void TestOne()
        {
            
            // arrange
            string A = "5.0";
            string B = "7.1";
             var calcultator = new AverageOne(A, B);


            //act
            var result = calcultator.calculateAverageSimple();

            //assert
            Assert.Equal("6.43182", result);
        }

        [Fact]
        public void TesteTwo()
        {
            // arrange
            string A = "0.0";
            string B = "7.1";
            string expectedResult = "4.84091";
            var calcultator = new AverageOne(A, B);


            //act
            var result = calcultator.calculateAverageSimple();

            //assert
            Assert.Equal(expectedResult, result);
        }


        [Fact]
        public void TesteTree()
        {
            // arrange
            string A = "10.0";
            string B = "10.0";
            string expectedResult = "10.00000";
            var calcultator = new AverageOne(A, B);


            //act
            var result = calcultator.calculateAverageSimple();

            //assert
            Assert.Equal(expectedResult, result);
        }


    }
}
