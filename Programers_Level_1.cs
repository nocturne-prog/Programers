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

    public int CountDivisors(int n)
    {
        int count = 0;
        for (int i = 1; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                count++;
                if (i != n / i)
                {
                    count++;
                }
            }
        }
        return count;
    }


    public bool IsPrimeNumber(int n)
    {
        if (n <= 1) return false;
        if (n == 2) return true; // 2는 소수
        if (n % 2 == 0) return false; // 2를 제외한 짝수는 소수가 아님

        for (int i = 3; i <= Math.Sqrt(n); i += 2)
        {
            if (n % i == 0) return false;
        }

        return true;
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


    //https://school.programmers.co.kr/learn/courses/30/lessons/12930
    public string s12930(string s)
    {
        StringBuilder sb = new StringBuilder();

        string[] split = s.Split(' ');

        for (int i = 0; i < split.Length; i++)
        {
            if (i != 0)
            {
                sb.Append(' ');
            }

            bool isEven = true;
            for (int m = 0; m < split[i].Length; m++)
            {
                char c = split[i][m];
                sb.Append(isEven == true ? char.ToUpper(c) : char.ToLower(c));
                isEven = !isEven;
            }
        }

        return sb.ToString();
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/86491
    public int s86491(int[,] sizes)
    {
        int maxWidth = 0;
        int maxHeight = 0;

        for (int i = 0; i < sizes.GetLength(0); i++)
        {
            int width = Math.Max(sizes[i, 0], sizes[i, 1]);
            int height = Math.Min(sizes[i, 0], sizes[i, 1]);

            maxWidth = Math.Max(width, maxWidth);
            maxHeight = Math.Max(height, maxHeight);
        }

        return maxWidth * maxHeight;
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/12926
    public string s12926(string s, int n)
    {
        char[] alpabetUpper = new char[]
        {
            'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'
        };

        char[] alpabetLower = new char[]
        {
            'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'
        };

        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];

            if (char.IsWhiteSpace(c) == true)
            {
                sb.Append(' ');
                continue;
            }

            int idx = 0;
            char[] array = char.IsUpper(c) == true ? alpabetUpper : alpabetLower;

            for (int m = 0; m < array.Length; m++)
            {
                if (char.Equals(c, array[m]) == true)
                {
                    idx = m;
                    break;
                }
            }

            idx += n;

            if (idx >= array.Length)
            {
                idx -= array.Length;
            }

            sb.Append(array[idx]);

        }

        return sb.ToString();
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/142086
    public int[] s142086(string s)
    {
        int[] answer = new int[s.Length];

        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            int count = 0;
            bool isFind = false;
            int m = i - 1;

            while (m >= 0)
            {
                count++;

                if (char.Equals(c, s[m]))
                {
                    isFind = true;
                    break;
                }

                m--;
            }

            answer[i] = isFind ? count : -1;
        }

        return answer;
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/12915
    public string[] s12915(string[] strings, int n)
    {
        return strings.OrderBy(x => x[n])
                        .ThenBy(x => x)
                        .ToArray();
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/134240
    public string s134240(int[] food)
    {
        string left = string.Empty;

        for (int i = 1; i < food.Length; i++)
        {
            int value = food[i];

            if (value % 2 != 0)
            {
                food[i]--;
            }

            for (int m = 0; m < food[i] / 2; m++)
            {
                left += i.ToString();
            }
        }

        char[] rightCharArray = left.ToCharArray();
        Array.Reverse(rightCharArray);
        string right = new string(rightCharArray);

        string answer = left + "0" + right;
        return answer;
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/81301
    public int s81301(string s)
    {
        string[] numbers = new string[]
        {
            "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"
        };

        for (int i = 0; i < numbers.Length; i++)
        {
            s = s.Replace(numbers[i], i.ToString());
        }

        return int.Parse(s);
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/42748
    public int[] s42748(int[] array, int[,] commands)
    {
        int[] answer = new int[commands.GetLength(0)];

        for (int i = 0; i < commands.GetLength(0); i++)
        {
            int a = commands[i, 0] - 1;
            int b = commands[i, 1];
            int c = commands[i, 2];

            List<int> list = new List<int>();

            for (int m = a; m < b; m++)
            {
                list.Add(array[m]);
            }

            answer[i] = list.OrderBy(x => x).ToList()[c - 1];

        }
        return answer;
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/138477
    public int[] s138477(int k, int[] score)
    {
        int[] answer = new int[score.Length];
        List<int> list = new List<int>();

        for (int i = 0; i < score.Length; i++)
        {
            list.Add(score[i]);

            list = list.OrderByDescending(x => x).ToList();

            if (list.Count > k)
            {
                list.RemoveAt(list.Count - 1);
            }

            answer[i] = list[list.Count - 1];
        }

        return answer;
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/132267
    public int s132267(int a, int b, int n)
    {
        int answer = 0;

        while (n >= a)
        {
            int addCount = (n / a) * b;

            n %= a;
            n += addCount;

            answer += addCount;
        }

        return answer;
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/159994
    public string s159994(string[] cards1, string[] cards2, string[] goal)
    {
        List<string> ref1 = new List<string>(cards1);
        List<string> ref2 = new List<string>(cards2);

        bool success = true;

        for (int i = 0; i < goal.Length; i++)
        {
            string value = goal[i];

            if (ref1.Count > 0 && value.Equals(ref1[0]) == true)
            {
                ref1.RemoveAt(0);
            }
            else if (ref2.Count > 0 && value.Equals(ref2[0]) == true)
            {
                ref2.RemoveAt(0);
            }
            else
            {
                success = false;
                break;
            }
        }

        return success ? "Yes" : "No";
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/136798
    public int s136798(int number, int limit, int power)
    {
        List<int> list = new List<int>();

        for (int i = 1; i <= number; i++)
        {
            int count = CountDivisors(i);
            list.Add(count);
        }

        return list.Select(x => x > limit ? power : x).Sum();
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/135808
    public int s135808(int k, int m, int[] score)
    {
        int answer = 0;

        List<int> apples = score.OrderByDescending(x => x).ToList();

        while (apples.Count % m != 0)
        {
            apples.RemoveAt(apples.Count - 1);
        }

        for (int i = 0; i < apples.Count; i += m)
        {
            List<int> appleScores = new List<int>();

            for (int h = i; h < i + m; h++)
            {
                appleScores.Add(apples[h]);
            }

            int minValue = appleScores.Min();

            if (minValue > k)
                minValue = k;

            answer += minValue * m;
        }

        return answer;
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/161989
    public int s161989(int n, int m, int[] section)
    {
        int count = 0;
        int index = 0;

        while (index < section.Length)
        {
            count++;

            int end = section[index] + m - 1;

            while (index < section.Length && section[index] <= end)
            {
                index++;
            }
        }

        return count;
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/12921
    public int s12921(int n)
    {
        int answer = 0;

        for (int i = 1; i <= n; i++)
        {
            if (IsPrimeNumber(i) == true)
                answer++;
        }

        return answer;
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/133499
    public int s133499(string[] babbling)
    {
        string[] referenceValues = new string[] { "aya", "ye", "woo", "ma" };
        int answer = 0;


        for (int i = 0; i < babbling.Length; i++)
        {
            string value = babbling[i];
            int length = value.Length;
            int skipIdx = -1;
            bool isNext = false;

            while (isNext == false)
            {
                for (int m = 0; m < referenceValues.Length; m++)
                {
                    if (skipIdx != -1 && skipIdx == m)
                        continue;

                    if (value.StartsWith(referenceValues[m]) == true)
                    {
                        value = value.Remove(0, referenceValues[m].Length);

                        skipIdx = m;
                        m = -1;

                        if (string.IsNullOrEmpty(value) == true)
                        {
                            answer++;
                            isNext = true;
                            break;
                        }
                    }
                }

                isNext = true;
            }

        }

        return answer;
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/77484
    public int[] s77484(int[] lottos, int[] win_nums)
    {
        Dictionary<int, int> lottoScore = new Dictionary<int, int>()
        {
            { 6, 1 },
            { 5 ,2 },
            { 4 ,3 },
            { 3 ,4 },
            { 2 ,5 },
            { 1 ,6 },
            { 0 ,6 },
        };

        int count = lottos.Intersect(win_nums).Count();
        int zeroCount = lottos.Where(x => x == 0).Count();

        return new int[] { lottoScore[count + zeroCount], lottoScore[count] };
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/42862
    public int s42862(int n, int[] lost, int[] reserve)
    {
        int reserveCount = 0;
        List<int> lostList = lost.Except(reserve).OrderBy(x => x).ToList();
        List<int> reserveList = reserve.Except(lost).OrderBy(x => x).ToList();

        for (int i = 0; i < lostList.Count; i++)
        {
            int prevIdx = Math.Clamp(lostList[i] - 1, 1, n);
            int nextIdx = Math.Clamp(lostList[i] + 1, 1, n);

            for (int m = 0; m < reserveList.Count; m++)
            {
                if (reserveList[m] == prevIdx)
                {
                    reserveList.Remove(prevIdx);
                    reserveCount++;
                    break;
                }
                else if (reserveList[m] == nextIdx)
                {
                    reserveList.Remove(nextIdx);
                    reserveCount++;
                    break;
                }
            }
        }

        return n - lostList.Count() + reserveCount;
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/155652
    public string s155652(string s, string skip, int index)
    {
        StringBuilder sb = new StringBuilder();

        List<char> alpabetLower = new List<char>
        {
            'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'
        };

        for (int i = 0; i < skip.Length; i++)
        {
            alpabetLower.Remove(skip[i]);
        }

        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];

            int alpabetIdx = -1;

            for (int m = 0; m < alpabetLower.Count; m++)
            {
                if (alpabetLower[m].Equals(c) == true)
                {
                    alpabetIdx = m;
                    break;
                }
            }

            alpabetIdx += index;
            if (alpabetIdx >= alpabetLower.Count)
            {
                alpabetIdx %= alpabetLower.Count;
            }

            sb.Append(alpabetLower[alpabetIdx]);
        }

        return sb.ToString();
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/140108
    public int s140108(string s)
    {
        int answer = 0;
        char x = ' ';
        int sameCount = 0;
        int diffCount = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (char.IsWhiteSpace(x) == true)
            {
                x = s[i];
            }

            if (x.Equals(s[i]) == true)
            {
                sameCount++;
            }
            else
            {
                diffCount++;
            }

            if (sameCount == diffCount)
            {
                x = ' ';
                sameCount = 0;
                diffCount = 0;

                answer++;
            }

            if (i == s.Length - 1 && (sameCount != 0 || diffCount != 0))
            {
                answer++;
            }
        }

        return answer;
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/160586
    public int[] s160586(string[] keymap, string[] targets)
    {
        Dictionary<char, int> dic = new Dictionary<char, int>();

        for (int i = 0; i < keymap.Length; i++)
        {
            for (int m = 0; m < keymap[i].Length; m++)
            {
                char key = keymap[i][m];

                if (dic.ContainsKey(key) == true)
                {
                    dic[key] = Math.Min(dic[key], m + 1);
                }
                else
                {
                    dic.Add(key, m + 1);
                }
            }
        }

        int[] answer = new int[targets.Length];

        for (int i = 0; i < targets.Length; i++)
        {
            int count = 0;
            bool isFail = false;
            for (int m = 0; m < targets[i].Length; m++)
            {
                char key = targets[i][m];

                if (dic.ContainsKey(key) == true)
                {
                    count += dic[key];
                }
                else
                {
                    isFail = true;
                }
            }

            if (isFail == true)
            {
                count = -1;
            }

            answer[i] = count;
        }

        return answer;
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/131128
    public string s131128(string X, string Y)
    {
        int[] numberX = new int[10];
        int[] numberY = new int[10];

        char[] arrayX = X.ToCharArray();
        char[] arrayY = Y.ToCharArray();

        foreach (char c in X.ToCharArray())
        {
            int value = c - '0';
            numberX[value]++;
        }

        foreach (char c in Y.ToCharArray())
        {
            int value = c - '0';
            numberY[value]++;
        }

        List<int> duplicateList = new List<int>();

        for (int i = 0; i < numberX.Length; i++)
        {
            int count = Math.Min(numberX[i], numberY[i]);

            if (count != 0)
            {
                for (int m = 0; m < count; m++)
                {
                    duplicateList.Add(i);
                }
            }
        }

        if (duplicateList.Count == 0)
        {
            return "-1";
        }
        else
        {
            if (duplicateList.Sum() == 0)
                return "0";

            StringBuilder sb = new StringBuilder();
            foreach (var v in duplicateList.OrderByDescending(x => x))
            {
                sb.Append(v);
            }

            return sb.ToString();
        }
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/133502
    public int s133502(int[] ingredient)
    {
        int answer = 0;
        Stack<int> stack = new Stack<int>();

        foreach (var v in ingredient)
        {
            stack.Push(v);

            if (stack.Count >= 4)
            {
                int[] lastItems = new int[4];

                int i = 0;
                foreach (var item in stack)
                {
                    lastItems[i] = item;
                    i++;

                    if (i >= 4)
                        break;
                }

                Array.Reverse(lastItems);

                if (lastItems[0] == 1 && lastItems[1] == 2 && lastItems[2] == 3 && lastItems[3] == 1)
                {
                    stack.Pop();
                    stack.Pop();
                    stack.Pop();
                    stack.Pop();
                    answer++;
                }
            }
        }

        return answer;
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/118666
    public string s118666(string[] survey, int[] choices)
    {
        Dictionary<char, int> dic = new Dictionary<char, int>()
        {
            { 'R' , 0 }, { 'T' , 0 },
            { 'C' , 0 }, { 'F' , 0 },
            { 'J' , 0 }, { 'M' , 0 },
            { 'A' , 0 }, { 'N' , 0 },
        };

        int[] score = new int[] { 0, 3, 2, 1, 0, 1, 2, 3 };

        for (int i = 0; i < survey.Length; i++)
        {
            char left = survey[i][0];
            char right = survey[i][1];

            int value = score[choices[i]];

            if (choices[i] > 4)
            {
                dic[right] += value;
            }
            else
            {
                dic[left] += value;
            }
        }

        List<char> keyList = dic.Keys.ToList();
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < keyList.Count; i += 2)
        {
            char left = keyList[i];
            char right = keyList[i + 1];

            if (dic[right] > dic[left])
            {
                sb.Append(right);
            }
            else
            {
                sb.Append(left);
            }
        }

        return sb.ToString();
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/161990
    public int[] s161990(string[] wallpaper)
    {
        int minX = int.MaxValue;
        int minY = int.MaxValue;
        int maxX = int.MinValue;
        int maxY = int.MinValue;

        for (int i = 0; i < wallpaper.Length; i++)
        {
            for (int m = 0; m < wallpaper[i].Length; m++)
            {
                char c = wallpaper[i][m];

                if (c.Equals('#') == true)
                {
                    minX = Math.Min(minX, i);
                    minY = Math.Min(minY, m);
                    maxX = Math.Max(maxX, i);
                    maxY = Math.Max(maxY, m);
                }
            }
        }

        return new int[] { minX, minY, maxX + 1, maxY + 1 };
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/150370
    public int[] s150370(string today, string[] terms, string[] privacies)
    {
        List<int> answer = new List<int>();
        DateTime dateTime_Today = DateTime.Parse(today);
        Dictionary<string, int> termsDic = new Dictionary<string, int>();

        for (int i = 0; i < terms.Length; i++)
        {
            string[] split = terms[i].Split(' ');

            termsDic.Add(split[0], int.Parse(split[1]));
        }

        for (int i = 0; i < privacies.Length; i++)
        {
            string[] split = privacies[i].Split(' ');

            DateTime dateTime = DateTime.Parse(split[0]);
            string term = split[1];

            DateTime expireTime = dateTime.AddMonths(termsDic[term]);

            if (expireTime <= dateTime_Today)
            {
                answer.Add(i + 1);
            }
        }

        return answer.ToArray();
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/172928
    public int[] s172928(string[] park, string[] routes)
    {
        int maxX = park[0].Length, maxY = park.Length;
        int x = 0, y = 0;

        for (int i = 0; i < park.Length; i++)
        {
            for (int m = 0; m < park[i].Length; m++)
            {
                if (char.Equals(park[i][m], 'S'))
                {
                    x = m;
                    y = i;
                }
            }
        }

        for (int i = 0; i < routes.Length; i++)
        {
            string[] split = routes[i].Split(' ');
            string dir = split[0];
            int length = int.Parse(split[1]);

            bool isAble = true;
            int newX = x, newY = y;
            for (int m = 1; m <= length; m++)
            {
                if (dir.Equals("E") == true)
                {
                    newX = x + m;
                }
                else if (dir.Equals("W") == true)
                {
                    newX = x - m;
                }
                else if (dir.Equals("N") == true)
                {
                    newY = y - m;
                }
                else
                {
                    newY = y + m;
                }

                if (newX < 0 || newX >= maxX || newY < 0 || newY >= maxY || char.Equals(park[newY][newX], 'X') == true)
                {
                    isAble = false;
                    break;
                }
            }

            if (isAble == true)
            {
                x = newX;
                y = newY;

                Console.WriteLine($"[{y},{x}]");
            }
        }

        return new int[] { y, x };
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/178871
    public string[] s178871(string[] players, string[] callings)
    {
        Dictionary<string, int> dic = new Dictionary<string, int>();

        for (int i = 0; i < players.Length; i++)
        {
            dic.Add(players[i], i);
        }

        for (int i = 0; i < callings.Length; i++)
        {
            string calledPlayer = callings[i];
            int currentIndex = dic[calledPlayer];
            string prevPlayer = players[currentIndex - 1];

            players[currentIndex - 1] = calledPlayer;
            players[currentIndex] = prevPlayer;

            dic[calledPlayer]--;
            dic[prevPlayer]++;
        }

        return players;
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/92334
    public int[] s92334(string[] id_list, string[] report, int k)
    {
        int[] answer = new int[id_list.Length];
        Dictionary<string, int> userList = new Dictionary<string, int>();
        Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();

        for (int i = 0; i < id_list.Length; i++)
        {
            dic.Add(id_list[i], new List<string>());
            userList.Add(id_list[i], i);
        }

        string[] uniqueReport = report.Distinct().ToArray();

        for (int i = 0; i < uniqueReport.Length; i++)
        {
            string[] split = uniqueReport[i].Split(' ');

            string left = split[0];
            string right = split[1];

            dic[right].Add(left);
        }

        var answerList = dic.Where(x => x.Value.Count >= k);

        foreach (var v in answerList)
        {
            // answer[userList[v.Key]]++;

            for (int i = 0; i < v.Value.Count; i++)
            {
                answer[userList[v.Value[i]]]++;
            }
        }

        return answer;
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/258712
    public int s258712(string[] friends, string[] gifts)
    {
        Dictionary<string, int> answerList = new Dictionary<string, int>();
        Dictionary<string, (Dictionary<string, int>, Dictionary<string, int>)> giftRecords = new Dictionary<string, (Dictionary<string, int>, Dictionary<string, int>)>();

        for (int i = 0; i < friends.Length; i++)
        {
            answerList[friends[i]] = 0;
            giftRecords.Add(friends[i], (new Dictionary<string, int>(), new Dictionary<string, int>()));

            for (int m = 0; m < friends.Length; m++)
            {
                if (i == m)
                    continue;

                giftRecords[friends[i]].Item1.Add(friends[m], 0);
                giftRecords[friends[i]].Item2.Add(friends[m], 0);
            }
        }

        foreach (var gift in gifts)
        {
            string[] parts = gift.Split(' ');
            string giver = parts[0];
            string receiver = parts[1];

            if (giver != receiver)
            {
                giftRecords[giver].Item1[receiver]++;
                giftRecords[receiver].Item2[giver]++;
            }
        }

        foreach (var record in giftRecords)
        {
            string giver = record.Key;
            Dictionary<string, int> sendRecord = record.Value.Item1;
            Dictionary<string, int> receiveRecord = record.Value.Item2;

            foreach (var item in record.Value.Item1)
            {
                if (sendRecord[item.Key] > receiveRecord[item.Key])
                {
                    answerList[giver]++;
                }
                else if (sendRecord[item.Key] == receiveRecord[item.Key])
                {
                    int giverGiftScore = sendRecord.Sum(x => x.Value) - receiveRecord.Sum(x => x.Value);
                    int receiverGiftScore = giftRecords[item.Key].Item1.Sum(x => x.Value) - giftRecords[item.Key].Item2.Sum(x => x.Value);

                    if (giverGiftScore > receiverGiftScore)
                    {
                        answerList[giver]++;
                    }
                }
            }
        }

        return answerList.Values.Max();
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/340213
    public class s340213
    {
        public string solution(string video_len, string pos, string op_start, string op_end, string[] commands)
        {
            int videoLen = TickToText(video_len);
            int opStart = TickToText(op_start);
            int opEnd = TickToText(op_end);
            int current = TickToText(pos);

            for (int i = 0; i < commands.Length; i++)
            {
                string c = commands[i];

                if (current >= opStart && current <= opEnd)
                    current = opEnd;

                if (c.Equals("next"))
                {
                    current += 10;

                    if (current > videoLen)
                        current = videoLen;
                }
                else if (c.Equals("prev"))
                {
                    current -= 10;

                    if (current < 0)
                        current = 0;
                }

                if (current >= opStart && current <= opEnd)
                    current = opEnd;
            }

            return TextToTick(current);
        }

        public string TextToTick(int tick)
        {
            return $"{(tick / 60).ToString("D2")}:{(tick % 60).ToString("D2")}";
        }

        public int TickToText(string text)
        {
            string[] split = text.Split(':');
            int mim = int.Parse(split[0]);
            int second = int.Parse(split[1]);

            return (mim * 60) + second;
        }
    }
}