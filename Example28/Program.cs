// Задача 28: Напишите программу, которая принимает на вход число N и M и выдаёт произведение чисел от M до N.
//2,4 -> 24 
//1,5 -> 120

Console.Write("Введите чило М: ");
int M = int.Parse(Console.ReadLine());
Console.Write("Введите чило N: ");
int N = int.Parse(Console.ReadLine());



Console.WriteLine(Multiplay(M,N));
Console.WriteLine(Multiplay(1,5));
int Multiplay(int from, int too)
{
    int sum = 1;
    while (from <= too)

    {
        sum = sum * from;
        from++;


    }
    return sum;
}