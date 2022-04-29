using System;
using System.Collections.Generic;
using System.Text;

namespace Practic2
{
    //Overriding the method 
    public class Mage : Character_hero
    {
        public override void SpecialAbilityHeal(Character_hero character)
        {
            base.SpecialAbilityHeal(character);
        }
        public override void SpecialAbilityDPS(Character_enemy character)
        {
            base.SpecialAbilityDPS(character);
        }
    }
}
