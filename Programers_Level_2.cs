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


    //https://school.programmers.co.kr/learn/courses/30/lessons/42586
    public class s42586
    {
        public int[] solution(int[] progresses, int[] speeds)
        {
            List<int> answer = new List<int>();
            int index = 0;

            while (index < progresses.Length)
            {
                if (progresses[index] == 100)
                {
                    int count = 0;
                    for (int i = index; i < progresses.Length; i++)
                    {
                        if (progresses[i] == 100)
                        {
                            count++;
                        }
                        else
                        {
                            break;
                        }
                    }

                    index += count;
                    answer.Add(count);
                }
                else
                {
                    progresses = Next(progresses, speeds);
                }
            }

            return answer.ToArray();
        }

        public int[] Next(int[] progresses, int[] speeds)
        {
            for (int i = 0; i < progresses.Length; i++)
            {
                progresses[i] = Math.Clamp(progresses[i] + speeds[i], 0, 100);
            }

            return progresses;
        }
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/43165
    public class s43165
    {
        public int solution(int[] numbers, int target)
        {
            return DFS(numbers, target, 0, 0);
        }

        public int DFS(int[] numbers, int target, int index, int sum)
        {
            if (index == numbers.Length)
            {
                return sum == target ? 1 : 0;
            }

            int c1 = DFS(numbers, target, index + 1, sum + numbers[index]);
            int c2 = DFS(numbers, target, index + 1, sum - numbers[index]);

            return c1 + c2;
        }
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/84512
    public class s84512
    {
        public int solution(string word)
        {
            string vowels = "AEIOU";
            int[] multiplier = { 781, 156, 31, 6, 1 }; // 각 자리의 가중치

            int position = 0;

            for (int i = 0; i < word.Length; i++)
            {
                int index = vowels.IndexOf(word[i]);
                position += index * multiplier[i] + 1;
            }

            return position;
        }
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/1844
    public class s1844
    {
        public int solution(int[,] maps)
        {
            int[,] dir = new int[,]
            {
                { -1,  0 },
                {  1,  0 },
                {  0, -1 },
                {  0,  1 }
            };

            Queue<(int, int, int)> queue = new Queue<(int, int, int)>();
            queue.Enqueue((0, 0, 1));
            maps[0, 0] = 0;

            while (queue.Count > 0)
            {
                var (x, y, distance) = queue.Dequeue();

                for (int i = 0; i < dir.GetLength(0); i++)
                {
                    int moveX = x + dir[i, 0];
                    int moveY = y + dir[i, 1];

                    if (moveY >= 0 && moveY < maps.GetLength(1) && moveX >= 0 && moveX < maps.GetLength(0) && maps[moveX, moveY] == 1)
                    {
                        if (moveX == maps.GetLength(0) - 1 && moveY == maps.GetLength(1) - 1)
                        {
                            return distance + 1;
                        }

                        maps[moveX, moveY] = 0;
                        queue.Enqueue((moveX, moveY, distance + 1));
                    }
                }
            }

            return -1;
        }

    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/92335
    public class s92335
    {
        public int solution(int n, int k)
        {
            int count = 0;
            string stringN = ConvertToBase(n, k);
            char[] arrayN = stringN.ToCharArray();

            string value = string.Empty;
            for (int i = 0; i < arrayN.Length; i++)
            {
                char c = arrayN[i];

                if (c.Equals('0') == false)
                {
                    value += c;
                }
                else
                {
                    if (string.IsNullOrEmpty(value))
                        continue;

                    if (IsPrimeNumber(long.Parse(value)))
                    {
                        count++;
                    }

                    value = "";
                }
            }

            if (string.IsNullOrEmpty(value) == false && IsPrimeNumber(long.Parse(value)))
            {
                count++;
            }

            return count;
        }

        public string ConvertToBase(int n, int k)
        {
            if (n == 0) return "0";

            string result = "";
            while (n > 0)
            {
                int remainder = n % k;
                result = remainder.ToString() + result;
                n /= k;
            }

            return result;
        }

        public bool IsPrimeNumber(long num)
        {
            if (num <= 1)
                return false;

            if (num == 2)
                return true;

            if (num % 2 == 0)
                return false;

            int sqrt = (int)Math.Sqrt(num);
            for (int i = 3; i <= sqrt; i += 2)
            {
                if (num % i == 0)
                    return false;
            }

            return true;
        }
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/49994
    public class s49994
    {
        public int solution(string dirs)
        {
            HashSet<(int, int, int, int)> hashSet = new HashSet<(int, int, int, int)>();

            int x = 0, y = 0;

            for (int i = 0; i < dirs.Length; i++)
            {
                char command = dirs[i];
                int newX = x, newY = y;

                if (command.Equals('U'))
                {
                    newY++;
                }
                else if (command.Equals('D'))
                {
                    newY--;
                }
                else if (command.Equals('L'))
                {
                    newX--;
                }
                else
                {
                    newX++;
                }

                if (Math.Abs(newX) <= 5 && Math.Abs(newY) <= 5)
                {
                    if (hashSet.Contains((newX, newY, x, y)) == false)
                    {
                        hashSet.Add((x, y, newX, newY));
                    }

                    x = newX;
                    y = newY;
                }
            }

            return hashSet.Count;
        }
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/154539
    public class s154539
    {
        public int[] solution(int[] numbers)
        {
            int[] answer = new int[numbers.Length];

            for (int i = 0; i < answer.Length; i++)
            {
                answer[i] = -1;
            }

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                while (stack.Count > 0 && numbers[stack.Peek()] < numbers[i])
                {
                    int idx = stack.Pop();
                    answer[idx] = numbers[i];
                }

                stack.Push(i);
            }

            return answer;
        }
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/132265
    public class s132265
    {
        public int solution(int[] topping)
        {
            Dictionary<int, int> leftDic = new Dictionary<int, int>();
            Dictionary<int, int> rightDic = new Dictionary<int, int>();

            foreach (int t in topping)
            {
                if (rightDic.ContainsKey(t) == false)
                {
                    rightDic.Add(t, 0);
                }

                rightDic[t]++;
            }

            int answer = 0;

            foreach (int t in topping)
            {
                if (leftDic.ContainsKey(t) == false)
                {
                    leftDic.Add(t, 0);
                }

                leftDic[t]++;
                rightDic[t]--;

                if (rightDic[t] == 0)
                {
                    rightDic.Remove(t);
                }

                if (leftDic.Count == rightDic.Count)
                {
                    answer++;
                }
            }

            return answer;
        }
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/92341
    public class s92341
    {
        public int[] solution(int[] fees, string[] records)
        {
            int baseTime = fees[0];
            int baseFare = fees[1];
            int unitTime = fees[2];
            int unitFare = fees[3];

            Dictionary<string, int> parkingTimeDic = new Dictionary<string, int>();
            Dictionary<string, DateTime> parkingZoneDic = new Dictionary<string, DateTime>();

            for (int i = 0; i < records.Length; i++)
            {
                string[] split = records[i].Split(' ');
                DateTime date = DateTime.Parse(split[0]);
                string number = split[1];
                bool isIn = split[2].Equals("IN");

                if (isIn == true)
                {
                    parkingZoneDic.Add(number, date);
                }
                else
                {
                    DateTime inTime = parkingZoneDic[number];
                    parkingZoneDic.Remove(number);
                    int minute = (int)(date - inTime).TotalMinutes;

                    if (parkingTimeDic.ContainsKey(number) == false)
                    {
                        parkingTimeDic.Add(number, 0);
                    }

                    parkingTimeDic[number] += minute;
                }
            }

            foreach (var v in parkingZoneDic)
            {
                int minute = (int)(DateTime.Parse("23:59") - v.Value).TotalMinutes;

                if (parkingTimeDic.ContainsKey(v.Key) == false)
                {
                    parkingTimeDic.Add(v.Key, 0);
                }

                parkingTimeDic[v.Key] += minute;
            }

            int[] answer = new int[parkingTimeDic.Count];
            int idx = 0;

            foreach (var v in parkingTimeDic.OrderBy(x => x.Key))
            {
                int value = 0;

                if (v.Value <= baseTime)
                {
                    value = baseFare;
                }
                else
                {
                    int multiplier = (v.Value - baseTime) / unitTime;

                    if ((v.Value - baseTime) % unitTime != 0)
                    {
                        multiplier++;
                    }

                    value = baseFare + (multiplier * unitFare);
                }

                answer[idx] = value;
                idx++;

            }

            return answer;
        }
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/131704
    public class s131704
    {
        public int solution(int[] order)
        {
            Stack<int> stack = new Stack<int>();
            List<int> answer = new List<int>();
            int orderIndex = 0;
            int max = order.Max() + 1;

            for (int i = 1; i <= max; i++)
            {
                while (stack.Count > 0 && stack.Peek() == order[orderIndex])
                {
                    answer.Add(stack.Pop());
                    orderIndex++;
                }

                stack.Push(i);
            }

            return answer.Count;
        }
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/154538
    public class s154538
    {
        public int solution(int x, int y, int n)
        {
            if (x == y)
                return 0;

            int[] op = new int[]
            {
                0, // +
                1, // * 2
                2  // * 3
            };

            HashSet<int> visited = new HashSet<int>();
            Queue<(int, int)> queue = new Queue<(int, int)>();
            queue.Enqueue((0, x));

            while (queue.Count > 0)
            {
                var (count, value) = queue.Dequeue();

                for (int i = 0; i < op.Length; i++)
                {
                    int newValue = op[i] == 0 ? value + n : op[i] == 1 ? value * 2 : value * 3;

                    if (newValue == y)
                    {
                        return count + 1;
                    }
                    else
                    {
                        if (newValue < y && visited.Contains(newValue) == false)
                        {
                            visited.Add(newValue);
                            queue.Enqueue((count + 1, newValue));
                        }

                    }
                }

            }

            return -1;
        }
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/77885
    public class s77885
    {
        public long[] solution(long[] numbers)
        {
            long[] answer = new long[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                string binary = "0" + ConvertToBase(numbers[i], 2);

                for (int m = binary.Length - 1; m >= 0; m--)
                {
                    char c = binary[m];

                    if (c.Equals('0') == true)
                    {
                        char[] binaryArray = binary.ToCharArray();
                        binaryArray[m] = '1';

                        if (m != binary.Length - 1)
                        {
                            binaryArray[m + 1] = '0';
                        }

                        string newBinary = new string(binaryArray);
                        answer[i] = Convert.ToInt64(newBinary, 2);
                        break;
                    }
                }
            }

            return answer;
        }

        public string ConvertToBase(long n, int k)
        {
            if (n == 0) return "0";

            string result = "";
            while (n > 0)
            {
                long remainder = n % k;
                result = remainder.ToString() + result;
                n /= k;
            }

            return result;
        }
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/42583
    public class s42583
    {
        public int solution(int bridge_length, int weight, int[] truck_weights)
        {
            Queue<int> bridgeQueue = new Queue<int>();
            int index = 0;
            int totalWeight = 0;
            int time = 0;

            for (int i = 0; i < bridge_length; i++)
            {
                bridgeQueue.Enqueue(0);
            }

            while (bridgeQueue.Count > 0)
            {
                time++;

                totalWeight -= bridgeQueue.Dequeue();

                if (index < truck_weights.Length)
                {
                    if (totalWeight + truck_weights[index] <= weight)
                    {
                        bridgeQueue.Enqueue(truck_weights[index]);
                        totalWeight += truck_weights[index];
                        index++;
                    }
                    else
                    {
                        bridgeQueue.Enqueue(0);
                    }
                }
            }

            return time;
        }
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/118667
    public class s118667
    {
        public int solution(int[] queue1, int[] queue2)
        {
            long queue1Sum = 0, queue2Sum = 0;

            foreach (var v in queue1)
                queue1Sum += v;

            foreach (var v in queue2)
                queue2Sum += v;

            long totalSum = queue1Sum + queue2Sum;
            long targetSum = totalSum / 2;

            if (totalSum % 2 != 0)
                return -1;

            int[] array = queue1.Concat(queue2).ToArray();
            int leftIdx = 0, rightIdx = queue1.Length;
            long currentSum = queue1Sum;
            int answer = 0;

            while (leftIdx < array.Length && rightIdx < array.Length)
            {
                if (currentSum == targetSum)
                    return answer;

                if (currentSum > targetSum)
                {
                    currentSum -= array[leftIdx++];
                }
                else
                {
                    currentSum += array[rightIdx++];
                }

                answer++;
            }

            return -1;
        }
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/42839
    public class s42839
    {
        HashSet<int> numberList = new HashSet<int>();
        public int solution(string numbers)
        {
            int answer = 0;

            CreateNumber("", numbers.ToCharArray(), new bool[numbers.Length]);

            foreach (var v in numberList)
            {
                if (IsPrimeNumber(v) == true)
                {
                    answer++;
                }
            }


            return answer;
        }

        public void CreateNumber(string value, char[] numbers, bool[] visited)
        {
            if (value.Length > 0)
            {
                numberList.Add(int.Parse(value));
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (visited[i] == true)
                    continue;

                visited[i] = true;
                CreateNumber(value + numbers[i], numbers, visited);
                visited[i] = false;
            }
        }

        public bool IsPrimeNumber(int num)
        {
            if (num <= 1)
                return false;

            if (num == 2)
                return true;

            if (num % 2 == 0)
                return false;

            int sqrt = (int)Math.Sqrt(num);
            for (int i = 3; i <= sqrt; i += 2)
            {
                if (num % i == 0)
                    return false;
            }

            return true;
        }
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/68936
    public class s68936
    {
        int[] answer = new int[2];
        public int[] solution(int[,] arr)
        {
            int length = arr.GetLength(0);
            Compress(arr, 0, 0, length);

            return answer;
        }

        public void Compress(int[,] arr, int x, int y, int size)
        {
            if (SameArea(arr, x, y, size) == true)
            {
                answer[arr[x, y]]++;
            }
            else
            {
                int newSize = size / 2;

                Compress(arr, x, y, newSize);
                Compress(arr, x, y + newSize, newSize);
                Compress(arr, x + newSize, y, newSize);
                Compress(arr, x + newSize, y + newSize, newSize);
            }
        }

        public bool SameArea(int[,] arr, int x, int y, int size)
        {
            int value = arr[x, y];

            for (int i = x; i < x + size; i++)
            {
                for (int m = y; m < y + size; m++)
                {
                    if (arr[i, m] != value)
                        return false;
                }
            }

            return true;
        }
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/42746
    public class s42746
    {
        public string solution(int[] numbers)
        {
            List<string> list = new List<string>();

            for (int i = 0; i < numbers.Length; i++)
            {
                list.Add(numbers[i].ToString());
            }

            list.Sort((x, y) => (y + x).CompareTo(x + y));

            StringBuilder sb = new StringBuilder();

            foreach (var v in list)
            {
                sb.Append(v);
            }

            if (sb.ToString().StartsWith('0'))
                return "0";

            return sb.ToString();
        }
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/68645
    public class s68645
    {
        public int[] solution(int n)
        {
            int[,] map = new int[n, n];
            int dir = 0;
            int[] dirRow = new int[] { 1, 0, -1 };
            int[] dirCol = new int[] { 0, 1, -1 };
            int row = 0, col = 0, number = 1;


            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int m = i; m < map.GetLength(1); m++)
                {
                    map[row, col] = number++;

                    int newRow = row + dirRow[dir];
                    int newCol = col + dirCol[dir];

                    if (newRow < 0 || newCol < 0 || newRow >= n || newCol >= n || map[newRow, newCol] != 0)
                    {
                        dir = (dir + 1) % 3;
                        newRow = row + dirRow[dir];
                        newCol = col + dirCol[dir];
                    }

                    row = newRow;
                    col = newCol;
                }
            }

            List<int> answer = new List<int>();

            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int m = 0; m < map.GetLength(1); m++)
                {
                    if (map[i, m] == 0)
                        continue;

                    answer.Add(map[i, m]);
                }
            }

            return answer.ToArray();
        }
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/178870
    public class s178870
    {
        public int[] solution(int[] sequence, int k)
        {
            int start = 0, end = 0, minLength = int.MaxValue;
            int sum = 0;
            int a = 0, b = 0;

            while (end < sequence.Length)
            {
                sum += sequence[end];

                while (sum > k && start <= end)
                {
                    sum -= sequence[start];
                    start++;
                }

                if (sum == k)
                {
                    int legnth = end - start + 1;

                    if (legnth < minLength)
                    {
                        minLength = legnth;
                        a = start;
                        b = end;
                    }
                }

                end++;
            }

            return new int[] { a, b };
        }
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/42883
    public class s42883
    {
        public string solution(string number, int k)
        {
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < number.Length; i++)
            {
                char value = number[i];

                while (stack.Count > 0 && k > 0 && stack.Peek() < value)
                {
                    stack.Pop();
                    k--;
                }

                stack.Push(value);
            }

            while (k > 0)
            {
                stack.Pop();
                k--;
            }

            char[] resultArray = stack.ToArray();
            Array.Reverse(resultArray);
            return new string(resultArray);
        }
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/155651
    public class s155651
    {
        public int solution(string[,] book_time)
        {
            List<(DateTime enter, DateTime exit)> list = new List<(DateTime enter, DateTime exit)>();

            for (int i = 0; i < book_time.GetLength(0); i++)
            {
                DateTime enter = DateTime.Parse(book_time[i, 0]);
                DateTime exit = DateTime.Parse(book_time[i, 1]).AddMinutes(10);

                list.Add((enter, exit));
            }

            list = list.OrderBy(x => x.enter).ToList();

            List<int> room = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                DateTime cTime = list[i].enter;

                int roomIdx = -1;

                for (int m = 0; m < room.Count; m++)
                {
                    DateTime extiTime = list[room[m]].exit;

                    if (cTime >= extiTime)
                    {
                        room[m] = i;
                        roomIdx = m;
                        break;
                    }
                }

                if (roomIdx < 0)
                    room.Add(i);
            }

            return room.Count;
        }
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/152996
    public class s152996
    {
        public long solution(int[] weights)
        {
            long answer = 0;

            Dictionary<int, long> count = new Dictionary<int, long>();
            double[] ratios = new double[] {
                2.0/3.0,
                2.0/4.0,
                3.0/2.0,
                3.0/4.0,
                4.0/2.0,
                4.0/3.0
            };

            foreach (var weight in weights)
            {
                if (count.ContainsKey(weight) == false)
                {
                    count.Add(weight, 0);
                }

                count[weight]++;
            }

            foreach (var weight in weights)
            {
                if (count[weight] == 0)
                    continue;

                if (count[weight] > 1)
                {
                    answer += (count[weight] * (count[weight] - 1)) / 2;
                }

                foreach (var ratio in ratios)
                {
                    double other = weight * ratio;

                    if (other != weight && other % 1 == 0 && count.ContainsKey((int)other) == true)
                    {
                        answer += count[weight] * count[(int)other];
                    }
                }

                count[weight] = 0;
            }

            return answer;
        }
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/148653
    public class s148653
    {
        public int solution(int storey)
        {
            int answer = 0;

            while (storey > 0)
            {
                int value = storey % 10;
                storey /= 10;

                if (value > 5 || (value == 5 && storey % 10 >= 5))
                {
                    answer += (10 - value);
                    storey++;
                }
                else
                {
                    answer += value;
                }
            }

            return answer;
        }
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/135807
    public class s135807
    {
        public int solution(int[] arrayA, int[] arrayB)
        {
            int a = GetGCD(arrayA);
            int b = GetGCD(arrayB);

            int resultA = CanDivide(arrayB, a) ? a : 0;
            int resultB = CanDivide(arrayA, b) ? b : 0;

            return Math.Max(resultA, resultB);
        }

        private int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        private int GetGCD(int[] array)
        {
            int gcd = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                gcd = GCD(gcd, array[i]);
            }
            return gcd;
        }

        private bool CanDivide(int[] array, int gcd)
        {
            foreach (int num in array)
            {
                if (num % gcd == 0) return false;
            }
            return true;
        }
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/86971
    public class s86971
    {
        public int solution(int n, int[,] wires)
        {
            int answer = int.MaxValue;

            for (int i = 0; i < wires.GetLength(0); i++)
            {
                int a = wires[i, 0];
                int b = wires[i, 1];

                int countA = GetCount(i, a, wires);
                int countB = GetCount(i, b, wires);

                int gap = Math.Abs(countA - countB);
                answer = Math.Min(answer, gap);
            }

            return answer > n ? 0 : answer;
        }

        private int GetCount(int startIdx, int start, int[,] wires)
        {
            int count = 0;

            List<(int, int)> list = new List<(int, int)>();

            for (int i = 0; i < wires.GetLength(0); i++)
            {
                if (i == startIdx)
                    continue;

                list.Add((wires[i, 0], wires[i, 1]));
            }

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(start);

            while (queue.Count > 0)
            {
                count++;

                int des = queue.Dequeue();
                var next = list.Where(x => x.Item1 == des || x.Item2 == des).ToList();

                if (next != null)
                {
                    foreach (var v in next)
                    {
                        list.Remove(v);
                        queue.Enqueue(des == v.Item1 ? v.Item2 : v.Item1);
                    }
                }
            }

            return count;
        }
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/12978
    public class s12978
    {
        HashSet<int> list = new HashSet<int>();

        public int solution(int N, int[,] road, int K)
        {
            List<(int, int, int)> roadList = new List<(int, int, int)>();

            for (int i = 0; i < road.GetLength(0); i++)
            {
                roadList.Add((road[i, 0], road[i, 1], road[i, 2]));
                roadList.Add((road[i, 1], road[i, 0], road[i, 2]));
            }

            bool[] visited = new bool[N];
            visited[0] = true;
            DFS(roadList, 1, K, 0, visited);

            list.Add(1);

            return list.Count;
        }

        public void DFS(List<(int, int, int)> road, int cPoint, int K, int tLength, bool[] visited)
        {
            for (int i = 0; i < road.Count; i++)
            {
                int startPoint = road[i].Item1;
                int endPoint = road[i].Item2;
                int length = road[i].Item3;

                if (startPoint != cPoint || visited[endPoint - 1] == true)
                    continue;

                if (tLength + length <= K)
                {
                    visited[endPoint - 1] = true;
                    list.Add(endPoint);
                    DFS(road, endPoint, K, tLength + length, visited);
                    visited[endPoint - 1] = false;
                }
            }
        }

        public int solution2(int N, int[,] road, int K)
        {
            List<(int, int)>[] list = new List<(int, int)>[N + 1];

            for (int i = 0; i < N + 1; i++)
            {
                list[i] = new List<(int, int)>();
            }

            for (int i = 0; i < road.GetLength(0); i++)
            {
                int a = road[i, 0];
                int b = road[i, 1];
                int c = road[i, 2];

                list[a].Add((b, c));
                list[b].Add((a, c));
            }

            int[] dist = new int[N + 1];
            Array.Fill(dist, int.MaxValue);
            dist[1] = 0;

            // PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
            // pq.Enqueue(1, 0);

            List<(int, int)> pq = new List<(int, int)>();
            pq.Add((1, 0));

            while (pq.Count > 0)
            {
                var item = pq[0];
                pq.Remove(item);

                foreach (var v in list[item.Item1])
                {
                    int nextDist = dist[item.Item1] + v.Item2;

                    if (nextDist < dist[v.Item1])
                    {
                        dist[v.Item1] = nextDist;
                        pq.Add((v.Item1, nextDist));

                        pq = pq.OrderBy(x => x.Item2).ToList();
                    }
                }
            }

            int answer = 0;

            for (int i = 1; i < dist.Length; i++)
            {
                if (dist[i] <= K)
                    answer++;
            }

            return answer++;
        }
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/159993
    public class s159993
    {
        public int solution(string[] maps)
        {
            char[,] map = new char[maps.Length, maps[0].Length];

            int startRow = 0, startCol = 0, leverRow = 0, leverCol = 0, exitRow = 0, exitCol = 0;

            for (int row = 0; row < maps.Length; row++)
            {
                for (int col = 0; col < maps[row].Length; col++)
                {
                    char c = maps[row][col];

                    if (c.Equals('S') == true)
                    {
                        startRow = row;
                        startCol = col;
                    }
                    else if (c.Equals('E') == true)
                    {
                        exitRow = row;
                        exitCol = col;
                    }
                    else if (c.Equals('L') == true)
                    {
                        leverRow = row;
                        leverCol = col;
                    }

                    map[row, col] = c;
                }
            }

            int goLever = GetLength(map, startRow, startCol, leverRow, leverCol);
            int goExit = GetLength(map, leverRow, leverCol, exitRow, exitCol);

            if (goLever < 0 || goExit < 0)
                return -1;

            return goLever + goExit;
        }

        public int GetLength(char[,] maps, int cRow, int cCol, int targetRow, int targetCol)
        {
            int[] dRow = new int[] { -1, 1, 0, 0 };
            int[] dCol = new int[] { 0, 0, -1, 1 };

            bool[,] visited = new bool[maps.GetLength(0), maps.GetLength(1)];
            visited[cRow, cCol] = true;

            Queue<(int row, int col, int count)> queue = new Queue<(int row, int col, int count)>();
            queue.Enqueue((cRow, cCol, 0));

            while (queue.Count > 0)
            {
                var (r, c, t) = queue.Dequeue();

                if (r == targetRow && c == targetCol)
                {
                    return t;
                }

                for (int i = 0; i < dRow.Length; i++)
                {
                    int dr = dRow[i];
                    int dc = dCol[i];

                    int newRow = r + dr;
                    int newCol = c + dc;

                    if (newRow >= 0 && newCol >= 0 && newRow < maps.GetLength(0) && newCol < maps.GetLength(1) && visited[newRow, newCol] == false && maps[newRow, newCol] != 'X')
                    {
                        queue.Enqueue((newRow, newCol, t + 1));
                        visited[newRow, newCol] = true;
                    }
                }
            }

            return -1;
        }
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/154540
    public class s154540
    {
        public int[] solution(string[] maps)
        {
            char[,] map = new char[maps.Length, maps[0].Length];

            for (int row = 0; row < maps.Length; row++)
            {
                for (int col = 0; col < maps[row].Length; col++)
                {
                    map[row, col] = maps[row][col];
                }
            }

            bool[,] visited = new bool[maps.Length, maps[0].Length];
            List<int> answer = new List<int>();

            for (int row = 0; row < maps.GetLength(0); row++)
            {
                for (int col = 0; col < maps[row].Length; col++)
                {
                    if (visited[row, col] == true || map[row, col] == 'X')
                        continue;

                    answer.Add(Plus(map, row, col, visited));
                }
            }

            if (answer.Count == 0)
            {
                return new int[] { -1 };
            }
            else
            {
                return answer.OrderBy(x => x).ToArray();
            }
        }

        public int Plus(char[,] map, int row, int col, bool[,] visited)
        {
            int[] dRow = new int[] { -1, 1, 0, 0 };
            int[] dCol = new int[] { 0, 0, -1, 1 };

            Queue<(int, int)> queue = new Queue<(int, int)>();
            queue.Enqueue((row, col));

            int result = map[row, col] - '0';

            visited[row, col] = true;

            while (queue.Count > 0)
            {
                var (r, c) = queue.Dequeue();

                for (int i = 0; i < dRow.Length; i++)
                {
                    int newRow = r + dRow[i];
                    int newCol = c + dCol[i];

                    if (newRow >= 0 && newCol >= 0 &&
                        newRow < map.GetLength(0) && newCol < map.GetLength(1) &&
                        visited[newRow, newCol] == false &&
                        map[newRow, newCol] != 'X')
                    {
                        queue.Enqueue((newRow, newCol));
                        result += map[newRow, newCol] - '0';
                        visited[newRow, newCol] = true;
                    }
                }
            }

            return result;
        }
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/77485
    public class s77485
    {
        public int[] solution(int rows, int columns, int[,] queries)
        {
            List<int> answer = new List<int>();
            int[,] map = new int[rows, columns];

            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int m = 0; m < map.GetLength(1); m++)
                {
                    map[i, m] = (i * map.GetLength(1)) + m + 1;
                }
            }

            for (int i = 0; i < queries.GetLength(0); i++)
            {
                int rowCount = queries[i, 2] - queries[i, 0];
                int colCount = queries[i, 3] - queries[i, 1];

                List<(int, int)> dirList = new List<(int, int)>();

                for (int m = 0; m < colCount; m++)
                {
                    dirList.Add((0, 1));
                }

                for (int m = 0; m < rowCount; m++)
                {
                    dirList.Add((1, 0));
                }

                for (int m = 0; m < colCount; m++)
                {
                    dirList.Add((0, -1));
                }

                for (int m = 0; m < rowCount; m++)
                {
                    dirList.Add((-1, 0));
                }

                int row = queries[i, 0] - 1;
                int col = queries[i, 1] - 1;

                List<(int, int, int)> list = new List<(int, int, int)>();

                for (int m = 0; m < dirList.Count; m++)
                {
                    var (r, c) = dirList[m];

                    row += r;
                    col += c;

                    int value = map[row, col];
                    list.Add((row, col, value));
                }

                for (int m = 0; m < list.Count; m++)
                {
                    var (r, c, v) = list[m];
                    int targetIdx = m - 1;

                    if (targetIdx < 0)
                        targetIdx += list.Count;

                    map[r, c] = list[targetIdx].Item3;
                }

                answer.Add(list.Min(x => x.Item3));
            }

            return answer.ToArray();
        }
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/169199
    public class s169199
    {
        public int solution(string[] board)
        {
            char[,] map = new char[board.Length, board[0].Length];
            bool[,] visited = new bool[board.Length, board[0].Length];
            int startRow = 0, startCol = 0, endRow = 0, endCol = 0;

            for (int row = 0; row < board.Length; row++)
            {
                for (int col = 0; col < board[row].Length; col++)
                {
                    map[row, col] = board[row][col];

                    if (map[row, col].Equals('R'))
                    {
                        startRow = row;
                        startCol = col;
                    }
                    else if (map[row, col].Equals('G'))
                    {
                        endRow = row;
                        endCol = col;
                    }
                }
            }

            int[] dRow = new int[] { -1, 1, 0, 0 };
            int[] dCol = new int[] { 0, 0, -1, 1 };

            Queue<(int r, int c, int d, int count)> queue = new Queue<(int r, int c, int d, int count)>();
            queue.Enqueue((startRow, startCol, -1, 0));

            while (queue.Count > 0)
            {
                var (currentRow, currentCol, currentDir, step) = queue.Dequeue();
                visited[currentRow, currentCol] = true;

                if (currentRow == endRow && currentCol == endCol)
                    return step;

                for (int i = 0; i < dRow.Length; i++)
                {
                    if (currentDir == i)
                        continue;

                    int newRow = currentRow + dRow[i];
                    int newCol = currentCol + dCol[i];
                    bool isMove = false;

                    while (newRow >= 0 && newCol >= 0 && newRow < map.GetLength(0) && newCol < map.GetLength(1) &&
                            map[newRow, newCol].Equals('D') == false)
                    {
                        newRow += dRow[i];
                        newCol += dCol[i];
                        isMove = true;
                    }

                    if (isMove)
                    {
                        int r = newRow - dRow[i];
                        int c = newCol - dCol[i];

                        if (visited[r, c] == false)
                        {
                            queue.Enqueue((r, c, i, step + 1));
                        }
                    }
                }
            }

            return -1;
        }
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/147354
    public class s147354
    {
        public int solution(int[,] data, int col, int row_begin, int row_end)
        {
            int[][] dataList = new int[data.GetLength(0)][];
            List<(int idx, int first, int order)> sortValue = new List<(int idx, int first, int order)>();

            for (int i = 0; i < dataList.Length; i++)
            {
                dataList[i] = new int[data.GetLength(1)];

                for (int m = 0; m < dataList[i].Length; m++)
                {
                    dataList[i][m] = data[i, m];
                }

                sortValue.Add((i, dataList[i][0], dataList[i][col - 1]));
            }

            sortValue = sortValue.OrderBy(x => x.order).ThenByDescending(x => x.first).ToList();

            int[][] sortedList = new int[dataList.Length][];

            for (int i = 0; i < sortValue.Count; i++)
            {
                sortedList[i] = dataList[sortValue[i].idx];
            }

            int answer = 0;

            for (int i = row_begin - 1; i <= row_end - 1; i++)
            {
                int[] array = sortedList[i];
                int sum = 0;
                for (int m = 0; m < array.Length; m++)
                {
                    sum += array[m] % (i + 1);
                }

                answer ^= sum;
            }

            return answer;
        }
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/81302
    public class s81302
    {
        public int[] solution(string[,] places)
        {
            char[][,] map = new char[places.GetLength(0)][,];

            for (int i = 0; i < places.GetLength(0); i++)
            {
                char[,] smallMap = new char[places.GetLength(1), places[i, 0].Length];

                for (int m = 0; m < smallMap.GetLength(0); m++)
                {
                    for (int h = 0; h < smallMap.GetLength(1); h++)
                    {
                        smallMap[m, h] = places[i, m][h];
                    }

                    map[i] = smallMap;
                }
            }

            int[] answer = new int[map.Length];
            for (int i = 0; i < map.Length; i++)
            {
                answer[i] = CheckMap(map[i]) ? 1 : 0;
            }

            return answer;
        }

        public bool CheckMap(char[,] map)
        {
            bool[,] check = new bool[map.GetLength(0), map.GetLength(1)];

            for (int m = 0; m < map.GetLength(0); m++)
            {
                for (int h = 0; h < map.GetLength(1); h++)
                {
                    if (map[m, h].Equals('P') == true && check[m, h] == false)
                    {
                        check[m, h] = true;
                        bool isAround = CheckAround(map, ref check, m, h);

                        if (isAround == false)
                            return false;
                    }
                }
            }

            return true;

        }

        public bool CheckAround(char[,] map, ref bool[,] check, int row, int col)
        {
            int[] dRow = new int[] { -2, -1, -1, -1, 0, 0, 0, 0, 0, 1, 1, 1, 2 };
            int[] dCol = new int[] { 0, -1, 0, 1, -2, -1, 0, 1, 2, -1, 0, 1, 0 };

            for (int i = 0; i < dRow.Length; i++)
            {
                if (i == 4)
                    continue;

                int r = row + dRow[i];
                int c = col + dCol[i];

                if (r < 0 || c < 0 || r >= map.GetLength(0) || c >= map.GetLength(1) || check[r, c] == true)
                    continue;

                if (map[r, c].Equals('P') == true)
                {
                    switch (i)
                    {
                        case 2:
                        case 5:
                        case 7:
                        case 10:
                            check[r, c] = true;
                            return false;

                        case 1:  // 2, 4
                        case 3:  // 2, 6
                        case 9:  // 5, 10
                        case 11: // 7, 10
                            int check1 = i == 1 || i == 3 ? 2 : i == 9 ? 5 : 7;
                            int check2 = i == 1 ? 4 : i == 3 ? 6 : i == 9 ? 10 : 10;

                            if (map[row + dRow[check1], col + dCol[check1]].Equals('X') == false || map[row + dRow[check2], col + dCol[check2]].Equals('X') == false)
                            {
                                return false;
                            }

                            break;

                        case 0: // 2
                        case 4: // 5
                        case 8: // 7
                        case 12: // 10
                            int check3 = i == 0 ? 2 : i == 4 ? 5 : i == 8 ? 7 : 10;
                            if (map[row + dRow[check3], col + dCol[check3]].Equals('X') == false)
                            {
                                return false;
                            }

                            break;
                    }
                }
            }

            return true;
        }
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/142085
    public class s142085
    {
        public int solution(int n, int k, int[] enemy)
        {
            int answer = 0;
            SortedSet<(int value, int index)> killedEnemy = new SortedSet<(int, int)>();
            int index = 0;

            for (int i = 0; i < enemy.Length; i++)
            {
                int e = enemy[i];
                var current = (e, index++);
                killedEnemy.Add(current);
                if (n >= e)
                {
                    n -= e;
                }
                else if (k > 0)
                {
                    var maxEnemy = killedEnemy.Max;

                    if (maxEnemy.value > e)
                    {
                        n += maxEnemy.value;
                        n -= e;
                        killedEnemy.Remove(maxEnemy);
                    }
                    else
                    {
                        killedEnemy.Remove(current);
                    }

                    k--;
                }
                else
                {
                    break;
                }

                answer++;
            }

            return answer;
        }
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/134239
    public class s134239
    {
        public double[] solution(int k, int[,] ranges)
        {
            List<int> sequence = new List<int>();
            sequence.Add(k);

            while (k > 1)
            {
                if (k % 2 == 1)
                {
                    k = (k * 3) + 1;
                }
                else
                {
                    k /= 2;
                }

                sequence.Add(k);
            }

            List<double> areas = new List<double>();

            for (int i = 0; i < sequence.Count - 1; i++)
            {
                double height = sequence[i];
                double height2 = sequence[i + 1];

                areas.Add((height + height2) / 2f);
            }

            List<double> answer = new List<double>();

            for (int i = 0; i < ranges.GetLength(0); i++)
            {
                int a = ranges[i, 0];
                int b = ranges[i, 1];
                int end = sequence.Count + b - 1;

                if (a > end)
                {
                    answer.Add(-1.0);
                }
                else
                {
                    double sum = 0;
                    for (int m = a; m < end; m++)
                    {
                        sum += areas[m];
                    }
                    answer.Add(sum);
                }
            }

            return answer.ToArray();
        }
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/62048
    public class s62048
    {
        /**
            1.	전체 정사각형 수: 직사각형 전체의 1cm x 1cm 정사각형의 개수는 W * H입니다.
	        2.	대각선에 의해 잘린 정사각형 수:
	            •	직사각형의 대각선이 지나가는 정사각형의 수는 W + H - GCD(W, H)입니다.
	            •	여기서, GCD(W, H)는 W와 H의 최대공약수로, 대각선이 지나가면서 정확히 한 번 지나가는 정사각형들을 제외하기 위해 사용됩니다.
	        3.	사용 가능한 정사각형 수:
	            •	전체 정사각형의 개수에서 대각선에 의해 잘린 정사각형의 개수를 뺀 값을 구합니다.
	            •	공식: Result = W * H - (W + H - GCD(W, H)).
        **/

        public long solution(int w, int h)
        {
            long gcd = GCD(w, h);
            long total = (long)w * h;
            long unusable = w + h - gcd;
            return total - unusable;
        }

        private long GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/172927
    public class s172927
    {
        public int solution(int[] picks, string[] minerals)
        {
            List<List<string>> group = new List<List<string>>();

            int count = Math.Min(picks.Sum() * 5, minerals.Length);
            List<string> tempList = new List<string>();

            for (int i = 0; i < count; i += 5)
            {
                group.Add(minerals.Skip(i).Take(5).ToList());
            }

            List<(int diamond, int iron, int stone)> fatigueList = new List<(int diamond, int iron, int stone)>();

            for (int i = 0; i < group.Count; i++)
            {
                int fatigueD = CalculateFatigue(group[i], "diamond");
                int fatigueI = CalculateFatigue(group[i], "iron");
                int fatigueS = CalculateFatigue(group[i], "stone");

                fatigueList.Add((fatigueD, fatigueI, fatigueS));
            }

            fatigueList = fatigueList
                            .OrderByDescending(x => x.stone)
                            .ThenByDescending(x => x.iron)
                            .ThenByDescending(x => x.diamond)
                            .ToList();

            int answer = 0;
            for (int i = 0; i < fatigueList.Count; i++)
            {
                var (diamond, iron, stone) = fatigueList[i];

                if (picks[0] > 0)
                {
                    answer += diamond;
                    picks[0]--;
                }
                else if (picks[1] > 0)
                {
                    answer += iron;
                    picks[1]--;
                }
                else if (picks[2] > 0)
                {
                    answer += stone;
                    picks[2]--;
                }
                else
                {
                    break;
                }
            }

            return answer;
        }

        private int CalculateFatigue(List<string> minerals, string pick)
        {
            int value = 0;

            for (int i = 0; i < minerals.Count; i++)
            {
                if (pick.Equals("diamond"))
                {
                    value++;
                }
                else if (pick.Equals("iron"))
                {
                    switch (minerals[i])
                    {
                        case "diamond": value += 5; break;
                        default: value++; break;
                    }
                }
                else
                {
                    switch (minerals[i])
                    {
                        case "diamond": value += 25; break;
                        case "iron": value += 5; break;
                        default: value++; break;
                    }
                }
            }

            return value;
        }
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/140107
    public class s140107
    {
        public long solution(int k, int d)
        {
            long answer = 0;

            for (int i = 0; i <= d; i += k)
            {
                int maxY = (int)Math.Sqrt((long)d * d - (long)i * i);
                answer += (maxY / k) + 1;
            }

            return answer;
        }
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/150368
    public class s150368
    {
        public int[] solution(int[,] users, int[] emoticons)
        {
            int[] discountArray = new int[] { 10, 20, 30, 40 };
            List<int[]> allCombinations = new List<int[]>();
            int[] answer = new int[2];

            GenerateCombinations(discountArray, new List<int>(), emoticons.Length, allCombinations);

            for (int i = 0; i < allCombinations.Count; i++)
            {
                int maxUser = 0;
                int maxSales = 0;

                for (int m = 0; m < users.GetLength(0); m++)
                {
                    int wantDiscount = users[m, 0];
                    int amount = users[m, 1];

                    int totalPrice = 0;
                    for (int h = 0; h < emoticons.Length; h++)
                    {
                        if (wantDiscount > allCombinations[i][h])
                            continue;

                        totalPrice += (int)(emoticons[h] * ((100 - allCombinations[i][h]) / 100f));
                    }

                    if (totalPrice >= amount)
                    {
                        maxUser++;
                    }
                    else
                    {
                        maxSales += totalPrice;
                    }
                }

                if (maxUser > answer[0])
                {
                    answer[0] = maxUser;
                    answer[1] = maxSales;
                }
                else if (maxUser == answer[0] && maxSales > answer[1])
                {
                    answer[1] = maxSales;
                }
            }

            return answer;
        }

        private void GenerateCombinations(int[] array, List<int> current, int length, List<int[]> result)
        {
            if (current.Count == length)
            {
                result.Add(current.ToArray());
                return;
            }

            foreach (var num in array)
            {
                current.Add(num);
                GenerateCombinations(array, current, length, result);
                current.RemoveAt(current.Count - 1);
            }
        }
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/181187
    public class s181187
    {
        public long solution(int r1, int r2)
        {
            long answer = 0;

            for (int i = -r2; i <= r2; i++)
            {
                int maxY = (int)Math.Sqrt((long)r2 * r2 - (long)i * i);
                int yCount = (maxY * 2) + 1;

                answer += yCount;
            }

            for (int i = -r1; i <= r1; i++)
            {
                double value = Math.Sqrt((long)r1 * r1 - (long)i * i);
                int maxY = 0;

                if (value % 1 != 0)
                {
                    maxY = (int)value;
                    answer -= (maxY * 2) + 1;
                }
                else
                {
                    if (value == 0)
                        continue;

                    maxY = (int)value - 1;
                    Console.WriteLine(i);
                    answer -= (maxY * 2) + 1;
                }
            }

            return answer;
        }
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/176962
    public class s176962
    {
        public string[] solution(string[,] plans)
        {
            List<(string title, DateTime startTime, int duration)> list = new List<(string, DateTime, int)>();
            Stack<(string title, DateTime startTime, int remainDuration)> pausedTask = new Stack<(string title, DateTime startTime, int remainDuration)>();
            List<string> answer = new List<string>();

            for (int i = 0; i < plans.GetLength(0); i++)
            {
                list.Add((plans[i, 0], DateTime.Parse(plans[i, 1]), int.Parse(plans[i, 2])));
            }

            list = list.OrderBy(x => x.startTime).ToList();

            DateTime currentTime = DateTime.Parse("00:00");
            foreach (var item in list)
            {
                DateTime startTime = item.startTime;

                while (pausedTask.Count > 0 && startTime >= currentTime)
                {
                    var task = pausedTask.Pop();
                    DateTime taskEndTime = currentTime.AddMinutes(task.remainDuration);

                    if (taskEndTime <= startTime)
                    {
                        answer.Add(task.title);
                        currentTime = taskEndTime;
                    }
                    else
                    {
                        task.remainDuration -= (int)(startTime - currentTime).TotalMinutes;
                        pausedTask.Push(task);
                        break;
                    }
                }

                currentTime = startTime;
                DateTime endTime = startTime.AddMinutes(item.duration);

                pausedTask.Push(item);
            }

            while (pausedTask.Count > 0)
            {
                answer.Add(pausedTask.Pop().title);
            }

            return answer.ToArray();
        }
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/181188
    public class s181188
    {
        public int solution(int[,] targets)
        {
            List<(int start, int end)> list = new List<(int, int)>();
            int answer = 0;

            for (int i = 0; i < targets.GetLength(0); i++)
            {
                list.Add((targets[i, 0], targets[i, 1]));
            }

            list = list.OrderBy(x => x.end).ToList();
            int interceptorPos = -1;

            foreach (var v in list)
            {
                if (interceptorPos < v.start)
                {
                    answer++;
                    interceptorPos = v.end;
                }
            }

            return answer;
        }
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/160585
    public class s160585
    {
        public int solution(string[] board)
        {
            int countO = 0, countX = 0;

            for (int i = 0; i < board.Length; i++)
            {
                countO += board[i].Count(x => x.Equals('O'));
                countX += board[i].Count(x => x.Equals('X'));
            }

            if (countO < countX || countO > countX + 1)
                return 0;

            bool winnerO = CheckWinner(board, 'O');
            bool winnerX = CheckWinner(board, 'X');

            if (winnerO && winnerX)
                return 0;

            if (winnerO && countO != countX + 1)
                return 0;

            if (winnerX && countO != countX)
                return 0;

            return 1;
        }

        public bool CheckWinner(string[] board, char player)
        {
            for (int i = 0; i < board.Length; i++)
            {
                if (board[i][0].Equals(player) && board[i][1].Equals(player) && board[i][2].Equals(player))
                    return true;

                if (board[0][i].Equals(player) && board[1][i].Equals(player) && board[2][i].Equals(player))
                    return true;
            }

            if (board[0][0].Equals(player) && board[1][1].Equals(player) && board[2][2].Equals(player))
                return true;

            if (board[0][2].Equals(player) && board[1][1].Equals(player) && board[2][0].Equals(player))
                return true;

            return false;
        }
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/131130
    public class s131130
    {
        public int solution(int[] cards)
        {
            bool[] visited = new bool[cards.Length];
            List<int> boxSize = new List<int>();

            for (int i = 0; i < cards.Length; i++)
            {
                if (visited[i] == false)
                {
                    int current = i;
                    int size = 0;

                    while (visited[current] == false)
                    {
                        visited[current] = true;
                        current = cards[current] - 1;
                        size++;
                    }

                    boxSize.Add(size);
                }
            }

            boxSize = boxSize.OrderByDescending(x => x).ToList();

            if (boxSize.Count < 2)
                return 0;
            else
                return boxSize[0] * boxSize[1];
        }
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/12952
    public class s12952
    {
        int answer = 0;
        public int solution(int n)
        {
            /*
            ㅁ ㅁ Q ㅁ
            Q ㅁ ㅁ ㅁ
            ㅁ ㅁ ㅁ Q
            ㅁ Q ㅁ ㅁ 
            일 때 Q의 위치를 {2,4,1,3} 으로 나타낼 수 있음 (값을 행, 인덱스 번호가 열)
            가로,세로 겹치지 않도록 -> 인접한 수의 차이가 2이상 나야 한다. 예) {2,4,6,1,3,5} O
            대각선 겹치지 않도록 -> 임의의 두 수의 차이가 그 수들의 인덱스 차이와 동일하면 안 된다.
            예) {1,3,5,2,4,6} 은 1과 6의 차이가 5이고 떨어진 거리도 5라서 대각선에서 겹침.
            */

            int[] board = new int[n];
            DropQeens(board, 0, n);
            return answer;
        }

        private void DropQeens(int[] board, int row, int n)
        {
            if (row == n)
            {
                answer++;
                return;
            }

            for (int col = 0; col < n; col++)
            {
                if (IsSafeArea(board, row, col))
                {
                    board[row] = col;
                    DropQeens(board, row + 1, n);
                }
            }
        }

        private bool IsSafeArea(int[] board, int row, int col)
        {
            for (int i = 0; i < row; i++)
            {
                if (board[i] == col || Math.Abs(board[i] - col) == Math.Abs(i - row))
                    return false;
            }

            return true;
        }
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/340212
    public class s340212
    {
        public int solution(int[] diffs, int[] times, long limit)
        {
            int low = 1;
            int high = 100000;

            while (low < high)
            {
                int mid = (low + high) / 2;

                if (CanSolve(diffs, times, limit, mid))
                {
                    high = mid;
                }
                else
                {
                    low = mid + 1;
                }
            }

            return low;
        }

        public bool CanSolve(int[] diffs, int[] times, long limit, int level)
        {
            long totalTime = 0;

            for (int i = 0; i < diffs.Length; i++)
            {
                if (level >= diffs[i])
                {
                    totalTime += times[i];
                }
                else
                {
                    totalTime += (times[i - 1] + times[i]) * (diffs[i] - level) + times[i];
                }

                if (totalTime > limit)
                    return false;
            }

            return true;
        }
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/12946
    public class s12946
    {
        public int[,] solution(int n)
        {
            List<(int from, int to)> moves = new List<(int from, int to)>();
            SolveHanoi(n, 1, 3, 2, moves);

            int[,] answer = new int[moves.Count, 2];

            for (int i = 0; i < moves.Count; i++)
            {
                answer[i, 0] = moves[i].from;
                answer[i, 1] = moves[i].to;
            }

            return answer;
        }

        private void SolveHanoi(int n, int from, int to, int via, List<(int from, int to)> moves)
        {
            if (n == 1)
            {
                moves.Add((from, to));
                return;
            }

            SolveHanoi(n - 1, from, via, to, moves);
            moves.Add((from, to));
            SolveHanoi(n - 1, via, to, from, moves);
        }
    }
}
