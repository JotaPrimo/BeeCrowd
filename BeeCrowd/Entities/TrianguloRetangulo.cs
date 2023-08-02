using BeeCrowd.Interface;
using BeeCrowd.Utils;

namespace BeeCrowd.Entities
{
    public class TrianguloRetangulo : FormGeometric
    {
        public TrianguloRetangulo(string a, string b, string c) : base(a, b, c)
        {
        }

        public override string CalcularArea()
        {
            var areaOfTrianguloRetangulo = (A * C) / 2;
            return $"TRIANGULO: {FormatarNumeros.formatarSaidaTresCasasDecimais(areaOfTrianguloRetangulo)} ";
        }
    }
}
