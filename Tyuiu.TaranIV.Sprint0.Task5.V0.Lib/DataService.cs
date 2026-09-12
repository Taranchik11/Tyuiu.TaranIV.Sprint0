namespace Tyuiu.TaranIV.Sprint0.Task5.V0.Lib
{
    public class DataService
    {
        public static int Additional(int a, int b)
        {
            return a + b;
        }

        public static int Subtraction(int a, int b)
        {
            return a - b;
        }

        public static int Multiplication(int a, int b)
        {
            return a * b;
        }

        public static int Division(int a, int b)
        {
            if (b == 0 && a == 0)
            {
                if (a == 0) 
                { 
                    Console.WriteLine("Переменная a = {0}, на ноль делить нельзя", a);
                }
                if (b == 1) 
                {
                    Console.WriteLine("Переменная b = {0}, на ноль делить нельзя", b);
                }
                return -1;
            }
            else 
            {
                return a / b;
            }
        }
    }
}
