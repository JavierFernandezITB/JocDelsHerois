
using System;
using Menu;
using Heroes;
using Utils;
using Messages;

namespace JocDelsHeroisNamespace
{
    public class JocDelsHeroisMainClass
    {
        public static void Main()
        {

            const int MaxTries = 3;
            int CurrentMenuTries = 1;

            bool exitMainMenu = false;
            bool startMainGame = false;

            while (!exitMainMenu)
            {
                int choice;
                Console.WriteLine(MessagesList.MainMenuWelcomeMessage);
                Console.WriteLine(MessagesList.MainMenuOptionsMessage);
                choice = Convert.ToInt32(Console.ReadLine());
                while (!UtilsHandler.IsInRange(choice, 0, 1) && CurrentMenuTries < MaxTries)
                {
                    CurrentMenuTries++;
                    Console.Clear();
                    Console.WriteLine(MessagesList.MainMenuErrorNotInRange);
                    Console.WriteLine(MessagesList.MainMenuOptionsMessage);
                    choice = Convert.ToInt32(Console.ReadLine());
                }

                if (choice == 1)
                    startMainGame = true;
                else if (CurrentMenuTries >= MaxTries)
                    Console.WriteLine(MessagesList.ErrorNoTriesLeft);

                exitMainMenu = true;
            }
        }
    }
}