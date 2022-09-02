/*Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.

0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

/* - решение - */

Console.Clear();

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[m, n];

FillArrayDouble(array);
PrintArrayDouble(array);


// заполняет массив значениями
void FillArrayDouble(double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().NextDouble() * 20 - 10;
            array[i, j] = Math.Round(array[i, j], 1);
        }
    }
}

//показ массива
void PrintArrayDouble(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}



/*--------------------------------------------------------------------------------------*/

/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента 
или же указание, что такого элемента нет.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет
*/

/* - решение - */


int[,] array2D = new int[,] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };

Console.Write("Введите координаты позиции элемента, разделенных запятой: ");
string? positionElement = Console.ReadLine();
int[] position = ParserString(positionElement);

PrintArrayInt(array2D);

SearchValuesIndexInt(array2D);


//показ массива 
void PrintArrayInt(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
// преобразование строки в массив чисел
int[] ParserString(string input)
{
    int countNumbers = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ',')
            countNumbers++;
    }

    int[] numbers = new int[countNumbers];

    int numberIndex = 0;
    for (int i = 0; i < input.Length; i++)
    {
        string subString = String.Empty;

        while (input[i] != ',')
        {
            subString += input[i].ToString();
            if (i >= input.Length - 1)
                break;
            i++;
        }
        numbers[numberIndex] = Convert.ToInt32(subString);
        numberIndex++;
    }

    return numbers;
}
//поиск элемента по индексу целых чисел
void SearchValuesIndexInt(int[,] inArray)
{
    int rows = position[0];
    int columns = position[1];

    if (rows >= inArray.GetLength(0) || columns >= inArray.GetLength(1))
    {
        Console.WriteLine("Такой позиции нет");
        Console.WriteLine($"Максимальная позиция: {inArray.GetLength(0) - 1},{inArray.GetLength(1) - 1}  ");
    }
    else
    {
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            if (i == rows)
            {
                for (int j = 0; j < inArray.GetLength(1); j++)
                {
                    if (j == columns)
                    {
                        Console.WriteLine($"{inArray[i, j]} ");
                        break;
                    }
                }
            }
        }
    }
}


SearchValuesIndexDouble(array);
//поиск элемента по индексу  вещественных чисел
void SearchValuesIndexDouble(double[,] inArray)
{
    int rows = position[0];
    int columns = position[1];

    if (rows >= inArray.GetLength(0) || columns >= inArray.GetLength(1))
    {
        Console.WriteLine("Такой позиции нет");
        Console.WriteLine($"Максимальная позиция: {inArray.GetLength(0) - 1},{inArray.GetLength(1) - 1}  ");
    }
    else
    {
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            if (i == rows)
            {
                for (int j = 0; j < inArray.GetLength(1); j++)
                {
                    if (j == columns)
                    {
                        Console.WriteLine($"{inArray[i, j]} ");
                        break;
                    }
                }
            }
        }
    }
}


/*--------------------------------------------------------------------------------------*/

/*Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

/* - решение - */

int[,] array2 = new int[,] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };

//ищет среднее арифметическое элементов в каждом столбце
void AveragePrint(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(1); i++)
    {
        double arithmeticMean = 0;
        for (int j = 0; j < inArray.GetLength(0); j++)
        {
            arithmeticMean += inArray[j, i];
        }
        arithmeticMean /= inArray.GetLength(0);
        arithmeticMean = Math.Round((arithmeticMean), 2);
        arithmeticMean = Math.Floor(arithmeticMean * 10) / 10;
        Console.WriteLine($"Cреднее арифметическое в столбце № {i + 1}: {arithmeticMean}");
    }
}

PrintArrayInt(array2);

AveragePrint(array2);
