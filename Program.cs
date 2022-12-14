/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
void PrintArray(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            Console.Write(table[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
int[,] FillArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
            array[i, j] = new Random().Next(1, 100);
    }
    return array;
}
int[,] DescendingRowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int rowMax = array[i, j];
            for (int h = j; h < array.GetLength(1); h++)
            {
                if (rowMax < array[i, h])
                {
                    int temp = array[i, h];
                    array[i, j] = temp;
                    array[i, h] = rowMax;
                    rowMax = array[i, j];
                }
            }
        }
    }
    return array;
}
Console.WriteLine("Задача 1");
Console.Write("Введите количество строк двумерного массива ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество стобцов двумерного массива ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] mas = FillArray(m, n);
PrintArray(mas);
Console.WriteLine();
PrintArray(DescendingRowArray(mas));
/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
string FingMinSumRow(int[,] array)
{
    int minRow = 0;
    foreach (int item in array)
    {
        minRow += item;
    }
    int indexMinRow = 1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int temp = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            temp += array[i, j];
        }
        if (temp < minRow)
        {
            minRow = temp;
            indexMinRow += i;
        }
    }
    return $"Строка с минимальной суммой элементов - {indexMinRow}\nСумма элементов = {minRow}";
}
Console.WriteLine("Задача 2");
Console.Write("Введите количество строк двумерного массива ");
m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество стобцов двумерного массива ");
n = Convert.ToInt32(Console.ReadLine());
int[,] mas2 = FillArray(m, n);
PrintArray(mas2);
Console.WriteLine(FingMinSumRow(mas2));
/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int[,] MultiplicationMatr(int[,] array1, int[,] array2)
{
    int[,] multiArr = new int[array1.GetLength(0), array2.GetLength(1)];
    if (array1.GetLength(0) == array2.GetLength(1))
    {
        for (int i = 0; i < multiArr.GetLength(0); i++)
        {
            for (int j = 0; j < multiArr.GetLength(1); j++)
            {
                for (int h = 0; h < array2.GetLength(0); h++)
                {
                    multiArr[i, j] += array1[i, h] * array2[h, j];
                }
            }
        }
    }
    return multiArr;
}
Console.WriteLine("Задача 3");
Console.Write("Введите количество строк двумерного массива ");
m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество стобцов двумерного массива ");
n = Convert.ToInt32(Console.ReadLine());
int[,] mas3 = FillArray(m, n);
Console.Write("Введите количество строк двумерного массива ");
m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество стобцов двумерного массива ");
n = Convert.ToInt32(Console.ReadLine());
int[,] mas4 = FillArray(m, n);
PrintArray(mas3);
Console.WriteLine();
PrintArray(mas4);
Console.WriteLine();
PrintArray(MultiplicationMatr(mas3, mas4));
/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
int[,,] FillThirdArray(int m, int n, int s)
{
    int[,,] array = new int[m, n, s];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int h = 0; h < s; h++)
            {
                array[i, j, h] = new Random().Next(1, 100);
            }
        }
    }
    return array;
}
void PrintIndex(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int h = 0; h < array.GetLength(2); h++)
            {
                Console.WriteLine($"{array[i, j, h]} имеет координаты ({i},{j},{h})");
            }
        }
    }
}
Console.WriteLine("Задача 4");
Console.Write("Введите длину трехмерного массива ");
m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите высоту трехмерного массива ");
n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите ширину трехмерного массива ");
int s = Convert.ToInt32(Console.ReadLine());
int[,,] mas5 = FillThirdArray(m, n, s);
PrintIndex(mas5);
/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
int[,] FillSpiralArray(int m, int n)
{
    int[,] array = new int[m, n];
    int count = 1;
    int positionY = 0;
    int positionX = 0;
    int lenghtToRight = n-1;
    int lenghtToDown = m - 1;
    int lenghtToLeft = 0;
    int lenghtToUp = 1;
    bool turnRight = true;
    bool turnDown = false;
    bool turnLeft = false;
    bool turnUp = false;
    while (count <= (m * n))
    {
        if (turnRight)
        {
            array[positionY, positionX] = count;
            if (positionX == lenghtToRight)
            {
                turnDown = true;
                turnRight = false;
                positionY++;
                lenghtToRight--;
                count++;
                goto endLoop;

            }
            positionX++;
        }
        if (turnDown)
        {
            array[positionY, positionX] = count;
            if (positionY == lenghtToDown)
            {
                lenghtToDown--;
                positionX--;
                turnDown = false;
                turnLeft = true;
                count++;
                goto endLoop;

            }
            positionY++;
        }
        if (turnLeft)
        {
            array[positionY, positionX] = count;
            if (positionX == lenghtToLeft)
            {
                lenghtToLeft++;
                turnUp = true;
                turnLeft = false;
                positionY--;
                count++;
                goto endLoop;

            }
            positionX--;
        }
        if (turnUp)
        {
            array[positionY, positionX] = count;
            if (positionY ==lenghtToUp)
            {
                lenghtToUp++;
                turnUp = false;
                turnRight = true;
                positionX++;
                count++;
                goto endLoop;
            }
            positionY--;
        }
        count++;
        endLoop: continue;
    }
    return array;
}
Console.WriteLine("Задача 5");
Console.Write("Введите количество строк двумерного массива ");
m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество стобцов двумерного массива ");
n = Convert.ToInt32(Console.ReadLine());
int[,] mas6 = FillSpiralArray(m, n);
PrintArray(mas6);