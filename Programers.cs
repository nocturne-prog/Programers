using System.Text;
using System.Linq;
using System.Collections;
using System.Collections.Generic;


public class Programers_Level_0
{
    //https://school.programmers.co.kr/learn/courses/30/lessons/181835
    public int[] s181835(int[] arr, int k)
    {
        int[] answer = arr.Select(x => k % 2 == 0 ? x + k : x * k).ToArray();
        return answer;
    }

    //https://school.programmers.co.kr/learn/courses/30/lessons/181840
    public int s181840(int[] num_list, int n)
    {
        int answer = num_list.Contains(n) == true ? 1 : 0;
        return answer;
    }

    //https://school.programmers.co.kr/learn/courses/30/lessons/181842
    public int s181842(string str1, string str2)
    {
        int answer = str2.Contains(str1) == true ? 1 : 0;
        return answer;
    }

    //https://school.programmers.co.kr/learn/courses/30/lessons/181843
    public int s181843(string my_string, string target)
    {
        int answer = my_string.Contains(target) == true ? 1 : 0;
        return answer;
    }

    //https://school.programmers.co.kr/learn/courses/30/lessons/181844
    public int[] s181844(int[] arr, int[] delete_list)
    {
        int[] answer = arr.Where(x => delete_list.Contains(x) == false).ToArray();
        return answer;
    }

    //https://school.programmers.co.kr/learn/courses/30/lessons/181845
    public string s181845(int n)
    {
        return n.ToString();
    }

    //https://school.programmers.co.kr/learn/courses/30/lessons/181848
    public int s181848(string n_str)
    {
        return int.Parse(n_str);
    }

    //https://school.programmers.co.kr/learn/courses/30/lessons/181849
    public int s181849(string num_str)
    {
        int answer = 0;

        for (int i = 0; i < num_str.Length; i++)
        {
            /*
            char을 int로 효과적으로 형변환하기 위해서는 char의 ASCII 값을 이용하는 방법이 있습니다.
            char의 숫자 값을 int로 변환할 때는, char에서 '0'을 빼면 됩니다.
            예를 들어, '5'의 ASCII 값은 53이고, '0'의 ASCII 값은 48이므로 '5' - '0'은 5가 됩니다.
            */
            answer += num_str[i] - '0';
        }

        return answer;
    }

    //https://school.programmers.co.kr/learn/courses/30/lessons/181850
    public int s181850(double flo)
    {
        return (int)flo;
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/181852
    public int[] s181852(int[] num_list)
    {
        var sortList = num_list.OrderBy(x => x).ToList();
        sortList.RemoveRange(0, 5);
        return sortList.ToArray();
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/181853
    public int[] s181853(int[] num_list)
    {
        var sortList = num_list.OrderBy(x => x).ToList();
        sortList.RemoveRange(5, sortList.Count - 5);
        return sortList.ToArray();
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/181854
    public int[] s181854(int[] arr, int n)
    {
        bool evenNumber = arr.Length % 2 == 0;
        bool pong = evenNumber == false;
        int[] answer = arr.Select(a =>
        {
            if (pong)
            {
                a += n;
            }

            pong = !pong;
            return a;

        }).ToArray();

        return answer;
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/181856
    public int s181856(int[] arr1, int[] arr2)
    {
        if (arr1.Length > arr2.Length)
            return 1;

        if (arr1.Length < arr2.Length)
            return -1;

        int sum1 = arr1.Sum();
        int sum2 = arr2.Sum();

        if (sum1 > sum2)
            return 1;

        if (sum1 < sum2)
            return -1;

        return 0;
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/181861
    public int[] s181861(int[] arr)
    {
        int[] answer = new int[arr.Sum()];

        int startIndex = 0;
        int startValue = arr[startIndex];

        for (int i = 0; i < answer.Length; i++)
        {
            if (startValue == 0)
            {
                startValue = arr[++startIndex];
            }

            answer[i] = arr[startIndex];
            startValue--;
        }

        return answer;
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/181863
    public string s181863(string rny_string)
    {
        string answer = rny_string.Replace("m", "rn");
        return answer;
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/181864
    public int s181864(string myString, string pat)
    {
        string reverse = myString.Replace("A", "a").Replace("B", "A").Replace("a", "B");
        return reverse.Contains(pat) ? 1 : 0;
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/181868
    public string[] s181868(string my_string)
    {
        string[] answer = my_string.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        return answer;
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/181869
    public string[] s181869(string my_string)
    {
        string[] answer = my_string.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        return answer;
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/181870
    public string[] s181870(string[] strArr)
    {
        string[] answer = strArr.Where(x => x.Contains("ad") == false).ToArray();
        return answer;
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/181873
    public string s181873(string my_string, string alp)
    {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < my_string.Length; i++)
        {
            if (my_string[i].ToString().Equals(alp))
            {
                sb.Append(char.ToUpper(my_string[i]));
            }
            else
            {
                sb.Append(my_string[i]);
            }
        }

        return sb.ToString();
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/181874
    public string s181874(string myString)
    {
        return myString.ToLower().Replace("a", "A");
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/181875
    public string[] s181875(string[] strArr)
    {
        string[] answer = new string[strArr.Length];

        for (int i = 0; i < answer.Length; i++)
        {
            bool evenNumber = i % 2 == 0;
            answer[i] = evenNumber ? strArr[i].ToLower() : strArr[i].ToUpper();
        }

        return answer;
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/181876
    public string s181876(string myString)
    {
        return myString.ToLower();
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/181877
    public string s181877(string myString)
    {
        return myString.ToUpper();
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/181950
    public void s181950(string myString)
    {
        String[] input;

        Console.Clear();
#pragma warning disable CS8602 // null 가능 참조에 대한 역참조입니다.
        input = Console.ReadLine().Split(' ');
#pragma warning restore CS8602 // null 가능 참조에 대한 역참조입니다.

        String s1 = input[0];
        int a = Int32.Parse(input[1]);

        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < a; i++)
        {
            sb.Append(s1);
        }

        Console.WriteLine(sb.ToString());
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/181949
    public void s181949()
    {
        String s;

        Console.Clear();
#pragma warning disable CS8600 // null 리터럴 또는 가능한 null 값을 null을 허용하지 않는 형식으로 변환하는 중입니다.
        s = Console.ReadLine();
#pragma warning restore CS8600 // null 리터럴 또는 가능한 null 값을 null을 허용하지 않는 형식으로 변환하는 중입니다.

        StringBuilder sb = new StringBuilder();
#pragma warning disable CS8602 // null 가능 참조에 대한 역참조입니다.
        foreach (char c in s)
        {
            if (char.IsUpper(c))
            {
                sb.Append(char.ToLower(c));
            }
            else
            {
                sb.Append(char.ToUpper(c));
            }
        }
#pragma warning restore CS8602 // null 가능 참조에 대한 역참조입니다.

        Console.WriteLine(sb.ToString());
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/181948
    public void s181948()
    {
        Console.WriteLine("!@#$%^&*(\\'\"<>?:;");
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/181943
    public string s181943(string my_string, string overwrite_string, int s)
    {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < my_string.Length; i++)
        {
            if (i == s)
            {
                for (int m = 0; m < overwrite_string.Length; m++)
                {
                    sb.Append(overwrite_string[m]);
                    i++;
                }

                i--;
            }
            else
            {
                sb.Append(my_string[i]);
            }
        }

        return sb.ToString();
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/181942
    public string s181942(string str1, string str2)
    {
        StringBuilder sb = new StringBuilder();
        int count = str1.Length;

        for (int i = 0; i < count; i++)
        {
            sb.Append(str1[i]);
            sb.Append(str2[i]);
        }

        return sb.ToString();
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/181941
    public string s181941(string[] arr)
    {
        StringBuilder sb = new StringBuilder();

        foreach (string str in arr)
        {
            sb.Append(str);
        }
        return sb.ToString();
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/181940
    public string s181940(string my_string, int k)
    {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < k; i++)
        {
            sb.Append(my_string);
        }
        return sb.ToString();
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/181939
    public int s181939(int a, int b)
    {
        int ab = int.Parse($"{a}{b}");
        int ba = int.Parse($"{b}{a}");

        return Math.Max(ab, ba);
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/181938
    public int s181938(int a, int b)
    {
        int result1 = int.Parse($"{a}{b}");
        int result2 = 2 * a * b;
        return Math.Max(result1, result2);
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/181937
    public int s181937(int num, int n)
    {
        return num % n == 0 ? 1 : 0;
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/181936
    public int s181936(int number, int n, int m)
    {
        // n과 m의 최소공배수를 구해서 계산해도 가능
        return number % n == 0 && number % m == 0 ? 1 : 0;
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/181935
    public int s181935(int n)
    {
        bool isEvenNumber = n % 2 == 0;

        if (isEvenNumber == true)
        {
            int answer = 0;
            for (int i = 2; i <= n; i += 2)
            {
                answer += (i * i);
            }

            return answer;
        }
        else
        {
            int answer = 0;
            for (int i = 1; i <= n; i += 2)
            {
                answer += i;
            }

            return answer;
        }
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/181934
    public int s181934(string ineq, string eq, int n, int m)
    {
        bool leftArrow = ineq.Equals("<");
        bool isEquals = eq.Equals("=");

        if (isEquals == true)
        {
            bool answer = leftArrow == true ? n <= m : n >= m;
            return answer ? 1 : 0;
        }
        else
        {
            bool answer = leftArrow == true ? n < m : n > m;
            return answer ? 1 : 0;
        }
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/181933
    public int s181933(int a, int b, bool flag)
    {
        return flag ? a + b : a - b;
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/181931
    public int s181931(int a, int d, bool[] included)
    {
        int answer = 0;

        for (int i = 0; i < included.Length; i++)
        {
            answer += included[i] ? a + (i * d) : 0;
        }

        return answer;
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/181930
    public int s181930(int a, int b, int c)
    {
        int sum1 = a + b + c;
        int sum2 = a * a + b * b + c * c;
        int sum3 = a * a * a + b * b * b + c * c * c;

        if (a == b && a == c)
        {
            return sum1 * sum2 * sum3;
        }
        else if (a == b || b == c || a == c)
        {
            return sum1 * sum2;
        }
        else
        {
            return sum1;
        }
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/181929
    public int s181929(int[] num_list)
    {
        int a = num_list.Sum() * num_list.Sum();
        int b = num_list.Aggregate(1, (acc, x) => acc * x);

        return b < a ? 1 : 0;
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/181928
    public int s181928(int[] num_list)
    {
        string odd = "";
        string even = "";

        for (int i = 0; i < num_list.Length; i++)
        {
            bool isEvenNumber = num_list[i] % 2 == 0;

            if (isEvenNumber == true)
            {
                even += num_list[i];
            }
            else
            {
                odd += num_list[i];
            }
        }

        return int.Parse(odd) + int.Parse(even);
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/181927
    public int[] s181927(int[] num_list)
    {
        int a = num_list[num_list.Length - 1];
        int b = num_list[num_list.Length - 2];
        int addValue = 0;

        if (a > b)
        {
            addValue = a - b;
        }
        else
        {
            addValue = a * 2;
        }

        return num_list.Append(addValue).ToArray();
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/181926
    public int s181926(int n, string control)
    {
        for (int i = 0; i < control.Length; i++)
        {
            char command = control[i];

            if (command.Equals('w'))
            {
                n++;
            }
            else if (command.Equals('s'))
            {
                n--;
            }
            else if (command.Equals('d'))
            {
                n += 10;
            }
            else if (command.Equals('a'))
            {
                n -= 10;
            }
        }

        return n;
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/181925
    public string s181925(int[] numLog)
    {
        string answer = "";

        for (int i = 1; i < numLog.Length; i++)
        {
            int result = numLog[i];
            int prev = numLog[i - 1];

            int v = result - prev;

            if (v == 1)
            {
                answer += "w";
            }
            else if (v == -1)
            {
                answer += "s";
            }
            else if (v == 10)
            {
                answer += "d";
            }
            else if (v == -10)
            {
                answer += "a";
            }
        }

        return answer;
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/181924
    public int[] s181924(int[] arr, int[,] queries)
    {
        for (int i = 0; i < queries.GetLength(0); i++)
        {
            int a = queries[i, 0];
            int b = queries[i, 1];

            int aValue = arr[a];
            int bValue = arr[b];

            arr[a] = bValue;
            arr[b] = aValue;
        }

        return arr;
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/181923
    public int[] s181923(int[] arr, int[,] queries)
    {
        int[] answer = new int[queries.GetLength(0)];

        for (int i = 0; i < queries.GetLength(0); i++)
        {
            int a = queries[i, 0];
            int b = queries[i, 1];
            int c = queries[i, 2];

            List<int> valueList = new List<int>();

            for (int m = 0; m <= arr.Length; m++)
            {
                if (a <= m && m <= b)
                {
                    int value = arr[m];
                    if (c < value)
                    {
                        valueList.Add(value);
                    }
                }
            }

            if (valueList.Count == 0)
            {
                answer[i] = -1;
            }
            else
            {
                answer[i] = valueList.Min();
            }
        }

        return answer;
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/181922
    public int[] s181922(int[] arr, int[,] queries)
    {
        for (int i = 0; i < queries.GetLength(0); i++)
        {
            int a = queries[i, 0];
            int b = queries[i, 1];
            int c = queries[i, 2];

            for (int m = 0; m < arr.Length; m++)
            {
                if (a <= m && m <= b)
                {
                    if (m == 0 || m % c == 0)
                    {
                        arr[m]++;
                    }
                }
            }
        }

        return arr;
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/181921
    public int[] s181921(int l, int r)
    {
        List<int> result = new List<int>();

        for (int i = l; i <= r; i++)
        {
            string value = i.ToString();
            if (value.All(x => char.Equals(x, '0') || char.Equals(x, '5')))
            {
                result.Add(i);
            }
        }

        if (result.Count == 0)
        {
            return new int[] { -1 };
        }
        else
        {
            return result.ToArray();
        }
    }




    //https://school.programmers.co.kr/learn/courses/30/lessons/181920
    public int[] s181920(int start_num, int end_num)
    {
        List<int> answer = new List<int>();

        for (int i = start_num; i <= end_num; i++)
        {
            answer.Add(i);
        }

        return answer.ToArray();
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/181919
    public int[] s181919(int n)
    {
        List<int> answer = new List<int>();
        answer.Add(n);

        while (n != 1)
        {
            bool isEvenNumber = n % 2 == 0;

            if (isEvenNumber == true)
            {
                n /= 2;
            }
            else
            {
                n = 3 * n + 1;
            }

            answer.Add(n);
        }

        return answer.ToArray();
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/181918
    public int[] s181918(int[] arr)
    {
        List<int> answer = new List<int>();

        for (int i = 0; i < arr.Length; i++)
        {
            int value = arr[i];

            if (answer.Count == 0)
            {
                answer.Add(value);
            }
            else if (answer.Last() < value)
            {
                answer.Add(value);
            }
            else
            {
                answer.RemoveAt(answer.Count - 1);
                i--;
            }
        }

        return answer.ToArray();
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/181917
    public bool s181917(bool x1, bool x2, bool x3, bool x4)
    {
        return (x1 || x2) && (x3 || x4);
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/181916
    public int s181916(int a, int b, int c, int d)
    {
        Dictionary<int, int> counter = new Dictionary<int, int>();
        int[] dices = new int[] { a, b, c, d };

        for (int i = 0; i < dices.Length; i++)
        {
            if (counter.ContainsKey(dices[i]))
            {
                counter[dices[i]]++;
            }
            else
            {
                counter.Add(dices[i], 1);
            }
        }

        bool isFour = counter.Values.Any(x => x == 4);
        bool isThree = counter.Values.Any(x => x == 3);
        bool isTwo = counter.Values.Any(x => x == 2);

        if (isFour)
        {
            return 1111 * counter.Keys.ToList()[0];
        }
        else if (isThree)
        {
            var max = counter
                        .Where(x => x.Value == 3)
                        .Select(x => x.Key).ToList()[0];

            var min = counter
                        .Where(x => x.Value == 1)
                        .Select(x => x.Key).ToList()[0];

            return (int)Math.Pow(10 * max + min, 2);
        }
        else if (isTwo)
        {
            bool isDouble = counter
                                .Where(x => x.Value == 2)
                                .Select(x => x.Key).ToList().Count > 1;

            if (isDouble)
            {
                var keyList = counter.Keys.ToList();
                return (keyList[0] + keyList[1]) * Math.Abs(keyList[0] - keyList[1]);
            }
            else
            {
                var keyList = counter
                                .Where(x => x.Value != 2)
                                .Select(x => x.Key).ToList();

                return keyList[0] * keyList[1];
            }
        }
        else
        {
            return counter.Keys.ToList().Min();
        }
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/181915
    public string s181915(string my_string, int[] index_list)
    {
        string answer = "";

        for (int i = 0; i < index_list.Length; i++)
        {
            answer += my_string[index_list[i]];
        }

        return answer;
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/181914
    public int s181914(string number)
    {
        int answer = 0;

        for (int i = 0; i < number.Length; i++)
        {
            answer += number[i] - '0';
        }

        return answer % 9;
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/181913
    public string s181913(string my_string, int[,] queries)
    {
        List<int> list = new List<int>();

        for (int i = 0; i < my_string.Length; i++)
        {
            list.Add(i);
        }

        for (int i = 0; i < queries.GetLength(0); i++)
        {
            int startIdx = queries[i, 0];
            int endIdx = queries[i, 1];

            List<int> reverseList = new List<int>();
            for (int m = startIdx; m <= endIdx; m++)
            {
                reverseList.Add(list[m]);
            }
            reverseList.Reverse();

            list.RemoveRange(startIdx, endIdx - startIdx + 1);
            list.InsertRange(startIdx, reverseList);
        }

        string answer = "";
        for (int i = 0; i < list.Count; i++)
        {
            answer += my_string[list[i]];
        }

        return answer;
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/181912
    public int[] s181912(string[] intStrs, int k, int s, int l)
    {
        List<int> answer = new List<int>();

        for (int i = 0; i < intStrs.Length; i++)
        {
            int value = int.Parse(intStrs[i].Substring(s, l));

            if (value > k)
                answer.Add(value);
        }

        return answer.ToArray();
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/181911
    public string s181911(string[] my_strings, int[,] parts)
    {
        string answer = "";

        for (int i = 0; i < my_strings.Length; i++)
        {
            int startIdx = parts[i, 0];
            int count = parts[i, 1];

            answer += my_strings[i].Substring(startIdx, count - startIdx + 1);
        }

        return answer;
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/181910
    public string s181910(string my_string, int n)
    {
        int removeCount = my_string.Length - n;

        return my_string.Remove(0, removeCount);
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/181909
    public string[] s181909(string my_string)
    {
        List<string> answer = new List<string>();

        for (int i = 0; i <= my_string.Length; i++)
        {
            int removeCount = my_string.Length - i;
            string value = my_string.Remove(0, removeCount);

            if (string.IsNullOrEmpty(value) == false)
            {
                answer.Add(value);
            }
        }

        return answer.OrderBy(x => x).ToArray();
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/181908
    public int s181908(string my_string, string is_suffix)
    {
        List<string> answer = new List<string>();

        for (int i = 0; i <= my_string.Length; i++)
        {
            int removeCount = my_string.Length - i;
            string value = my_string.Remove(0, removeCount);

            if (string.IsNullOrEmpty(value) == false)
            {
                answer.Add(value);
            }
        }

        return answer.Contains(is_suffix) ? 1 : 0;
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/181907
    public string s181907(string my_string, int n)
    {
        return my_string.Substring(0, n);
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/181906
    public int s181906(string my_string, string is_prefix)
    {
        int count = my_string.Length;
        List<string> list = new List<string>();

        for (int i = 0; i < my_string.Length; i++)
        {
            string value = my_string.Substring(0, i);

            if (string.IsNullOrEmpty(value) == false)
            {
                list.Add(value);
            }
        }

        return list.Contains(is_prefix) == true ? 1 : 0;
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/181905
    public string s181905(string my_string, int s, int e)
    {
        string answer = "";
        string targetString = my_string.Substring(s, e - s + 1);
        string reverse = new string(targetString.Reverse().ToArray());
        answer = my_string.Remove(s, e - s + 1).Insert(s, reverse);
        return answer;
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/181904
    public string s181904(string my_string, int m, int c)
    {
        int count = my_string.Length / m;
        string answer = "";
        for (int i = 0; i < count; i++)
        {
            answer += my_string[i * m + c - 1];
        }

        return answer;
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/181903
    public string s181903(int q, int r, string code)
    {
        string answer = "";

        for (int i = 0; i < code.Length; i++)
        {
            if (i % q == r)
                answer += code[i];
        }

        return answer;
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/181902
    public int[] s181902(string my_string)
    {
        int[] answer = new int[52];

        foreach (char c in my_string)
        {
            //인덱스 0부터 25는 대문자 ‘A’부터 ‘Z’까지의 개수를 저장.
            //인덱스 26부터 51은 소문자 ‘a’부터 ‘z’까지의 개수를 저장.
            if (c >= 'A' && c <= 'Z')
            {
                answer[c - 'A']++;
            }
            else if (c >= 'a' && c <= 'z')
            {
                answer[c - 'a' + 26]++;
            }
        }

        return answer;
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/181901
    public int[] s181901(int n, int k)
    {
        List<int> answer = new List<int>();

        for (int i = k; i <= n; i++)
        {
            if (i % k == 0)
                answer.Add(i);
        }

        return answer.ToArray();
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/181900
    public string s181900(string my_string, int[] indices)
    {
        Array.Sort(indices);
        string answer = "";

        int indicesIdx = 0;
        for (int i = 0; i < my_string.Length; i++)
        {
            if (indicesIdx < indices.Length && i == indices[indicesIdx])
            {
                indicesIdx++;
                continue;
            }

            answer += my_string[i];
        }

        return answer;
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/181899
    public int[] s181899(int start_num, int end_num)
    {
        List<int> answer = new List<int>();
        int count = start_num - end_num + 1;
        int startNumber = start_num;

        for (int i = 0; i < count; i++)
        {
            answer.Add(startNumber--);
        }

        return answer.ToArray();
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/181898
    public int s181898(int[] arr, int idx)
    {
        if (arr[idx] == 1)
        {
            return idx;
        }

        for (int i = idx; i < arr.Length; i++)
        {
            if (arr[i] > 0)
                return i;
        }

        return -1;
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/181897
    public int[] s181897(int n, int[] slicer, int[] num_list)
    {
        List<int> answer = new List<int>();
        int a = slicer[0];
        int b = slicer[1];
        int c = slicer[2];

        if (n == 1)
        {
            for (int i = 0; i <= b; i++)
            {
                answer.Add(num_list[i]);
            }
        }
        else if (n == 2)
        {
            for (int i = a; i < num_list.Length; i++)
            {
                answer.Add(num_list[i]);
            }
        }
        else if (n == 3)
        {
            for (int i = a; i <= b; i++)
            {
                answer.Add(num_list[i]);
            }
        }
        else
        {
            for (int i = a; i <= b; i += c)
            {
                answer.Add(num_list[i]);
            }
        }

        return answer.ToArray();
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/181896
    public int s181896(int[] num_list)
    {
        for (int i = 0; i < num_list.Length; i++)
        {
            if (num_list[i] < 0)
                return i;
        }

        return -1;
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/181895
    public int[] s181895(int[] arr, int[,] intervals)
    {
        List<int> answer = new List<int>();

        int a1 = intervals[0, 0];
        int b1 = intervals[0, 1];
        int a2 = intervals[1, 0];
        int b2 = intervals[1, 1];

        for (int i = a1; i <= b1; i++)
        {
            answer.Add(arr[i]);
        }

        for (int i = a2; i <= b2; i++)
        {
            answer.Add(arr[i]);
        }

        return answer.ToArray();
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/181894
    public int[] s181894(int[] arr)
    {
        var indexArr = arr
                        .Select((value, index) => new { value, index })
                        .Where(x => x.value == 2)
                        .Select(x => x.index)
                        .ToList();

        if (indexArr.Count == 0)
            return new int[] { -1 };

        int min = indexArr.Min();
        int max = indexArr.Max();

        List<int> answer = new List<int>();

        for (int i = min; i <= max; i++)
        {
            answer.Add(arr[i]);
        }

        return answer.ToArray();
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/181893
    public int[] s181893(int[] arr, int[] query)
    {
        List<int> answer = new List<int>(arr);

        for (int i = 0; i < query.Length; i++)
        {
            int idx = query[i];
            bool isEvenNumber = i % 2 == 0;

            if (isEvenNumber == true)
            {
                int count = answer.Count - idx - 1;
                answer.RemoveRange(idx + 1, count);
            }
            else
            {
                int count = idx;
                answer.RemoveRange(0, count);
            }
        }

        return answer.ToArray();
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/181892
    public int[] s181892(int[] num_list, int n)
    {
        List<int> answer = new List<int>(num_list);
        answer.RemoveRange(0, n - 1);

        return answer.ToArray();
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/181891
    public int[] s181891(int[] num_list, int n)
    {
        List<int> answer = new List<int>(num_list);

        for (int i = 0; i < n; i++)
        {
            int value = answer[0];
            answer.RemoveAt(0);
            answer.Add(value);
        }

        return answer.ToArray();
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/181890
    public string[] s181890(string[] str_list)
    {
        int idx = -1;
        bool isLeft = false;
        List<string> answer = new List<string>(str_list);

        for (int i = 0; i < str_list.Length; i++)
        {
            if (str_list[i].Equals("l"))
            {
                idx = i;
                isLeft = true;
                break;
            }

            if (str_list[i].Equals("r"))
            {
                idx = i;
                isLeft = false;
                break;
            }
        }

        if (idx != -1)
        {
            if (isLeft == true)
            {
                answer.RemoveRange(idx, answer.Count - idx);
            }
            else
            {
                answer.RemoveRange(0, idx + 1);
            }

            return answer.ToArray();
        }
        else
        {
            return new string[] { };
        }
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/181889
    public int[] s181889(int[] num_list, int n)
    {
        List<int> answer = new List<int>();

        for (int i = 0; i < n; i++)
        {
            answer.Add(num_list[i]);
        }

        return answer.ToArray();
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/181888
    public int[] s181888(int[] num_list, int n)
    {
        List<int> answer = new List<int>();

        for (int i = 0; i < num_list.Length; i += n)
        {
            answer.Add(num_list[i]);
        }

        return answer.ToArray();
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/181887
    public int s181887(int[] num_list)
    {
        bool isEvenNumber = false;
        int[] sum = new int[] { 0, 0 };
        for (int i = 0; i < num_list.Length; i++)
        {
            if (isEvenNumber == true)
            {
                sum[1] += num_list[i];
            }
            else
            {
                sum[0] += num_list[i];
            }

            isEvenNumber = !isEvenNumber;
        }

        return sum.Max();
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/181886
    public string[] solution(string[] names)
    {
        List<string> answer = new List<string>();

        for (int i = 0; i < names.Length; i += 5)
        {
            answer.Add(names[i]);
        }

        return answer.ToArray();
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/181885
    public string[] solution(string[] todo_list, bool[] finished)
    {
        var answer = todo_list
                        .Select((value, index) => new { value, index })
                        .Where(x => finished[x.index] == false)
                        .Select(x => x.value)
                        .ToArray();

        return answer;
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/181884
    public int s181884(int[] numbers, int n)
    {
        int answer = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            answer += numbers[i];

            if (answer > n)
                return answer;
        }

        return 0;
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/181883
    public int[] s181883(int[] arr, int[,] queries)
    {
        for (int i = 0; i < queries.GetLength(0); i++)
        {
            int a = queries[i, 0];
            int b = queries[i, 1];

            for (int m = a; m <= b; m++)
            {
                arr[m]++;
            }
        }

        return arr;
    }




    //https://school.programmers.co.kr/learn/courses/30/lessons/181882
    public int[] s181882(int[] arr)
    {
        int[] answer = new int[arr.Length];

        for (int i = 0; i < answer.Length; i++)
        {
            int value = arr[i];

            bool isEvenNumber = value % 2 == 0;
            bool isOver50 = value >= 50;

            if (isOver50 == true && isEvenNumber == true)
            {
                answer[i] = value / 2;
            }
            else if (isOver50 == false && isEvenNumber == false)
            {
                answer[i] = value * 2;
            }
            else
            {
                answer[i] = arr[i];
            }
        }

        return answer;
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/181881
    public int s181881(int[] arr)
    {
        int count = 0;

        while (true)
        {
            int changedCount = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int value = arr[i];

                bool isEvenNumber = value % 2 == 0;
                bool isOver50 = value >= 50;

                if (isOver50 == true && isEvenNumber == true)
                {
                    arr[i] = value / 2;
                    changedCount++;
                }
                else if (isOver50 == false && isEvenNumber == false)
                {
                    arr[i] = (value * 2) + 1;
                    changedCount++;
                }
            }

            if (changedCount == 0)
                break;

            count++;
        }

        return count;
    }
}
