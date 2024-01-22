namespace Utils
{
    public class UtilsHandler
    {
        public static bool IsInRange(int value, int min, int max)
        { 
            return value >= min && value <= max;
        }
    }
}