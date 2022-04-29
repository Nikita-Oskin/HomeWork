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
////PLAYER VS PLAYER
//public class PersVsPers
//{
//    public void PVP()
//    {
//        PlayerActionsHero choose1 = new PlayerActionsHero();
//        choose1.CreateCharacterHero();
//        PlayerActionsEnemy choose2 = new PlayerActionsEnemy();
//        choose2.CreateCharacterEnemy();

//        Console.WriteLine("\nThe PVP battle has begun!");

//        while (true)
//        {
//            Console.WriteLine("Damage to Player_1");
//            choose2.SelectActionsEnemy(choose1);
//            if (choose1.HealthHero <= 0)
//            {
//                break;
//            }

//            Console.WriteLine($"Player's_1 current health: {choose1.HealthHero}");
//            Console.WriteLine();

//            System.Threading.Thread.Sleep(1000);

//            Console.WriteLine("Damage to Player_2");
//            choose1.SelectActionsHero(choose2);
//            if (choose2.HealthEnemy <= 0)
//            {
//                break;
//            }

//            Console.WriteLine($"Player's_2 current health): {choose2.HealthEnemy}");
//            Console.WriteLine();

//            System.Threading.Thread.Sleep(1000);
//        }

//        Console.ReadKey();
//    }

//}
//// Player VS BOT
//public class PersVsBot
//{
//    public void PVB()
//    {
//        PlayerActionsHero choose1 = new PlayerActionsHero();
//        choose1.CreateCharacterHero();
//        PlayerActionsEnemy choose2 = new PlayerActionsEnemy();
//        choose2.CreateCharacterEnemy();

//        Console.WriteLine("\nThe PVB battle has begun!");

//        while (true)
//        {
//            Console.WriteLine("Damage to Player");
//            choose2.BOTSelectActionsEnemy(choose1);
//            if (choose1.HealthHero <= 0)
//            {
//                break;
//            }

//            Console.WriteLine($"Player's current health: {choose1.HealthHero}");
//            Console.WriteLine();

//            System.Threading.Thread.Sleep(1000);

//            Console.WriteLine("Damage to Bot");
//            choose1.SelectActionsHero(choose2);
//            if (choose2.HealthEnemy <= 0)
//            {
//                break;
//            }

//            Console.WriteLine($"Bot's current health): {choose2.HealthEnemy}");
//            Console.WriteLine();

//            System.Threading.Thread.Sleep(1000);
//        }

//        Console.ReadKey();
//    }
//}
//// BOT VS BOT

//public class BotVsBot
//{ 
//    public void BVB()
//    {
//        PlayerActionsHero choose1 = new PlayerActionsHero();
//        choose1.CreateCharacterHero();

//        PlayerActionsEnemy choose2 = new PlayerActionsEnemy();
//        choose2.CreateCharacterEnemy();

//        Console.WriteLine("\nThe BVB battle has begun!");

//        while (true)
//        {
//            Console.WriteLine("Damage to Bot_1");
//            choose2.BOTSelectActionsEnemy(choose1);
//            if (choose1.HealthHero <= 0)
//            {
//                break;
//            }

//            Console.WriteLine($"Bot's_1 current health: {choose1.HealthHero}");
//            Console.WriteLine();

//            System.Threading.Thread.Sleep(1000);

//            Console.WriteLine("Damage to Bot_2");
//            choose1.BOTSelectActionsHero(choose2);
//            if (choose2.HealthEnemy <= 0)
//            {
//                break;
//            }

//            Console.WriteLine($"Bot's_2 current health): {choose2.HealthEnemy}");
//            Console.WriteLine();

//            System.Threading.Thread.Sleep(1000);
//        }

//        Console.ReadKey();
//    }
//}

//public class Character_enemy
//{
//    //Creating an enemy
//    public Character_enemy CreateCharacterEnemy()
//    {
//        Console.WriteLine("\nChoose an enemy");
//        Console.WriteLine("Available Enemies:\n1.Warlock\n2.Rogue\n3.Death King");

//        int race_enemy = Convert.ToInt32(Console.ReadLine());
//        Character_enemy character_enemy = new Character_enemy();

//        switch (race_enemy)
//        {
//            case 1:
//                Console.WriteLine("\nYour class is Warlock");
//                character_enemy = new Warlock();
//                break;
//            case 2:
//                Console.WriteLine("\nYour class is Rogue");
//                character_enemy = new Rogue();
//                break;
//            case 3:
//                Console.WriteLine("\nYour class is Death King");
//                character_enemy = new Death_King();
//                break;
//        }

//        return character_enemy;
//    }
//    public int HealthEnemy { get; private set; }
    
//    public Character_enemy()
//    {
//        HealthEnemy = 550;
//    }
//    //Realization of normal damage
//    public virtual void GetDamage(int damage)
//    {
//        HealthEnemy -= damage;
//        Console.WriteLine($"Enemy took damage: {damage}");
//        if (HealthEnemy < 1)
//        {
//            Console.WriteLine("The enemy is dead");
//        }
//    }
//    public void NormalAttackEnemy(Character_hero character)
//    {
//        int AttackEnemy = 55;
//        character.GetDamage(AttackEnemy);
//    }
//    //Realization of normal heal
//    public virtual void Regeneration(int heal)
//    {
//        HealthEnemy += heal;
//        Console.WriteLine($"Enemy restored health: {heal}");
//    }
//    public void RegenerationHealthEnemy(Character_enemy character)
//    {
//        int RegHP = 60;
//        character.Regeneration(RegHP);
//    }
//    //Realization of special ability dagame/heal
//    public virtual void SpecialAbilityDPS(Character_hero character)
//    {
//        Random rand = new Random();
//        int SpecAttack = rand.Next(1, 121);
//        character.GetDamage(SpecAttack);
//    }

//    public virtual void SpecialAbilityHeal(Character_enemy character)
//    {
//        int SpecAttack = 60;
//        character.Regeneration(SpecAttack);
//    }

//}

// public class Character_hero
// {
//    //Creating a Hero
//    public Character_hero CreateCharacterHero()
//    {
//        Console.WriteLine("\nChoose a hero");
//        Console.WriteLine("Available Heroes:\n1.Warrior\n2.Mage\n3.Monk");

//        int race_hero = Convert.ToInt32(Console.ReadLine());
//        Character_hero character_hero = new Character_hero();

//        switch (race_hero)
//        {
//            case 1:
//                Console.WriteLine($"\nYour class is Warrior");
//                character_hero = new Warrior();
//                break;
//            case 2:
//                Console.WriteLine($"\nYour class is Mage");
//                character_hero = new Mage();
//                break;
//            case 3:
 
//                Console.WriteLine($"\nYour class is Monk");
//                character_hero = new Monk();
//                break;
//        }

//        return character_hero;
//    }
//    public int HealthHero { get; private set; }
//    public Character_hero()
//    {
//        HealthHero = 550;
//    }
//    //Realization of normal damage
//    public virtual void GetDamage(int damage)
//    {
//        HealthHero -= damage;
//        Console.WriteLine($"Hero took damage: {damage}");
//        if (HealthHero < 1)
//        {
//            Console.WriteLine($"The hero died");
//        }
//    }
//    public void NormalAttackHero(Character_enemy character)
//    {
//        int AttackHero = 55;
//        character.GetDamage(AttackHero);
//    }
//    //Realization of normal heal
//    public virtual void Regeneration(int heal)
//    {
//        HealthHero += heal;
//        Console.WriteLine($"Hero is restored to health: {heal}");
//    }
//    public void RegenerationHealthHero(Character_hero character)
//    {
//        int RegHP = 60;
//        character.Regeneration(RegHP);
//    }
//    //Realization of special ability damage/heal
//    public virtual void SpecialAbilityDPS(Character_enemy character)
//    {
//        Random rand = new Random();
//        int SpecAttack = rand.Next(1, 121);
//        character.GetDamage(SpecAttack);
//    }
//    public virtual void SpecialAbilityHeal(Character_hero character)
//    {
//        int SpecAttack = 60;
//        character.Regeneration(SpecAttack);
//    }
//}

////Overriding the method 
//public class Warrior : Character_hero
//{
//    public override void SpecialAbilityHeal(Character_hero character)
//    {
//        base.SpecialAbilityHeal(character);
//    }
//    public override void SpecialAbilityDPS(Character_enemy character)
//    {
//        base.SpecialAbilityDPS(character);
//    }
//}
////Overriding the method 
//public class Mage : Character_hero
//{
//    public override void SpecialAbilityHeal(Character_hero character)
//    {
//        base.SpecialAbilityHeal(character);
//    }
//    public override void SpecialAbilityDPS(Character_enemy character)
//    {
//        base.SpecialAbilityDPS(character);
//    }
//}
////Overriding the method 
//public class Monk : Character_hero
//{
//    public override void SpecialAbilityHeal(Character_hero character)
//    {
//        base.SpecialAbilityHeal(character);
//    }
//    public override void SpecialAbilityDPS(Character_enemy character)
//    {
//        base.SpecialAbilityDPS(character);
//    }
//}
////Overriding the method 
//public class Rogue : Character_enemy
//{
//    public override void SpecialAbilityHeal(Character_enemy character)
//    { 
//        base.SpecialAbilityHeal(character);
//    }
//    public override void SpecialAbilityDPS(Character_hero character)
//    {
//        base.SpecialAbilityDPS(character);
//    }
//}
////Overriding the method 
//public class Warlock : Character_enemy
//{
//    public override void SpecialAbilityHeal(Character_enemy character)
//    {
//        base.SpecialAbilityHeal(character);
//    }
//    public override void SpecialAbilityDPS(Character_hero character)
//    {
//        base.SpecialAbilityDPS(character);
//    }
//}
////Overriding the method 
//public class Death_King : Character_enemy
//{
//    public override void SpecialAbilityHeal(Character_enemy character)
//    {
//        base.SpecialAbilityHeal(character);
//    }
//    public override void SpecialAbilityDPS(Character_hero character)
//    {
//        base.SpecialAbilityDPS(character);
//    }
//}

////Hero Actions
//public class PlayerActionsHero : Character_hero
//{
//    public void SelectActionsHero(Character_enemy character)
//    {
//        Console.WriteLine("What do you want to use?");
//        Console.WriteLine("\n1. Normal attack - stable damage");
//        Console.WriteLine("\n2. Special ability Damage - random damage");
//        Console.WriteLine("\n3. Special ability Heal - random heal");
//        Console.WriteLine("\n4. Regeneration HP - health recovery");

//        int player = Convert.ToInt32(Console.ReadLine());

//        if (player == 1)
//        {
//            NormalAttackHero(character);
//            Console.WriteLine("You used a normal attack");
//        }
//        else if (player == 2)
//        {
//            SpecialAbilityDPS(character);
//            Console.WriteLine("You used a special ability: Damage");
//        }
//        else if (player == 3)
//        {
//            RegenerationHealthHero(this);
//            Console.WriteLine("You used a special ability: Heal");
//        }
//        else if (player == 4)
//        {
//            RegenerationHealthHero(this);
//        }
//        else if (player < 1 || player > 5)
//        {
//            Console.WriteLine("You entered the wrong one");
//        }

//    }
//    //Hero_bot actions
//    public void BOTSelectActionsHero(Character_enemy character)
//    {
//        Random rand = new Random();
//        int num = rand.Next(1, 5);
//        int player = num;

//        if (player == 1)
//        {
//            NormalAttackHero(character);
//            Console.WriteLine("You used a normal attack");
//        }
//        else if (player == 2)
//        {
//            SpecialAbilityDPS(character);
//            Console.WriteLine("You used a special ability: Damage");
//        }
//        else if (player == 3)
//        {
//            RegenerationHealthHero(this);
//            Console.WriteLine("You used a special ability: Heal");
//        }
//        else if (player == 4)
//        {
//            RegenerationHealthHero(this);
//        }
//    }
//}
////Enemy actions
//public class PlayerActionsEnemy : Character_enemy
//{
//    public void SelectActionsEnemy(Character_hero character)
//    {
//        Console.WriteLine("What do you want to use?");
//        Console.WriteLine("\n1. Normal attack - stable damage");
//        Console.WriteLine("\n2. Special ability Damage - random damage");
//        Console.WriteLine("\n3. Special ability Heal - random heal");
//        Console.WriteLine("\n4. Regeneration HP - health recovery");

//        int player = Convert.ToInt32(Console.ReadLine());

//        if (player == 1)
//        {
//            NormalAttackEnemy(character);
//            Console.WriteLine("You used a normal attack");
//        }
//        else if (player == 2)
//        {
//            SpecialAbilityDPS(character);;
//           Console.WriteLine("You used a special ability: Damage");
//        }
//        else if (player == 3)
//        {
//            SpecialAbilityHeal(this);
//            Console.WriteLine("You used a special ability: Heal");
//        }
//        else if(player == 4)
//        {
//            RegenerationHealthEnemy(this);
//        }    
//        else if (player < 1 || player > 5)
//        {
//            Console.WriteLine("You entered the wrong one");
//        }
//    }
//    // Enemy_bot actions
//    public void BOTSelectActionsEnemy(Character_hero character)
//    {
//        Random rand = new Random();
//        int num = rand.Next(1, 5);
//        int player = num;

//        if (player == 1)
//        {
//            NormalAttackEnemy(character);
//            Console.WriteLine("You used a normal attack");
//        }
//        else if (player == 2)
//        {
//            SpecialAbilityDPS(character); ;
//            Console.WriteLine("You used a special ability: Damage");
//        }
//        else if (player == 3)
//        {
//            SpecialAbilityHeal(this);
//            Console.WriteLine("You used a special ability: Heal");
//        }
//        else if (player == 4)
//        {
//            RegenerationHealthEnemy(this);
//        }
//    }
//}