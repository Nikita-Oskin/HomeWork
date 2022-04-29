using System;
using System.Collections.Generic;
using System.Text;

namespace Practic2
{
    //Enemy actions
    public class PlayerActionsEnemy : Character_enemy
    {
        public void SelectActionsEnemy(Character_hero character)
        {
            Console.WriteLine("What do you want to use?");
            Console.WriteLine("\n1. Normal attack - stable damage");
            Console.WriteLine("\n2. Special ability Damage - random damage");
            Console.WriteLine("\n3. Special ability Heal - random heal");
            Console.WriteLine("\n4. Regeneration HP - health recovery");

            int player = Convert.ToInt32(Console.ReadLine());

            if (player == 1)
            {
                NormalAttackEnemy(character);
                Console.WriteLine("You used a normal attack");
            }
            else if (player == 2)
            {
                SpecialAbilityDPS(character); ;
                Console.WriteLine("You used a special ability: Damage");
            }
            else if (player == 3)
            {
                SpecialAbilityHeal(this);
                Console.WriteLine("You used a special ability: Heal");
            }
            else if (player == 4)
            {
                RegenerationHealthEnemy(this);
            }
            else if (player < 1 || player > 5)
            {
                Console.WriteLine("You entered the wrong one");
            }
        }
        // Enemy_bot actions
        public void BOTSelectActionsEnemy(Character_hero character)
        {
            Random rand = new Random();
            int num = rand.Next(1, 5);
            int player = num;

            if (player == 1)
            {
                NormalAttackEnemy(character);
                Console.WriteLine("You used a normal attack");
            }
            else if (player == 2)
            {
                SpecialAbilityDPS(character); ;
                Console.WriteLine("You used a special ability: Damage");
            }
            else if (player == 3)
            {
                SpecialAbilityHeal(this);
                Console.WriteLine("You used a special ability: Heal");
            }
            else if (player == 4)
            {
                RegenerationHealthEnemy(this);
            }
        }
    }
}
