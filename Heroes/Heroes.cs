using Messages;
using Utils;

namespace Heroes
{
    public class HeroesHandler
    {

        public static void SetStat(ref int heroStat, int newHealth)
        {
            heroStat = newHealth;
        }

        public static bool IsDead(int[][] characterStats, int number)
        {
            return characterStats[number][0] <= 0;
        }

        public static int CalcDamage(int[][] characterStats, int targetNum, int damage)
        {
            return damage - (damage * characterStats[targetNum][2] / 100);
        }

        public static bool IsCrit()
        {
            int critChance = 10;
            return UtilsHandler.GenRandomNumber(0, 100) <= critChance;
        }

        public static bool IsMissed()
        {
            int missChance = 5;
            return UtilsHandler.GenRandomNumber(0, 100) <= missChance;
        }

        public static bool DisplayFightStats(int[][] characterStats, string[] characterNames, string[] origCharacterNames)
        {
            for (int i = 0; i < characterNames.Length; i++)
            {
                Console.WriteLine(characterNames[i] + " (" + origCharacterNames[i] + ")");
                if (characterStats[i][0] > 0)
                    UtilsHandler.PrintColored("\t Vida: " + characterStats[i][0] + "\n", ConsoleColor.Green);
                else
                    UtilsHandler.PrintColored("\t FALLECIDO\n", ConsoleColor.Red);
            }
            Console.WriteLine("MONSTRUO");
            if (characterStats[4][0] > 0)
                UtilsHandler.PrintColored("\t Vida: " + characterStats[4][0] + "\n", ConsoleColor.Green);
            else
                UtilsHandler.PrintColored("\t FALLECIDO\n", ConsoleColor.Red);
            return true;
        }
    }
}