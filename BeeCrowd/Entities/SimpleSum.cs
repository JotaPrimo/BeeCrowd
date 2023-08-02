
namespace BeeCrowd.Entities
{
    internal class SimpleSum
    {
        public int A { get; private set; }
        public int B { get; private set; }

        public SimpleSum(int a, int b)
        {
            A = a;
            B = b;
        }

        public string calcular()
        {
            int soma = A + B;
            return $"SOMA = {soma}";
        }
    }
}
