using System.Data;
//Дано число обозначающее день недели. Выяснить является номер дня недели выходным
//По заданному номеру дня недели вывести его название
Console.Write("Введите номер дня недели:");
int num_day = int.Parse(Console.ReadLine() ?? "0");

switch (num_day)
{
    case 1:
        Console.WriteLine("Понедельник");
    break;

    case 2:
        Console.WriteLine("Вторник");
    break;

    case 3:
        Console.WriteLine("Среда");
    break;

    case 4:
        Console.WriteLine("Четверг");
    break;

    case 5:
        Console.WriteLine("Пятница");
    break;

    case 6:
        Console.WriteLine("Суббота");
    break;

    case 7:
        Console.WriteLine("Воскресение");
    break;

    default:
        Console.WriteLine("некоректный номер дня недели!!!!");
    break;
}
if (num_day == 7 ^ num_day == 6)
{
    Console.WriteLine("Это выходной день!!!");
}
else
{
    Console.WriteLine("Это будний день!");
}