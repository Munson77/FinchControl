using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FinchControl
{
    //************************************
    //Title: Finch Control
    //Application Type: Console
    //Description: (describe the purpose and function)
    //Author: Victoria Munson
    //Date Created: 5/25/2020
    //Last Modified:
    //************************************
    class Program
    {

        /// <param name="args"></param>
        static void Main(string[] args)
        {

            DisplayWelcomeScreen();
            DisplayMenuScreen();
            DisplayClosingScreen();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;
        }

        private static void DisplayClosingScreen()
        {
            throw new NotImplementedException();
        }

        private static void DisplayWelcomeScreen()
        {
            throw new NotImplementedException();
        }



        //Main Menu

        static void DisplayMenuScreen()
        {
            Console.CursorVisible = true;

            bool quitApplication = false;
            string menuChoice;

            Finch finchRobot = new Finch();

            do
            {
                DisplayScreenHeader("Main Menu");


                // get user menu choice

                Console.WriteLine("\ta) Connect Finch Robot");
                Console.WriteLine("\tb) Talent Show");

                menuChoice = Console.ReadLine().ToLower();

                // process user menu choice

                switch (menuChoice)
                {
                    case "a":
                        DisplayConnectFinchRobot(finchRobot);
                        break;

                    case "b":
                        DisplayTalentShowMenuScreen(finchRobot);
                        break;

                    case "c":

                        break;

                    case "d":

                        break;

                    case "e":

                        break;

                    case "f":
                        DisplayDisconnectFinchRobot(finchRobot);
                        break;

                    case "q":
                        DisplayDisconnectFinchRobot(finchRobot);
                        quitApplication = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a letter for the menu choice.");
                        DisplayContinuePrompt();
                        break;
                }

            } while (!quitApplication);
        }

        private static void DisplayConnectFinchRobot(Finch finchRobot)
        {
            throw new NotImplementedException();
        }

        private static void DisplayDisconnectFinchRobot(Finch finchRobot)
        {
            if (finchRobot is null)
            {
                throw new ArgumentNullException(nameof(finchRobot));
            }

            throw new NotImplementedException();
        }

        private static void DisplayContinuePrompt()
        {
            throw new NotImplementedException();
        }

        private static void DisplayScreenHeader(string v)
        {
            throw new NotImplementedException();
        }


        //Talent Show Menu                          

        static void DisplayTalentShowMenuScreen(Finch myFinch)
        {
            Console.CursorVisible = true;
            bool quitTalentShowMenu = false;
            string menuChoice;
            do
            {
                DisplayScreenHeader("Talent Show Menu");
                // get user menu choice
                Console.WriteLine("\ta) Light and Sound");
                Console.WriteLine("\tb) ");
                Console.WriteLine("\tc) ");
                Console.WriteLine("\td) ");
                Console.WriteLine("\tq) Main Menu");
                Console.Write("\t\tEnter Choice:");
                menuChoice = Console.ReadLine().ToLower();

                switch (menuChoice)
                {
                    case "a":
                        DisplayLightAndSound(myFinch);
                        break;

                    case "b":

                        break;

                    case "c":

                        break;

                    case "d":

                        break;

                    case "q":
                        quitTalentShowMenu = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a letter for the menu choice.");
                        DisplayContinuePrompt();
                        break;
                }

            } while (!quitTalentShowMenu);
        }

        //Talent Show / Light and Sound                   

        static void DisplayLightAndSound(Finch finchRobot)
        {
            Console.CursorVisible = false;

            DisplayScreenHeader("Light and Sound");

            Console.WriteLine("\tThe Finch robot will not show off its glowing talent!");
            DisplayContinuePrompt();

            for (int lightSoundLevel = 0; lightSoundLevel < 255; lightSoundLevel++)
            {
                object p = finchRobot.setLED(lightSoundLevel, lightSoundLevel, lightSoundLevel);
                finchRobot.noteOn(lightSoundLevel * 100);
            }
            DisplayMenuPrompt("Talent Show Menu");
        }

        private static void DisplayMenuPrompt(string v)
        {
            throw new NotImplementedException();
        }
    }
}