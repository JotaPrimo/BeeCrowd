using System.Globalization;

namespace BeeCrowd.Entities
{

    internal class AreaCircle
    {
        static double PI = 3.14159;
        private double _r;

        public AreaCircle(string r)
        {
            _r = formatarValoresEntrada(r);
        }


        public double getR()
        {
           return _r;
        }

        // deve formatar com duas casas decimais os valores de entrada
        public static double formatarValoresEntrada(string valorString)
        {
            double valorDouble;

            if (Double.TryParse(valorString, NumberStyles.Float, CultureInfo.GetCultureInfo("en-US"), out valorDouble))

            {
                return valorDouble;
            }

            throw new ArgumentNullException(nameof(valorString), "Ocorreu um erro ao tentar formatar");
        }

        // deve formatar o valores de saida com 4 casas decimais
   
            

        public string calcular()
        {           
             double resultado =  PI * (_r * _r);
            return formatarResultado(resultado);
        }

        // deve formatar o resultado com 4 casas decimais após a virugla
        public static string formatarResultado(double resultado)
        {
           // Console.WriteLine($"valor antes da formacao {resultado.ToString("0.0000")}");
            return resultado.ToString("0.0000");
        }


    }


}
