using System;


namespace EduPrac2._2._5
{
    class Program
    {
        static void Main()
        {
            People Serj = new People("Serj", 18);
            People Dima = new People("Dima", 99);
            People Egor = new People("Egor", 7);
            
            Serj.Print();
            Dima.Print();
            Egor.Print();
            
            Egor.Delete();
        } 
    }

    class People
    {
        private string name;
        private int age;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public People(string n, int a)
        {
            name = n;
            age = a;
        }

        public void Print()
        {
            Console.WriteLine($"Name: {name} Age: {age}");
        }

        ~People()
        {
            Console.WriteLine($"{name} has deleted");
        }

        public void Delete()
        {
            Console.WriteLine($"{name} has deleted");
        }
    }
}