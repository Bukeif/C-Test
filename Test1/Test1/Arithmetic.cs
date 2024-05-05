
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
            return Add(sum, carry);
        }

        // 減法
        public static int Sub(int a, int b)
        {
            b = Add(~b, 1);
            return Add(a, b);
        }

        // 乘法
        public static int Multiply(int a, int b)
        {
            int result = 0;
            for (int i = 0; i < b; i++)
            {
                result += a;
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
                remainder -= b;
                quotient++;
            }
            return quotient;
        }

        public static void show()
        {
            int a = 5;
            int b = 3;

            int product = Multiply(a, b);
            Console.WriteLine($"{a}*{b} = {product}");
        }

    }
}
