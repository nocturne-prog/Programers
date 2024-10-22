using System.Text;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class Programers_Level_3
{
    //https://school.programmers.co.kr/learn/courses/30/lessons/161988
    public class s161988
    {
        public long solution(int[] sequence)
        {
            long[] pulse1 = new long[sequence.Length];
            long[] pulse2 = new long[sequence.Length];

            for (int i = 0; i < sequence.Length; i++)
            {
                if (i % 2 == 0)
                {
                    pulse1[i] = sequence[i];
                    pulse2[i] = -sequence[i];
                }
                else
                {
                    pulse1[i] = -sequence[i];
                    pulse2[i] = sequence[i];
                }
            }

            long a = GetMax(pulse1);
            long b = GetMax(pulse2);

            return Math.Max(a, b);
        }

        private long GetMax(long[] array)
        {
            long a = array[0];
            long b = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                a = Math.Max(array[i], a + array[i]);

                if (a > b)
                {
                    b = a;
                }
            }

            return b;
        }
    }

    //https://school.programmers.co.kr/learn/courses/30/lessons/132266
    public class s132266
    {
        public int[] solution(int n, int[,] roads, int[] sources, int destination)
        {
            List<int> answer = new List<int>();
            Dictionary<int, HashSet<int>> map = new Dictionary<int, HashSet<int>>();

            for (int i = 0; i < roads.GetLength(0); i++)
            {
                int a = roads[i, 0];
                int b = roads[i, 1];

                if (map.ContainsKey(a) == false)
                {
                    map.Add(a, new HashSet<int>());
                }

                if (map.ContainsKey(b) == false)
                {
                    map.Add(b, new HashSet<int>());
                }

                map[a].Add(b);
                map[b].Add(a);
            }

            for (int i = 0; i < sources.Length; i++)
            {
                answer.Add(MoveCount(sources[i], destination, map));
            }

            return answer.ToArray();
        }

        private int MoveCount(int start, int destination, Dictionary<int, HashSet<int>> map)
        {
            Queue<(int s, int d, int c)> queue = new Queue<(int s, int d, int c)>();

            if (map.ContainsKey(start) == false)
                return -1;

            foreach (var v in map[start])
                queue.Enqueue((start, v, 0));

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();

                if (current.s == destination)
                {
                    return current.c;
                }

                if (current.d == destination)
                {
                    return current.c + 1;
                }

                if (map.ContainsKey(current.d) == true)
                {
                    foreach (var v in map[current.d])
                    {
                        if (v != current.s)
                        {
                            queue.Enqueue((current.d, v, current.c + 1));
                        }
                    }
                }
            }

            return -1;
        }
    }

    //https://school.programmers.co.kr/learn/courses/30/lessons/12904
    public class s12904
    {
        public int solution(string s)
        {
            int answer = 0;

            for (int i = 0; i < s.Length; i++)
            {
                answer = Math.Max(answer, ExpandAroundCenter(s, i, i));
            }


            for (int i = 0; i < s.Length - 1; i++)
            {
                answer = Math.Max(answer, ExpandAroundCenter(s, i, i + 1));
            }

            return answer;
        }

        private int ExpandAroundCenter(string s, int left, int right)
        {
            int length = 0;
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                length = right - left + 1;
                left--;
                right++;
            }
            return length;
        }
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/77486
    public class s77486
    {
        public int[] solution(string[] enroll, string[] referral, string[] seller, int[] amount)
        {
            Dictionary<string, string> list = new Dictionary<string, string>();
            Dictionary<string, int> result = new Dictionary<string, int>();

            for (int i = 0; i < enroll.Length; i++)
            {
                list.Add(enroll[i], referral[i]);
                result.Add(enroll[i], 0);
            }

            for (int i = 0; i < seller.Length; i++)
            {
                string name = seller[i];
                int earnCoin = amount[i] * 100;

                while (name.Equals("-") == false && earnCoin > 0)
                {
                    int value = earnCoin / 10;
                    result[name] += earnCoin - value;
                    earnCoin = value;
                    name = list[name];
                }
            }

            return result.Values.ToArray();
        }
    }
}