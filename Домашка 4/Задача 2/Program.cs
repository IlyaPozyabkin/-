Console.WriteLine("Введите число");
int i = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (i > 0)
{
int n = i % 10;
i = i / 10;
sum = sum + n;
}

Console.WriteLine("Сумма цифр в числе равна: " + sum);