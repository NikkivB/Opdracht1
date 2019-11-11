using System;

namespace AutoDealer
{
    class Program
    {
        static void Main(string[] args)
        {
            string naam;
            Double standaartPrijs;
            string mLak;
            string leer;
            string automaat;
            double goedePrijs = 0;

            Console.WriteLine("Wat is uw naam?");
            naam = Console.ReadLine();
            Console.WriteLine("Wat is de standaartprijs van de auto");
            standaartPrijs = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wilt u metallic lak?");
            mLak = Console.ReadLine();
            Console.WriteLine("Wilt u leren bekleding?");
            leer = Console.ReadLine();
            Console.WriteLine("Wilt u een automaat ipv handschakeling?");
            automaat = Console.ReadLine();

            Console.WriteLine("U bent {0}", naam);
            Console.WriteLine("De standaartprijs van de auto is {0}", standaartPrijs);
            Console.WriteLine("Lak: {0}", mLak);
            Console.WriteLine("Leren bekleding: {0}", leer);
            Console.WriteLine("Automaat: {0}", automaat);

            goedePrijs = standaartPrijs;

            if (mLak == "ja")
            {
                goedePrijs = (Convert.ToDouble(goedePrijs) / 100) * 105;
                Console.WriteLine("5% extra vanwege Lak");
            }
            if (leer == "ja")
            {
                goedePrijs = (Convert.ToDouble(goedePrijs) / 100) * 105;
                Console.WriteLine("5% extra vanwege leren bekleding");
            }
            if (automaat == "ja")
            {
                goedePrijs = goedePrijs + 1000;
                Console.WriteLine("1000 extra vanwege automaat");
            }

            Console.WriteLine("Prijs zonder BTW: {0}", goedePrijs);

            goedePrijs = (goedePrijs / 100) * 121;

            Console.WriteLine("Prijs met BTW: {0}", goedePrijs);
        }
    }
