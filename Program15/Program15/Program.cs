// method 方法
using ConsoleApp1;

Person person1 = new Person();
person1.height = 170.5;
person1.age = 42;
person1.name = "阿蔡";
Console.WriteLine(person1.Add(2, 5, "qwqd"));

Person person2 = new Person();
person2.height = 168.5;
person2.age = 16;
person2.name = "阿局";
person2.IsAdult();
