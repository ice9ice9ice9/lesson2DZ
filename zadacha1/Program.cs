/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */

Console.WriteLine("Введите трёхзначное число: ");
string num3 = Console.ReadLine();
if (num3.Length != 3)
{
    Console.WriteLine("Введено не 3ех значное число");
}

Index index1 = 1;
Console.WriteLine(num3[index1]);
