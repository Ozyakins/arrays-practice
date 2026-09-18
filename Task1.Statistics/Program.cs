using System;
using System.Globalization;
namespace Task1
{
   class Program
  {
      static void Main()
      {
          
          int[] arr = new int[10];
          Random rnd = new Random();
          for (int i = 0; i < arr.Length; i++) arr[i] = rnd.Next(1, 101);

          
          Console.WriteLine("Массив: {0}", string.Join(", ", arr));

          
          int sum = 0;
          int evenCount = 0;
          foreach (int v in arr)
          {
              sum += v;
              if (v % 2 == 0) evenCount++;
          }

          
          double product = 1.0;
          foreach (int v in arr) product *= v;

          double avg = sum / (double)arr.Length;

          int aboveAvgCount = 0;
          foreach (int v in arr) if (v > avg) aboveAvgCount++;
          
          Console.WriteLine("Сумма: {0}", sum);
          Console.WriteLine("Произведение: {0}", product.ToString("E2", CultureInfo.InvariantCulture));
          Console.WriteLine("Чётных чисел: {0}", evenCount);
          Console.WriteLine("Больше среднего ({0}): {1}",
                            avg.ToString("0.0", CultureInfo.InvariantCulture),
                            aboveAvgCount);
      }
  }
}