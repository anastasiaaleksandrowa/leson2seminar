﻿//Напишите программу, которая принимает на вход трёхзначное число и удаляет вторую цифру этого числа.

// int num = new Random().Next(100, 1000);
// Console.WriteLine(num);
// int num1 = num % 10;
// int num2 = num % 100; твоя ошибка в неправильном типе деления обрати внимание / и %

// Console.WriteLine(num2 + " " + num1);
// Console.WriteLine(num2 * 10 + num1);

int num = new Random().Next(100,1000);
Console.WriteLine(num);
int num_1 = num % 10;
int num_2 = num / 100;

Console.WriteLine(num_2 + "" + num_1);
Console.WriteLine(num_2 * 10 + num_1);

int result = num_2 * 10 + num_1;
Console.WriteLine($"{num} -> {result}");

// int result_2 = Convert.ToInt32((num_2 + "" + num_1));
// Console.WriteLine($"{num} -> {result_2}");  второй вариант преподавателя

// string num_str = Convert.ToString(num);
// Console.WriteLine(Convert.ToString(num_str[0]) + Convert.ToString(num_str[2]));
// Console.WriteLine(num_str[0] + "" + num_str[2]); третий вариант совсем на крутом
