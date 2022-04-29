using System;
using System.Collections.Generic;
using System.Text;

namespace Practic2
{
    public class BotVsBot
    {
        public void BVB()
        {
            PlayerActionsHero choose1 = new PlayerActionsHero();
            choose1.CreateCharacterHero();

            PlayerActionsEnemy choose2 = new PlayerActionsEnemy();
            choose2.CreateCharacterEnemy();

            Console.WriteLine("\nThe BVB battle has begun!");

            while (true)
            {
                Console.WriteLine("Damage to Bot_1");
                choose2.BOTSelectActionsEnemy(choose1);
                if (choose1.HealthHero <= 0)
                {
                    break;
                }

                Console.WriteLine($"Bot's_1 current health: {choose1.HealthHero}");
                Console.WriteLine();

                System.Threading.Thread.Sleep(1000);

                Console.WriteLine("Damage to Bot_2");
                choose1.BOTSelectActionsHero(choose2);
                if (choose2.HealthEnemy <= 0)
                {
                    break;
                }

                Console.WriteLine($"Bot's_2 current health): {choose2.HealthEnemy}");
                Console.WriteLine();

                System.Threading.Thread.Sleep(1000);
            }

            Console.ReadKey();
        }
    }
}
