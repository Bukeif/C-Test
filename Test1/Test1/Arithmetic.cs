
namespace Arithmetic
{
    public class ArithmeticOperations
    {
        // 加法
        public static int Add(int a, int b)
        {
            if (b == 0)
                return a;
            int sum = a ^ b;
            int carry = (a & b) << 1;
            Console.WriteLine("目前的 Sum : " + (sum));
            Console.WriteLine("目前的值 Carry : " + (carry));
            return Add(sum, carry);
        }

        // 減法
        public static int Sub(int a, int b)
        {
            b = Add(~b, 1);
            Console.WriteLine("目前的值 b : " + (b));

            return Add(a, b);
        }

        // 乘法
        public static int Multiply(int a, int b)
        {
            int result = 0;
            for (int i = 0; i < b; i++)
            {
                result = Add(result, a);
            }
            return result;
        }
        // 除法
        public static int Divide(int a, int b)
        {
            int quotient = 0;
            int remainder = a;

            while (remainder >= b)
            {
                remainder = Sub(remainder, b);
                quotient = Add(quotient, 1);
            }
            return quotient;
        }

        public static void show()
        {
            int a = 5;
            int b = 3;

            int product = Divide(a, b);
            Console.WriteLine($"{a}/{b} = {product}");
        }

    }
}
