using System;

namespace Opdracht4
{
    class Program
    {
        static void Main(string[] args)
        {

            int maths = 0;
            int chemistry = 0;
            int science = 0;




            Console.WriteLine("Hallo om te kijken of je een examen mag maken heb ik bepaalde gegevens  nodig");
            Console.WriteLine("Wat is je cijfer van Wiskunde? (0-100)");
            maths = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wat is je cijfer van Scheikunde? (0-100)");
            chemistry = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wat is je cijfer van Natuurkunde? (0-100)");
            science = Convert.ToInt32(Console.ReadLine());

            int total = maths + chemistry + science;

            if ((maths < 40 || science < 40 || chemistry < 40) || (maths == 0 || chemistry == 0 || science == 0))
            {
                Console.WriteLine("Helaas je mag niet deelnemen aan het examen");
            }
            else if ((maths >= 60 && (science >= 60 || chemistry >= 60)) || total >= 180)
            {
                Console.WriteLine("Gefeliciteerd je mag meedoen met het examen");
            }
            else
            {
                Console.WriteLine("Helaas je mag niet deelnemen aan het examen");
            }

        }
    }
}
