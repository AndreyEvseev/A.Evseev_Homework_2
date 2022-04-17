// Задача 4: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным

int nomDayWeek = 7;

if(nomDayWeek > 7 || nomDayWeek < 1) Console.WriteLine("Ошибка! Задан некорректный номер дня недели");
else
{
    if(nomDayWeek == 6 || nomDayWeek == 7) Console.WriteLine("Да");
    else Console.WriteLine("Нет");
}

