int [] array = new int[8];

Console.Write("[");
for (int i = 0; i < array.Length; i++)
 {
    array [i] = new Random().Next(99);
    Console.Write(" " + array [i] + " ");
 }
Console.Write("]");
