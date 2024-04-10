using System;

namespace EduPrac2._2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Nums Number = new Nums();
            Number.InputNums();
            Number.SumNums();
            Number.MaxNum();
        }
    }

    class Nums
    {
        private int num1;
        private int num2;

        public int Num1
        {
            get
            {
                return num1;
            }
            set
            {
                num1 = value;
            }
        }
        
        public int Num2
        {
            get
            {
                return num2;
            }
            set
            {
                num2 = value;
            }
        }

        public void InputNums()
        {
            Console.Write("Введите первое число: ");
            Num1 = Int32.Parse(Console.ReadLine());
            
            Console.Write("Введите второе число: ");
            Num2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"Первое число: {Num1} \nВторое число: {Num2}");
        }

        public void SumNums()
        {
            int sum;
            sum = Num1 + Num2;
            Console.WriteLine($"Сумма чисел: {sum}");
        }

        public void MaxNum()
        {
            if (Num1 > Num2)
            {
                Console.WriteLine($"Наибольшее число: {Num1}");
            }

            else if (Num2 > Num1)
            {
                Console.WriteLine($"Наибольшее число: {Num2}");
            }

            else
            {
                Console.WriteLine("Числа равны");
            }
        }
        
    }
}