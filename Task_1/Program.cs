
int number = 0, sum = 0;

Console.WriteLine("Введите число: ");
number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Сумма цифр в числе: ");
Console.WriteLine(count_sum(number));

int count_sum(int num) {
    if (num  > 9) {
        sum = sum + num % 10;
        num = num / 10;
        count_sum(num);
    } else {
        sum = sum + num;
    }
    return sum;
}