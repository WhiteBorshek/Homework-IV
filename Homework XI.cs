﻿/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
Console.WriteLine("Размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int [size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Массив:");
PrintArray(numbers);
int sum = 0;

for (int a = 0; a < numbers.Length; a+=2)
    sum = sum + numbers[a];

Console.WriteLine($"всего{numbers.Length} чисел, сумма элементов на нечетных позициях = {sum}");

void FillArrayRandomNumbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers [i] = new Random().Next(1,10);
    }
}
void PrintArray(int[]numbers)
{
    Console.Write("[ ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
