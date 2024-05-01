// 猜數字遊戲

// 自己寫的
// int secret_num = 90;
// bool bonk = false;
// double guess;

// Console.WriteLine("歡迎來到猜數字遊戲");
// Console.WriteLine("請輸入 1 - 100來作猜測 : ");
// guess = Convert.ToDouble(Console.ReadLine());

// while (!bonk)
// {
//     if(guess == secret_num)
//     {
//         Console.WriteLine("恭喜猜對囉~ 答案就是" + secret_num);
//         bonk = true;
//     }
//     else
//     {
//         Console.WriteLine("ohoh , 猜錯囉在猜一次吧");
//         guess = Convert.ToDouble(Console.ReadLine());
//     }
// }


int secret_num = 90;
double guess;
int guess_count = 0;
int guess_limit = 3;
bool win = false;

do
{
    Console.Write("請輸入猜測 : ");
    guess = Convert.ToDouble(Console.ReadLine());
    guess_count++;

        if (guess > secret_num)
        {
            Console.WriteLine("小一點");
            Console.WriteLine("目前還有 " + (guess_limit - guess_count) + " 次 可以猜");
        }
        else if (guess < secret_num)
        {
            Console.WriteLine("大一點");
            Console.WriteLine("目前還有 " + (guess_limit - guess_count) + " 次 可以猜");
        }
        else
        {
            Console.WriteLine("恭喜你答對了");
            win = true;
        }
    
} while (guess != secret_num && guess_count < guess_limit);

if (!win)
{
    Console.WriteLine("抱歉你輸了~");
}
