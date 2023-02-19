int GetNumber(string message);
{
Console.WriteLine("message");
int number = Convert.ToInt32(Console.ReadLine());
return number;
}
int numDigit = GetNumber("Введите число:");
int number = GetNumber("Введите число: ");

if (numDigit <=2)
{
    Console.WriteLine("Третьей цифры нет: ");
}
else
{
    if (numDigit > 3)
    {
        number = number / Convert.ToInt32(Math.Pow(10, numDigit - 3));
    }
    number = number % 10;
Console.WriteLine($"Третья цифра: {number}");
}




