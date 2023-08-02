using BeeCrowd.Interface;
using BeeCrowd.Utils;

namespace BeeCrowd.Entities
{
    public class Quadrado : FormGeometric
    {
        public Quadrado(string a, string b, string c) : base(a, b, c)
        {
        }

        public override string CalcularArea()
        {
            var resultado = FormatarNumeros.formatarSaidaTresCasasDecimais(Math.Pow(B, 2));
            return $"QUADRADO: {resultado} ";
        }

    }
}
