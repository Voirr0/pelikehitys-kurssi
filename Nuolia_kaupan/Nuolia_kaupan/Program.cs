using System;

namespace Nuolia_kaupan
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Minkälainen kärki:");
            string[] kärjet = Enum.GetNames<Kärki_tyyppi>();
            for (int i = 0; i < kärjet.Length; i++)
            {
                Console.WriteLine(kärjet[i]);
            }

            Kärki_tyyppi valittuKärki;
            while (true)
            {
                Console.WriteLine("-----------------------------------");
                string syöte = Console.ReadLine();

                if (Enum.TryParse(syöte, true, out valittuKärki))
                    break;

                Console.WriteLine("Virheellinen valinta, yritä uudestaan.");
            }

            
            Console.WriteLine("Minkälainen perä:");
            string[] perät = Enum.GetNames<Perä_tyyppi>();
            for (int i = 0; i < perät.Length; i++)
            {
                Console.WriteLine(perät[i]);
            }

            Perä_tyyppi valittuPerä;
            while (true)
            {
                Console.WriteLine("-----------------------------------");
                string syöte = Console.ReadLine();

                if (Enum.TryParse(syöte, true, out valittuPerä))
                    break;

                Console.WriteLine("Virheellinen valinta, yritä uudestaan.");
            }

            
            int pituus;
            while (true)
            {
                Console.WriteLine("Kuinka pitkä nuoli (60-100):");
                string syöte = Console.ReadLine();

                if (int.TryParse(syöte, out pituus) && pituus >= 60 && pituus <= 100)
                    break;

                Console.WriteLine("Anna luku väliltä 60–100.");
            }

           
            Nuolet tilaus = new Nuolet(valittuKärki, valittuPerä, pituus);

          
            Console.WriteLine($"Tämän nuolen hinta on {tilaus.PalautaHinta()} kultarahaa.");
        }
    }
}