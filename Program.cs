﻿namespace programers;
using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Programers_Level_0 p0 = new Programers_Level_0();
        Programers_Level_1 p1 = new Programers_Level_1();


        var v = p1.s92334(["muzi", "frodo", "apeach", "neo"], ["muzi frodo", "apeach frodo", "frodo neo", "muzi neo", "apeach muzi"], 2);

        // PrintArray(v);
        // Console.WriteLine(v);
    }

    public static void PrintArray<T>(T[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            T[] temp = new T[array.GetLength(0)];
            for (int m = 0; m < array.GetLength(1); m++)
            {
                temp[m] = array[i, m];
            }

            PrintArray(temp);
        }
    }
    public static void PrintArray<T>(T[] _array)
    {
        StringBuilder sb = new StringBuilder();

        sb.Append("[");

        for (int i = 0; i < _array.Length; i++)
        {
            if (i != 0)
                sb.Append(",");

            sb.Append(_array[i]);
        }

        sb.Append("]");

        Console.WriteLine(sb.ToString());
    }
}
