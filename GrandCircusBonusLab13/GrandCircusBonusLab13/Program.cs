using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusBonusLab13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating my GameCharacter objects
            GameCharacter Dumbledore = new Wizard("Albus Percival Wulfric Brian Dumbledore", 50, 200, 10000, 1000);
            GameCharacter Harry = new Wizard("Harry \"Lucky Ass\" Potter", 15, 30, 300, 2);
            GameCharacter Sabrina = new Wizard("Sabrina The Teenage Witch", 25, 45, 500, 23);
            GameCharacter Kratos = new Warrior("Kratos, The Ghost of Sparta", 500, 200, "Blades of Chaos");
            GameCharacter James = new Warrior("James Bond", 50, 500, "Gun");
            //Adding them to a list of type<GameCharacter>
            List<GameCharacter> gameCharacters = new List<GameCharacter>
            {
                Dumbledore,
                Harry,
                Sabrina,
                James,
                Kratos
            };
            //Iterating through and executing .Play()
            Console.WriteLine("Check out all these characters!");
            foreach (GameCharacter player in gameCharacters)
            {
                Console.WriteLine(player.Play());
            }
            
            Console.ReadKey();

        }
    }
}
