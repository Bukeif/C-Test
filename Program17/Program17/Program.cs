// Constructor 建構方法

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Person person1 = new Person(170.5 , 42, "阿蔡");
            Person person2 = new Person(168.5, 16, "阿菊");

            Console.WriteLine(person1.age);
            Console.WriteLine(person2.age);

        }
    }
}
