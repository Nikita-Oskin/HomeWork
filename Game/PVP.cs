using System;
using System.Collections.Generic;
using System.Text;

namespace Practic2
{
    public class PersVsPers
    {
        public void PVP()
        {
            PlayerActionsHero choose1 = new PlayerActionsHero();
            choose1.CreateCharacterHero();
            PlayerActionsEnemy choose2 = new PlayerActionsEnemy();
            choose2.CreateCharacterEnemy();

            Console.WriteLine("\nThe PVP battle has begun!");

            while (true)
            {
                Console.WriteLine("Damage to Player_1");
                choose2.SelectActionsEnemy(choose1);
                if (choose1.HealthHero <= 0)
                {
                    break;
                }

                Console.WriteLine($"Player's_1 current health: {choose1.HealthHero}");
                Console.WriteLine();

                System.Threading.Thread.Sleep(1000);

                Console.WriteLine("Damage to Player_2");
                choose1.SelectActionsHero(choose2);
                if (choose2.HealthEnemy <= 0)
                {
                    break;
                }

                Console.WriteLine($"Player's_2 current health): {choose2.HealthEnemy}");
                Console.WriteLine();

                System.Threading.Thread.Sleep(1000);
            }

            Console.ReadKey();
        }

    }
}
