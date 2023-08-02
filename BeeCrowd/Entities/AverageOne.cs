
using System.Globalization;

namespace BeeCrowd.Entities
{
    public class AverageOne
    {
        const double PESO_A = 3.5;
        const double PESO_B = 7.5;
        const double PESO_TOTAL = 11;


        public double A { get; private set; }
        public double B { get; private set; }

        public AverageOne()
        {
        }

        public AverageOne(string a, string b)
        {
            A = formatarValoresEntrada(a);
            B = formatarValoresEntrada(b);
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

        public string calculateAverageSimple()
        {
            double result = (calcularNotaA() + calcularNotaB()) / 11;           
            return formatarResultado(result);
        }

        // deve retornar o valor da nota a vezes seu peso
        public double calcularNotaA() 
        {
            return A * PESO_A;
        }

        // deve retornar o valor da nota B vezes seu peso
        public double calcularNotaB()
        {
            return B * PESO_B;
        }


        // deve formatar a saida com 5 casas decimais
        public static string formatarResultado(double resultado)
        {            
            return resultado.ToString("0.00000", CultureInfo.InvariantCulture);
        }

    }
}
