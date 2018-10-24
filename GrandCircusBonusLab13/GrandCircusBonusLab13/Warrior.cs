using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusBonusLab13
{
    class Warrior : GameCharacter
    {
        public string WeaponType { get; set; }

        public Warrior(string name, int strength, int intelligence,
            string weaponType) : base(name, strength, intelligence)
        {
            WeaponType = weaponType;
        }

        public override string Play()
        {
            string characterSHeet = $"Character Weapon Type: {WeaponType}\n";
            return base.Play() + characterSHeet;
        }
    }

    
}
