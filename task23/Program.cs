// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// Console.WriteLine("Hello, World!");
Console.WriteLine("введите число");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
for (int i = 1; i <= number; i++)
{
    Console.WriteLine(i*i*i);
}