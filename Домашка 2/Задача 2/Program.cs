int number = Read("Введите число: ");
int amount = number.ToString().Length;

if (amount < 3)
{
    Console.WriteLine("Третьей цифры не существует");
}
else
{
    Console.WriteLine("Третья цифра - " + number.ToString()[2]);
}
 
int Read(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


