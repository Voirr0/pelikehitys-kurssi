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
        public override string ToString() => "Nuoli";
    }

    internal class Jousi : Tavara
    {
        public Jousi() : base(1f, 4f) { }
        public override string ToString() => "Jousi";
    }

    internal class Köysi : Tavara
    {
        public Köysi() : base(1f, 1.5f) { }
        public override string ToString() => "Köysi";
    }

    internal class Vesi : Tavara
    {
        public Vesi() : base(2f, 2f) { }
        public override string ToString() => "Vesi";
    }

    internal class RuokaAnnos : Tavara
    {
        public RuokaAnnos() : base(1f, 0.5f) { }
        public override string ToString() => "Ruoka-annos";
    }

    internal class Miekka : Tavara
    {
        public Miekka() : base(5f, 3f) { }
        public override string ToString() => "Miekka";
    }
}