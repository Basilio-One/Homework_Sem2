// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.Через строку решать нельзя.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
Console.WriteLine("Введите цифру ");
int num = Convert.ToInt32(Console.ReadLine());
int div1 = num%10;
int div2 = num%100/10;
int div3 = num%1000/100;

if (num>100 && num<1000) Console.WriteLine($"Третяя цифра {div1}");
else if (num>1000 && num <10000) Console.WriteLine($"Третяя цифра {div2}");
else if (num>10000 && num <100000) Console.WriteLine($"Третяя цифра {div3}");
else
{ 
    Console.WriteLine("Третей цифры нет");
}