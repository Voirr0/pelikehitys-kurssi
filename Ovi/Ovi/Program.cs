namespace Ovi
{
    internal class Program
    {

        enum Oventila
        {
            auki,
            kiinni,
            lukossa
        }

        enum Toiminnot
        {
            avaa,
            sulje,
            lukitse,
            poistalukitus
        }
        static void Main(string[] args)
        {
            Oventila oven_tila = Oventila.auki;
            Toiminnot oven_toiminnot = Toiminnot.avaa;
            while (true)
            {
                string[] OviToiminnot = Enum.GetNames<Toiminnot>();

                Console.WriteLine($"Ovi on {oven_tila.ToString().ToLower()}");
                Console.WriteLine("Mitä haluat tehdä?");
                for (int i = 0; i < OviToiminnot.Length; i++)
                {
                    Console.WriteLine(OviToiminnot[i]);
                }
                Console.WriteLine("-------------------------------------------------");
                string vastaus = Console.ReadLine();

                for (int i = 0; i < OviToiminnot.Length; i++)
                {
                   if (vastaus == OviToiminnot[i])
                    {
                        oven_toiminnot = Enum.Parse<Toiminnot>(vastaus);
                        break;
                    }
                }

                if (oven_toiminnot == Toiminnot.sulje && oven_tila == Oventila.auki)
                {
                    oven_tila = Oventila.kiinni;
                }

                else if (oven_toiminnot == Toiminnot.avaa && oven_tila == Oventila.kiinni)
                {
                    oven_tila = Oventila.auki;
                }

               else if (oven_toiminnot == Toiminnot.lukitse && oven_tila == Oventila.kiinni)
                {
                    oven_tila = Oventila.lukossa;
                }

               else if (oven_toiminnot == Toiminnot.poistalukitus && oven_tila == Oventila.lukossa)
                {
                    oven_tila = Oventila.kiinni;
                }

                else
                {
                    Console.WriteLine("Virhe!");
                }
            }
        }
    }
}
