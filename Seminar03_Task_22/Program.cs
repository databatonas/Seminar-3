// Задача 22
/* Напишите программу, которая на вход принимает число(N) 
   и выдаёт квадраты чисел от 1 до N.*/

Console.WriteLine("Введите число N (используйте запятую при введении дробного числа)");

double N = Convert.ToDouble(Console.ReadLine());/*оператор double дает возможность вводить дробные числа*/
Console.ForegroundColor = ConsoleColor.Red;     /*Вывод ответа в консоль красным цветом*/

int a = (int)N; /* Преобразуем дробное число (N) в целое число (а).*/

if (a <= 1)// Если (а) меньше или равно (1), то...
{
    for (int i = 1; i >= a; i--)/* Вводим переменную (i), равную (1) и запускаем цикл: (i),
                                   начиная от (1) и до тех пор, пока не сравняется
                                   с (а), будем уменьшать на (1) и ...*/
    {
        Console.Write(i * i + "  ");/* В консоль выводим квадрат всех целых чисел от 1 до (а).
                                       Здесь (+)-для склейки, кавычки(" ")- это пробелы
                                       между выводами ответов, чтобы не сливались.*/
    }
}

if (a > 1) // Если (а) больше (1), то...
{
    for (int i = 1; i <= a; i++) /* Вводим переменную (i), равную (1) и запускаем цикл: (i),
                                   начиная от (1) и до тех пор, пока не сравняется
                                   с (а), будем увеличивать на (1) и ...*/

        Console.Write(i * i + "  ");/* В консоль выводим квадрат всех целых чисел от 1 до (а).
                                       Здесь (+)-для склейки, кавычки(" ")- это пробелы
                                       между выводами ответов, чтобы не сливались.*/
}
