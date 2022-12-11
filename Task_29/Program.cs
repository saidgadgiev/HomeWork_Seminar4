/*
Задача 29: Напишите программу, которая задаёт 
массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

Console.WriteLine("Будет создан массив из 8 элементов.");

int[] number = new int[8];
Random rnd = new Random();
Console.Write("[");
for (int i = 0; i < number.Length; i++)
{
    number[i]=rnd.Next(0,100);
    Console.Write(number[i] + (i < number.Length-1 ?", ":""));
}
Console.Write("]");
