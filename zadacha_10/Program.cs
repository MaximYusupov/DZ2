﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
int number = new Random().Next(100,1000); // Next (start, finish + 1)

int firstDigit = number/100; // Первая цифра числа: 456 -> 4 для получения делаем 456\100 = 4 целых, остатка нет это "/" - целочисленное деление

int firdDigit = number%10;// Третья цифра числа: 456 -> 6 для полуцения делаем 456%10 = 6 "%" - остаток

int secondDigit = (number - (firstDigit*100 + number%10)) /10; // Вторая цифра

Console.WriteLine("Исходное число:" + number);
Console.WriteLine("Второе число:" + secondDigit);