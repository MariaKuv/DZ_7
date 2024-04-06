// Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.

// Пример
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"
// M = 8; N = 4 -> "8, 7, 6, 5, 4"

void PrintNumbers(int m, int n)
{
    if (n > 0 && m > 0)
    {
        if (m == n)
        {
            Console.WriteLine(m);
            return;
        }
        if (m < n)
        {

            Console.Write($"{m}, ");
            PrintNumbers(m + 1, n);
        }
        else
        {
            if (m == n)
            {
                Console.WriteLine(m);
                return;
            }
            Console.Write($"{m}, ");
            PrintNumbers(m - 1, n);
        }
    }
    else Console.WriteLine("Некорректный ввод!");
}

Console.WriteLine("Введите первое натуральное число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());

PrintNumbers(m, n);