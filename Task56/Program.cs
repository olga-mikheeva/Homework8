/* Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int InputNum(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] Rectangle(int rows, int columns)
{
    return new int[rows, columns];
}

void FillRectangel(int[,] ints)
{
    Random rnd = new Random();
    for (int i = 0; i < ints.GetLength(0); i++)
    {
        for (int j = 0; j < ints.GetLength(1); j++)
        {
            ints[i, j] = rnd.Next(0, 10);
        }
    }
}

void PrintRectangle(int[,] ints)
{
    for (int i = 0; i < ints.GetLength(0); i++)
    {
        for (int j = 0; j < ints.GetLength(1); j++)
        {
            Console.Write(ints[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void MinSumNumbers(int[,] ints)
{
    int numberLine = 0;
    int minSum = 0;
    for (int i = 0; i < ints.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < ints.GetLength(1); j++)
        {
            sum += ints[i, j];
        }
         if (i == 0) // если текущая строка первая,то
        {
            minSum = sum;
        }
        else if (sum < minSum) // если нет, то сравниваем сумму текущей строки с minSum
        {
            minSum = sum; 
            numberLine = i;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов -> {numberLine + 1} ");
}   



int rows = InputNum("Введите количество строк");
int columns = InputNum("Введите количество столбцов");

int[,] myArray = Rectangle(rows, columns);

FillRectangel(myArray);
PrintRectangle(myArray);
MinSumNumbers(myArray);