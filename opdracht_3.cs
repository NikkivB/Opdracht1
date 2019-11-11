using System;

namespace taalKiezen
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] list = { "de huidige maand is maart", "der Aktuele monat ist März", "The current month is march", ": Le moi en cours est mars", "el mes actual es marzo", "bu ay mart ayi" };
            string[] talen = { "1 = Nederlands", "2 = Duits", "3 = Engels", "4 = Frans", "5 = Spaans", "6 = Turks" };
            for (int x = 0; x < talen.Length; x++)
            {
                Console.WriteLine(talen[x]);
            }
            Console.WriteLine("type het cijfer voor de taal");
            int cijfer = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(list[cijfer - 1]);

            Console.ReadLine();

        }
    }
}
