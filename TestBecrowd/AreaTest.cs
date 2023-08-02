using BeeCrowd.Entities;

namespace TestBecrowd
{
    public class AreaTest
    {
        [Fact]
        public void ItsShouldBeSame()
        {
            // arrange data
            string A = "3.0";
            string B = "4.0";
            string C = "5.2";
            var expectedResult = "TRIANGULO: 7.800 CIRCULO: 84.949 TRAPEZIO: 18.200 QUADRADO: 16.000 RETANGULO: 12.000";

            // act
            var resultGenerated = 
                (new TrianguloRetangulo(A, B, C)).CalcularArea() +
               (new Circle(A, B, C)).CalcularArea() +
               (new Trapezium(A, B, C)).CalcularArea() +
               (new Quadrado(A, B, C)).CalcularArea() +
               (new Retangulo(A, B, C)).CalcularArea() ;

            // Assert
            Assert.Equal(expectedResult, resultGenerated);
        }

        [Fact]
        public void ItsShouldBeSameVersionTwo()
        {
            // arrange data
            string A = "12.7";
            string B = "10.4";
            string C = "15.2";
            var expectedResult = "TRIANGULO: 96.520 CIRCULO: 725.833 TRAPEZIO: 175.560 QUADRADO: 108.160 RETANGULO: 132.080";

            // act
            var resultGenerated =
                (new TrianguloRetangulo(A, B, C)).CalcularArea() +
               (new Circle(A, B, C)).CalcularArea() +
               (new Trapezium(A, B, C)).CalcularArea() +
               (new Quadrado(A, B, C)).CalcularArea() +
               (new Retangulo(A, B, C)).CalcularArea();

            // Assert
            Assert.Equal(expectedResult, resultGenerated);
        }       

    }


}
