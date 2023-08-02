using Xunit;
using BeeCrowd.Entities;

namespace TestBecrowd
{
    public class GreatestTest
    {
        [Fact]
        public void ItsShouldbeEquals()
        {
            // arrange 7 14 106
            int A = 7;
            int B = 14;
            int C = 106;
            string resultExpected = "106 eh o maior";

            // act
            TheGreatest theGreatest = new TheGreatest(A, B, C);
            var resultGenerated = theGreatest.presentGreatestNumber();

            // Assert
            Assert.Equal(resultGenerated, resultExpected);
        }

        [Fact]
        public void ItsShouldbeEqualsVersionTwo()
        {
            // arrange 7 14 106
            int A = 217;
            int B = 14;
            int C = 6;
            string resultExpected = "217 eh o maior";

            // act
            TheGreatest theGreatest = new TheGreatest(A, B, C);
            var resultGenerated = theGreatest.presentGreatestNumber();

            // Assert
            Assert.Equal(resultGenerated, resultExpected);
        }

    }
}
