using System;

namespace _06._Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double pointsOfAccademy = double.Parse(Console.ReadLine());
            int numOfJury = int.Parse(Console.ReadLine());
            double sumOfpoints = pointsOfAccademy;

            for (int i = 0; i < numOfJury; i++)
            {
                string nameOfJury = Console.ReadLine();
                double pointsOfJury = double.Parse(Console.ReadLine());
                double momentPoints = (nameOfJury.Length * pointsOfJury) / 2;
                sumOfpoints = momentPoints + sumOfpoints;
                if (sumOfpoints>=1250.5)
                {
                    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {sumOfpoints:f1}!");
                    break;
                }
                
            }
            if (sumOfpoints<1250.5)
            {
                double difference = 1250.5 - sumOfpoints;
                Console.WriteLine($"Sorry, {actorName} you need {difference:f1} more!");
            }
            

            
            // Zahari Baharov
            //205
            //4
            //Johnny Depp
            //45
            //Will Smith
            //29
            //Jet Lee
            //10
            //Matthew Mcconaughey
            //39

        }
    }
}
