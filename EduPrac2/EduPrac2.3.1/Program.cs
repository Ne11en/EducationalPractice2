using System;

namespace EduPrac2._3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker SE = new Worker();
            SE.name = "Sergey";
            SE.surname = "Ermolin";
            SE.rate = 999;
            SE.days = 20;
            SE.GetSalary();
        }
    }

    class Worker
    {
        public string name;
        public string surname;
        public int rate;
        public int days;

        public void GetSalary()
        {
            int salary = days * rate;
            Console.WriteLine($"Зарплата работника составляет: {salary}");
        }
        
    }
}