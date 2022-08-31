Console.Write("Введите пятизначное число: ");
string? num = Console.ReadLine();


void PoliNum(string num)
{
    if (num[0] == num[4] || num[1] == num[3])
    {
        Console.WriteLine($"Ваше число палиндром");
    }
    else
    {
        Console.WriteLine($"Ваше не число палиндром");
    }

}
if (num!.Length == 5)
{
   PoliNum(num);
}
else if (num!.Length > 5)
{
    Console.WriteLine($"Ваше число имеет больше пяти знаков");
}
else if ((num!.Length < 5))
{
    Console.WriteLine($"Ваше число имеет меньше пяти знаков");
} 


