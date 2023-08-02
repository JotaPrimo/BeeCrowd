using BeeCrowd.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeCrowd.Entities
{
    
    public class Sphere
    {
        public const double PI = 3.14159;

        public double Raio { get; private set; }

        public Sphere(string volume)
        {
            Raio = FormatarNumeros.formatarValoresEntrada(volume);
        }

        public string calcularVolume()
        {
            var result = (4 / 3.0) * PI * Math.Pow(Raio, 3);
            return $"VOLUME = {FormatarNumeros.formatarSaidaTresCasasDecimais(result)}";
        }

    }

}
