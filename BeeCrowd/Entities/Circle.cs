using BeeCrowd.Interface;
using BeeCrowd.Utils;

namespace BeeCrowd.Entities
{
    public class Circle : FormGeometric
    {
        const double PI = 3.14159;
        public Circle(string a, string b, string c) : base(a, b, c)
        {
        }

        public override string CalcularArea()
        {
            var areaCircle = PI * Math.Pow(C, 2);
            return $"CIRCULO: {FormatarNumeros.formatarSaidaTresCasasDecimais(areaCircle)} ";
        }

    }
}
