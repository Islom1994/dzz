// Задача 25: Напишите цикл, который принимает на вход два числа
// (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// using System;

// namespace Dz25
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       Console.Write("Введите чеслo  ");
//       int numbers = int.Parse(Console.ReadLine());
//       int number = int.Parse(Console.ReadLine());
//       var a = numbers*numbers*numbers*numbers;
//       var b = number*number*number*number*number;
//       Console.WriteLine(a);

//     }

//   }
// }










// Задача 27: Напишите программу, которая принимает вход на число и 
// выдает сумму, включающую сумму.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
 
// using System;
// using System.Collections;
// using System.Collections.Generic;
// using System.Collections.ObjectModel;
// using System.Linq;
// using System.Text;
// using System.Threading;
//  namespace Lesson
//  {
//    class Program
//    {
    
//      static void Main(string[] args)
//      {
      
//       Console.WriteLine("Введите сумму");
//       int number = int.Parse(Console.ReadLine());
//       int a;
//       int b = number%10+number/10%10+number/100;
//       Console.WriteLine(b);
//    }
//  }
//  }


// Задача 29: Напишите программу, которая задает массив
// из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33] 

// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Globalization;
// using System.Linq;
//  namespace Lesson
//  {
//    class Program
//    {
    
//      static void Main(string[] args)
//      {
//       Console.Write("Введите количество елементов массива:\t");
//       int elementsCount = int.Parse(Console.ReadLine());
//       int[]myArray = new int[elementsCount];
//       for (int i = 0; i < myArray.Length; i++)
//       {
//         Console.Write($"\nВведите елементов массива под индексом {i}:\t");
//         myArray[i] = int.Parse(Console.ReadLine());
//       }
//       Console.WriteLine("\nВывод массива:");
//       for (int i = 0; i< myArray.Length; i++)
//       {
//         Console.WriteLine(myArray[i]);
//       }
//      }
//    }
// }