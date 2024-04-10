using System;

namespace EduPrac2._2._1
{
    class Program
    {
        static void Main()
        {
            Student serj = new Student();
            Console.Write("Введите фамилию студента: ");
            serj.surname = Console.ReadLine();

            Console.WriteLine("Введите дату рождения студента: ");
            serj.dateOfBirth = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Введите номер группы студента: ");
            serj.groupNum = int.Parse(Console.ReadLine());

            serj.academicPerformance = new int[5] { 5, 3, 4, 2, 5};
            
            serj.PrintInfoStudent();
        } 
    }

    class Student
    {
        public string surname;
        public DateTime dateOfBirth = new DateTime();
        public int groupNum;
        public int[] academicPerformance;

        public void PrintInfoStudent()
        {
            Console.WriteLine($"Фамилия студента: {surname} \nДата рождения студента: {dateOfBirth} \nНомер группы студента: {groupNum}");
            Console.Write("Оценки студента: ");
            for (int i = 0; i < academicPerformance.Length; i++)
            {
                Console.Write($"{academicPerformance[i]} ");
            }
        }
    }
}