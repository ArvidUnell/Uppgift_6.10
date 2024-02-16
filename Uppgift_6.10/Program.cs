using System;
namespace Uppgift_6_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv en sträng");
            Console.WriteLine($"Den strängen innehöll {AntalTalIText(Console.ReadLine())} tal.");
        }
        static int AntalTalIText(string meddelande)
        {
            string[] meddelandeArr = meddelande.Split(' ');

            int summa = 0;
            double x;

            foreach (string text in meddelandeArr)
            {
                if (double.TryParse(text,out x))
                {
                    summa++;
                }
            }

            return summa;
        }
    }
}