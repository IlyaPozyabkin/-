Console.Write("Введи цифру, обозначающую день недели: ");
int Number = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int Number) {
  if (Number == 6 || Number == 7) {
  Console.WriteLine($"{Number} день недели является выходным");
  }
  else if (Number < 1 || Number > 7) {
    Console.WriteLine($"Число {Number} не является днём недели");
  }
  else Console.WriteLine($"{Number} день недели не является выходным");
}

CheckingTheDayOfTheWeek(Number);

