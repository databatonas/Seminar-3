﻿/* Напишите программу, которя на вход принимает два числа (X и Y), 
   причём X не равно нулю и Y не равно нулю и выдает номер четверти плоскости,
   в которой находится эта точка.*/

Console.WriteLine("Введите число X. При введении дробного числа используйте запятую");

double x = Convert.ToDouble(Console.ReadLine());/*double- дает возможность
                                                   вводить дробные числа*/
Console.WriteLine("Введите число Y. При введении дробного числа используйте запятую");

double y = Convert.ToDouble(Console.ReadLine());/*double- дает возможность
                                                   вводить дробные числа*/

if(x > 0 && y > 0) Console.WriteLine("Точка находится в первой четверти плоскости.");
if(x < 0 && y > 0) Console.WriteLine("Точка находится во второй четверти плоскости.");
if(x < 0 && y < 0) Console.WriteLine("Точка находится в третьей четверти плоскости.");
if(x > 0 && y < 0) Console.WriteLine("Точка находится в четвёртой четверти плоскости.");
