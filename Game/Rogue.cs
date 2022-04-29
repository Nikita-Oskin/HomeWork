using System;
using System.Collections.Generic;
using System.Text;

namespace Practic2
{
    //Overriding the method 
    public class Rogue : Character_enemy
    {
        public override void SpecialAbilityHeal(Character_enemy character)
        {
            base.SpecialAbilityHeal(character);
        }
        public override void SpecialAbilityDPS(Character_hero character)
        {
            base.SpecialAbilityDPS(character);
        }
    }
}
