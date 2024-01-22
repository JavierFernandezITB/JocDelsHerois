using Messages;

namespace Heroes
{
    public class HeroesHandler
    {

        public static void SetStat(ref int heroStat, int newHealth)
        {
            Console.WriteLine(MessagesList.ChangedHeroStatMessage, heroStat, newHealth);
            heroStat = newHealth;
        }
    }
}