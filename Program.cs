//Задача 34: Задайте массив заполненный случайными положительными
// трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.



// using System;
// class Program
// {
//   static void Main(string[]args)
//   {
//     int number = int.Parse(Console.ReadLine());
//     int[] arr = new int[12];             
//     int k = 0, sum = 0;             
//     Random rnd = new Random();               
//     Console.WriteLine("Исходный массив");             
//     for (int i = 0; i < 12; i++)             
//     {                 
//       arr[i] = rnd.Next(-50, 50);                 
//       Console.Write("{0} ", arr[i]);             
//     }                          
//     Console.WriteLine("Отсортированный массив ");             
//     Array.Sort(arr);               
//     foreach(int element in arr)             
//     Console.Write("{0} ", element);                 
//     if (element % 2 == 0)                 
//     {                    
//       k++;                     
//       sum += element;       
//       Console.WriteLine("Количество четных элементов {0}, сумма четных элементов {1}", k, sum);              
//     }             
//   }                     
//  }                               
// }          
  

//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.







// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.


// using System;
// class Program
// {
//   static void Main(string[]args)
//   {
//        Console.WriteLine("Введите чесло ..");
//        int num = int.Parse(Console.ReadLine()!);
//        if(num <= 99)
//        {
//          Console.WriteLine("Третьей цифры нет ");
      
//        }
//        if(num >= 100 && num <= 999)
//        {
//          int num2 = num % 10;
//          Console.WriteLine("num2");
//        }
//        if(num >= 1000 && num < 10000)
//        {
//          int num2 = num %100/10;
//          Console.WriteLine(num2);
//        }
//        if(num >= 10000 && num <100000)
//        {
//          int num2 = num %1000 / 100;
//          Console.WriteLine(num2);

//        }
//      }              
                 
//    }     
//  }   
        
