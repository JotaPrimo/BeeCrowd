using System.Globalization;


namespace BeeCrowd.Models
{
    public class ProdutoSimpleCalculate
    {
        public int Code { get; private set; }
        public int NumberOfUnits { get; private set; }
        public double PriceOfUnit { get; private set; }

        public ProdutoSimpleCalculate(int code, int numberOfUnits, string priceOfUnit)
        {
            Code = code;
            NumberOfUnits = numberOfUnits;
            PriceOfUnit = formatarValoresEntrada(priceOfUnit);
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
              

        public double precoTotal()
        {
            return NumberOfUnits * PriceOfUnit;
        }

    }
}
