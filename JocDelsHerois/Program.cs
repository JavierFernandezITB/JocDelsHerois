
using Heroes;
using Utils;
using Messages;
using System.Security.Cryptography;

namespace JocDelsHeroisNamespace
{
    public class JocDelsHeroisMainClass
    {
        public static void Main()
        {
            string[] StatsName = { "VIDA", "DAÑO", "REDUCCIÓN DE DAÑO" };

            string[] CharacterNames = { "ARQUERA", "BARBARO", "MAGO", "DRUIDA", "MONSTRUO" };
            string[] customNames = { };

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
            bool exitNameCreation = false;
            bool exitBattleStage = false;

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
                    Console.Clear();
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
                    {
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
                                            if (!UtilsHandler.IsInRange(selection, characterStatsRanges[(i * 3) + x][0], characterStatsRanges[(i * 3) + x][1]))
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
                    }

                    exitDifficultySelection = true;
                }

                CurrentMenuTries = 0;
                while (!exitNameCreation)
                {
                    Console.Clear();
                    do
                    {
                        
                        Console.WriteLine(MessagesList.NameSelectionPrompt);
                        customNames = Console.ReadLine().Split(", ");
                        if (!UtilsHandler.CheckValidNames(customNames))
                            CurrentMenuTries++;
                    } while (!UtilsHandler.CheckValidNames(customNames) && CurrentMenuTries < MaxTries);

                    if (CurrentMenuTries >= MaxTries)
                        Console.WriteLine(MessagesList.ErrorNoTriesLeft);

                    exitNameCreation = true;
                }

                bool isKnocked = false;
                int knockedTurns = 0;
                int oldDefense = charactersStats[1][2];
                int maxDefenseTurns = 0;

                while (!exitBattleStage)
                {
                    int[] turnsDone = { -1, -1, -1, -1 };
                    bool[] isProtected = { false, false, false, false };
                    int turns = 0;
                    do
                    {
                        Console.Clear();
                        int randomTurn = UtilsHandler.GenRandomNumber(0, 3);
                        int currentCharacterTries = 0;

                        if (!HeroesHandler.IsDead(charactersStats, randomTurn) && !UtilsHandler.FindInArray(turnsDone, randomTurn))
                        {
                            HeroesHandler.DisplayFightStats(charactersStats, customNames, CharacterNames);
                            Console.WriteLine("Turno de " + customNames[randomTurn] + " (" + CharacterNames[randomTurn] + ")");
                            turnsDone[randomTurn] = randomTurn;
                            turns++;
                            do
                            {
                                Console.WriteLine(MessagesList.FightChoiceMessage);
                                Console.WriteLine(MessagesList.FightChoiceOpciones);
                                choice = Convert.ToInt32(Console.ReadLine());
                                if (!UtilsHandler.IsInRange(choice, 1, 3))
                                    currentCharacterTries++;
                            } while (!UtilsHandler.IsInRange(choice, 1, 3) && currentCharacterTries < MaxTries);
                            if (currentCharacterTries < MaxTries)
                            {
                                switch (choice)
                                {
                                    case 1:
                                        int damage = HeroesHandler.CalcDamage(charactersStats, 4, charactersStats[randomTurn][1]);
                                        if (!HeroesHandler.IsMissed())
                                        {
                                            if (HeroesHandler.IsCrit())
                                            {
                                                damage *= 2;
                                                UtilsHandler.PrintColored(MessagesList.FightCritMessage, ConsoleColor.Blue);
                                            }
                                            charactersStats[4][0] -= damage;
                                            Console.WriteLine(MessagesList.FightAttackMessage, damage);
                                        }
                                        else
                                        {
                                            UtilsHandler.PrintColored(MessagesList.FightMissedMessage, ConsoleColor.Red);
                                        }
                                        
                                        break;
                                    case 2:
                                        Console.WriteLine(MessagesList.FightProtectedMessage);
                                        isProtected[randomTurn] = true;
                                        break;
                                    case 3:
                                        switch (randomTurn)
                                        {
                                            case 0:
                                                isKnocked = true;
                                                Console.WriteLine(MessagesList.ArcherSkillMessage);
                                                break;
                                            case 1:
                                                charactersStats[1][2] = 100;
                                                Console.WriteLine(MessagesList.BarbarianSkillMessage);
                                                break;
                                            case 2:
                                                damage = HeroesHandler.CalcDamage(charactersStats, 4, charactersStats[randomTurn][1]);
                                                charactersStats[4][0] -= damage * 3;
                                                Console.WriteLine(MessagesList.MageSkillMessage, damage * 3);
                                                break;
                                            case 3:
                                                Console.WriteLine(MessagesList.DruidSkillMessage);
                                                for (int i = 0; i < 3; i++)
                                                {
                                                    if (charactersStats[i][0] + 500 > characterStatsRanges[i * 3][1])
                                                    {
                                                        charactersStats[i][0] = characterStatsRanges[i * 3][1];
                                                    }
                                                    else
                                                    {
                                                        charactersStats[i][0] += 500;
                                                    }
                                                }
                                                break;
                                        }
                                        break;
                                }
                            }
                            UtilsHandler.PressAnyKey();
                        }
                    } while (turns < 4);

                    // Monster Turn

                    Console.Clear();
                    HeroesHandler.DisplayFightStats(charactersStats, customNames, CharacterNames);
                    Console.WriteLine(MessagesList.FightMonsterTurnMessageMessage);

                    if (!isKnocked)
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            if (!HeroesHandler.IsDead(charactersStats, i))
                            {
                                if (!isProtected[i])
                                {
                                    int damage = HeroesHandler.CalcDamage(charactersStats, i, charactersStats[4][1]);
                                    if (!HeroesHandler.IsMissed())
                                    {
                                        charactersStats[i][0] -= damage;
                                        Console.WriteLine(MessagesList.FightMonsterAttacksMessage, customNames[i] + " (" + CharacterNames[i] + ")", damage);
                                    }
                                    else
                                    {
                                        Console.WriteLine(MessagesList.FightMonsterDefMissedMessage, customNames[i] + " (" + CharacterNames[i] + ")");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine(MessagesList.FightMonsterMissedMessage, customNames[i] + " (" + CharacterNames[i] + ")");
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine(MessagesList.MonsterKnockedMessage);
                        knockedTurns++;
                        if (knockedTurns == 2)
                        { 
                            knockedTurns = 0;
                            isKnocked = false;
                        }
                    }

                    if (charactersStats[1][2] == 100) // Si está activa.
                    {
                        maxDefenseTurns++;
                        if (maxDefenseTurns == 2)
                        {
                            maxDefenseTurns = 0;
                            charactersStats[1][2] = oldDefense;
                        }
                    }

                    UtilsHandler.PressAnyKey();

                    if (HeroesHandler.IsDead(charactersStats, 0) && HeroesHandler.IsDead(charactersStats, 1) && HeroesHandler.IsDead(charactersStats, 2) && HeroesHandler.IsDead(charactersStats, 3))
                    {
                        Console.Clear();
                        HeroesHandler.DisplayFightStats(charactersStats, customNames, CharacterNames);
                        exitBattleStage = true;
                        UtilsHandler.PrintColored(MessagesList.EndingHeroDead, ConsoleColor.Red);
                    }
                    else if (HeroesHandler.IsDead(charactersStats, 4))
                    {
                        Console.Clear();
                        HeroesHandler.DisplayFightStats(charactersStats, customNames, CharacterNames);
                        exitBattleStage = true;
                        UtilsHandler.PrintColored(MessagesList.EndingMonsterDead, ConsoleColor.Green);
                    }
                }
            }
        }
    }
}