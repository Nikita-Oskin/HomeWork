using System;
using System.Collections.Generic;
using System.Text;

namespace Practic2
{
    public class Character_enemy
    {
        //Creating an enemy
        public Character_enemy CreateCharacterEnemy()
        {
            Console.WriteLine("\nChoose an enemy");
            Console.WriteLine("Available Enemies:\n1.Warlock\n2.Rogue\n3.Death King");

            int race_enemy = Convert.ToInt32(Console.ReadLine());
            Character_enemy character_enemy = new Character_enemy();

            switch (race_enemy)
            {
                case 1:
                    Console.WriteLine("\nYour class is Warlock");
                    character_enemy = new Warlock();
                    break;
                case 2:
                    Console.WriteLine("\nYour class is Rogue");
                    character_enemy = new Rogue();
                    break;
                case 3:
                    Console.WriteLine("\nYour class is Death King");
                    character_enemy = new Death_King();
                    break;
            }

            return character_enemy;
        }
        public int HealthEnemy { get; private set; }

        public Character_enemy()
        {
            HealthEnemy = 550;
        }
        //Realization of normal damage
        public virtual void GetDamage(int damage)
        {
            HealthEnemy -= damage;
            Console.WriteLine($"Enemy took damage: {damage}");
            if (HealthEnemy < 1)
            {
                Console.WriteLine("The enemy is dead");
            }
        }
        public void NormalAttackEnemy(Character_hero character)
        {
            int AttackEnemy = 55;
            character.GetDamage(AttackEnemy);
        }
        //Realization of normal heal
        public virtual void Regeneration(int heal)
        {
            HealthEnemy += heal;
            Console.WriteLine($"Enemy restored health: {heal}");
        }
        public void RegenerationHealthEnemy(Character_enemy character)
        {
            int RegHP = 60;
            character.Regeneration(RegHP);
        }
        //Realization of special ability dagame/heal
        public virtual void SpecialAbilityDPS(Character_hero character)
        {
            Random rand = new Random();
            int SpecAttack = rand.Next(1, 121);
            character.GetDamage(SpecAttack);
        }

        public virtual void SpecialAbilityHeal(Character_enemy character)
        {
            int SpecAttack = 60;
            character.Regeneration(SpecAttack);
        }

    }
}
