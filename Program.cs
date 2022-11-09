/* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.8*/


int [,] CreateArray(int lenRows, int lenColumns)//задаем массив
{
        int [,] array = new int[lenRows, lenColumns];
        Random random = new Random();
        for (int i = 0; i < array.GetLength(0); i++) // генерация строк
        {
                for (int j = 0; j < array.GetLength(1); j++) // генерация столбцов
                {
                        array[i, j] = random.Next(-5, 6); // задали вывод случайных элементов массива
                }
        }
        return array; // вернули двумерный массив
}

void PrintArray(int[,] array) // вывод на экран
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine(); // переход на следующую строку
    }
}

int[,] array = CreateArray(3, 3); // задали размер двумерного массива
PrintArray(array); // вывели масив на экран

// теперь имея двумерный массив мы выводим массив из срднеарифметических каждого столбца
double[] SrSummColump(double [,] array) 
{
    double[] sumColump = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
        {
            sumColump[i] = 0;
            for (int j = 0; j < array.GetLength(0); j++)
            {
                sumColump[i] += array[j,i];
            }  
            sumColump[i] /= array.GetLength(0);
            System.Console.WriteLine($"{sumColump[i] /= array.GetLength(0)}\t");
        }
        return sumColump;
}

System.Console.WriteLine();

double[] arr = SrSummColump(array); 
SrSummColump(arr); // вывели масив на экран