using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player that throws an exception when they lose to the other player
    // Where might you catch this exception????
    public class SoreLoserPlayer : Player
    {
        public override void Play(Player other)
        {
            // Call roll for "this" object and for the "other" object
            int myRoll = Roll();
            int otherRoll = other.Roll();
            

            Console.WriteLine($"{Name} rolls a {myRoll}");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");
            // try{
            //     //Console.WriteLine(myRoll > otherRoll ? $"{Name} Wins TRY TRY TRY " : $"{parse(40, 0)} TRY TRY TRY ERROR");
            //     if(myRoll > otherRoll)
            //     {
            //         Console.WriteLine("Win");
            //     }
            //     else
            //     {
            //         throw new Exception("YOU CHEATED");
            //     }
            // }
            // catch
            // {

            //     Console.WriteLine(myRoll == otherRoll ? "Its a  Tie...CATCH WORKS???" : $"{other.Name} is the KINGGG!!!!!");
            // }
           

            if(myRoll > otherRoll)
                {
                    Console.WriteLine("Win");
                }
                else
                {
                    throw new Exception("YOU CHEATED");
                }
        }
        static string parse(int num, int num2)
        {
            int num3 = num / num2;
            return num.ToString();
        }
    }
}