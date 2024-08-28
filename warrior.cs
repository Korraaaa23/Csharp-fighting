using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Warrior
    {
        public string Name { get; set; }    
        public double Health { get; set; }  
        public double AttkMax { get; set; }
        public double BlckMax { get; set; }

        Random rnd = new Random();

        //constructor

        public Warrior (string name = "Warrior", double health = 0, double attkMax = 0 , double blckMax = 0)
        {
            Name = name;
            Health = health;
            AttkMax = attkMax;
            BlckMax = blckMax;
           
        }

        // to generate a random attack amount
        public double Attack()
        {
            return rnd.Next(1,(int)AttkMax);
        }
        public virtual double Block()
        {
            return rnd.Next(1, (int)BlckMax);
        }
    }
}
