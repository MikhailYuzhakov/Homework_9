/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
*/

Console.Clear();
Console.WriteLine("Введите два неотрицательных числа m и n с клавиатуры через пробел: ");
int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();

Console.WriteLine("Значение функции Аккермана: ");
Console.WriteLine(Ackerman_func(Math.Abs(size[0]), Math.Abs(size[1])));

Int64 Ackerman_func(Int64 n, Int64 m) {
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return Ackerman_func(n - 1, 1);
    else
      return Ackerman_func(n - 1, Ackerman_func(n, m - 1));
}