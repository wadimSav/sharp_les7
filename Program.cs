// Задача 1: Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.
// =================================================
// bool checkWeight (int f_num, int s_num) {
//     if(f_num > s_num)
//         return true;

//     return false;
// }
// string printNums(int f_num, int s_num, int c) {
//     if(checkWeight(f_num, s_num)) {
//         if(f_num == s_num) 
//             return "";
//         if(c == 0)
//             return printNums(f_num - 1, s_num, c + 1);

//         return $"{f_num}" + printNums(f_num - 1, s_num, c + 1);
//     } else {
//         if(f_num == s_num) 
//             return "";
//         if(c == 0)
//             return printNums(f_num + 1, s_num, c + 1);

//         return $"{f_num}" + printNums(f_num + 1, s_num, c + 1);
//     }
// }

// Console.Clear();
// Console.Write("введите число: ");
// int M = int.Parse(Console.ReadLine()!);
// Console.Write("введите второе число: ");
// int N = int.Parse(Console.ReadLine()!);
// int count = 0;
// Console.WriteLine(printNums(M, N, count));
// ===============================================

// Задача 2: Напишите программу вычисления функции Аккермана с 
// помощью рекурсии. Даны два неотрицательных числа m и n.
// void AkkermanFunction(int m, int n) {
//     Console.WriteLine(Akkerman(m, n)); 
// }

// int Akkerman(int m, int n) {
//     if (m == 0) {
//         return n + 1;
//     } else if (n == 0 && m > 0) {
//         return Akkerman(m - 1, 1);
//     } else {
//         return (Akkerman(m - 1, Akkerman(m, n - 1)));
//     }
// }

// Console.Clear();
// Console.Write("Введите число M: ");
// int m = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число N: ");
// int n = int.Parse(Console.ReadLine()!);

// AkkermanFunction(m,n);
// ========================================

// Задача 3: Задайте произвольный массив. Выведете его элементы, 
// начиная с конца. Использовать рекурсию, не использовать циклы.
Console.Clear();
Console.Write("Введите кол-во чисел: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];

int[] inputArray(int[] array) {
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 11);
    return array;
}

void printExpandNumbers(int[] arr, int count) {
    if(count >= 0) {
        Console.WriteLine(arr[count]);
        printExpandNumbers(arr, count - 1);
    }
}
int[] resultArray = inputArray(array);
printExpandNumbers(resultArray, array.Length - 1);