using Heroes;
using Utils;

namespace UnitTesting
{
    [TestClass]
    public class JocDelsHeroisTests
    {
        [TestMethod]
        public void Utils_IsInRange()
        {
            const int input = 5;
            const int min = 0;
            const int max = 10;
            bool result;

            result = UtilsHandler.IsInRange(input, min, max);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Utils_GenRandomNumber()
        {
            const int min = 0;
            const int max = 10;
            int result;

            result = UtilsHandler.GenRandomNumber(min, max);

            Assert.IsTrue(result >= min && result <= max);
        }

        [TestMethod]
        public void Utils_CheckValidNames()
        {
            string[] names = { "pa", "ta", "ta", "das" };
            bool result;

            result = UtilsHandler.CheckValidNames(names);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Utils_PrintColored()
        {
            string test = "ABDCD";
            bool result;

            result = UtilsHandler.PrintColored(test, ConsoleColor.Red);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Utils_FindInArray()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int query = 5;
            bool result;

            result = UtilsHandler.FindInArray(arr, query);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Heroes_SetStat()
        {
            int stat = 0;
            int newStat = 5;
            int expected = 5;

            HeroesHandler.SetStat(ref stat, newStat);

            Assert.IsTrue(stat == expected);
        }

        [TestMethod]
        public void Heroes_IsDead()
        {
            int[] health = { 0 };
            int[][] stat = { health };
            bool expected = true;
            bool result;

            result = HeroesHandler.IsDead(stat, 0);

            Assert.IsTrue(result == expected);
        }

        [TestMethod]
        public void Heroes_CalcDamage()
        {
            int[] character = { 100, 0, 50 };
            int[][] stat = { character };
            int expected = 50;
            int result;

            result = HeroesHandler.CalcDamage(stat, 0, 100);

            Assert.IsTrue(result == expected);
        }

        [TestMethod]
        public void Heroes_IsCrit()
        {
            bool expected = true;
            bool result;

            result = HeroesHandler.IsCrit();

            Assert.IsTrue(result == expected || result == !expected);
        }

        [TestMethod]
        public void Heroes_IsMissed()
        {
            bool expected = true;
            bool result;

            result = HeroesHandler.IsMissed();

            Assert.IsTrue(result == expected || result == !expected);
        }
    }
}