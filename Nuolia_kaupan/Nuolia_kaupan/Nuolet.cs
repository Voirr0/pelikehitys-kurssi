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
        private Perä_tyyppi perä;
        private Kärki_tyyppi kärki;
        private int pituus;

        
        public Nuolet(Kärki_tyyppi kärki, Perä_tyyppi perä, int pituus)
        {
            this.kärki = kärki;
            this.perä = perä;
            this.pituus = pituus;
        }

    
        public Kärki_tyyppi GetKärki()
        {
            return kärki;
        }

        public Perä_tyyppi GetPerä()
        {
            return perä;
        }

        public int GetPituus()
        {
            return pituus;
        }

        public float PalautaHinta()
        {
            float kärjenHinta = (int)kärki;
            float peränHinta = (int)perä;
            float varrenHinta = pituus * 0.05f;

            return kärjenHinta + peränHinta + varrenHinta;
        }
    }
}