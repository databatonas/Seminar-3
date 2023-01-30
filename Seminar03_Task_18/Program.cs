/* Напишите программу, которая по заданному номеру четверти, 
   показывает диапозон возможных координат точек в этой четверти (X и Y).*/

Console.WriteLine("Введите номер четверти от 1 до 4, используя целые значения");

int quarter = Convert.ToInt32(Console.ReadLine());/* quarter- четверть*/

// /*Если четверть меньше 1 или больше 4*/
// if(quarter < 1 || quarter > 4) Console.WriteLine("Вы ввели некорректное число");

// if(quarter == 1) Console.WriteLine("X > 0  и Y > 0");
// if(quarter == 2) Console.WriteLine("X < 0  и Y > 0");
// if(quarter == 3) Console.WriteLine("X < 0  и Y < 0");
// if(quarter == 4) Console.WriteLine("X > 0  и Y < 0");

/* Ещё один способ*/

switch (quarter)/* switch-переключатель*/
{
    case 1:     /* case-дело. Если quarter имеет значение(1), то...*/
        Console.WriteLine("X > 0  и Y > 0");
        break;  /* break-прервать*/

    case 2:     /* case-дело. Если quarter имеет значение(2), то...*/
        Console.WriteLine("X < 0  и Y > 0");
        break;  /* break-прервать*/

    case 3:     /* case-дело. Если quarter имеет значение(3), то...*/
        Console.WriteLine("X < 0  и Y < 0");
        break;  /* break-прервать*/

    case 4:     /* case-дело. Если quarter имеет значение(4), то...*/
        Console.WriteLine("X > 0  и Y < 0");
        break;  /* break-прервать*/

    default:    /* default-по умолчанию. То есть, если вводимое число не (1,2,3, или 4), то...*/
        Console.WriteLine("Вы ввели некорректное число");
        break;  /* break-прервать*/
}
