// See https://aka.ms/new-console-template for more information

// 常見資料型態 & 變數
// 字串 string "我好帥" 雙引號
// 字元 char 'a' 單引號 只有一個字
// 整數 int 40
// 整數 int -40
// 浮點數 double 160.5
// 布林值 bool true false


string name = "阿黑";
char sex = 'M';
int age = 30;
double height = 180.2;
bool sexcheck = true;


Console.WriteLine(sexcheck);
Console.WriteLine("你好");
if (!sexcheck)
{
    Console.WriteLine("boy");
}
// 下面這行會印出 我今年 24
Console.WriteLine("我今年 24");
Console.WriteLine("我叫 阿蘭");


Console.WriteLine("有一個人叫" + name);
name = "小黃";
Console.WriteLine(name + "他今年" + age);
name = "小洪";
Console.WriteLine(name + " 他身高" + height);
name = "小綠";
Console.WriteLine(name + "討厭自己 " + age);
