int SumNumbers(int from, int to)
{
    if (from == to)
    {
        return from;
    }
    var direction = to > from ? 1 : -1;
    return SumNumbers(from + direction, to) + from;
}

Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int sum = SumNumbers(firstNumber, secondNumber);
Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}");