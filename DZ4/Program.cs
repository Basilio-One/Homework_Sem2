﻿// Задача необязательная FIZZ BUZZ: Напишите программу, которая выводит на экран числа от 1 до 100. 
// При этом вместо чисел, кратных трем, программа должна выводить слово Fizz, а вместо чисел, кратных пяти — слово Buzz. 
// Если число кратно пятнадцати, то программа должна выводить слово FizzBuzz. 
// Задача может показаться очевидной, но нужно получить наиболее простое и красивое решение.

int num = new Random().Next(1,101);
Console.WriteLine($"Сгенерированно случайное число от 1 до 100:  {num}");
// int x1 = num/10;
// int x2 = num%100;
if (num%3==0)
{
    Console.Write("Fizz");
}
else if (num%5==0)
{
     Console.WriteLine("Buzz");
}
else if (num%15/100==0)
{
     Console.WriteLine("FiZZBuzz");
}
else 
{
    Console.WriteLine("Целое число, остатка нет");
}