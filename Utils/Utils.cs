using Messages;

namespace Utils
{
    public class UtilsHandler
    {
        public static bool IsInRange(int value, int min, int max)
        {
            return value >= min && value <= max;
        }

        public static int GenRandomNumber(int low, int high)
        {
            return new Random().Next(low, high + 1);
        }

        public static bool CheckValidNames(string[] nameList)
        {
            return nameList.Length == 4;
        }

        public static bool PrintColored(string msg, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(msg);
            Console.ResetColor();
            return true;
        }

        public static void PressAnyKey()
        {
            Console.WriteLine(MessagesList.PressAnyKey);
            Console.ReadKey();
        }

        public static bool FindInArray(int[] arr, int query)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == query)
                    return true;
            }
            return false;
        }
    }
}