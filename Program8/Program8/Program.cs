// 進階計算機

Console.Write("請輸入第一個數 : ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("請輸入要作的運算(+、-、*、/) : ");
string oper = Console.ReadLine();

Console.Write("請輸入第二個數 : ");
double num2 = Convert.ToDouble(Console.ReadLine());

if(oper == "+") 
{
    Console.WriteLine(num1 + num2);
}else if(oper == "-")
{
    Console.WriteLine(num1 - num2);
}else if(oper == "*")
{
    Console.WriteLine(num1 * num2);
}else if (oper == "/")
{
    Console.WriteLine(num1 / num2);
}
else
{
    Console.WriteLine("不合法的運算符號");
}