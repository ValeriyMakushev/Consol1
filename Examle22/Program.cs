// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4
Console.WriteLine("Введите число: ");
int A = int.Parse(Console.ReadLine());
int b = 1;
while( b<A)
{
    Console.WriteLine(Math.Pow(b,2));
    b++;
}

