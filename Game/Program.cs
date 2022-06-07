using System;
using System.Collections.Generic;
using System.Text;

namespace Practic2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello! Welcome to Death Duel.");
            Console.WriteLine("Choose game mode");
            Console.WriteLine("\nAvailable modes:\n1.BVB - bot vs bot\n2 PVP - player vs player\n3.PVB - player vs bot");
            BotVsBot play1 = new BotVsBot();
            PersVsPers play2 = new PersVsPers();
            PersVsBot play3 = new PersVsBot();

            int selection = 0;
            while (selection < 1 || selection > 4)
            {
                selection = Convert.ToInt32(Console.ReadLine());
            }

            Console.Clear();

            switch (selection)
            {
                case 1:
                    Console.WriteLine("\nYou choosed: BVB");
                    play1.BVB();
                    break;
                case 2:
                    Console.WriteLine("\nYou choosed: PVP");
                    play2.PVP();
                    break;
                case 3:
                    Console.WriteLine("\nYou choosed: PVB");
                    play3.PVB();
                    break;
            }

        }
    }
}
