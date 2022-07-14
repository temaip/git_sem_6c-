// // Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


// int[] CreateRandomArray(int size, int min, int max)
// {
//    int[] array = new int[size];
//      for (int i = 0; i < size; i++)
//     {
//         Console.WriteLine("Введите число массива  M");
//         array[i] = Convert.ToInt32(Console.ReadLine());

//     }
//     return array;
// }
//     void ShowArray(int[] array)
// {

//      for (int i = 0; i < array.Length; i++)
//      {
//          Console.Write(array[i] + " ");
//      }
//      Console.WriteLine();
//  }

// Console.WriteLine("Введите число M ");
// int M = Convert.ToInt32(Console.ReadLine());
// int[] myArray = CreateRandomArray(M, 0, M - 1);

// ShowArray(myArray);
// int N = 0;
// int n = 0;
// for (int i = 0; i < myArray.Length; i++)
// {
//       if (  myArray[i] > 0 )
//     {
//         N++;
//     }
//     else
//     {
//         n--;
//     }
// }
// if ( N > 0)
// {
//     Console.WriteLine(" Пользователь ввел чисел больше нуля = " + N );
// }
// else
// {
// Console.WriteLine("Ниодного числа больше нуля пользователь не ввел " );
// }

// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// Console.WriteLine("Введите число b1 ");
// double b1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число k1 ");
// double k1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число b2 ");
// double b2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число k2 ");
// double k2 = Convert.ToInt32(Console.ReadLine());
// double x =  Math.Round((b2 - b1) / (k1 - k2), 2);
// double y1 = Math.Round((k1 * x + b1), 2);
// double y2 = Math.Round((k2 * x + b2), 2);

// if (y1 == y2)
// {
//     Console.WriteLine(" Точка пересечения прямых " + "(" + x + ";" + y1 + ")");
// }
// else
// {
//     Console.WriteLine("Прямые не имеют точку пересечения ");
// }

