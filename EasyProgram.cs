
using System;

namespace GitExerciseRepository
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите ваше имя: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine($"Спасибо, {name}! Ваш возраст - {age} лет");
        }
    }
}
