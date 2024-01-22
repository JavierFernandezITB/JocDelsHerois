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
            return new Random().Next(low, high+1);
        }
    }
}