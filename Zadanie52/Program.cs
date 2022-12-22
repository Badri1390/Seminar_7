//  Задайте двумерный массив из целых чисел.
//   Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
const int M = 5;
const int N = 4;
const int LEFT_RANGE = 1;
const int RIGHT_RANGE = 20;
double[,] array = FillArrayWithRandomNumbers(M, N, LEFT_RANGE, RIGHT_RANGE);
Result(array);








void Result(double[,] array)
{
    double sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        System.Console.Write(Math.Round((sum / array.GetLength(0)), 2) + "\t");
        sum = 0;
    }
}


double[,] FillArrayWithRandomNumbers(int size, int sizeX, int leftRange, int rightRange)
{
    double[,] tempArr = new double[size, sizeX];
    Random rand = new Random();
        for (int i = 0; i < tempArr.GetLength(0); i++)
        {
            for (int j = 0; j < tempArr.GetLength(1); j++)
            {
                tempArr[i, j] = rand.Next(leftRange, rightRange);
                System.Console.Write(tempArr[i,j]+ "\t");

            }
            System.Console.WriteLine();
        }
    System.Console.WriteLine();    
    return tempArr;    
}
