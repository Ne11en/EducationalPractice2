using System;

namespace EduPrac2._3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculation Number = new Calculation();
            
            Console.WriteLine("Введите значение: ");
            Number.SetCalculationLine();
            
            Console.WriteLine("Введите символ который надо прибавить в конец: ");
            Number.SetLastSumbolCalculationLine();
            
            Console.WriteLine("Значение свойства: ");
            Number.GetCalculationLine();
            
            Console.WriteLine("Последний символ строки: ");
            Number.GetLastSymbol();
            
            Console.WriteLine("Строка с последним удаленным символом: ");
            Number.DeleteLastSymbol();
        }
    }

    class Calculation
    {
        private string calculationLine;

        public string CalculationLine
        {
            get
            {
                return calculationLine;
            }
            set
            {
                calculationLine = value;
            }
        }

        public void SetCalculationLine()
        {
            calculationLine = Console.ReadLine();
        }

        public void SetLastSumbolCalculationLine()
        {
            calculationLine = calculationLine + Console.ReadLine();
        }

        public void GetCalculationLine()
        {
            Console.WriteLine(calculationLine);
        }

        public void GetLastSymbol()
        {
            Console.WriteLine(calculationLine[calculationLine.Length-1]);
        }

        public void DeleteLastSymbol()
        {
            calculationLine = calculationLine.Remove(calculationLine.Length - 1);
            Console.WriteLine(calculationLine);
        }
    }
}