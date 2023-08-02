using BeeCrowd.Interface;
using BeeCrowd.Utils;


namespace BeeCrowd.Entities
{
    public class Retangulo : FormGeometric
    {
        public Retangulo(string a, string b, string c) : base(a, b, c)
        {
        }

        public override string CalcularArea()
        {
            var areaOfRetangule = A * B;
            return $"RETANGULO: {FormatarNumeros.formatarSaidaTresCasasDecimais(areaOfRetangule)}";
        }
    }


}
