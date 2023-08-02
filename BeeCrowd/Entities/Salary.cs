

using System.Globalization;

namespace BeeCrowd.Entities
{
    internal class Salary
    {
        public int number { get; private set; }
        public int horasTrabalhadas { get; private set; }
        public double valorHora { get; private set; }

        public Salary(int number, int horasTrabalhadas, string valorHora)
        {
            this.number = number;
            this.horasTrabalhadas = horasTrabalhadas;
            this.valorHora = formatarValoresEntrada(valorHora);
        }

        // convertendo para double
        public static double formatarValoresEntrada(string valorString)
        {
            double valorDouble;

            if (Double.TryParse(valorString, NumberStyles.Float, CultureInfo.GetCultureInfo("en-US"), out valorDouble))

            {
                return valorDouble;
            }

            throw new ArgumentNullException(nameof(valorString), "Ocorreu um erro ao tentar formatar");
        }

        public string calculateSalary()
        {
            return formatarSaida(horasTrabalhadas * valorHora);
        }
        
        // deve formatar a saida com uma casa decimal
        public string formatarSaida(double valor)
        {
            return valor.ToString("0.00", CultureInfo.InvariantCulture);
        }

    }
}
