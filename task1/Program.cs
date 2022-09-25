/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
Console.WriteLine("Введите число");
int userNumber = Convert.ToInt32(Console.ReadLine());
double userDigit4 = Math.Round(((userNumber % Math.Pow(10, 2)) - (userNumber % Math.Pow(10, 1))) / Math.Pow(10, 1));
double userDigit5 = Math.Round(userNumber % Math.Pow(10, 1));
double userDigit1 = Math.Round(userNumber / Math.Pow(10, 4));
double userDigit2 = Math.Round(((userNumber % Math.Pow(10, 4)) - (userNumber % Math.Pow(10, 3))) / Math.Pow(10, 3));
if (userDigit2 == userDigit4 && userDigit1 == userDigit5)
{
    Console.WriteLine($"Ваше число {userNumber} является палиндромом");
}
else 
{
    Console.WriteLine($"Ваше число {userNumber} не является палиндромом");
}
