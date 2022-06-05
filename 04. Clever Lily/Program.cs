using System;

namespace _04._Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int ageLili = int.Parse(Console.ReadLine());
            double priceMachine = double.Parse(Console.ReadLine());
            int singlePriceToy = int.Parse(Console.ReadLine());
            int sum = 0;
            int toysNum = 0;

            for (int i = 1; i <= ageLili; i++)
            {
                if (i % 2 == 0) // 2->10,4-->20,6-->30, 8 --> 40
                {
                    sum = (sum + i * 5) - 1; //(0 + 2*10) - 1 = 19
                }
                else
                {
                    toysNum++;
                }
            }
            double totalPriceForToys = singlePriceToy * toysNum;
            double total = totalPriceForToys + sum;
            double difference = total - priceMachine;
            if (total >= priceMachine)
            {
                Console.WriteLine($"Yes! {difference:f2}");
            }
            else
            {
                Console.WriteLine($"No! {Math.Abs (difference):F2}");
            }
        }
    }
}
