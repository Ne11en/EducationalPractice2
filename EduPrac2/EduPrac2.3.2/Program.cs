using System;

namespace EduPrac2._3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker SE = new Worker();
            SE.Name = "Sergey";
            SE.Surname = "Ermolin";
            SE.Rate = 999;
            SE.Days = 20;
            Console.WriteLine($"Name: {SE.Name} Surname: {SE.Surname} ");
            SE.GetSalary();
            
        }
    }

    class Worker
    {
        private string name;
        private string surname;
        private int rate;
        private int days;

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
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }
        
        public int Rate
        {
            get
            {
                return rate;
            }
            set
            {
                rate = value;
            }
        }

        public int Days
        {
            get
            {
                return days;
            }
            set
            {
                days = value;
            }
        }

        public void GetSalary()
        {
            int salary = days * rate;
            Console.WriteLine($"Зарплата работника составляет: {salary}");
        }
        
    }
}