﻿// Задача 1: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа

int number3 = 918;
if(number3 > 99 && number3 < 1000) Console.WriteLine(number3 / 10 % 10 );
else Console.WriteLine("Ошибка! Число не явлется трёхзначным");
