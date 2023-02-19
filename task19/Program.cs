// Напишите программу, которая принимает на 
// вход пятизначное число и проверяет, является ли оно палиндромом
// Console.WriteLine("Hello, World!");
Console.WriteLine("введите пятизначное число число");
string number = Console.ReadLine();
if (number.Length == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine("введенное число является палиндромом");
    }
    else
    {
      Console.WriteLine("введенное число не является палиндромом");  
    }
}
else
{
    Console.WriteLine("введенное число не является пятизначным");
}