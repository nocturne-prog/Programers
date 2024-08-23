using System.Text;
using System.Linq;
using System.Collections;
using System.Collections.Generic;


public class Programers_Level_2
{
    //최대공약수 구하기
    public int GreatestCommonDivisor(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }


    //최소공배수 구하기
    public int LeastCommonMultiple(int a, int b)
    {
        return (a * b) / GreatestCommonDivisor(a, b);
    }

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


    //https://school.programmers.co.kr/learn/courses/30/lessons/12985
    public int s12985(int n, int a, int b)
    {
        int answer = 0;

        while (a != b)
        {
            a = (a + 1) / 2;
            b = (b + 1) / 2;

            answer++;
        }

        return answer;
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/12981
    public int[] s12981(int n, string[] words)
    {
        List<string> list = new List<string>();
        string prevWords = words[0];

        list.Add(prevWords);
        for (int i = 1; i < words.Length; i++)
        {
            char tail = prevWords[prevWords.Length - 1];
            char head = words[i][0];

            if (tail.Equals(head) == true && list.Contains(words[i]) == false)
            {
                prevWords = words[i];
                list.Add(words[i]);
            }
            else
            {
                return new int[] { (i % n) + 1, (i / n) + 1 };
            }
        }

        return new int[] { 0, 0 };
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/12953
    public int s12953(int[] arr)
    {
        Array.Sort(arr);
        int answer = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            answer = LeastCommonMultiple(answer, arr[i]);
        }

        return answer;
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/12914
    public long s12914(int n)
    {
        if (n == 1) return 1;
        if (n == 2) return 2;

        int[] dp = new int[n + 1];
        dp[1] = 1;
        dp[2] = 2;

        for (int i = 3; i <= n; i++)
        {
            dp[i] = (dp[i - 1] + dp[i - 2]) % 1234567;
        }

        return dp[n];
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/131701
    public int s131701(int[] elements)
    {
        HashSet<int> answerList = new HashSet<int>(elements);
        answerList.Add(elements.Sum());

        for (int i = 2; i < elements.Length; i++)
        {
            int length = i;
            int count = elements.Length - length + 1;

            for (int m = 0; m < elements.Length; m++)
            {
                int value = 0;
                for (int h = 0; h < count; h++)
                {
                    int idx = (m + h) % elements.Length;
                    value += elements[idx];
                }

                answerList.Add(value);
            }
        }

        return answerList.Count;
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/131127
    public int s131127(string[] want, int[] number, string[] discount)
    {
        int answer = 0;

        List<string> wantList = new List<string>();

        for (int i = 0; i < want.Length; i++)
        {
            for (int m = 0; m < number[i]; m++)
            {
                wantList.Add(want[i]);
            }
        }

        wantList.Sort();

        for (int i = 0; i < discount.Length; i++)
        {
            List<string> v = discount.Skip(i).Take(10).ToList();
            v.Sort();

            if (wantList.SequenceEqual(v))
            {
                answer++;
            }
        }

        return answer;
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/76502
    public int s76502(string s)
    {
        int answer = 0;

        for (int i = 0; i < s.Length; i++)
        {
            bool isValid = true;
            Stack<char> stack = new Stack<char>();
            for (int m = 0; m < s.Length; m++)
            {
                if (s[m] == '(' || s[m] == '{' || s[m] == '[')
                {
                    stack.Push(s[m]);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        isValid = false;
                        break;
                    }
                    else
                    {
                        char pop = stack.Pop();

                        if ((s[m] == ')' && pop != '(') ||
                            (s[m] == '}' && pop != '{') ||
                            (s[m] == ']' && pop != '['))
                        {
                            isValid = false;
                            break;
                        }
                    }
                }
            }

            if (isValid == true && stack.Count == 0)
            {
                answer++;
            }

            s = s.Substring(1) + s[0];
        }

        return answer;
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/87390
    public int[] s87390(int n, long left, long right)
    {
        int[] answer = new int[right - left + 1];

        for (long k = left; k <= right; k++)
        {
            long row = k / n;
            long col = k % n;
            answer[k - left] = (int)(Math.Max(row, col) + 1);
        }

        return answer;
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/42747
    public int s42747(int[] citations)
    {
        int answer = 0;

        for (int i = citations.Length; i > 0; i--)
        {
            int count = citations.Count(x => x >= i);

            if (count >= i)
            {
                answer = i;
                break;
            }
        }

        return answer;
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/42578
    public int s42578(string[,] clothes)
    {
        Dictionary<string, int> dic = new Dictionary<string, int>();

        for (int i = 0; i < clothes.GetLength(0); i++)
        {
            string key = clothes[i, 1];

            if (dic.ContainsKey(key) == false)
            {
                dic.Add(key, 0);
            }

            dic[key]++;
        }

        int answer = 1;

        foreach (var v in dic)
        {
            answer *= (v.Value + 1);
        }

        answer--;
        return answer;
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/12949
    public int[,] s12949(int[,] arr1, int[,] arr2)
    {
        int[,] answer = new int[arr1.GetLength(0), arr2.GetLength(1)];

        for (int i = 0; i < answer.GetLength(0); i++)
        {
            for (int m = 0; m < answer.GetLength(1); m++)
            {
                answer[i, m] = 0;

                for (int h = 0; h < arr1.GetLength(1); h++)
                {
                    answer[i, m] += (arr1[i, h] * arr2[h, m]);
                }
            }
        }

        return answer;
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/87946
    public class s87946
    {
        int maxCount = 0;
        public int solution(int k, int[,] dungeons)
        {
            bool[] visited = new bool[dungeons.GetLength(0)];
            DFS(k, dungeons, visited, 0);

            return maxCount;
        }

        public void DFS(int k, int[,] dungeons, bool[] visited, int count)
        {
            for (int i = 0; i < dungeons.GetLength(0); i++)
            {
                if (visited[i] == false && k >= dungeons[i, 0])
                {
                    visited[i] = true;
                    DFS(k - dungeons[i, 1], dungeons, visited, count + 1);
                    visited[i] = false;
                }
            }

            maxCount = Math.Max(maxCount, count);
        }
    }
}