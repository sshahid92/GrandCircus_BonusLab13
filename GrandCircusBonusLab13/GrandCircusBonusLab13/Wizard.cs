using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusBonusLab13
{
    class Wizard : MagicUsingCharacter
    {
        public int SpellNumber { get; set; }

        public Wizard(string name, int strength, int intelligence, int magicalEnergy,
            int spellNumber) : base(name, strength, intelligence, magicalEnergy)
        {
            SpellNumber = spellNumber;
        }
        public override string Play()
        {
            string characterSHeet = $"Character Spell Number: {SpellNumber}\n";
            return base.Play() + characterSHeet;
        }

    }
}
