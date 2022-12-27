namespace Delegates
{
    class CalculationService
    {
        public static void ShowMax(double x, double y)
        {
            double max = (x > y) ? x : y;
            System.Console.WriteLine(max);
        }

        public static void ShowSum(double x, double y)
        {
            double sum = x + y;
            System.Console.WriteLine(sum);
        }

        public static double Sum(double x, double y)
        {
            return x + y;
        }

        public static double Square(double x, double y)
        {
            return x * y;
        }
    }
}