using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Programers_Level_2.s150368 a = new Programers_Level_2.s150368();
        var v = a.solution(
            new int[,]{
                 {40, 2900},
                 {23, 10000},
                 {11, 5200},
                 {5, 5900},
                 {40, 3100},
                 {27, 9200},
                 {32, 6900}
            },
            [1300, 1500, 1600, 4900]
        );
        PrintArray(v);
        // Console.WriteLine(v);
    }

    public static void PrintArray<T>(T[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            T[] temp = new T[array.GetLength(1)];
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
