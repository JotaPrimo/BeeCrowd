using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeCrowd.Entities
{
    public class TheGreatest
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }

        public TheGreatest(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;
        }

        public string presentGreatestNumber()
        {
            var greatest = A;

            if (B > greatest)
            {
                greatest = B;
            }

            if (C > greatest)
            {
                greatest = C;
            }

            return $"{greatest} eh o maior";
        }

    }
}
