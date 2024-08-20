using System.Text;
using System.Linq;
using System.Collections;
using System.Collections.Generic;


public class Programers_Level_2
{
    //https://school.programmers.co.kr/learn/courses/30/lessons/12939
    public string s12939(string s)
    {
        string[] split = s.Split(' ');
        int[] answerList = new int[split.Length];

        for (int i = 0; i < split.Length; i++)
        {
            answerList[i] = int.Parse(split[i]);
        }

        return $"{answerList.Min()} {answerList.Max()}";
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/12951
    public string s12951(string s)
    {
        StringBuilder sb = new StringBuilder();

        string[] split = s.Split(' ');

        for (int i = 0; i < split.Length; i++)
        {
            if (i != 0)
            {
                sb.Append(' ');
            }

            if (string.IsNullOrEmpty(split[i]))
            {
                continue;
            }

            sb.Append($"{char.ToUpper(split[i][0])}{split[i].Substring(1).ToLower()}");
        }

        return sb.ToString();
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/12941
    public int s12941(int[] A, int[] B)
    {
        int answer = 0;
        A = A.OrderBy(x => x).ToArray();
        B = B.OrderByDescending(x => x).ToArray();

        for (int i = 0; i < A.Length; i++)
        {
            answer += A[i] * B[i];
        }

        return answer;
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/12909
    public bool s12909(string s)
    {
        int value = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (char.Equals(s[i], '('))
            {
                value++;
            }
            else
            {
                value--;
            }

            if (value < 0)
                return false;
        }

        return value == 0;
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/70129
    public int[] s70129(string s)
    {
        int count = 0;
        int removeZeroCount = 0;

        while (s.Equals("1") == false)
        {
            count++;

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];

                if (c.Equals('0') == true)
                {
                    removeZeroCount++;
                }
            }

            s = s.Replace("0", "");
            s = Convert.ToString(s.Length, 2);
        }

        return new int[] { count, removeZeroCount };
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/12911
    public int s12911(int n)
    {
        int oneCount = Convert.ToString(n, 2).Count(x => x.Equals('1'));
        int nextN = n + 1;

        while (oneCount != Convert.ToString(nextN, 2).Count(x => x.Equals('1')))
        {
            nextN++;
        }

        return nextN;
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/12945
    public int s12945(int n)
    {
        List<int> sequence = new List<int>()
        {
            0, 1
        };

        for (int i = 2; i <= n; i++)
        {
            sequence.Add((sequence[i - 2] + sequence[i - 1]) % 1234567);
        }

        return sequence[n];
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/42842
    public int[] s42842(int brown, int yellow)
    {
        int tileCount = brown + yellow;

        for (int i = 3; i <= Math.Sqrt(tileCount); i++)
        {
            if (tileCount % i == 0)
            {
                int max = Math.Max(i, tileCount / i);
                int min = Math.Min(i, tileCount / i);

                if ((max * 2) + ((min - 2) * 2) == brown)
                {
                    return new int[] { max, min };
                }
            }
        }

        return new int[] { };
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/12980
    public int s12980(int n)
    {
        int answer = 0;
        while (n > 0)
        {
            if (n % 2 != 0)
            {
                answer++;
                n--;
            }

            n /= 2;
        }

        return answer;
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/138476
    public int s138476(int k, int[] tangerine)
    {
        Dictionary<int, int> dic = new Dictionary<int, int>();

        for (int i = 0; i < tangerine.Length; i++)
        {
            if (dic.ContainsKey(tangerine[i]) == false)
            {
                dic.Add(tangerine[i], 0);
            }

            dic[tangerine[i]]++;
        }

        int count = 0;
        int typeCount = 0;

        foreach (var v in dic.Values.OrderByDescending(x => x))
        {
            count += v;
            typeCount++;

            if (count >= k)
                break;

        }

        return typeCount;
    }
}