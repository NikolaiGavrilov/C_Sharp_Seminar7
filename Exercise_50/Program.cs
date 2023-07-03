// Задача 50. Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого
// элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int [,] CreateNewArray ()
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

void PrintNewArray (int [,] arrayToPrint)
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

void FindElement (int [,] arrayToAnalyse)
{
    Console.WriteLine("Enter the element's row");
    int rowsPosition = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the element's column");
    int columnsPosition = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < arrayToAnalyse.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToAnalyse.GetLength(1); j++)
        {
            if (i == rowsPosition-1 && j == columnsPosition-1)
                Console.WriteLine($"Your result is {arrayToAnalyse[rowsPosition - 1, columnsPosition - 1]}");
        }
    }
    if (rowsPosition > arrayToAnalyse.GetLength(0) || columnsPosition > arrayToAnalyse.GetLength(1))
        Console.WriteLine("Error. There is no such element. Try again");
    else if (rowsPosition < 0 || columnsPosition < 0)
        Console.WriteLine("Error. There is no such element. Try again");
}

int [,] arrayFromUser = CreateNewArray();
Console.WriteLine("Your array is:");
PrintNewArray(arrayFromUser);
FindElement(arrayFromUser);