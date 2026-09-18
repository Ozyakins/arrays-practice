//Вариант 0
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] students = { "Анна", "Борис", "Виктор", "Галина" };
        int[] grades = { 85, 92, 78, 95 };

        Console.WriteLine("Имя        Баллы");
        for (int i = 0; i < students.Length; i++)
        {
            Console.WriteLine("{0,-12} {1,5}", students[i], grades[i]);
        }

        int max = grades.Max();
        int bestIndex = Array.IndexOf(grades, max);
        string bestStudent = students[bestIndex];

        int sum = 0;
        foreach (int g in grades) sum += g;
        double average = (double)sum / grades.Length;

        Console.WriteLine();
        Console.WriteLine($"Лучший студент: {bestStudent} ({max} баллов)");
        Console.WriteLine($"Средний балл группы: {average:F2}");
    }
}
