using System.Text;
using System.Linq;
using System.Collections;
using System.Collections.Generic;


public class Programers_Level_1
{
    public List<int> GetDivisors(int n)
    {
        List<int> divisors = new List<int>();

        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                divisors.Add(i);
            }
        }

        return divisors;
    }

    //https://school.programmers.co.kr/learn/courses/30/lessons/12928
    public int s12928(int n)
    {
        int answer = GetDivisors(n).Sum();
        return answer;
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/87389
    public int s87389(int n)
    {
        int answer = 1;

        while (true)
        {
            int value = n % answer;

            if (value == 1)
                break;

            answer++;
        }

        return answer;
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/12912
    public long s12912(int a, int b)
    {
        long answer = 0;
        int min = Math.Min(a, b);
        int max = Math.Max(a, b);

        for (int i = min; i <= max; i++)
        {
            answer += i;
        }

        return answer;
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/12910
    public int[] s12910(int[] arr, int divisor)
    {
        var answer = arr.Where(x => x % divisor == 0)
                        .OrderBy(x => x)
                        .ToList();

        if (answer.Count > 0)
            return answer.ToArray();
        else
            return new int[] { -1 };
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/86051
    public int s86051(int[] numbers)
    {
        int answer = 0;

        for (int i = 0; i < 10; i++)
        {
            if (numbers.Contains(i) == false)
            {
                answer += i;
            }
        }

        return answer;
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/76501
    public int s76501(int[] absolutes, bool[] signs)
    {
        for (int i = 0; i < absolutes.Length; i++)
        {
            absolutes[i] = signs[i] ? absolutes[i] : -absolutes[i];
        }

        return absolutes.Sum();
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/12919
    public string s12919(string[] seoul)
    {
        for (int i = 0; i < seoul.Length; i++)
        {
            if (seoul[i].Equals("Kim") == true)
            {
                return $"김서방은 {i}에 있다";
            }
        }

        return string.Empty;
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/77884
    public int s77884(int left, int right)
    {
        int answer = 0;
        for (int i = left; i <= right; i++)
        {
            int count = GetDivisors(i).Count;

            if (count % 2 == 0)
            {
                answer += i;
            }
            else
            {
                answer -= i;
            }
        }

        return answer;
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/70128
    public int s70128(int[] a, int[] b)
    {
        int answer = 0;

        for (int i = 0; i < a.Length; i++)
        {
            answer += (a[i] * b[i]);
        }

        return answer;
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/12922
    public string s12922(int n)
    {
        string answer = "";

        for (int i = 0; i < n; i++)
        {
            answer += i % 2 == 1 ? "박" : "수";
        }

        return answer;
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/12917
    public string s12917(string s)
    {
        char[] charArray = s.ToCharArray();
        return new string(charArray.OrderByDescending(x => x).ToArray());
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/82612
    public long s82612(int price, int money, int count)
    {
        long answer = 0;

        for (int i = 1; i <= count; i++)
        {
            answer += price * i;
        }

        if (money >= answer)
            return 0;
        else
            return answer - money;
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/12918
    public bool s12918(string s)
    {
        if (s.Length == 4 || s.Length == 6)
        {
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];

                if (char.IsDigit(c) == false)
                {
                    return false;
                }
            }

            return true;
        }
        else
        {
            return false;
        }
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/147355
    public int s147355(string t, string p)
    {
        List<long> list = new List<long>();

        for (int i = 0; i <= t.Length - p.Length; i++)
        {
            string value = t.Substring(i, p.Length);
            list.Add(long.Parse(value));
        }

        return list.Count(x => long.Parse(p) >= x);
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/68935
    public int s68935(int n)
    {
        int answer = 0;
        int value = n;
        string n3 = "";

        while (value != 0)
        {
            n3 += value % 3;
            value /= 3;
        }

        char[] charArray = n3.ToCharArray();
        Array.Reverse(charArray);

        for (int i = 0; i < charArray.Length; i++)
        {
            int multiplier = charArray[i] - '0';
            answer += (int)Math.Pow(3, i) * multiplier;
        }

        return answer;
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/131705
    public int s131705(int[] number)
    {
        int count = 0;
        int n = number.Length;

        for (int i = 0; i < n - 2; i++)
        {
            for (int j = i + 1; j < n - 1; j++)
            {
                for (int k = j + 1; k < n; k++)
                {
                    if (number[i] + number[j] + number[k] == 0)
                    {
                        count++;
                    }
                }
            }
        }

        return count;
    }
}