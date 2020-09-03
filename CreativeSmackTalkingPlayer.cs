using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        private readonly List<string> Taunts;

        public override int Roll()
        {
            int num = new Random().Next(Taunts.Count)-1;
            Console.WriteLine(Taunts[num]);
            // Return a random number between 1 and DiceSize
            return new Random().Next(DiceSize) + 1;
        }
        public CreativeSmackTalkingPlayer(string t1, string t2, string t3)
        {
            Taunts = new List<string>(){
                t1, t2, t3
            };
        }

    }
}