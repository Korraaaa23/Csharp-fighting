using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Magicwarrior : Warrior
    {
        int teleportChance = 0;
        CanTeleport teleportType = new CanTeleport ();

        //constructor 
        public Magicwarrior(string name = "Warrior", double health = 0 , double attkMax = 0 , 
            double blckMax = 0 , int teleportChance = 0) : base(name, health, attkMax, blckMax)
        {
            this.teleportChance = teleportChance;
        }

        public override double Block()
        {
            Random rnd = new Random();
            int rndDodge = rnd.Next(1, 100);

            if (rndDodge < this.teleportChance) 
            {
                Console.WriteLine($"{Name} {teleportType.teleport()}");
                return 10000;
            } else
            {
                return base.Block();
            }
        }
    }
}
