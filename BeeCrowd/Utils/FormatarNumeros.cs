using System.Globalization;


namespace BeeCrowd.Utils
{
    public class FormatarNumeros
    {
        public static double formatarValoresEntrada(string valorString)
        {
            double valorDouble;

            if (Double.TryParse(valorString, NumberStyles.Float, CultureInfo.GetCultureInfo("en-US"), out valorDouble))

            {
                return valorDouble;
            }

            throw new ArgumentNullException(nameof(valorString), "Ocorreu um erro ao tentar formatar");
        }

        public static string formatarSaidaUmaCasaDecimal(double valor)
        {
            return valor.ToString("0.0", CultureInfo.InvariantCulture);
        }

        public static string formatarSaidaDuasCasasDecimais(double valor)
        {
            return valor.ToString("0.00", CultureInfo.InvariantCulture);
        }

        public static string formatarSaidaTresCasasDecimais(double valor)
        {
            return valor.ToString("0.000", CultureInfo.InvariantCulture);
        }

        public static string formatarSaidaQuatroCasasDecimais(double valor)
        {
            return valor.ToString("0.0000", CultureInfo.InvariantCulture);
        }

        public static string formatarSaidaCincoCasasDecimais(double valor)
        {
            return valor.ToString("0.00000", CultureInfo.InvariantCulture);
        }

    }
}
