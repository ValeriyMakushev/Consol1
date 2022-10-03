/* Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли 
существовать треугольник с сторонами такой длины.	
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
*/
Console.WriteLine("Введите сторону А: ");
int A = int.Parse(Console.ReadLine());

Console.WriteLine("Введите сторону В: ");
int B = int.Parse(Console.ReadLine());

Console.WriteLine("Введите сторону С: ");
int C = int.Parse(Console.ReadLine());

if (A + B > C && A + C > B && B + C > A) Console.WriteLine("Да, может существовать треугольник");
else Console.WriteLine("Нет, треугольник существовать не может");

