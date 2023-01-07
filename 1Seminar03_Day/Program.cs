Console.WriteLine("Введите число от 1 до 7: ");

int day = int.Parse(Console.ReadLine());

string s = "не день недели";

if (day == 1)
{
    s = "понедельник";
}
else if (day == 2)
{
    s = "вторник";
}
else if (day == 3)
{
    s = "среда";
}
else if (day == 4)
{
    s = "четверг";
}
else if (day == 5)
{
    s = "пятница";
}
else if (day == 6)
{
    s = "суббота";
}
else if (day == 7)
{
    s = "воскресение";
}
Console.WriteLine(s);