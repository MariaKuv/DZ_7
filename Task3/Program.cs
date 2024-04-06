// Задача 3: Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.

// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 

int[] CreareArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max);
    }

    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write($"{array[i]}");
        }
    }
    Console.Write("]");
}

void ReversNumberFromArray(int[] array, int count = 0)
{
    if(array.Length == count) return;
    ReversNumberFromArray(array, count + 1);
    Console.Write(array[count] + " ");
    }

int[] arr = CreareArrayRndInt(5, 1, 100);
PrintArray(arr);

Console.WriteLine();

ReversNumberFromArray(arr);