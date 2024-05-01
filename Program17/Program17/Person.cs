namespace ConsoleApp1
{
    class Person
    {
        public double height;
        public int age;
        public string name;

        // 建構方法 不會回傳資料，可以設定每次創建物件時要做的事
        // 物件屬性名如果跟參數一樣 要加上 this. 表示指定屬性名
        public Person(double height, int age, string name)
        {
            this.height = height; 
            this.age = age;
            this.name = name;
        }
    }
}


