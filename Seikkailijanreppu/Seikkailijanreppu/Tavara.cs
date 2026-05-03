namespace SeikkailijanReppu
{
    internal class Tavara
    {
        public float Paino { get; }
        public float Tilavuus { get; }

        public Tavara(float paino, float tilavuus)
        {
            Paino = paino;
            Tilavuus = tilavuus;
        }
    }

    internal class Nuoli : Tavara
    {
        public Nuoli() : base(0.1f, 0.05f) { }
    }

    internal class Jousi : Tavara
    {
        public Jousi() : base(1f, 4f) { }
    }

    internal class Köysi : Tavara
    {
        public Köysi() : base(1f, 1.5f) { }
    }

    internal class Vesi : Tavara
    {
        public Vesi() : base(2f, 2f) { }
    }

    internal class RuokaAnnos : Tavara
    {
        public RuokaAnnos() : base(1f, 0.5f) { }
    }

    internal class Miekka : Tavara
    {
        public Miekka() : base(5f, 3f) { }
    }
}