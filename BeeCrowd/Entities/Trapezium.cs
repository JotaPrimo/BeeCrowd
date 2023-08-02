using BeeCrowd.Interface;
using BeeCrowd.Utils;


namespace BeeCrowd.Entities
{
    public class Trapezium : FormGeometric
    {
        public Trapezium(string a, string b, string c) : base(a, b, c)
        {
        }

        public override string CalcularArea()
        {
            var areaOfTrapezuim = (A + B) * C / 2;
            return $"TRAPEZIO: {FormatarNumeros.formatarSaidaTresCasasDecimais(areaOfTrapezuim)} ";
        }
    }

}
