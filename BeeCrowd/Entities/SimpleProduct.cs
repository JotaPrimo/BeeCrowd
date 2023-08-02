namespace BeeCrowd.Entities
{
    internal class SimpleProduct
    {       

        public int A { get; private set; }
        public int B { get; private set; }

        public SimpleProduct(int a, int b)
        {
            A = a;
            B = b;
        }

        public string calculate() 
        {
            int prod = A * B;

            return $"PROD = {prod}";
        }

    }
}
