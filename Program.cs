using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Programers_Level_2.s176962 a = new Programers_Level_2.s176962();
        var v = a.solution(
          new string[,] {
            {"science", "12:40", "50"},
            {"music", "12:20", "40"},
            {"history", "14:00", "30"},
            {"computer", "12:30", "100"}
          }
        );
        // PrintArray(v);
        Console.WriteLine(v);
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
