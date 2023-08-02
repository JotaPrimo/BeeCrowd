using BeeCrowd.Utils;


namespace BeeCrowd.Interface
{
    public abstract class FormGeometric
    {
        protected double A;
        protected double B;
        protected double C;

        protected FormGeometric(string a, string b, string c)
        {
            A = FormatarNumeros.formatarValoresEntrada(a);
            B = FormatarNumeros.formatarValoresEntrada(b);
            C = FormatarNumeros.formatarValoresEntrada(c);
        }

        public abstract string CalcularArea();
    }
}
