using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusBonusLab13
{
    class MagicUsingCharacter : GameCharacter
    {
        public int MagicalEnergy { get; set; }

        public MagicUsingCharacter(string name, int strength, int intelligence,
            int magicalEnergy) : base(name, strength, intelligence)
        {
            MagicalEnergy = magicalEnergy;
        }

        public override string Play()
        {
            string characterSHeet = $"Character Magical Energy: {MagicalEnergy}\n";
            return base.Play() + characterSHeet;
        }
    }
}
