using ConsoleApp1;
using ConsoleApp9;
using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;

namespace ConsoleApp1
{
    public class Program
    {
        //-------- FUNCTIONS START-------

        //--------- FUNCTIONS END---------

        static void Main(string[] args)
        {
            // define thor thor = new warrior("Thor", 100, 26,10) (name, total health ,
            // how much damage can he give,how much can he block)
            Warrior thor = new Warrior("Thor", 100, 26, 10);
            //hulk = new warrior("hulk", 100, 26,10) the adeed 50 at the end is the probability of teleportation 
            Magicwarrior loki = new Magicwarrior("Loki", 75, 20, 10,50);
            // battle.StartFight(thor, hulk);
            battle.StartFight(thor, loki);
        }


    }
}









/* 
             Thor attacks hulk and deals 74 damage 
            Maximus has 69 health

            hulk attacks thor and deals 6 damage 
            bob has 6 health 

            thor attacks hulk and deals 48 damage
            maximus has 21 health 

            hulk attacks thor and deals 48 damage 
            bob has -42 health 

            thor has died and hulk is victorious 

            Game over
             
            */