// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int ReadInt (string message)
{
    System.Console.Write(message);
    string inputedStr = Console.ReadLine ();
    int number = Convert.ToInt32(inputedStr);
    return number;
}

bool Validate3Digits(int number)
{
        if (99 < number && number < 1000)
        {
            return true;
        }  
        System.Console.WriteLine("Число не трехзначное");
        return false;
}
int num;
num = ReadInt("Введите число = ");
if (Validate3Digits(num))
{
    int secondDigit = num /10 % 10;
Console.WriteLine($"Вторая цифра числа {num} равна {secondDigit}");
}
