using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace consoletest
{
    class SentryRPGTools
    {
        //Some variables I had to place here for combat to work....
        public static double cAttackRatio;
        public static double eAttackRatio;
        public static bool firstPhase = true;
        public static string userResponse;
        //Combat
        public static void combat(string eName, double eHealth, double eBaseAttack, double cHealth, double cBaseAttack)
        {
            if (firstPhase)
            {
                cAttackRatio = cHealth / eHealth;
                eAttackRatio = eHealth / cHealth;

                Console.Clear();
                Console.WriteLine("You've entered combat");
                Console.WriteLine("You're fighting a " + eName + " with " + eHealth + " HP");
                Thread.Sleep(1000);

                Console.Clear();
                Console.WriteLine("Your enemy has " + eHealth + " HP whileist you have " + cHealth + " HP");
                Console.WriteLine("What do you wish to do?");

                userResponse = Console.ReadLine();
                if (userResponse == "Attack" || userResponse == "attack")
                {
                    eHealth = eHealth - cBaseAttack;
                    Console.WriteLine("You attack " + eName + " for " + cBaseAttack + " damage to the " + eName + " now has " + eHealth + "HP left");
                    if (eHealth > 0)
                    {
                        cHealth = cHealth - eBaseAttack;
                        Console.WriteLine(eName + " attacks you for " + eBaseAttack + " damage. You have " + cHealth + " HP left");
                    }
                    if (cHealth > 0 || eHealth > 0)
                    {
                        if (eHealth < 0)
                        {
                            Console.WriteLine("You stand victorious");
                        }
                        else if (cHealth > 0)
                        {
                            firstPhase = false;
                            SentryRPGTools.combat(eName, eHealth, eBaseAttack, cHealth, cBaseAttack);
                        }
                    }
                    else
                    {
                        Thread.Sleep(1000);
                        Console.WriteLine("You are a fucking looser, you died to " + eName);
                        Console.WriteLine("If you want to retry you'll have to restart the game manually cuz we're too stupid to program that");
                    }
                }
            }
            else if (!firstPhase)
            {
                Console.Clear();
                Console.WriteLine("Your enemy has " + eHealth + " HP whileist you have " + cHealth + " HP");
                Console.WriteLine("What do you wish to do?");

                userResponse = Console.ReadLine();
                if (userResponse == "Attack" || userResponse == "attack")
                {
                    //Character attack calculation
                    double cAttack = cBaseAttack * ((cHealth / eHealth) / cAttackRatio);
                    eHealth = eHealth - cAttack;
                    Console.WriteLine("You attack " + eName + " for " + cAttack + " damage to the " + eName + " now has " + eHealth + "HP left");
                    if (eHealth > 0)
                    {
                        //Enemy attack calculation
                        double eAttack = eBaseAttack * ((eHealth / cHealth) / eAttackRatio);
                        cHealth = cHealth - eAttack;
                        Console.WriteLine(eName + " attacks you for " + eAttack + " damage. You have " + cHealth + " HP left");
                    }
                    if (cHealth > 0 || eHealth > 0)
                    {
                        if (eHealth < 0)
                        {
                            Console.WriteLine("You stand victorious");
                        }
                        else if (cHealth > 0)
                        {
                            firstPhase = false;
                            SentryRPGTools.combat(eName, eHealth, eBaseAttack, cHealth, cBaseAttack);
                        }
                    }
                    else
                    {
                        Thread.Sleep(1000);
                        Console.WriteLine("You are a fucking looser, you died to " + eName);
                        Console.WriteLine("If you want to retry you'll have to restart the game manually cuz we're too stupid to program that");
                    }
                }
            }
        }

        public static void LoadingBar(int lineNr, int loadingDelay)
        {
            Console.Write("Oooooooooooooooo");
            Console.SetCursorPosition(1, lineNr);
            Thread.Sleep(loadingDelay);
            Console.Write("oOoooooooooooooo");
            Console.SetCursorPosition(1, lineNr);
            Thread.Sleep(loadingDelay);
            Console.Write("ooOooooooooooooo");
            Console.SetCursorPosition(1, lineNr);
            Thread.Sleep(loadingDelay);
            Console.Write("oooOoooooooooooo");
            Console.SetCursorPosition(1, lineNr);
            Thread.Sleep(loadingDelay);
            Console.Write("ooooOooooooooooo");
            Console.SetCursorPosition(1, lineNr);
            Thread.Sleep(loadingDelay);
            Console.Write("oooooOoooooooooo");
            Console.SetCursorPosition(1, lineNr);
            Thread.Sleep(loadingDelay);
            Console.Write("ooooooOooooooooo");
            Console.SetCursorPosition(1, lineNr);
            Thread.Sleep(loadingDelay);
            Console.Write("oooooooOoooooooo");
            Console.SetCursorPosition(1, lineNr);
            Thread.Sleep(loadingDelay);
            Console.Write("ooooooooOooooooo");
            Console.SetCursorPosition(1, lineNr);
            Thread.Sleep(loadingDelay);
            Console.Write("oooooooooOoooooo");
            Console.SetCursorPosition(1, lineNr);
            Thread.Sleep(loadingDelay);
            Console.Write("ooooooooooOooooo");
            Console.SetCursorPosition(1, lineNr);
            Thread.Sleep(loadingDelay);
            Console.Write("oooooooooooOoooo");
            Console.SetCursorPosition(1, lineNr);
            Thread.Sleep(loadingDelay);

        }

        public static void Quit()
        {
            Environment.Exit(0);
            return;
        }
    }
}
