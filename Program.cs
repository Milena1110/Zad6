﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Задание 41

/*Console.WriteLine("Сколько чисел вы хотите ввести?");
int AmOfNum = Convert.ToInt32(Console.ReadLine());
int[] Massiv = new int[AmOfNum];
int PolNum = 0;

for (int i = 0; i < AmOfNum; i++)
{
    Console.WriteLine("Введите пожалуйста число " + (i+1));
    Massiv[i] = Convert.ToInt32(Console.ReadLine());
}

// var str = string.Join(" ", Massiv);
//     Console.WriteLine(str);

int ColPolNum()
{
    for (int i = 0; i < AmOfNum; i++)
    {
        if (Massiv[i]>0)
        {
            PolNum = PolNum + 1;
        }
    }
    return PolNum;
}

Console.WriteLine(ColPolNum());*/

// Задание 43

Console.WriteLine("Введите пожалуйста k1");
int K1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите пожалуйста k2");
int K2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите пожалуйста b1");
int B1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите пожалуйста b2");
int B2 = Convert.ToInt32(Console.ReadLine());
double[] Massiv = new double [2];

double[] TochkaPeres()
{
    double x = 0;
    double y = 0;
    if (B1 != B2 && K1 == K2)
    {
        Console.WriteLine("Прямые параллельны и не имеют точек пересечения!");
    }
    else
    {
        // K1 * x + B1 = K2 * x + B2
        // ( K1 * x ) + ( K2 * x ) = B2 + B1
        int K3 = K1 + (K2 * -1);
        int B3 = (B1 * -1) + B2;
        // K3*x = B3
        x = (double)B3 / K3;
        y = K1 * x + B1;
        Massiv[0] = x;
        Massiv[1] = y;
        var str = string.Join("", Massiv);
    Console.WriteLine(str);
    }
    return Massiv;
}

var str = string.Join(" ", TochkaPeres());
    Console.WriteLine(str);
