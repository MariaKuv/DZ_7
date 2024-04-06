// Задача 2: Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n. 

// m = 2, n = 3 -> A(m,n) = 29   !!! В примере ошибка, согласно википедии переменные перепутаны,
//                                   т.е должно быть A(n,m), например: 
//                                   А(2, 3) = 9, а вот А(3, 2) = 29
// m = 11, n = 3-> A(m,n) = 16381   !!! Здесь также А(3, 11) = 16381

int AckermannFunction(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }

    else if (m == 0)
    {
        return AckermannFunction(n - 1, 1);
    }

    else
    {
        return AckermannFunction(n - 1, AckermannFunction(n, m - 1));
    }
}

Console.Write(AckermannFunction(3, 11));