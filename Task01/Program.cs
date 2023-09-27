// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
int ThirdDigit(int numeral)
{
    while (numeral > 999)
    {
        numeral /= 10;
    }
    return numeral % 10;
}
bool LessDigit(int number)
{
    if (number < 100)
    {
        Console.WriteLine("Третьей цифры нет");
        return false;
    }
    return true;
}
int number;
Console.WriteLine("Введите трехзначное число: ");
number = Convert.ToInt32(Console.ReadLine());
if  (LessDigit(number))
{
    Console.WriteLine(ThirdDigit(number));
}