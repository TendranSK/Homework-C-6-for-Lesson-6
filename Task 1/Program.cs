/*

Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3


*/

Console.Write("Введите колличество чисел: ");

int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите числа:");

int[] arrayNumber  = new int[numberM];

for(int i = 0; i < numberM; i++)
{
arrayNumber[i] = Convert.ToInt32(Console.ReadLine());
}


int valueAboveZero=0;

Console.Write("Масив: \n [");

for (int i = 0; i < numberM; i++)
{
    Console.Write(arrayNumber[i] + " ");
    
    if (arrayNumber[i]>0)
    {
        valueAboveZero++;
    }
}

Console.Write("] чисел больше нуля - {0}",valueAboveZero);