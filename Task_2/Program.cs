// Задача 2: Напишите программу, которая выводит случайное трёхзначное число 
// и удаляет вторую цифру этого числа

int number3, digit1, digit3;
number3 = new Random().Next(100, 1000);
Console.Write(number3 + " -> ");
digit1 = number3 / 100;
digit3 = number3 % 10;
Console.WriteLine($"{digit1 * 10 + digit3};");
