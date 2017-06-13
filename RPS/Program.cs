using System;
using System.Threading;
using System.Collections.Generic;


namespace RockPaperSkizzers
{
    class Game
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors! \nHere, you battle for your life! \nReady...Go!");

            var hand = new List<string>() { "Rock", "Paper", "Scissors" };
            Console.WriteLine("Select one of the following choices: \n1. Rock \n2. Paper \n3. Scissors");
            int userChoice = Convert.ToInt32(Console.ReadLine()) - 1;



            Random random = new Random();
            int computerHand = random.Next(0, 3);
            Console.WriteLine("You chose: " + hand[userChoice]);
            Console.WriteLine("The computer chose: " + hand[computerHand]);
            if (computerHand == userChoice)
            {
                Thread.Sleep(2000); //delay of 1000 milliseconds or 1 second.
                Console.WriteLine("DOPEH. You won professional bro!");
            }
            if (computerHand == 0 && userChoice == 1)
            {
                Thread.Sleep(2000); //delay of 1000 milliseconds or 1 second.
                Console.WriteLine("DOPEH. You won professional bro!");
            }
            if (computerHand == 0 && userChoice == 2)
            {
                Thread.Sleep(2000); //delay of 1000 milliseconds or 1 second.
                Console.WriteLine("YOU ARE A DISGRACE!");
            }
            if (computerHand == 1 && userChoice == 0)
            {
                Thread.Sleep(2000); //delay of 1000 milliseconds or 1 second.
                Console.WriteLine("YOU ARE A DISGRACE!");
            }
            if (computerHand == 1 && userChoice == 2)
            {
                Thread.Sleep(2000); //delay of 1000 milliseconds or 1 second.
                Console.WriteLine("DOPEH. You won professional bro!");
            }
            if (computerHand == 2 && userChoice == 0)
            {
                Thread.Sleep(2000); //delay of 1000 milliseconds or 1 second.
                Console.WriteLine("DOPEH. You won professional bro!");
            }
            if (computerHand == 2 && userChoice == 1)
            {
                Thread.Sleep(2000); //delay of 1000 milliseconds or 1 second.
                Console.WriteLine("YOU ARE A DISGRACE!");
            }
            ConsoleKeyInfo k = new ConsoleKeyInfo();
            Console.WriteLine("Press any key in the next 5 seconds.");
            for (int cnt = 5; cnt > 0; cnt--)
            {
                if (Console.KeyAvailable == true)
                {
                    k = Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine(cnt.ToString());
                    System.Threading.Thread.Sleep(1000);
                }
            }
            Console.WriteLine("The key pressed was " + k.Key);

        }
    }
}