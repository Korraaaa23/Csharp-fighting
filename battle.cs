using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class battle
    {
        //StartFight 
        // war1 atttacks war2, war 2 is damaged and health decreases 
        // Get attack result
        // war2 atttacks war1, war 1 is damaged and health decreases 
        // Get attack result
        public static void StartFight(Warrior warrior1, Warrior warrior2)
        {
            while (true)
            {

                if (GetAttackResult(warrior1, warrior2) == "Game over")
                {
                    Console.WriteLine("Game over");
                    break;
                }

                if (GetAttackResult(warrior2, warrior1) == "Game over")
                {
                    Console.WriteLine("Game over");
                    break;
                }

            }
        }

        // Get attack result 

        public static string GetAttackResult(Warrior warriorA, Warrior warriorB) 
        {
            double warAAtckAmt = warriorA.Attack();
            double warBBlckAmt = warriorB.Block();

            double dmg2WarB = warAAtckAmt - warBBlckAmt;

            if (dmg2WarB > 0)
            {
                warriorB.Health = warriorB.Health - dmg2WarB;

            } else dmg2WarB = 0;

            Console.WriteLine("{0} Attacks {1} and Deals {2} Damage", warriorA.Name, warriorB.Name, dmg2WarB );

            Console.WriteLine("{0} has {1} Health\n", warriorB.Name, warriorB.Health);

            if (warriorB.Health <= 0)
            {
                Console.WriteLine("{0} has died and {1} is Victorious", warriorB.Name, warriorA.Name);

                return "Game over";
            }
            else return "Fight Again";
        }

    }
}
