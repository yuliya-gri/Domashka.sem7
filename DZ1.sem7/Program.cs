// задача 47. задайте двумерный массив размером m*n, заполненный
// случайными вещественными числами

void PrintArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
       Console.Write($"{array[i,j],3}\t");
       Console.WriteLine();
    }
   
}
void FillArray(double[,] array)
{
    Random rnd = new Random();
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        array[i,j] = Math.Round( (rnd.NextDouble()*100), 2);
    }
}
Console.WriteLine("Введите количество строк двумерного массива");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива");
int cols = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[rows,cols];
FillArray(array);
PrintArray(array);
