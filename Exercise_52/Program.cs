// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int [,] CreateSampleArray ()
{
    Console.WriteLine("Enter count of rows");
    int userRows = Convert.ToInt32(Console.ReadLine());
    while (userRows <= 0)
    {
        Console.WriteLine("Try again! Number of rows must be > 0");
        userRows = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("Enter count of columns");
    int userColumns = Convert.ToInt32(Console.ReadLine());
    while (userColumns <= 0)
    {
        Console.WriteLine("Try again! Number of columns must be > 0");
        userColumns = Convert.ToInt32(Console.ReadLine());
    }

    int [,] arrayToCreate = new int [userRows, userColumns];

    for (int i = 0; i < userRows; i++)
    {
        for (int j = 0; j < userColumns; j++)
        {
            arrayToCreate[i,j] = new Random().Next(0, 10);
        }
    }
    return arrayToCreate;
}

void PrintSampleArray (int [,] arrayToPrint)
{
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FindArithmeticMean (int [,] arrayToProcess)
{
    for (int j = 0; j < arrayToProcess.GetLength(1); j++)
    {
        double arithmeticMean = 0;
        Console.Write($"Arithmetic mean of column {j+1} is ");
        for (int i = 0; i < arrayToProcess.GetLength(0); i++)
        {
            arithmeticMean = arithmeticMean + arrayToProcess[i,j];
        }
        Console.WriteLine($"{Math.Round(arithmeticMean / arrayToProcess.GetLength(1), 2)}");
    }
}

int [,] arrayCreatedByUser = CreateSampleArray();
Console.WriteLine("Your array is:");
PrintSampleArray(arrayCreatedByUser);
FindArithmeticMean(arrayCreatedByUser);