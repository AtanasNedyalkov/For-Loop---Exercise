using System;

namespace _05._Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int openTabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());
            //•	"Facebook"-> 150 лв.
            //•	"Instagram"-> 100 лв.
            //•	"Reddit"-> 50 лв.
            int penaltySum = 0;
            for (int i = 0; i < openTabs; i++)
            {
                string tabName = Console.ReadLine();
                if (tabName == "Facebook")
                {
                    penaltySum += 150;
                }
                else if (tabName == "Instagram")
                {
                    penaltySum += 100;
                }
                else if (tabName == "Reddit")
                {
                    penaltySum += 50;
                }
            }
            int difference = salary - penaltySum;
            if (difference<=0)
            {
                Console.WriteLine($"You have lost your salary.");
            }
            else
            {
                Console.WriteLine(salary-penaltySum);
            }
            

        }
    }
}
