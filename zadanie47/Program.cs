//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
Console.Clear();
int m = 5;
int n = 4;
const int LEFT_RANGE = 1;
const int RIGHT_RANGE = 20;
double[,] array = FillArrayWithRandomNumbers(m, n, LEFT_RANGE, RIGHT_RANGE);








double[,] FillArrayWithRandomNumbers(int size, int sizeX, int leftRange, int rightRange)
{
    double[,] tempArr = new double[size, sizeX];
    Random rand = new Random();
    for (int i = 0; i < tempArr.GetLength(0); i++)
    {
        for (int j = 0; j < tempArr.GetLength(1); j++)
        {
            tempArr[i, j] = Math.Round(rand.Next(leftRange, rightRange + 1) + rand.NextDouble(), 1);
            System.Console.Write(tempArr[i,j] + "\t");

        }
        System.Console.WriteLine();
    }
    return tempArr;
}