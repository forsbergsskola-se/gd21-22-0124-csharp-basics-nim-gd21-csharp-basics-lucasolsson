using System.Drawing;

namespace System
{
    class program
    {
        static void Main()
        {
            string matches;
            int matchesamount = 24;
            matches = matchesamount.ToString("||||||||||||||||||||||||");
            Random randompick = new Random();
            Console.ForegroundColor = ConsoleColor.Cyan;

            void MatchControl(int changeMatch)
            {
                int zero = 0;
                matchesamount -= changeMatch;
                matches = "";

                while (zero < matchesamount)
                {
                    matches += "|";
                }
                
            }
            
            Console.WriteLine("Welcome to my very hard Nim-Game!");
            Console.WriteLine("You're competing against me, your computer. I have no life so i've played this game 100 million times.");
            Console.WriteLine("No one beats me in my game. Let's see if I will add you to my loser list.");
            Console.WriteLine("In this game you and me will take turns drawing matches.");
            Console.WriteLine("You can only draw 1, 2 or 3 matches at a time.");
            Console.WriteLine("The one who draws the last match loses, simple as that.");
            Console.WriteLine("We start with 24 matches. Good luck, you're going to need it.");
            Console.WriteLine(matches);
        } 
    }
}

