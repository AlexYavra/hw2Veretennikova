// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int ReadInt (string message)
{
    System.Console.Write(message);
    string inputedStr = Console.ReadLine ();
    int result = Convert.ToInt32(inputedStr);
    return result;
}
bool Weekend (int days)
{
    if (days > 5)
    {
        return true;
    }
    return false;
}
bool ValidateDays (int number)
{
    if (number > 0 && number <= 7)
    {
        return true;
    }
    System.Console.Write("Это не день недели");
    return false;
}
int days = ReadInt ("Введите день недели >");
if (ValidateDays (days))
{
    if (Weekend (days))
    {
        System.Console.Write("Это выходной ");
    }
    else 
    {
        System.Console.Write("Это рабочий день ");
    }

}