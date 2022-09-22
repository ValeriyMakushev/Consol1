
Console.WriteLine("введите координату точки Xa: ");
int Xa = int.Parse(Console.ReadLine());

Console.WriteLine("введите координату точки Ya: ");
int Ya = int.Parse(Console.ReadLine());

Console.WriteLine("введите координату точки Xb: ");
int Xb = int.Parse(Console.ReadLine());

Console.WriteLine("введите координату точки Yb: ");
int Yb = int.Parse(Console.ReadLine());

double Ligth = Math.Sqrt (Math.Pow((Xb-Xa),2)+ Math.Pow((Yb-Ya),2));

Console.WriteLine($"Ответ: {Ligth}" );



