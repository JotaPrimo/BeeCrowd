
namespace BeeCrowd.Entities
{
    internal class Difference
    {
        public int A { get; private set; }
        public int B { get; private set; }  
        public int C { get; private set; }
        public int D { get; private set; }

        public Difference(int a, int b, int c, int d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }

        // deve retornar  (A * B - C * D)
        public string calculateDiference()
        {
            int resultado = getProdutoAB() - getProdutoCD();
            return $"DIFERENCA = {resultado}";
        }

        // deve retornar o produto a por b
        public int getProdutoAB()
        {
            return A * B;
        }

        // deve retornar o produto c por d
        public int getProdutoCD()
        {
            return C * D;
        }


    }
}
