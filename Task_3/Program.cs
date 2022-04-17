// Задача 3: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет

int number = 12456;
int i = 1, count = 0, div = 1;
int help = 0;
while(number / i > 0)
{
    i *= 10;
    count++ ;
}
if(count < 3) Console.WriteLine(number + " -> третьей цифры нет");
else
    {   if(count > 3)
        {
            i = 1;
            while(i < count - 2)
            {
                div = div * 10;
                i++;
            }
        }
    help = number / div;
    Console.WriteLine($"{number} -> {help % 10}");
}
