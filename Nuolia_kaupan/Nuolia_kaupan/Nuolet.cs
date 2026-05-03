namespace Nuolia_kaupan
{
    enum Kärki_tyyppi
    {
        puu = 3,
        teräs = 5,
        timantti = 50
    }

    enum Perä_tyyppi
    {
        lehti = 0,
        kanansulka = 1,
        kotkansulka = 5
    }

    internal class Nuolet
    {
        public Kärki_tyyppi Kärki { get; set; }
        public Perä_tyyppi Perä { get; set; }
        public int Pituus { get; set; }

        public Nuolet(Kärki_tyyppi kärki, Perä_tyyppi perä, int pituus)
        {
            Kärki = kärki;
            Perä = perä;
            Pituus = pituus;
        }

        public float PalautaHinta()
        {
            float kärjenHinta = (int)Kärki;
            float peränHinta = (int)Perä;
            float varrenHinta = Pituus * 0.05f;

            return kärjenHinta + peränHinta + varrenHinta;
        }

  
        public static Nuolet LuoEliittiNuoli()
        {
            return new Nuolet(Kärki_tyyppi.timantti, Perä_tyyppi.kotkansulka, 100);
        }

        public static Nuolet LuoAloittelijaNuoli()
        {
            return new Nuolet(Kärki_tyyppi.puu, Perä_tyyppi.kanansulka, 70);
        }

        public static Nuolet LuoPerusNuoli()
        {
            return new Nuolet(Kärki_tyyppi.teräs, Perä_tyyppi.kanansulka, 85);
        }
    }
}