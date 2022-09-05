Console.WriteLine("введите число A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число B");
int b = Convert.ToInt32(Console.ReadLine());
int n = a;

for (int i = 1; i < b; i++)
{
n = n * a;
}
Console.WriteLine("A в степени B равно: " + n);