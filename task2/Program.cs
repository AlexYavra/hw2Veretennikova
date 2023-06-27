// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int ReadInt (string message)
{
    System.Console.Write(message);
    string inputedStr = Console.ReadLine ();
    int number = Convert.ToInt32(inputedStr);
    return number;
}
int GetThirdRank(int number)
{
    while (number > 999)
    {
        number /= 10;
    }
    return number % 10;
}
bool ValidateNumber(int number)
{
    if (number < 100)
    {
        System.Console.WriteLine("Третьей цифры нет");
        return false;
    }
    return true;
}
int number = ReadInt("Введите число = ");
if (ValidateNumber(number))
{
    Console.Write($"Третья цифра числа {number} равна {GetThirdRank(number)}");
}