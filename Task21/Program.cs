// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int inputnumber(string str)
{
    System.Console.WriteLine(str);
    return Convert.ToInt32(Console.ReadLine());
}

int x1 = inputnumber("Введите координату X первой точки: ");
int y1 = inputnumber("Введите координату Y первой точки: ");
int z1 = inputnumber("Введите координату Z первой точки: ");
int x2 = inputnumber("Введите координату X второй точки: ");
int y2 = inputnumber("Введите координату Y второй точки: ");
int z2 = inputnumber("Введите координату Z второй точки: ");


System.Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow((x2-x1),2)+ Math.Pow((y2-y1),2) + Math.Pow((z2-z1),2)), 2));


// // вариант 2 (рабочий)
// int x1 = ReadInt("Введите координату X первой точки: ");
// int y1 = ReadInt("Введите координату Y первой точки: ");
// int z1 = ReadInt("Введите координату Z первой точки: ");
// int x2 = ReadInt("Введите координату X второй точки: ");
// int y2 = ReadInt("Введите координату Y второй точки: ");
// int z2 = ReadInt("Введите координату Z второй точки: ");

// int A = x2 - x1;
// int B = y2 - y1;
// int C = z2 - z1;

// double length = Math.Round(Math.Sqrt(A * A + B * B + C * C), 2);
// Console.WriteLine($"Длинна отрезка {length}");

// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }