/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
(делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/
Console.WriteLine("введите первое число");
int userNumber1 = Convert.ToInt32(Console.ReadLine());
if (userNumber1 % 2 == 0)
{
    Console.WriteLine($"{userNumber1} четное число");
}
else
{
    Console.WriteLine($"{userNumber1} нечетное число");
}