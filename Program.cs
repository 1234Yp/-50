//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

//Например, задан массив:

//1 4 7 2

//5 9 2 3

//8 4 2 4

//17 -> такого числа в массиве нет

Random rnd = new Random();
int [,] nums = new int[3,4];
int ip, jp;

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        nums[i, j] = rnd.Next(0, 10);
        Console.Write(nums[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("Введи номер столбца");
jp = int.Parse(Console.ReadLine());
Console.WriteLine("Введи номер строки");
ip = int.Parse(Console.ReadLine());

if ((jp > 4) || (ip > 3)) Console.WriteLine("Ошибка, такого элемента нет");
else Console.WriteLine(nums[ip - 1, jp - 1]);
