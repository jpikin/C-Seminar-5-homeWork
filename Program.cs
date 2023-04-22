// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// void GetResult(int[] arr, int count)
// {
//     Console.WriteLine($"{"["}{String.Join(", ", arr)}{"]"} -> {count}");
// }

// int GetRandNum(int a, int b)
// {
//     int num = new Random().Next(a, b);
//     return num;
// }

// int [] arrNum = new int [GetRandNum(5, 10)];
// int counter = 0;
// for (int i = 0; i<arrNum.Length; i++)
// {
//     arrNum[i] = GetRandNum(100, 1000);
//     if (arrNum[i] % 2 == 0)
//     {
//         counter++;
//     }
// }
// GetResult(arrNum, counter);


// Задача 36: Задайте одномерный массив, заполненный случайными числами.
//  Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// void GetResult(int[] arr, int count)
// {
//     Console.WriteLine($"{"["}{String.Join(", ", arr)}{"]"} -> {count}");
// }

// int GetRandNum(int a, int b)
// {
//     int num = new Random().Next(a, b);
//     return num;
// }

// int [] arrNum = new int [GetRandNum(5, 10)];
// int counter = 0;
// for (int i = 0; i<arrNum.Length; i++)
// { 
//    arrNum[i] = GetRandNum(1, 1000);
//    if (i % 2 !=0)
//    {
//     counter += arrNum[i];
//    } 
// }
// GetResult(arrNum, counter);


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// void GetResult(double[] arr, double count)
// {
//     Console.WriteLine($"{"["}{String.Join(", ", arr)}{"]"} -> {count}");
// }

// int GetRandNum(int a, int b)
// {
//     int num = new Random().Next(a, b);
//     return num;
// }

// double GetDif(double a, double b)
// {
//     return a - b;
// }

// double [] arrNum = new double [GetRandNum(5, 10)];
// double maxNum = 0,
//        minNum = 1000;

// for (int i = 0; i < arrNum.Length; i++)
// {
//     arrNum[i] = Convert.ToDouble(GetRandNum(1, 1000));
//     if (arrNum[i] > maxNum)
//     {
//         maxNum = arrNum[i];
//     }
//     if (arrNum[i] < minNum)
//     {
//         minNum = arrNum[i];
//     }
// }

// GetResult(arrNum, GetDif(maxNum, minNum));