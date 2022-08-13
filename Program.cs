// Напишите программу,корорая на вход принимает два числа
// И  выдает,какое число большее, а какое меньшее 
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10 
// a = -9 b = -3 -> max = -3 


using System;
using System.Linq;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Введите первое число:");
      int firstNumber = Int32.Parse(Console.ReadLine());

      Console.WriteLine("Введите второе число:");
      int secondNumber = Int32.Parse(Console.ReadLine());

      Console.WriteLine("Введите третье число:");
      int thirdNumber = Int32.Parse(Console.ReadLine());

      int[] arr = { firstNumber, secondNumber, thirdNumber };

      Console.WriteLine("Максимальное число: " + arr.Max());

    }
  }
}
  
// Напишите программу,которая принимает на вход принимает число и выдает,
// являеться ли это число четным (делиться ли оно на два без остатка).
// 4-> да
// -3 -> нет
// 7 -> нет 


Console.Write("Введите число: ");
Convert.Tolnt32(Console.WriteLine());
int remain = num % 2;
if (remain == 0)
{
    Console.WriteLine("Число " + num + " четное?");
    Console.WriteLine("ДА!");
}
else
{
    Console.WriteLine("Число " + num + " четное?");
    Console.WriteLine("НЕТ!");
}

