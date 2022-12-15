﻿
// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и возвращает 
// позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],3}\t");
        Console.WriteLine();
    }
}
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(1, 11);
}
bool FindNum(int[,] array, int num) 
{ 
    bool res = false; 
    for (int i = 0; i < array.GetLength(0); i++)
       for (int j = 0; j < array.GetLength(1); j++)
    { 
        if (array[i, j] == num) 
        { 
            res = true; 
            break; 
        } 
    } 
    return res; 
}
Console.WriteLine("Введите количество строк двумерного массива");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];
FillArray(array);
PrintArray(array);
Console.WriteLine("Введите искомое число: "); 
int num = Convert.ToInt32(Console.ReadLine());
FindNum(array, num);
if (FindNum(array, num)) Console.WriteLine(" Данное число присутствует в массиве!"); 
else Console.WriteLine("Данного числа в массиве нет");