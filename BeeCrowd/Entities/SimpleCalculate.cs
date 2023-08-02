using BeeCrowd.Models;
using System.Globalization;

namespace BeeCrowd.Entities
{
    public class SimpleCalculate
    {
        public ProdutoSimpleCalculate Produto_Um { get; private set; }
        public ProdutoSimpleCalculate Produto_Dois { get; private set; }

        public SimpleCalculate(ProdutoSimpleCalculate produto_Um, ProdutoSimpleCalculate produto_Dois)
        {
            Produto_Um = produto_Um;
            Produto_Dois = produto_Dois;
        }
   

        public string calcularPrecoFinal()
        {          

            // para calcular o preço final
            // preço vs unidades
            double result = Produto_Um.precoTotal() + Produto_Dois.precoTotal();
            return $"VALOR A PAGAR: R$ {formatarSaida(result)}";
        }

        public string formatarSaida(double valor)
        {
            return valor.ToString("0.00", CultureInfo.InvariantCulture);
        }

    }

}
