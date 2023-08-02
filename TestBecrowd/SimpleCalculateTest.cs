using BeeCrowd.Entities;
using BeeCrowd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBecrowd
{
    public class SimpleCalculateTest
    {
        [Fact]
        public void ItsShouldBeSame()
        {
            // arange
            var expectedResult = "VALOR A PAGAR: R$ 15.50";

            ProdutoSimpleCalculate produto = new ProdutoSimpleCalculate(12, 1, "5.30");
            ProdutoSimpleCalculate produtoDois = new ProdutoSimpleCalculate(16, 2, "5.10");

            //act
            SimpleCalculate simpleCalculate = new SimpleCalculate(produto, produtoDois);            
            var resultGenerated = simpleCalculate.calcularPrecoFinal();

            //assert
            Assert.Equal(resultGenerated, expectedResult);
        }

        [Fact]
        public void ItsShouldBeSameVersioTwo()
        {
            // arange
            var expectedResult = "VALOR A PAGAR: R$ 51.40";

            ProdutoSimpleCalculate produto = new ProdutoSimpleCalculate(13, 2, "15.30");
            ProdutoSimpleCalculate produtoDois = new ProdutoSimpleCalculate(161, 4, "5.20");

            //act
            SimpleCalculate simpleCalculate = new SimpleCalculate(produto, produtoDois);
            var resultGenerated = simpleCalculate.calcularPrecoFinal();

            //assert
            Assert.Equal(resultGenerated, expectedResult);
        }

        [Fact]
        public void ItsShouldBeSameVersioTree()
        {
            // arange
            var expectedResult = "VALOR A PAGAR: R$ 30.20";

            ProdutoSimpleCalculate produto = new ProdutoSimpleCalculate(1, 1, "15.10");
            ProdutoSimpleCalculate produtoDois = new ProdutoSimpleCalculate(2, 1, "15.10");

            //act
            SimpleCalculate simpleCalculate = new SimpleCalculate(produto, produtoDois);
            var resultGenerated = simpleCalculate.calcularPrecoFinal();

            //assert
            Assert.Equal(resultGenerated, expectedResult);
        }

    }

}
