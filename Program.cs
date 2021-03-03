using System;
using System.Threading;

namespace consoletest
{
    
    class Game : SentryRPGTools
    {

        public static void StartGame()
        {
            String title = @"

 _____ _                 _      
/  ___(_)               | |     
\ `--. _ _ __ ___  _ __ | | ___ 
 `--. \ | '_ ` _ \| '_ \| |/ _ \
/\__/ / | | | | | | |_) | |  __/
\____/|_|_| |_| |_| .__/|_|\___|
                  | |           
                  |_|           
  ___      _                 _                  
 / _ \    | |               | |                 
/ /_\ \ __| |_   _____ _ __ | |_ _   _ _ __ ___ 
|  _  |/ _` \ \ / / _ \ '_ \| __| | | | '__/ _ \
| | | | (_| |\ V /  __/ | | | |_| |_| | | |  __/
\_| |_/\__,_| \_/ \___|_| |_|\__|\__,_|_|  \___|";

            Console.ForegroundColor = ConsoleColor.Red;
            //this is the code for the title big man
            Console.WriteLine(title);
            Console.ResetColor();
            Console.WriteLine("By SamuraiWeebR");
            Console.WriteLine("This is A Very Basic Game.");
            Console.WriteLine("DISCLAIMER: This is game is really simple. i doubt you will enjoy it. \n do you accept the fact that this game could be quick or crap?");
            string userResponse = Console.ReadLine();

            //eula to tell someone to fuck off if they gonna judge
            if (userResponse== "Yes" || userResponse == "yes")
            {
                Console.WriteLine("Then enjoy the experience.");
            }
            else if (userResponse == "No" || userResponse == "no")
            {
                Console.WriteLine("Then Go Away.");
                Environment.Exit(5);
            }
            else if (userResponse == "Maybe"|| userResponse == "maybe")
            {
                Console.WriteLine("Make your mind up you fucking wanker");
            }
            else
            {
                Console.WriteLine("That doesn't look right. Answer must be yes/no");
                if (userResponse == "Yes" || userResponse == "yes")
                {
                    Console.WriteLine("Then enjoy the experience.");
                }
                else if (userResponse == "No" || userResponse == "no")
                {
                    Console.WriteLine("Then Go Away.");
                    SentryRPGTools.Quit();
                }
            }
            //here comes the fun part
            Console.WriteLine("What is your name?");
            string characterName = Console.ReadLine();
            Console.WriteLine("Your Name is " + characterName + "!");
            Console.WriteLine("What is your age?");
            int characterAge = Convert.ToInt32(Console.ReadLine());
            if (characterAge < 18)
            {
                Console.WriteLine("You can't be UnderAge!");
                return;
            }
            else if (characterAge > 18)
            {
                Console.WriteLine("Your Age is " + characterAge + "!");
            }
            //game starts now.
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Cyan;
            double eArmorToughness = 0.1;
            double cAttackDamage = 10.50 - eArmorToughness;
            double playerHP = 20.00;
            Console.WriteLine("You Enter the Temple, It's Walls shining a blue hue. 'my first quest' you thought, as you entered. what do you do?");
            string userAction = Console.ReadLine();
            if (userAction == "walk" || userAction == "run")
            {
                Console.WriteLine("you move deeper into the temple, when suddenly, a goblin appears! what will you do?");
            }
            userAction = Console.ReadLine();
            eArmorToughness = 2.5;

            SentryRPGTools.combat("Goblin", 20, 5, playerHP, cAttackDamage);
        }
    }
    class Item
    {
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            Game.StartGame();
            Console.WriteLine("The Game has Shut Down. If your seeing this, it probably crashed.");
            SentryRPGTools.Quit();
        }
    }
}
