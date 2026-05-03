using System;

namespace SeikkailijanReppu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Reppu reppu = new Reppu(10, 15f, 20f);

            while (true)
            {
                Console.WriteLine("\nValitse lisättävä tavara:");
                Console.WriteLine("1. Nuoli");
                Console.WriteLine("2. Jousi");
                Console.WriteLine("3. Köysi");
                Console.WriteLine("4. Vesi");
                Console.WriteLine("5. Ruoka-annos");
                Console.WriteLine("6. Miekka");
                Console.WriteLine("0. Lopeta");

                string valinta = Console.ReadLine();
                Tavara tavara = null;

                switch (valinta)
                {
                    case "1": tavara = new Nuoli(); break;
                    case "2": tavara = new Jousi(); break;
                    case "3": tavara = new Köysi(); break;
                    case "4": tavara = new Vesi(); break;
                    case "5": tavara = new RuokaAnnos(); break;
                    case "6": tavara = new Miekka(); break;
                    case "0": return;
                    default:
                        Console.WriteLine("Virheellinen valinta.");
                        continue;
                }

                bool onnistui = reppu.Lisää(tavara);

                if (onnistui)
                    Console.WriteLine("Tavara lisätty.");
                else
                    Console.WriteLine("Reppu täynnä tai kapasiteetti ylittyy.");

                Console.WriteLine($"\nRepun tila:");
                Console.WriteLine($"Tavaroita: {reppu.TavaraMaara}/{reppu.MaxMaara}");
                Console.WriteLine($"Paino: {reppu.NykyPaino}/{reppu.MaxPaino}");
                Console.WriteLine($"Tilavuus: {reppu.NykyTilavuus}/{reppu.MaxTilavuus}");
            }
        }
    }
}