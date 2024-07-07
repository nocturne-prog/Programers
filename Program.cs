namespace programers;
using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Programers_Level_0 p0 = new Programers_Level_0();
        int v = p0.s181864("ABBAA", "AABB");

        // PrintArray(v);
        // Console.ReadLine();
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
