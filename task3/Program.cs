/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
Console.Clear();
Console.WriteLine("Приветствую! Эта программа принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N");
string userChoice = "y";
while (userChoice.ToLower() == "y")
{
Console.WriteLine("Введите число");
int userNumber = Convert.ToInt32(Console.ReadLine());
int result = 1;
double resultUser = 0;
Console.Write($"Ваше число {userNumber} -> ");
while (resultUser < Math.Pow(userNumber, 3))
{
    resultUser = Math.Pow(result, 3);
    Console.Write($"{resultUser} ");
    result++;
}
Console.WriteLine("");
Console.WriteLine("Вы хотите продолжить работу с программой? Да - Y, Нет - N");
    userChoice = Console.ReadLine();
    while (userChoice.ToLower() != "y" && userChoice.ToLower() != "n")
    {
    Console.WriteLine("Пожалуйста, введите верное решение. Если хотите продолжить работу - введите Y, если желаете закрыть программу - введите N");
    userChoice = Console.ReadLine();
    }
}
Console.WriteLine("Bye!");