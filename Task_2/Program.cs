/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
*/

int sum = 0;

Console.Clear();
Console.WriteLine("Введите значения M и N с клавиатуры через пробел: ");
int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();

Console.WriteLine("Сумма натуральных чисел между указанными числами: ");
Console.WriteLine(summary(size[0] + 1, size[1]));

int summary(int min, int max) {
    if (Math.Abs(max - min) > 0) {
        sum = sum + min;
        min = min + 1;
        summary(min, max);
    }
    return sum;
}