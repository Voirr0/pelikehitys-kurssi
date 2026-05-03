using System.Collections.Generic;
using System.Linq;

namespace SeikkailijanReppu
{
    internal class Reppu
    {
        private List<Tavara> tavarat = new List<Tavara>();

        public int MaxMaara { get; }
        public float MaxPaino { get; }
        public float MaxTilavuus { get; }

        public int TavaraMaara => tavarat.Count;
        public float NykyPaino => tavarat.Sum(t => t.Paino);
        public float NykyTilavuus => tavarat.Sum(t => t.Tilavuus);

        public Reppu(int maxMaara, float maxPaino, float maxTilavuus)
        {
            MaxMaara = maxMaara;
            MaxPaino = maxPaino;
            MaxTilavuus = maxTilavuus;
        }

        public bool Lisää(Tavara tavara)
        {
            if (TavaraMaara + 1 > MaxMaara) return false;
            if (NykyPaino + tavara.Paino > MaxPaino) return false;
            if (NykyTilavuus + tavara.Tilavuus > MaxTilavuus) return false;

            tavarat.Add(tavara);
            return true;
        }


        public override string ToString()
        {
            if (tavarat.Count == 0)
                return "Reppu on tyhjä";

            string sisältö = string.Join(", ", tavarat);
            return $"Repussa on seuraavat tavarat: {sisältö}";
        }
    }
}