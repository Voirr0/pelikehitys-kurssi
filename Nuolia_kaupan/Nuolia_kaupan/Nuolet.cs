using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public Perä_tyyppi perä;
        public Kärki_tyyppi kärki;
        public int pituus;

        public float PalautaHinta()
        {
            float kärjenHinta = (int)kärki;
            float peränHinta = (int)perä;
            float varrenHinta = pituus * 0.05f;

            return kärjenHinta + peränHinta + varrenHinta;
        }
    }
}
