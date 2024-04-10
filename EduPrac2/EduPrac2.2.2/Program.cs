using System;
using System.Collections.Generic;

namespace EduPrac2._2._2
{
    class Program
    {
        static void Main()
        {
            Train lastochka = new Train();
            lastochka.city = "Санкт-Петербург";
            lastochka.departureTime = new DateTime(2024, 12, 31, 18, 30, 0);
            lastochka.trainNum = 999;
            
            Train tatarstan = new Train();
            tatarstan.city = "Набережные Челны";
            tatarstan.departureTime = new DateTime(2024, 12, 31, 17, 30, 0);
            tatarstan.trainNum = 666;
            
            Train phoenix = new Train();
            phoenix.city = "Краснодар";
            phoenix.departureTime = new DateTime(2024, 12, 31, 11, 11, 0);
            phoenix.trainNum = 1;
            
            Train papa = new Train();
            papa.city = "Москва";
            papa.departureTime = new DateTime(2024, 12, 31, 15, 0, 0);
            papa.trainNum = 777;
            
            Train mama = new Train();
            mama.city = "Санкт-Петербург";
            mama.departureTime = new DateTime(2024, 12, 31, 5, 55, 0);
            mama.trainNum = 8;

            Console.Write("Введите номер поезда: ");
            int numTrain = Int32.Parse(Console.ReadLine());
            
            switch (numTrain)
            {
                case 999:
                    lastochka.PrintInfoTrain();
                    break;
                case 666:
                    tatarstan.PrintInfoTrain();
                    break;
                case 1:
                    phoenix.PrintInfoTrain();
                    break;
                case 777:
                    papa.PrintInfoTrain();
                    break;
                case 8:
                    mama.PrintInfoTrain();
                    break;
                
                default:
                    Console.WriteLine("Введен неверный номер поезда.");
                    break;
            }
        } 
    }

    class Train
    {
        public string city;
        public DateTime departureTime = new DateTime();
        public int trainNum;
        
        public void PrintInfoTrain()
        {
            Console.WriteLine($"Номер поезда: {trainNum} \nПункт назначения: {city} \nВремя отправления: {departureTime.ToShortTimeString()}");
        }
    }
}