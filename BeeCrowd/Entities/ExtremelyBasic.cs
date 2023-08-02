
namespace BeeCrowd.Entities
{
    internal class ExtremelyBasic
    {
        public int A { get; private set; }
        public int B { get; private set; }

        public ExtremelyBasic(int a, int b)
        {
            A = a;
            B = b;
        }

        public int calcular()
        {
            return  A + B;
        }

    }
}
