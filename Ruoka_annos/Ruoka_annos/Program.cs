namespace Ruoka_annos
{
    internal class Program
    {


        static void Main(string[] args)
        {
            ateria tilaus = new ateria();

            string[] Pääraaka_aine = Enum.GetNames<Pääraaka_aine>();
            Console.WriteLine("Valitse pääraaka-aine");
            for (int i = 0; i < Pääraaka_aine.Length; i++)
            {
                Console.WriteLine(Pääraaka_aine[i]);
            }

            Console.WriteLine("-------------------------------------------------");
                string vastaus = Console.ReadLine();
            Pääraaka_aine valintaout;

            if (Enum.TryParse<Pääraaka_aine>(vastaus,out valintaout))
            {
                tilaus.pääaine = valintaout;
            }



            string[] Lisuke = Enum.GetNames<Lisuke>();
            Console.WriteLine("Valitse Lisuke");
            for (int i = 0; i < Lisuke.Length; i++)
            {
                Console.WriteLine(Lisuke[i]);
            }

            Console.WriteLine("-------------------------------------------------");
            string vastaus1 = Console.ReadLine();
            Lisuke valintaout1;

            if (Enum.TryParse<Lisuke>(vastaus, out valintaout1))
            {
                tilaus.lisuke = valintaout1;
            }

            string[] Kastike = Enum.GetNames<Kastike>();
            Console.WriteLine("Valitse Kastike");
            for (int i = 0; i < Lisuke.Length; i++)
            {
                Console.WriteLine(Kastike[i]);
            }

            Console.WriteLine("-------------------------------------------------");
            string vastaus2 = Console.ReadLine();
            Kastike valintaout2;

            if (Enum.TryParse<Kastike>(vastaus, out valintaout2))
            {
                tilaus.kastike = valintaout2;
            }

            Console.WriteLine($"{vastaus} ja {vastaus1} {vastaus2}-kastikkeella");
        }
    }
}
