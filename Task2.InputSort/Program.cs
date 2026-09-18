using System;

class Program
{
    static void Main()
    {
        int N = 0;
        while (true)
        {
            Console.Write("Введите количество элементов: ");
            string input = Console.ReadLine();
            try
            {
                N = int.Parse(input);
                if (N > 0) break;
                Console.WriteLine("Введите число больше 0.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный формат числа. Повторите ввод.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Число слишком велико. Повторите ввод.");
            }
        }

        int[] arr = new int[N];
        for (int i = 0; i < N; i++)
        {
            while (true)
            {
                Console.Write($"Элемент [{i}]: ");
                string s = Console.ReadLine();
                try
                {
                    arr[i] = int.Parse(s);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Неверный формат числа. Повторите ввод.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Число слишком велико. Повторите ввод.");
                }
            }
        }

        Console.Write("Исходный массив:  ");
        Console.WriteLine(string.Join(", ", arr));

        Console.Write("Обратный порядок:  ");
        for (int i = N - 1; i >= 0; i--)
        {
            if (i != N - 1) Console.Write(", ");
            Console.Write(arr[i]);
        }
        Console.WriteLine();

        Array.Sort(arr);

        Console.Write("Отсортированный:  ");
        for (int i = 0; i < N; i++)
        {
            if (i > 0) Console.Write(", ");
            Console.Write(arr[i]);
        }
        Console.WriteLine();

        int min = arr[0];
        int max = arr[N - 1];
        Console.WriteLine($"Максимум: {max}");
        Console.WriteLine($"Минимум: {min}");
    }
}