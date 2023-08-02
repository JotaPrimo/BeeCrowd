using System.Globalization;


namespace BeeCrowd.Entities
{
    internal class SalaryWithBonus
    {
        const double PORCENTAGEM_VENDAS = 0.15;

        public string Nome { get; set; }
        public double Salario { get; set; }
        public double TotalVendas { get; set; }

        public SalaryWithBonus(string nome, string salario, string totalVendas)
        {
            Nome = nome;
            Salario = formatarValoresEntrada(salario);
            TotalVendas = formatarValoresEntrada(totalVendas);
        }

        // deve retornar o valor da comissão
        public double calcularValorPorcentagemVendas()
        {
            return TotalVendas * PORCENTAGEM_VENDAS;
        }

        public string calcularSalarioTotal()
        {
           double salarioTotal = Salario + calcularValorPorcentagemVendas();
            return $"TOTAL = R$ {formatarSaida(salarioTotal)}";
        }

        public static double formatarValoresEntrada(string valorString)
        {
            double valorDouble;

            if (Double.TryParse(valorString, NumberStyles.Float, CultureInfo.GetCultureInfo("en-US"), out valorDouble))

            {
                return valorDouble;
            }

            throw new ArgumentNullException(nameof(valorString), "Ocorreu um erro ao tentar formatar");
        }

        public string formatarSaida(double salarioTotal)
        {
            return salarioTotal.ToString("0.00", CultureInfo.InvariantCulture);
        }
    }
}
