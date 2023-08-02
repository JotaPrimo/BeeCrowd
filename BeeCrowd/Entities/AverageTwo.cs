using System.Collections.Generic;
using System.Globalization;


namespace BeeCrowd.Entities
{
    internal class AverageTwo
    {
        const int PESO_A = 2;
        const int PESO_B = 3;
        const int PESO_C = 5;
        const int PESO_TOTAL = 10;

        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }

        public AverageTwo(string a, string b, string c)
        {
            A = formatarValoresEntrada(a);
            B = formatarValoresEntrada(b);
            C = formatarValoresEntrada(c);
        }

        // deve converter o valor string para decimal
        public static double formatarValoresEntrada(string valorString)
        {
            double valorDouble;

            if (Double.TryParse(valorString, NumberStyles.Float, CultureInfo.GetCultureInfo("en-US"), out valorDouble))

            {
                return valorDouble;
            }

            throw new ArgumentNullException(nameof(valorString), "Ocorreu um erro ao tentar formatar");
        }

        public string calculateAverage()
        {  
            double notaA = A * PESO_A;
            double notaB = B * PESO_B;
            double notaC = C * PESO_C;
            double resultado = (notaA + notaB + notaC) / PESO_TOTAL;
            return $"MEDIA = {formatarSaida(resultado)}";
        }

       

        // deve formatar a saida com uma casa decimal
        public string formatarSaida(double valor)
        {
            return valor.ToString("0.0");
        }       


    }
}
