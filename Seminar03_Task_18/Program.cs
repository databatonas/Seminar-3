/* Напишите программу, которая по заданному номеру четверти, 
   показывает диапозон возможных координат точек в этой четверти (X и Y).*/

Console.WriteLine("Введите номер четверти от 1 до 4, используя целые значения");

int quarter = Convert.ToInt32(Console.ReadLine());/* quarter- четверть*/

/*Если четверть меньше 1 или больше 4*/
if(quarter < 1 || quarter > 4) Console.WriteLine("Вы ввели некорректное число");

if(quarter == 1) Console.WriteLine("X > 0  и Y > 0");
if(quarter == 2) Console.WriteLine("X < 0  и Y > 0");
if(quarter == 3) Console.WriteLine("X < 0  и Y < 0");
if(quarter == 4) Console.WriteLine("X > 0  и Y < 0");