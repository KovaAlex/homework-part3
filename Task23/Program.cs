// Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// вариант 1
// System.Console.WriteLine("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// for (int count = 1; count <= n; count++)
// {
//     System.Console.Write(Math.Pow(count, 3) + " ");
// }

// вариант 2
void PrintSquares(int n)
{
    for (int i = 1; i <= n; i++)
    {
        System.Console.Write(Math.Pow(i, 3) + " ");
    }
}
System.Console.WriteLine("Введите число N: ");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine();
PrintSquares(a);