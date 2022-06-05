using System;

namespace _08._Tennis_Ranklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int numsOfTournaments = int.Parse(Console.ReadLine());
            double startPoints = int.Parse(Console.ReadLine());
            int finalPoints = 0;
            double numsOfWins = 0;
            for (int i = 0; i < numsOfTournaments; i++)
            {
                string resultOfTournament = Console.ReadLine();
                
                switch (resultOfTournament)
                {
                    case "W":
                        finalPoints += 2000;
                        numsOfWins++;
                        break;
                    case "F":
                        finalPoints += 1200;
                        break;
                    case "SF":
                        finalPoints += 720;
                        break;
                    default:
                        break;
                }
            }
                int averagePoints = finalPoints / numsOfTournaments;
                double percentageOfWins = numsOfWins/numsOfTournaments * 100;
            Console.WriteLine($"Final points: {finalPoints+startPoints}");
            Console.WriteLine($"Average points: {averagePoints}");
            Console.WriteLine($"{percentageOfWins:f2}%");

            
            // 	W - ако е победител получава 2000 точки
            //	F - ако е финалист получава 1200 точки
            //	SF - ако е полуфиналист получава 720 точки

        }
    }
}
