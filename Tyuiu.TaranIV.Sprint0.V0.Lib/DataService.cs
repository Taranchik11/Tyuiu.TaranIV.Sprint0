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
            if (b == 0)
            {
                Console.WriteLine("B = {0}, на ноль нельзя делить", b);
                return -1;
            }
            if (a == 0)
            {
                Console.WriteLine("A = {0}, на ноль нельзя делить", a);
                return -1;
            }
            else
            {
                return a / b;
            }
        }
    }
}
