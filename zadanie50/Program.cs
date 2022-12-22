// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Clear();
int m = inputNumber("Введите значение m: ");
int n = inputNumber("Введите значение n: ");
int[,] arr = FillAndPrintArray(m, n);
int i = inputNumber("Введите индекс строки: ");
int j = inputNumber("Введите индекс столбца: ");
Result(i,j);








void Result(int i, int j)
{
if(i < arr.GetLength(0) && j < arr.GetLength(1))
    {System.Console.WriteLine(arr[i,j]);}
else
    {System.Console.WriteLine($"{i}{j} -> Такого числа в массиве нет");}
}





int[,] FillAndPrintArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1,30);
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
    return array;
}

int inputNumber(string str)
{
    int number;
    string text;

    while (true)
    {
        System.Console.Write(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        System.Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
    }
    return number;
}