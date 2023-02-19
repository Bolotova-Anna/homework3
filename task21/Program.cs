// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// Console.WriteLine("Hello, World!");
int [] firstpoint = new int [2];
int [] secondpoint = new int [2];
int [] thirdpoint = new int [2];
Console.WriteLine("введите x1");
firstpoint [0] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите y1");
firstpoint [1] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите x2");
secondpoint [0] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите y2");
secondpoint [1] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите x3");
thirdpoint [0] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите y3");
thirdpoint [1] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Math.Sqrt(Math.Pow(firstpoint [1]-firstpoint [0],2)+Math.Pow(secondpoint [1]-secondpoint [0],2)+Math.Pow(thirdpoint [1]-thirdpoint [0],2)));