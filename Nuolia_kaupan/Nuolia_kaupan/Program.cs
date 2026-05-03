using System;

namespace Nuolia_kaupan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tervetuloa nuolikauppaan.");

            while (true)
            {
                Console.WriteLine("\nHaluatko:");
                Console.WriteLine("1. Teettää nuolen tilaustyönä?");
                Console.WriteLine("2. Ostaa valmiin nuolen?");
                Console.Write("Valinta: ");

                string valinta = Console.ReadLine();
                Nuolet nuoli = null;

                if (valinta == "1")
                {
                
                    Console.WriteLine("\nValitse kärki:");
                    foreach (var nimi in Enum.GetNames<Kärki_tyyppi>())
                        Console.WriteLine(nimi);

                    Kärki_tyyppi kärki;
                    while (!Enum.TryParse(Console.ReadLine(), true, out kärki))
                        Console.WriteLine("Virheellinen, yritä uudestaan.");

                   
                    Console.WriteLine("\nValitse perä:");
                    foreach (var nimi in Enum.GetNames<Perä_tyyppi>())
                        Console.WriteLine(nimi);

                    Perä_tyyppi perä;
                    while (!Enum.TryParse(Console.ReadLine(), true, out perä))
                        Console.WriteLine("Virheellinen, yritä uudestaan.");

                   
                    int pituus;
                    while (true)
                    {
                        Console.WriteLine("\nAnna pituus (60-100):");
                        if (int.TryParse(Console.ReadLine(), out pituus) && pituus >= 60 && pituus <= 100)
                            break;

                        Console.WriteLine("Virheellinen pituus.");
                    }

                    nuoli = new Nuolet(kärki, perä, pituus);
                }
                else if (valinta == "2")
                {
                    Console.WriteLine("\nValitse valmis nuoli:");
                    Console.WriteLine("1. Eliittinuoli");
                    Console.WriteLine("2. Aloittelijanuoli");
                    Console.WriteLine("3. Perusnuoli");

                    string valmisValinta = Console.ReadLine();

                    if (valmisValinta == "1")
                        nuoli = Nuolet.LuoEliittiNuoli();
                    else if (valmisValinta == "2")
                        nuoli = Nuolet.LuoAloittelijaNuoli();
                    else if (valmisValinta == "3")
                        nuoli = Nuolet.LuoPerusNuoli();
                    else
                    {
                        Console.WriteLine("Virheellinen valinta.");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Virheellinen valinta.");
                    continue;
                }

                Console.WriteLine($"\nNuolen hinta on {nuoli.PalautaHinta()} kultarahaa.");
            }
        }
    }
}