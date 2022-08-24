// Задача 41. Пользователь вводит с клавиатуры М чисел.
// Посчитайте, сколько чисел больше 0 ввел пользователь?
// 0, 7, 8, -2, -2 -> 2

// Array.ConverAll() метод преобразования массива одного типа в другой.
Console.Clear();
// Console.Write("Введите необходимые элементы, через запятую: ");
// int[] number = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
// int count = 0;
 
// for (int i = 0; i < number.Length; i++)
// {
//     if (number[i] > 0)
//     {
//         count++;
//     }
// }
// Console.WriteLine($"Указанных элементов > 0: {count}");



// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


// Console.WriteLine("Число b1: ");
// double b1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Число k1: ");
// double k1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Число b2: ");
// double b2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Число k2: ");
// double k2 = Convert.ToInt32(Console.ReadLine());
// if (b2 - b1 != k2 - k1)
// {
// double x = (b2 - b1) / (k1 - k2);
// double y = k1 * ((b2 - b1) / (k1 - k2)) + b1;
// Console.WriteLine($"({x}; {y})");
// }
// else
// {
//     Console.WriteLine("При заданных параметрах, пересечения нет");
// }