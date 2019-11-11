using System;

namespace opdracht_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string lengte;
            string gewicht;
            double bmi;

            Console.WriteLine("Wat is uw lengte?");
            lengte = Console.ReadLine();
            Console.WriteLine("Wat is uw gewicht>");
            gewicht = Console.ReadLine();

            //bmi = kg / m*m
            bmi = Convert.ToDouble(gewicht) / (Convert.ToDouble(lengte) * Convert.ToDouble(lengte));

            Console.WriteLine("Uw bmi is {0}", bmi);
        }
    }
}
