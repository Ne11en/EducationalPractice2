using System;

namespace EduPrac2._2._4
{
    class Program
    {
        static void Main()
        {
            Counter count = new Counter();
            Console.WriteLine("Введите 1(увеличить счетчик на 1)\nВведите 2(уменьшить счетчик на 1)\nВведите 0(установить значение счетчика по умолчанию)\nВведите 9(задать собственное значение счетчика)\nВведите Q(завершить)");
            
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Q")
                {
                    Console.WriteLine("До свидания!");
                    break;
                }
                switch (command)
                {
                    case "1":
                        count.Plus();
                        break;
                    case "2": 
                        count.Minus();
                        break;
                    case "0": 
                        count.Default(); 
                        break;
                    case "9": 
                        count.Custom(); 
                        break;
                    default: 
                        Console.WriteLine("Введена неверная команда"); 
                        break;
                }
            }
            
        }
    }

    class Counter
    {
        public int point;

        private int Point
        {
            get
            {
                return point;
            }
            set
            {
                point = value;
            }
        }

        public void Default()
        {
            point = 0;
            Console.WriteLine($"Применено значение счетчика по умолчанию \nЗначение счетчика: {Point}");
        }

        public void Plus()
        {
            point += 1;
            Console.WriteLine($"Значение счетчика увечичено на 1 \nЗначение счетчика: {Point}");
        }

        public void Minus()
        {
            point -= 1;
            Console.WriteLine($"Значение счетчика уменьшено на 1 \nЗначение счетчика: {Point}");
        }

        public void Custom()
        {
            Console.Write("Введите собственное значение счетчика: ");
            Point = int.Parse(Console.ReadLine());
            Console.WriteLine($"Применено собственное значение счетчика\nЗначение счетчика: {Point}");
        }
    }
}