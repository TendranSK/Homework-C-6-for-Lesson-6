/*
Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 0,5) => при проверке получается (-0,5; -0,5); y = 0,5 - ошибка

x=(b2-b1)/(k1-k2) , y=k1(b2-b1)/(k1-k2)+b1
*/
Console.Write("Введите значиние b1:");
double valueB1 = Convert.ToDouble(Console.ReadLine());

Console.Clear();

Console.Write("Введите значине k1:");
double valueK1 = Convert.ToDouble(Console.ReadLine());

Console.Clear();

Console.Write("Введите значине b2:");
double valueB2 = Convert.ToDouble(Console.ReadLine());

Console.Clear();

Console.Write("Введите значине k2:");
double valueK2 = Convert.ToDouble(Console.ReadLine());

Console.Clear();

double valueX = (valueB2-valueB1)/(valueK1-valueK2);

double valueY = valueK1*(valueB2-valueB1)/(valueK1-valueK2)+valueB1;

Console.Write("y = k1 * x + b1" + "\n" + "y = k2 * x + b2" + "\n" + "b1 = {0}, k1 = {1}, b2 = {2}, k2 = {3}" + "\n" + "Точка пересечения - ({4},{5})",valueB1,valueK1,valueB2,valueK2,valueX,valueY);
