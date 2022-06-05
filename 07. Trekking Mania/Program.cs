using System;

namespace _07._Trekking_Mania
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupVolume = int.Parse(Console.ReadLine());
            double pMusala = 0;
            double pMontBlanc = 0;
            double pKili = 0;
            double pK2 = 0;
            double pEverest = 0;
            int totalOfPeople = 0;


            for (int i = 0; i < groupVolume; i++)
            {
                int numsOfPeople = int.Parse(Console.ReadLine());
                totalOfPeople += numsOfPeople;
                if (numsOfPeople <= 5)
                {
                    pMusala += numsOfPeople;
                }
                else if (numsOfPeople > 5 && numsOfPeople <= 12)
                {
                    pMontBlanc += numsOfPeople;
                }
                else if (numsOfPeople > 12 && numsOfPeople <= 25)
                {
                    pKili += numsOfPeople;
                }
                else if (numsOfPeople > 25 && numsOfPeople <= 40)
                {
                    pK2 += numsOfPeople;

                }
                else if (numsOfPeople > 40)
                {
                    pEverest += numsOfPeople;
                }

            }
            Console.WriteLine($"{(pMusala / totalOfPeople * 100):f2}%");
            Console.WriteLine($"{(pMontBlanc / totalOfPeople * 100):f2}%");
            Console.WriteLine($"{(pKili / totalOfPeople * 100):f2}%");
            Console.WriteLine($"{(pK2 / totalOfPeople * 100):f2}%");
            Console.WriteLine($"{(pEverest / totalOfPeople * 100):f2}%");

        }
    }
}
