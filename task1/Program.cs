/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
Console.Clear();
Console.WriteLine("Приветствую! Эта программа поможет узнать, является ли Ваше пятизначное число палиндромом(числом, одинаково читающимся в обоих направлениях)");
string userChoice = "y";
while (userChoice.ToLower() == "y")
{
Console.WriteLine("Введите число");
int userNumber = Convert.ToInt32(Console.ReadLine());
while (userNumber < 10000 || userNumber > 99999)
{
    Console.WriteLine("Вы ввели не пятизначное число, проверьте вводимое число");
    userNumber = Convert.ToInt32(Console.ReadLine());
}
double userDigit4 = Math.Round(((userNumber % Math.Pow(10, 2)) - Math.Round((userNumber % Math.Pow(10, 1))))) / Math.Pow(10, 1);
double userDigit5 = Math.Round(userNumber % Math.Pow(10, 1));
double userDigit1 = Math.Floor(userNumber / Math.Pow(10, 4));
double userDigit2 = Math.Round(((userNumber % Math.Pow(10, 4)) - Math.Round((userNumber % Math.Pow(10, 3))))) / Math.Pow(10, 3);
if (userDigit2 == userDigit4 && userDigit1 == userDigit5)
{
    Console.WriteLine($"Ваше число {userNumber} является палиндромом");
}
    else 
    {
        Console.WriteLine($"Ваше число {userNumber} не является палиндромом");
    }
Console.WriteLine("Вы хотите продолжить работу с программой? Да - Y, Нет - N");
    userChoice = Console.ReadLine();
    while (userChoice.ToLower() != "y" && userChoice.ToLower() != "n")
    {
    Console.WriteLine("Пожалуйста, введите верное решение. Если хотите продолжить работу - введите Y, если желаете закрыть программу - введите N");
    userChoice = Console.ReadLine();
    }
}
Console.WriteLine("Bye!");