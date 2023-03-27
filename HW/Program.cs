// // Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// // N = 5 -> "5, 4, 3, 2, 1"
// // N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.WriteLine("Задайте значение N:");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Натуральные числа от {N} до 1: {Numbers(N)}");

// string Numbers(int N)
// {
//     if (N <= 1) return $"1"; // исключаем ненатуральные числа
//     return $"{N} " + Numbers(N - 1);
// }


// // Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// // M = 1; N = 15 -> 120
// // M = 4; N = 8. -> 30


// Console.WriteLine("Задайте значение M");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Задайте значение N");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Сумма натуральных чисел от {M} до {N} равна {Summa(M, N)}");

// int Summa(int M, int N)
//     {
//         // if (M == N) return N;
//         // return M + Summa(M + 1, N);
//         if (N < 0 && M < 0) return 0; // исключаем ненатуральные числа
//         if (N == M) return M;
//         return N + Summa(M, N - 1);
//     }


// // // Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// // m = 2, n = 3 -> A(m,n) = 9
// // m = 3, n = 2 -> A(m,n) = 29

// Console.WriteLine("Задайте неотрицательное число m");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Задайте неотрицательное число n");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Функция Аккермана равна {Ackermann(m, n)}");

// int Ackermann(int n, int m)
// {
//     if (n == 0) return m + 1;
//     else
//     {
//         if ((n != 0) && (m == 0)) return Ackermann(n - 1, 1);
//         else return Ackermann(n - 1, Ackermann(n, m - 1));
//     }
// }

