// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введинет цифру дня недели 1 - 7: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

if (dayNumber == 1) 
Console.WriteLine("Понедельник выходной -> Нет");
    else if (dayNumber == 2) Console.WriteLine("Вторник, выходной? -> Нет");
    else if (dayNumber == 3) Console.WriteLine("Среда, выходной? -> Нет");
    else if (dayNumber == 4) Console.WriteLine("Четверг, выходной? -> Нет");
    else if (dayNumber == 5) Console.WriteLine("Пятница, выходной? -> Нет");
    else if (dayNumber == 6) Console.WriteLine("Суббота, выходной? -> Да");
    else if (dayNumber == 7) Console.WriteLine("Воскресенье, выходной? -> Да");
    