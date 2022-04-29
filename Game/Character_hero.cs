using System;
using System.Collections.Generic;
using System.Text;

namespace Practic2
{
    public class Character_hero
    {
        //Creating a Hero
        public Character_hero CreateCharacterHero()
        {
            Console.WriteLine("\nChoose a hero");
            Console.WriteLine("Available Heroes:\n1.Warrior\n2.Mage\n3.Monk");

            int race_hero = Convert.ToInt32(Console.ReadLine());
            Character_hero character_hero = new Character_hero();

            switch (race_hero)
            {
                case 1:
                    Console.WriteLine($"\nYour class is Warrior");
                    character_hero = new Warrior();
                    break;
                case 2:
                    Console.WriteLine($"\nYour class is Mage");
                    character_hero = new Mage();
                    break;
                case 3:

                    Console.WriteLine($"\nYour class is Monk");
                    character_hero = new Monk();
                    break;
            }

            return character_hero;
        }
        public int HealthHero { get; private set; }
        public Character_hero()
        {
            HealthHero = 550;
        }
        //Realization of normal damage
        public virtual void GetDamage(int damage)
        {
            HealthHero -= damage;
            Console.WriteLine($"Hero took damage: {damage}");
            if (HealthHero < 1)
            {
                Console.WriteLine($"The hero died");
            }
        }
        public void NormalAttackHero(Character_enemy character)
        {
            int AttackHero = 55;
            character.GetDamage(AttackHero);
        }
        //Realization of normal heal
        public virtual void Regeneration(int heal)
        {
            HealthHero += heal;
            Console.WriteLine($"Hero is restored to health: {heal}");
        }
        public void RegenerationHealthHero(Character_hero character)
        {
            int RegHP = 60;
            character.Regeneration(RegHP);
        }
        //Realization of special ability damage/heal
        public virtual void SpecialAbilityDPS(Character_enemy character)
        {
            Random rand = new Random();
            int SpecAttack = rand.Next(1, 121);
            character.GetDamage(SpecAttack);
        }
        public virtual void SpecialAbilityHeal(Character_hero character)
        {
            int SpecAttack = 60;
            character.Regeneration(SpecAttack);
        }
    }
}
