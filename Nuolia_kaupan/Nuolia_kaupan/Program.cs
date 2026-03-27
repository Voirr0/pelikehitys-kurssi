namespace Nuolia_kaupan
{
    internal class Program
    {

        static void Main(string[] args)
        {
         Nuolet tilaus = new Nuolet();

        string[] kärki_tyyppi = Enum.GetNames<Kärki_tyyppi>();
            Console.WriteLine("Minkälainen käkri");
            for (int i = 0; i < kärki_tyyppi.Length; i++)
            {
                Console.WriteLine(kärki_tyyppi[i]);
            }

            Console.WriteLine("-------------------------------------------------");
            string vastaus = Console.ReadLine();
            Kärki_tyyppi valintaout;

            if (Enum.TryParse<Kärki_tyyppi>(vastaus, out valintaout))
            {
                tilaus.kärki = valintaout;  
            }

            string[] perä_tyyppi = Enum.GetNames<Perä_tyyppi>();
            Console.WriteLine("Minkälainen perä");
            for (int i = 0; i < perä_tyyppi.Length; i++)
            {
                Console.WriteLine(perä_tyyppi[i]);
            }

            Console.WriteLine("-------------------------------------------------");
            string vastaus1 = Console.ReadLine();
            Perä_tyyppi valintaout1;

            if (Enum.TryParse<Perä_tyyppi>(vastaus1, out valintaout1))
            {
                tilaus.perä = valintaout1;
            }



            Console.WriteLine("Kuinka pitkä nuoli");

            string vastaus3 = Console.ReadLine();

            int valintaout3;


            if (Int32.TryParse(vastaus3, out valintaout3))
            {
                if (valintaout3 >= 60 && valintaout3 <= 100)
                {
                    tilaus.pituus = valintaout3;
                }

                else
                {
                    Console.WriteLine("Valitse 60-100 väliltä");
                }
            }

            else
            {
                Console.WriteLine("Vastauksen pitää olla luku");
            }



            Console.WriteLine($"Tämän nuolen hinta on {tilaus.PalautaHinta()} kultarahaa.");






        }
    }
}
