// Задача 15: 
//Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
bool DayWeek(int number)
{
    if (number > 0 && number <= 7)
    {
        return true;
    }
    Console.WriteLine("Это не день недели");
    return false;
}
bool WeekEnd(int weekend)
{
    if (weekend > 5)
    {
        return true;
    }
    return false;
}
int weekend;
Console.WriteLine("Введите день недели: ");
weekend = Convert.ToInt32(Console.ReadLine());
if (DayWeek(weekend))
{
    if (WeekEnd(weekend))
    {
        Console.WriteLine("Выходной");
    }
    else
    {
        Console.WriteLine("Рабочий день");
    }
}