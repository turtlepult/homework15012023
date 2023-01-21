//По двум заданным числам проверять является ли одно квадратом другого
Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine() ??"0");

if ((num2*num2)==num1)
{
    Console.Write("Число " + num1 + " является квадратом числа " + num2);
}
else
{
    Console.Write("Число " + num1 + " НЕ является квадратом числа " + num2);
}