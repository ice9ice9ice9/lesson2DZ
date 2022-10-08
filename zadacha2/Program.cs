/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6 */

Console.WriteLine("Введите число: ");
string num3 = Console.ReadLine();

if (num3.Length < 3)

{
    Console.WriteLine("третьей цифры нет");
}

Index index2 = 2;
Console.WriteLine(num3[index2]);

