﻿Console.Write("Введите число : ");
int num = Convert.ToInt32(Console.ReadLine());
int num2 = - num; //Присваиваем num2 значение num отрицательную
while(num2 <= num) //Пока введённое число больше num2 мы просим команду выводить это самое (num2 число)в терминал
{
Console.Write($"{num2},");
num2++;//Как только условно: num2(-15) <= num(15) то на значении которое ввёл пользователь вся программа и закончится.
}

//Программа выводит в терминал каждое число от минусового введённого числа до положительного введённого числа.

//Задача 5: Напишите программу, которая на вход принимает одно число (N),
// а на выходе показывает все целые числа в промежутке от -N до N.

//4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
//2 -> " -2, -1, 0, 1, 2"*/