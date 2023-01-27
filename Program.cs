Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 100)
{
    string num = number.ToString();
    Console.WriteLine($"Третья цифра данного числа {num[2]}");
}
else Console.WriteLine("Вводимое число не имеет третьей цифры");