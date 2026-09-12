namespace Tyuiu.TaranIV.Sprint0.Task5.V0.Lib
{
    internal static class DataServiceHelpers
    {

        public static int Division(int a, int b)
        {
            if (b == 0 && a == 0)
            {
                if (a == 0)
                {
                    Console.WriteLine("Переменная a = {0}, на ноль делить нельзя", a);
                    return -1;
                }
                if (b == 1)
                {
                    Console.WriteLine("Переменная b = {0}, на ноль делить нельзя", b);
                    return -1;
                }

            }
            else
            {
                return a / b;
            }
        }
    }
}