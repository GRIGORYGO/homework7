/*Задача 50. Напишите программу, которая на вход принимает позиции элемента
в двумерном массиве, и возвращает значение этого элемента или же указание, 
что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

int [,] InitMatrix()
{
    int [,] array = new int[4,4];
    Random rnd = new Random();
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array [i,j] = rnd.Next(0,100);
    }
}
return array;
}

void PrintMatrix(int [,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i,j]} ");
    }
Console.WriteLine();
}
}

int GetNumber(string massage)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(massage);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не цифру попробуйте еще раз: ");
        }
    }
    return result;
}


int [,] matrix = InitMatrix();
InitMatrix();
PrintMatrix(matrix);
int rows = GetNumber($"Введите номер строки:");
int columns = GetNumber($"Введите номер столбца:");


void CheckAndPrint(int rows, int columns, int [,] matrix)
{
    if (rows > 4 ||
        columns > 4)
     Console.WriteLine($"Такой позиции нет в массиве");
     else  Console.WriteLine($"->{matrix[rows,columns]}");
}

CheckAndPrint(rows,columns,matrix);
