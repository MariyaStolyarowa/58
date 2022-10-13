//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18
void FillArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i, j] = new Random().Next(0, 10);
        }
}
void PrintArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($" {Array[i,j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}   
Console.Clear();
Console.Write("Введите число строк первой матрицы = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов первой матрицы = ");
int n = Convert.ToInt32(Console.ReadLine());
int [,] Array1= new int[m,n];
FillArray(Array1);
Console.Write("Введите число строк второй матрицы = ");
int k = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов второй матрицы = ");
int l = Convert.ToInt32(Console.ReadLine());
int [,] Array2= new int[k,l];
int [,] ArrayRez= new int[m,l];
FillArray(Array2);
Console.WriteLine();
if (n==k)
{
    for (int i=0; i<m; i++)
    {
        for (int j=0; j<l; j++)
        {
            ArrayRez[i,j]=0;
            for (int p=0; p<n; p++)
                {
                ArrayRez[i,j]=ArrayRez[i,j]+(Array1[i,p]*Array2[p,j]);
                }
        }
    }
    Console.WriteLine("Матрица 1:");
    PrintArray(Array1);
    Console.WriteLine("Матрица 2:");
    PrintArray(Array2);
    Console.WriteLine("Результирующая матрица будет:");
    PrintArray(ArrayRez);
}
else 
{Console.Write("Первую матрицу нельзя умножить на вторую, т.к. число ее столбцов не равно числу строк второй матрицы!");}