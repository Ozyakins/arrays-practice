using System;

class Program
{
    static void Main()
    {
        int[] arr = new int[5];

        for (int i = 0; i < arr.Length; )
        {
            Console.Write($"Введите элемент [{i}]: ");
            string s = Console.ReadLine();
            try
            {
                arr[i] = int.Parse(s);
                i++;
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Введите целое число!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Ошибка: Число слишком большое!");
            }
        }

        while (true)
        {
            Console.Write("Введите индекс для вывода (0-4): ");
            string s = Console.ReadLine();
            try
            {
                int idx = int.Parse(s);
                Console.WriteLine($"Элемент по индексу {idx}: {arr[idx]}");
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Введите целое число!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Ошибка: Число слишком большое!");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Ошибка: Индекс вне границ массива.");
            }
        }
    }
}