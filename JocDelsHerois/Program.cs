
using Heroes;
using Utils;
using Messages;

namespace JocDelsHeroisNamespace
{
    public class JocDelsHeroisMainClass
    {
        public static void Main()
        {
            string[] StatsName = { "VIDA", "DAÑO", "REDUCCIÓN DE DAÑO" };

            string[] CharacterNames = { "ARQUERA", "BARBARO", "MAGO", "DRUIDA", "MONSTRUO" };

            string archerName;
            string barbarianName;
            string mageName;
            string druidName;
            string monsterName;

            int[] archerStats = { 0, 0, 0 };
            int[] barbarianStats = { 0, 0, 0 };
            int[] mageStats = { 0, 0, 0 };
            int[] druidStats = { 0, 0, 0 };
            int[] monsterStats = { 0, 0, 0 };

            int[][] charactersStats = { archerStats, barbarianStats, mageStats, druidStats, monsterStats };

            int[] archerHealthRange = { 1500, 2000 };
            int[] barbarianHealthRange = { 3000, 3750 };
            int[] mageHealthRange = { 1100, 1500 };
            int[] druidHealthRange = { 2000, 2500 };
            int[] monsterHealthRange = { 7000, 10000 };

            int[] archerDamageRange = { 200, 300 };
            int[] barbarianDamageRange = { 150, 250 };
            int[] mageDamageRange = { 300, 400 };
            int[] druidDamageRange = { 70, 120 };
            int[] monsterDamageRange = { 300, 400 };

            int[] archerReductionRange = { 25, 35 };
            int[] barbarianReductionRange = { 35, 45 };
            int[] mageReductionRange = { 20, 35 };
            int[] druidReductionRange = { 25, 40 };
            int[] monsterReductionRange = { 20, 30 };

            int[][] characterStatsRanges =
            {
                archerHealthRange, archerDamageRange, archerReductionRange,
                barbarianHealthRange, barbarianDamageRange, barbarianReductionRange,
                mageHealthRange, mageDamageRange, mageReductionRange,
                druidHealthRange, druidDamageRange, druidReductionRange,
                monsterHealthRange, monsterDamageRange, monsterReductionRange
            };

            const int MaxTries = 3;
            int CurrentMenuTries = 1;
            int choice;

            bool exitMainMenu = false;
            bool startMainGame = false;
            bool exitDifficultySelection = false;

            while (!exitMainMenu)
            {
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

            if (startMainGame)
            {
                CurrentMenuTries = 0;
                while (!exitDifficultySelection)
                {
                    Console.WriteLine(MessagesList.DifficultySelectionMessage);
                    Console.WriteLine(MessagesList.DifficultySelectionOptions);
                    choice = Convert.ToInt32(Console.ReadLine());
                    while (!UtilsHandler.IsInRange(choice, 1, 4) && CurrentMenuTries < MaxTries)
                    {
                        CurrentMenuTries++;
                        Console.Clear();
                        Console.WriteLine(MessagesList.MainMenuErrorNotInRange);
                        Console.WriteLine(MessagesList.DifficultySelectionOptions);
                        choice = Convert.ToInt32(Console.ReadLine());
                    }

                    if (CurrentMenuTries >= MaxTries)
                        Console.WriteLine(MessagesList.ErrorNoTriesLeft);
                    else
                        switch (choice)
                        {
                            case 1:
                                for (int i = 0; i < 4; i++)
                                {
                                    for (int x = 0; x < 3; x++)
                                    {
                                        HeroesHandler.SetStat(ref charactersStats[i][x], characterStatsRanges[(i * 3) + x][1]);
                                    }
                                }
                                HeroesHandler.SetStat(ref charactersStats[4][0], monsterHealthRange[0]);
                                HeroesHandler.SetStat(ref charactersStats[4][1], monsterDamageRange[0]);
                                HeroesHandler.SetStat(ref charactersStats[4][2], monsterReductionRange[0]);
                                break;
                            case 2:
                                for (int i = 0; i < 4; i++)
                                {
                                    for (int x = 0; x < 3; x++)
                                    {
                                        HeroesHandler.SetStat(ref charactersStats[i][x], characterStatsRanges[(i * 3) + x][0]);
                                    }
                                }
                                HeroesHandler.SetStat(ref charactersStats[4][0], monsterHealthRange[1]);
                                HeroesHandler.SetStat(ref charactersStats[4][1], monsterDamageRange[1]);
                                HeroesHandler.SetStat(ref charactersStats[4][2], monsterReductionRange[1]);
                                break;
                            case 3:
                                int selection;
                                int currentStatTries;
                                for (int i = 0; i < 5; i++)
                                {
                                    for (int x = 0; x < 3; x++)
                                    {
                                        currentStatTries = 0;
                                        do
                                        {
                                            Console.WriteLine(MessagesList.DifficultyCustomChangeStat, StatsName[x], CharacterNames[i], characterStatsRanges[(i * 3) + x][0], characterStatsRanges[(i * 3) + x][1]);
                                            selection = Convert.ToInt32(Console.ReadLine());
                                            if (!UtilsHandler.IsInRange(selection, characterStatsRanges[(i * 3 ) + x][0], characterStatsRanges[(i * 3) + x][1]))
                                                currentStatTries++;
                                        } while (!UtilsHandler.IsInRange(selection, characterStatsRanges[(i * 3) + x][0], characterStatsRanges[(i * 3) + x][1]) && currentStatTries < MaxTries);

                                        if (currentStatTries >= MaxTries)
                                            selection = characterStatsRanges[(i * 3) + x][0];

                                        HeroesHandler.SetStat(ref charactersStats[i][x], selection);
                                    }
                                }
                                break;
                            case 4:
                                for (int i = 0; i < 5; i++)
                                {
                                    for (int x = 0; x < 3; x++)
                                    {
                                        HeroesHandler.SetStat(ref charactersStats[i][x], UtilsHandler.GenRandomNumber(characterStatsRanges[(i * 3) + x][0], characterStatsRanges[(i * 3) + x][1]));
                                    }
                                }
                                break;
                        }

                    exitDifficultySelection = true;
                }
            }
        }
    }
}