using System;

class Program
{
    // Возвращает массив уникальных элементов без LINQ и HashSet
    static int[] GetUnique(int[] source)
    {
        if (source == null || source.Length == 0)
            return new int[0];

        int[] temp = new int[source.Length];
        int count = 0;

        foreach (int v in source)
        {
            bool exists = false;
            for (int i = 0; i < count; i++)
            {
                if (temp[i] == v)
                {
                    exists = true;
                    break;
                }
            }
            if (!exists)
            {
                temp[count++] = v;
            }
        }

        int[] result = new int[count];
        Array.Copy(temp, result, count);
        return result;
    }

    static void Main()
    {
        int[] original = { 1, 2, 2, 3, 4, 4, 4, 5 };

        Console.WriteLine("Исходный:  " + string.Join(", ", original));
        int[] uniques = GetUnique(original);
        Console.WriteLine("Уникальные: " + string.Join(", ", uniques));
    }
}