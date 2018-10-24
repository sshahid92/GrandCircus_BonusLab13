using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusBonusLab13
{
    class GameCharacter
    {
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }

        public GameCharacter(string name, int strength, int intelligence)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
        }

        public virtual string Play()
        {
            string characterSHeet = $"Character Name: {Name}\n" +
                                    $"Character Strength: {Strength}\n" +
                                    $"Character Intelligence: {Intelligence}\n";
            return characterSHeet;
        }

    }
}
