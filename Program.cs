using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Programers_Level_3.s132266 a = new Programers_Level_3.s132266();
        var v = a.solution(
            3,
            new int[,] {
                {1,2},
                {2,3}
            },
            [2, 3],
            1
        );

        var v2 = a.solution(
                        5,
            new int[,]{
                    {1, 2},
                    {1, 4},
                    {2, 4},
                    {2, 5},
                    {4, 5},
                },
                    [1, 3, 5], 5
        );

        PrintArray(v);
        PrintArray(v2);
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
