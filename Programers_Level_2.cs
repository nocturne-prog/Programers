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
            return answer;
        }
    }

}