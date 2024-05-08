
namespace Arithmetic
{
    public class ArithmeticOperations
    {
        // 加法
        public static int Add(int pNum1, int pNum2)
        {
            // b(進位數)為0時返回a
            if (pNum2 == 0)
                return pNum1;
            // 透過 XOR 把不用進位，即不是 1 1 對應的數先算出來
            int sum = pNum1 ^ pNum2;
            // 透過 AND 獲取需要進為位置，即1 1位置，並 << 往左移一位
            int carry = (pNum1 & pNum2) << 1;
            //反覆推送 直到透過 AND 獲取都為 0000 即10進位 10 即停止
            return Add(sum, carry);
        }

        // 減法
        public static int Sub(int pNum1, int pNum2)
        {
            // ~取減數的反數 ， 得到負值
            pNum2 = Add(~pNum2, 1);
            // 透過加法的原理 ， a + (-b)
            return Add(pNum1, pNum2);
        }

        // 乘法
        public static int Multiply(int pNum1, int pNum2)
        {
            //  計算總值
            int result = 0;
            // 循迴直到 pNum2 為 0 
            while (pNum2 != 0)
            {
                // 如果 pNum2 當前位，即最右邊的數為一時
                if (pNum2 & 1)
                {
                    // result 累加目前的乘數的值
                    result = Add(result, pNum1);
                }
                // 不為1時 ， 代表該次出來的值都為 0
                // 讓被乘數整體向左位移增加0 
                pNum1 <<= 1;
                // 同時乘數向右位移1，把乘過的值去掉
                pNum2 >>= 1;

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
            int a = 25;
            int b = 5;

            int product = Divide(a, b);
            Console.WriteLine($"{a}/{b} = {product}");
        }

    }
}