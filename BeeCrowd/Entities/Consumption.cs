using BeeCrowd.Utils;


namespace BeeCrowd.Entities
{
    public class Consumption
    {
        public int TotalDistance { get; set; }
        public double SpentFuel { get; set; }

        public Consumption(int totalDistance, string spentFuel)
        {
            TotalDistance = totalDistance;
            SpentFuel = FormatarNumeros.formatarValoresEntrada(spentFuel);
        }

        public string calculeConsumption()
        {
            var Consumption = TotalDistance / SpentFuel;

            return $"{FormatarNumeros.formatarSaidaTresCasasDecimais(Consumption)} km/l";
        }
    }
}
