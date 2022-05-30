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
            //add some fancy color
            Console.ForegroundColor = ConsoleColor.Cyan;

            void MatchControl(int changeMatch)
            {
                int zero = 0;
                matchesamount -= changeMatch;
                matches = "";

                while (zero < matchesamount)
                {
                    matches += "|";
                    ++zero;
                }
            }
            
            //Instructions
            Console.WriteLine("Welcome to my very hard Nim-Game!");
            Console.WriteLine("You're competing against me, your computer. I have no life so i've played this game 100 million times.");
            Console.WriteLine("No one beats me in my game. Let's see if I will add you to my loser list.");
            Console.WriteLine("In this game you and me will take turns drawing matches.");
            Console.WriteLine("You can only draw 1, 2 or 3 matches at a time.");
            Console.WriteLine("The one who draws the last match loses, simple as that.");
            Console.WriteLine("We start with 24 matches. Good luck, you're going to need it.");
            Console.WriteLine(matches);
            
            // playAgain:// tried using a goto loop to play the Nim game again but didn't get it to work
            
            // The main game loop
            while (matchesamount != 100)
            {
                //Check if game is over
                if (matchesamount == 1) goto lose;
                else if (matchesamount <= 0) goto win;
                
                //Player turn
                Console.WriteLine("Do you want to draw 1, 2 or 3 matches?");
                wrongMessage:
                int changeMatch = Convert.ToInt32(Console.ReadLine());
                if (changeMatch > 3 || changeMatch < 1)
                {
                    Console.WriteLine("please only type 1, 2 or 3");
                    goto wrongMessage;
                }
                MatchControl(changeMatch);
                Console.WriteLine($"You drew {changeMatch} matches,");
                Console.WriteLine(matches);
                
                //Check if game is over
                if (matchesamount == 1) goto win;
                else if (matchesamount <= 0) goto lose;
                
                //Ai turn
                int aiNum = randompick.Next(1, 4);
                changeMatch = aiNum;
                MatchControl(changeMatch);
                Console.WriteLine($"The ai drew {changeMatch} matches,");
                Console.WriteLine(matches);
            }
            
            //Game over state
            win: Console.WriteLine("Well okay, you won congrats...");
            Console.WriteLine("Now challenge me again");
            // goto playAgain;
            return;
            lose: 
            Console.WriteLine("Haha I win, you lose");
            Console.WriteLine("Now challenge me again");
            // goto playAgain;
        } 
    }
}

