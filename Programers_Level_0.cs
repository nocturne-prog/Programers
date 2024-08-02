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



    //https://school.programmers.co.kr/learn/courses/30/lessons/181880
    public int s181880(int[] num_list)
    {
        int answer = 0;

        for (int i = 0; i < num_list.Length; i++)
        {
            int value = num_list[i];

            while (value != 1)
            {
                value /= 2;
                answer++;
            }
        }

        return answer;
    }




    //https://school.programmers.co.kr/learn/courses/30/lessons/181879
    public int solution(int[] num_list)
    {
        if (num_list.Length >= 11)
        {
            return num_list.Sum();
        }
        else
        {
            return num_list.Aggregate(1, (acc, val) => acc * val);
        }
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/181878
    public int s181878(string myString, string pat)
    {
        return myString.ToLower().Contains(pat.ToLower()) ? 1 : 0;
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/181872
    public string s181872(string myString, string pat)
    {
        int idx = myString.LastIndexOf(pat);
        return myString.Substring(0, idx + pat.Length);
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/181871
    public int s181871(string myString, string pat)
    {
        int answer = 0;

        for (int i = 0; i <= myString.Length - pat.Length; i++)
        {
            string value = myString.Substring(i, pat.Length);

            if (value.Equals(pat))
            {
                answer++;
            }
        }

        return answer;
    }




    //https://school.programmers.co.kr/learn/courses/30/lessons/181867
    public int[] s181867(string myString)
    {
        string[] split = myString.Split('x');
        return split.Select(x => x.Length).ToArray();
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/181866
    public string[] s181866(string myString)
    {
        return myString.Split('x')
                            .Where(x => string.IsNullOrEmpty(x) == false)
                            .OrderBy(x => x)
                            .ToArray();
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/181932
    public string s181932(string code)
    {
        StringBuilder ret = new StringBuilder();
        int mode = 0;

        for (int idx = 0; idx < code.Length; idx++)
        {
            if (code[idx] == '1')
            {
                mode = 1 - mode; // mode 전환
            }
            else
            {
                if (mode == 0 && idx % 2 == 0)
                {
                    ret.Append(code[idx]);
                }
                else if (mode == 1 && idx % 2 == 1)
                {
                    ret.Append(code[idx]);
                }
            }
        }

        return ret.Length > 0 ? ret.ToString() : "EMPTY";
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/181865
    public int s181865(string binomial)
    {
        if (binomial.Contains("+"))
        {
            string[] split = binomial.Split("+");
            return int.Parse(split[0]) + int.Parse(split[1]);
        }
        else if (binomial.Contains("-"))
        {
            string[] split = binomial.Split("-");
            return int.Parse(split[0]) - int.Parse(split[1]);
        }
        else
        {
            string[] split = binomial.Split("*");
            return int.Parse(split[0]) * int.Parse(split[1]);
        }
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/181862
    public string[] s181862(string myStr)
    {
        string[] answer = myStr.Split('a', 'b', 'c').Where(x => string.IsNullOrEmpty(x) == false).ToArray();

        return answer.Length > 0 ? answer : new string[] { "EMPTY" };
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/181860
    public int[] s181860(int[] arr, bool[] flag)
    {
        List<int> answer = new List<int>();

        for (int i = 0; i < flag.Length; i++)
        {
            if (flag[i] == true)
            {
                IEnumerable<int> items = Enumerable.Repeat(arr[i], arr[i] * 2);
                answer.AddRange(items);
            }
            else
            {
                answer.RemoveRange(answer.Count - arr[i], arr[i]);
            }
        }

        return answer.ToArray();
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/181859
    public int[] s181859(int[] arr)
    {
        List<int> answer = new List<int>();

        for (int i = 0; i < arr.Length; i++)
        {
            int value = arr[i];

            if (answer.Count == 0)
            {
                answer.Add(value);
            }
            else
            {
                if (answer.Last() == value)
                {
                    answer.RemoveAt(answer.Count - 1);
                }
                else
                {
                    answer.Add(value);
                }
            }
        }

        if (answer.Count == 0)
            return new int[] { -1 };

        return answer.ToArray();
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/181858
    public int[] s181858(int[] arr, int k)
    {
        List<int> answer = new List<int>(arr.Distinct());

        if (answer.Count > k)
        {
            answer.RemoveRange(k, answer.Count - k);
        }
        else if (answer.Count < k)
        {
            IEnumerable<int> defaultValue = Enumerable.Repeat(-1, k - answer.Count);
            answer.AddRange(defaultValue);
        }

        return answer.ToArray();
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/181857
    public int[] s181857(int[] arr)
    {
        List<int> answer = new List<int>(arr);

        int length = arr.Length;
        int value = 1;

        while (value < length)
        {
            value *= 2;
        }

        IEnumerable<int> addValue = Enumerable.Repeat(0, value - length);
        answer.AddRange(addValue);

        return answer.ToArray();
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/181855
    public int s181855(string[] strArr)
    {
        var answer = strArr.GroupBy(x => x.Length).ToDictionary(x => x.Key, x => x.ToList());
        return answer.Max(x => x.Value.Count);
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/181851
    public int s181851(int[] rank, bool[] attendance)
    {
        Dictionary<int, int> list = new Dictionary<int, int>();

        for (int i = 0; i < rank.Length; i++)
        {
            if (attendance[i] == true)
            {
                list.Add(i, rank[i]);
            }
        }

        int[] answer = new int[3];

        for (int i = 0; i < answer.Length; i++)
        {
            int key = list.OrderBy(kv => kv.Value)
                            .First()
                            .Key;
            list.Remove(key);

            answer[i] = key;
        }

        return (10000 * answer[0]) + (100 * answer[1]) + answer[2];
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/181847
    public string s181847(string n_str)
    {
        return n_str.TrimStart('0');
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/181846
    public string s181846(string a, string b)
    {
        int i = a.Length - 1;
        int j = b.Length - 1;
        int carry = 0;
        StringBuilder result = new StringBuilder();

        while (i >= 0 || j >= 0 || carry > 0)
        {
            int sum = carry;
            if (i >= 0)
            {
                sum += a[i] - '0';
                i--;
            }

            if (j >= 0)
            {
                sum += b[j] - '0';
                j--;
            }
            result.Insert(0, sum % 10); // 결과 문자열의 맨 앞에 추가
            carry = sum / 10; // 다음 자리로 넘길 올림 값
        }

        return result.ToString();
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/181841
    public string s181841(string[] str_list, string ex)
    {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < str_list.Length; i++)
        {
            string value = str_list[i];

            if (value.Contains(ex))
                continue;

            sb.Append(value);
        }

        return sb.ToString();
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/181839
    public int s181839(int a, int b)
    {
        bool isEvenNumber_A = a % 2 == 0;
        bool isEvenNumber_B = b % 2 == 0;

        if (isEvenNumber_A == false && isEvenNumber_B == false)
        {
            return (a * a) + (b * b);
        }
        else if (isEvenNumber_A == false || isEvenNumber_B == false)
        {
            return 2 * (a + b);
        }
        else
        {
            return Math.Abs(a - b);
        }
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/181838
    public int s181838(int[] date1, int[] date2)
    {
        DateTime dateA = new DateTime(date1[0], date1[1], date1[2]);
        DateTime dateB = new DateTime(date2[0], date2[1], date2[2]);

        return dateA < dateB ? 1 : 0;
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/181837
    public int s181837(string[] order)
    {
        int answer = 0;

        for (int i = 0; i < order.Length; i++)
        {
            string value = order[i];

            if (value.Contains("cafelatte"))
            {
                answer += 5000;
            }
            else
            {
                answer += 4500;
            }
        }

        return answer;
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/181836
    public string[] s181836(string[] picture, int k)
    {
        List<string> answer = new List<string>();

        for (int i = 0; i < picture.Length; i++)
        {
            string value = picture[i];
            string result = "";
            for (int m = 0; m < value.Length; m++)
            {
                char mark = value[m];

                for (int h = 0; h < k; h++)
                {
                    result += mark;
                }
            }

            for (int m = 0; m < k; m++)
            {
                answer.Add(result);
            }
        }

        return answer.ToArray();
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/181834
    public string s181834(string myString)
    {
        char[] charArray = myString.ToCharArray();

        for (int i = 0; i < charArray.Length; i++)
        {
            if (charArray[i] < 'l')
            {
                charArray[i] = 'l';
            }
        }

        return new string(charArray);
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/181833
    public int[,] s181833(int n)
    {
        if (n == 1)
            return new int[,] { { 1 } };

        int[,] answer = new int[n, n];

        for (int i = 0; i < answer.GetLength(0); i++)
        {
            answer[i, i] = 1;
        }

        return answer;
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/181831
    public int s181831(int[,] arr)
    {
        for (int i = 1; i < arr.GetLength(0); i++)
        {
            if (arr[0, i] != arr[i, 0])
            {
                return 0;
            }

            if (arr[arr.GetLength(1) - 1, i] != arr[i, arr.GetLength(1) - 1])
            {
                return 0;
            }
        }

        return 1;
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/181830
    public int[,] s181830(int[,] arr)
    {
        if (arr.GetLength(0) == arr.GetLength(1))
            return arr;

        int size = Math.Max(arr.GetLength(0), arr.GetLength(1));

        int[,] answer = new int[size, size];

        for (int i = 0; i < answer.GetLength(0); i++)
        {
            for (int m = 0; m < answer.GetLength(1); m++)
            {
                if (i >= arr.GetLength(0) || m >= arr.GetLength(1))
                    answer[i, m] = 0;
                else
                    answer[i, m] = arr[i, m];
            }
        }

        return answer;
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/181829
    public int s181829(int[,] board, int k)
    {
        int answer = 0;

        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int m = 0; m < board.GetLength(1); m++)
            {
                if (i + m <= k)
                    answer += board[i, m];
            }
        }

        return answer;
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/181832
    enum Dir
    {
        RIGHT,
        LEFT,
        DOWN,
        UP
    }
    public int[,] s181832(int n)
    {
        Dir dir = Dir.RIGHT;
        int[,] answer = new int[n, n];
        answer[0, 0] = 1;

        int count = 2;

        int xMaxIdx = n - 1;
        int xMinIdx = 0;
        int yMaxIdx = n - 1;
        int yMinIdx = 0;

        int x = 0, y = 0;

        while (count < (n * n) + 1)
        {
            if (x == xMaxIdx && y == yMinIdx && dir != Dir.DOWN)
            {
                dir = Dir.DOWN;
                yMinIdx++;
            }
            else if (x == xMaxIdx && y == yMaxIdx && dir != Dir.LEFT)
            {
                dir = Dir.LEFT;
                xMaxIdx--;
            }
            else if (x == xMinIdx && y == yMaxIdx && dir != Dir.UP)
            {
                dir = Dir.UP;
                yMaxIdx--;
            }
            else if (x == xMinIdx && y == yMinIdx && dir != Dir.RIGHT)
            {

                dir = Dir.RIGHT;
                xMinIdx++;

            }

            switch (dir)
            {
                case Dir.RIGHT: x++; break;
                case Dir.LEFT: x--; break;
                case Dir.DOWN: y++; break;
                case Dir.UP: y--; break;
            }

            answer[y, x] = count++;
        }

        return answer;
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/120956
    public int s120956(string[] babbling)
    {
        string[] referenceValues = new string[] { "aya", "ye", "woo", "ma" };
        int answer = 0;

        for (int i = 0; i < babbling.Length; i++)
        {
            string value = babbling[i];

            for (int m = 0; m < referenceValues.Length; m++)
            {
                if (value.Contains(referenceValues[m]))
                {
                    value = value.Replace(referenceValues[m], " ");

                    // string[] split = value.Split(referenceValues[m]);
                    // value = string.Join("", split);

                    if (string.IsNullOrEmpty(value.Trim()) == true)
                    {
                        answer++;
                        break;
                    }
                }
            }
        }

        return answer;
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/120924
    public int s120924(int[] common)
    {
        bool isGeometric = common[2] - common[1] == common[1] - common[0];

        if (isGeometric == true)
        {
            int gap = common[1] - common[0];

            return common[common.Length - 1] + gap;
        }
        else
        {
            int gap = common[1] / common[0];

            return common[common.Length - 1] * gap;
        }
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/120923
    public int[] s120923(int num, int total)
    {
        int start = (total - num * (num - 1) / 2) / num;
        return Enumerable.Range(start, num).ToArray();
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/120922
    public int s120922(int M, int N)
    {
        return (N - 1) + (N * (M - 1));
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/120921
    public int s120921(string A, string B)
    {
        string value = A + A;
        int idx = value.LastIndexOf(B);

        if (idx < 0)
            return -1;
        else
            return A.Length - idx;
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/120913
    public string[] s120913(string my_str, int n)
    {
        List<string> answer = new List<string>();

        for (int i = 0; i < my_str.Length; i += n)
        {
            int length = Math.Min(n, my_str.Length - i);
            answer.Add(my_str.Substring(i, length));
        }

        return answer.ToArray();
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/120912
    public int s120912(int[] array)
    {
        int answer = 0;

        for (int i = 0; i < array.Length; i++)
        {
            string value = array[i].ToString();

            for (int m = 0; m < value.Length; m++)
            {
                if (value[m].Equals('7'))
                {
                    answer++;
                }
            }
        }

        return answer;
    }




    //https://school.programmers.co.kr/learn/courses/30/lessons/120911
    public string s120911(string my_string)
    {
        char[] value = my_string.ToLower().ToCharArray();

        value = value.OrderBy(x => x).ToArray();

        return new string(value);
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/120910
    public int s120910(int n, int t)
    {
        return n * (int)Math.Pow(2, t);
    }




    //https://school.programmers.co.kr/learn/courses/30/lessons/120909
    public int s120909(int n)
    {
        int sqrt = (int)Math.Sqrt(n);

        return sqrt * sqrt == n ? 1 : 2;
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/120908
    public int s120908(string str1, string str2)
    {
        return str1.Contains(str2) ? 1 : 2;
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/120907
    public string[] s120907(string[] quiz)
    {
        List<string> answer = new List<string>();

        for (int i = 0; i < quiz.Length; i++)
        {
            string value = quiz[i];
            string[] split = value.Split(' ');

            int x = int.Parse(split[0]);
            bool isPlus = split[1].Equals("+");
            int y = int.Parse(split[2]);
            int z = int.Parse(split[4]);

            string OX = isPlus ?
                            x + y == z ? "O" : "X" :
                            x - y == z ? "O" : "X";

            answer.Add(OX);
        }

        return answer.ToArray();
    }




    //https://school.programmers.co.kr/learn/courses/30/lessons/120906
    public int s120906(int n)
    {
        string nString = n.ToString();

        int answer = 0;
        for (int i = 0; i < nString.Length; i++)
        {
            answer += nString[i] - '0';
        }

        return answer;
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/120905
    public int[] s120905(int n, int[] numlist)
    {
        List<int> answer = new List<int>();

        for (int i = 0; i < numlist.Length; i++)
        {
            if (numlist[i] % n == 0)
                answer.Add(numlist[i]);
        }

        return answer.ToArray();
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/120904
    public int s120904(int num, int k)
    {
        string numString = num.ToString();
        int answer = numString.IndexOf(k.ToString());

        return answer < 0 ? answer : answer + 1;
    }




    //https://school.programmers.co.kr/learn/courses/30/lessons/120903
    public int s120903(string[] s1, string[] s2)
    {
        HashSet<string> h1 = new HashSet<string>(s1);
        HashSet<string> h2 = new HashSet<string>(s2);

        h1.IntersectWith(h2);

        return h1.Count;
    }




    //https://school.programmers.co.kr/learn/courses/30/lessons/120902
    public int s120902(string my_string)
    {
        string[] split = my_string.Split(' ');

        int answer = 0;
        answer += int.Parse(split[0]);

        for (int i = 1; i < split.Length; i += 2)
        {
            bool isPlus = split[i].Equals("+");
            int value = int.Parse(split[i + 1]);
            if (isPlus == true)
            {
                answer += value;
            }
            else
            {
                answer -= value;
            }

        }

        return answer;
    }




    //https://school.programmers.co.kr/learn/courses/30/lessons/120899
    public int[] s120899(int[] array)
    {
        int max = array[0];
        int idx = 0;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                idx = i;
            }
        }

        return new int[] { max, idx };
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/120898
    public int s120898(string message)
    {
        return message.Length * 2;
    }




    //https://school.programmers.co.kr/learn/courses/30/lessons/120897
    public int[] s120897(int n)
    {
        HashSet<int> hashSet = new HashSet<int>();
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                hashSet.Add(n);
                hashSet.Add(i);
            }
        }

        return hashSet.OrderBy(x => x).ToArray();
    }




    //https://school.programmers.co.kr/learn/courses/30/lessons/120896
    public string s120896(string s)
    {
        Dictionary<char, int> dic = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            char value = s[i];

            if (dic.ContainsKey(value))
            {
                dic[value]++;
            }
            else
            {
                dic.Add(value, 1);
            }
        }

        var answerList = dic.Where(x => x.Value == 1)
                            .OrderBy(x => x.Key);

        string answer = "";

        foreach (var v in answerList)
            answer += v.Key;

        return answer;
    }




    //https://school.programmers.co.kr/learn/courses/30/lessons/120895
    public string s120895(string my_string, int num1, int num2)
    {
        char[] mystring = my_string.ToCharArray();

        char a = mystring[num1];
        mystring[num1] = my_string[num2];
        mystring[num2] = a;

        return new string(mystring);
    }




    //https://school.programmers.co.kr/learn/courses/30/lessons/120894
    public long s120894(string numbers)
    {
        Dictionary<string, string> dic = new Dictionary<string, string>
        {
            { "zero", "0" },
            { "one", "1" },
            { "two", "2" },
            { "three", "3" },
            { "four", "4" },
            { "five", "5" },
            { "six", "6" },
            { "seven", "7" },
            { "eight", "8" },
            { "nine", "9" }
        };

        foreach (var v in dic)
        {
            numbers = numbers.Replace(v.Key, v.Value);
        }

        return long.Parse(numbers);
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/120893
    public string s120893(string my_string)
    {
        return string.Concat(my_string.Select(x => char.IsUpper(x) ? char.ToLower(x) : char.ToUpper(x)));
    }




    //https://school.programmers.co.kr/learn/courses/30/lessons/120892
    public string s120892(string cipher, int code)
    {
        string answer = "";

        for (int i = code - 1; i < cipher.Length; i += code)
        {
            answer += cipher[i];
        }

        return answer;
    }




    //https://school.programmers.co.kr/learn/courses/30/lessons/120891
    public int s120891(int order)
    {
        return string.Concat(order.ToString().Where(x => x.Equals('3') || x.Equals('6') || x.Equals('9'))).Length;
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/120890
    public int s120890(int[] array, int n)
    {
        int[] answerArray = array.Select(x => Math.Abs(x - n)).ToArray();
        int minValue = answerArray.Min();
        int[] answerList = answerArray.Select((value, index) => new { value, index })
                                            .Where(x => x.value == minValue)
                                            .Select(x => array[x.index])
                                            .ToArray();

        return answerList.Min();
    }




    //https://school.programmers.co.kr/learn/courses/30/lessons/120889
    public int s120889(int[] sides)
    {
        return sides.Max() < sides.Sum() - sides.Max() ? 1 : 2;
    }




    //https://school.programmers.co.kr/learn/courses/30/lessons/120888
    public string s120888(string my_string)
    {
        HashSet<char> answer = new HashSet<char>();

        for (int i = 0; i < my_string.Length; i++)
        {
            answer.Add(my_string[i]);
        }

        return string.Concat(answer);
    }




    //https://school.programmers.co.kr/learn/courses/30/lessons/120887
    public int s120887(int i, int j, int k)
    {
        int answer = 0;

        for (int m = i; m <= j; m++)
        {
            string value = m.ToString();

            for (int h = 0; h < value.Length; h++)
            {
                if (value[h] - '0' == k)
                    answer++;
            }
        }

        return answer;
    }




    //https://school.programmers.co.kr/learn/courses/30/lessons/120886
    public int s120886(string before, string after)
    {
        string sortBefore = string.Concat(before.OrderBy(x => x));
        string sortAfter = string.Concat(after.OrderBy(x => x));

        return sortBefore.Equals(sortAfter) ? 1 : 0;
    }




    //https://school.programmers.co.kr/learn/courses/30/lessons/120885
    public string s120885(string bin1, string bin2)
    {
        int num1 = Convert.ToInt32(bin1, 2);
        int num2 = Convert.ToInt32(bin2, 2);

        return Convert.ToString(num1 + num2, 2);
    }




    //https://school.programmers.co.kr/learn/courses/30/lessons/120884
    public int s120884(int chicken)
    {
        int answer = 0;

        while (chicken >= 10)
        {
            int quotient = chicken / 10;
            int remider = chicken % 10;

            answer += quotient;

            chicken = remider + quotient;
        }

        return answer;
    }




    //https://school.programmers.co.kr/learn/courses/30/lessons/120883
    public string s120883(string[] id_pw, string[,] db)
    {
        string id = "";
        string pw = "";

        for (int i = 0; i < db.GetLength(0); i++)
        {
            string dbID = db[i, 0];
            string dbPW = db[i, 1];

            if (id_pw[0].Equals(dbID))
            {
                id = dbID;
                pw = dbPW;
                break;
            }
        }

        if (string.IsNullOrEmpty(id) == true)
        {
            return "fail";
        }

        if (id_pw[1].Equals(pw) == false)
        {
            return "wrong pw";
        }

        return "login";
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/120882
    public int[] s120882(int[,] score)
    {
        float[] avgScore = new float[score.GetLength(0)];

        for (int i = 0; i < avgScore.Length; i++)
        {
            avgScore[i] = (score[i, 0] + score[i, 1]) / 2f;
        }

        List<float> sortList = avgScore.OrderByDescending(x => x).ToList();
        Dictionary<float, int> dic = new Dictionary<float, int>();
        int rank = 1;

        for (int i = 0; i < sortList.Count; i++)
        {
            if (dic.ContainsKey(sortList[i]) == true)
            {
                rank++;
            }
            else
            {
                dic.Add(sortList[i], rank++);
            }
        }

        return avgScore.Select(x => dic[x]).ToArray();
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/120880
    public int[] s120880(int[] numlist, int n)
    {
        Dictionary<int, int> answerDic = numlist.Select((value, index) => new { Key = value - n, Value = index })
                                            .ToDictionary(x => x.Key, x => x.Value);

        return answerDic.OrderBy(x => Math.Abs(x.Key))
                .ThenByDescending(x => numlist[x.Value])
                .Select(x => numlist[x.Value]).ToArray();
    }




    //https://school.programmers.co.kr/learn/courses/30/lessons/120878
    public int s120878(int a, int b)
    {
        int A = a;
        int B = b;

        while (B != 0)
        {
            int temp = B;
            B = A % B;
            A = temp;
        }

        int greatestCommonDivisor = b / A;

        while (greatestCommonDivisor % 2 == 0)
        {
            greatestCommonDivisor /= 2;
        }

        while (greatestCommonDivisor % 5 == 0)
        {
            greatestCommonDivisor /= 5;
        }

        return greatestCommonDivisor == 1 ? 1 : 2;
    }




    //https://school.programmers.co.kr/learn/courses/30/lessons/120876
    public int s120876(int[,] lines)
    {
        int[] lineArray = new int[201];

        for (int i = 0; i < lines.GetLength(0); i++)
        {
            for (int m = lines[i, 0]; m < lines[i, 1]; m++)
            {
                lineArray[m + 100]++;
            }
        }

        int answer = 0;

        for (int i = 0; i < lineArray.Length; i++)
        {
            if (lineArray[i] > 1)
                answer++;
        }

        return answer;
    }




    //https://school.programmers.co.kr/learn/courses/30/lessons/120875
    public int s120875(int[,] dots)
    {
        int answer = 0;
        return answer;
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/120871
    public int s120871(int n)
    {
        int answer = 0;

        for (int i = 1; i <= n; i++)
        {
            answer++;

            while (answer % 3 == 0 || answer.ToString().Contains("3"))
            {
                answer++;
            }
        }

        return answer;
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/120869
    public int s120869(string[] spell, string[] dic)
    {
        string spellString = string.Concat(spell.OrderBy(x => x));
        string[] sortDic = dic.Select(x => string.Concat(x.ToCharArray().OrderBy(y => y))).ToArray();

        return sortDic.FirstOrDefault(x => spellString.Equals(x)) == null ? 2 : 1;
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/120819
    public int[] s120819(int money)
    {
        int cost = 5500;

        int[] answer = new int[2];
        answer[0] = money / cost;
        answer[1] = money % cost;

        return answer;
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/120818
    public int s120818(int price)
    {
        float percent = price >= 500000 ? 0.8f : price >= 300000 ? 0.9f : price >= 100000 ? 0.95f : 1f;
        return (int)(price * percent);
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/120583
    public int s120583(int[] array, int n)
    {
        return array.Count(x => x == n);
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/120585
    public int s120585(int[] array, int height)
    {
        return array.Count(x => x > height);
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/120802
    public int s120802(int num1, int num2)
    {
        return num1 + num2;
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/120803
    public int s120803(int num1, int num2)
    {
        return num1 - num2;
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/120808
    public int[] s120808(int numer1, int denom1, int numer2, int denom2)
    {
        int denom = denom1 * denom2;
        int a = numer1 * denom2;
        int b = numer2 * denom1;
        int numer = a + b;

        int A = numer;
        int B = denom;

        while (B != 0)
        {
            int temp = B;
            B = A % B;
            A = temp;
        }

        int[] answer = new int[] { numer / A, denom / A };
        return answer;
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/120809
    public int[] s120809(int[] numbers)
    {
        return numbers.Select(x => x * 2).ToArray();
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/120810
    public int s120810(int num1, int num2)
    {
        return num1 % num2;
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/120811
    public int s120811(int[] array)
    {
        return array.OrderByDescending(x => x).ToArray()[array.Length / 2];
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/120812
    public int s120812(int[] array)
    {
        var frequency = array.GroupBy(x => x)
                            .Select(s => new { Value = s.Key, Count = s.Count() })
                            .OrderByDescending(x => x.Count)
                            .ToList();

        if (frequency.Count > 1 && frequency[0].Count == frequency[1].Count)
            return -1;


        return frequency[0].Value;
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/120813
    public int[] s120813(int n)
    {
        List<int> answer = new List<int>();

        for (int i = 1; i <= n; i += 2)
            answer.Add(i);

        return answer.ToArray();
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/120814
    public int s120814(int n)
    {
        int a = n / 7;
        int b = n % 7;

        return b == 0 ? a : a + 1;
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/120815
    public int s120815(int n)
    {
        int slice = 6;
        int GCD = slice;
        int count = n;

        while (count != 0)
        {
            int temp = count;
            count = GCD % count;
            GCD = temp;
        }

        return (slice * n) / GCD / slice;
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/120816
    public int s120816(int slice, int n)
    {
        int a = n / slice;
        int b = n % slice;

        return b == 0 ? a : a + 1;
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/120817
    public double s120817(int[] numbers)
    {
        return numbers.Sum() / (double)numbers.Length;
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/120821
    public int[] s120821(int[] num_list)
    {
        return num_list.Reverse().ToArray();
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/120822
    public string s120822(string my_string)
    {
        return new string(my_string.ToCharArray().Reverse().ToArray());
    }


    //https://school.programmers.co.kr/learn/courses/30/lessons/120823
    public void s120823(int n)
    {
        string star = "";
        for (int i = 0; i < n; i++)
        {
            star += "*";
            Console.WriteLine($"{star}");
        }
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/120824
    public int[] s120824(int[] num_list)
    {
        int odd = num_list.Count(x => x % 2 == 1);
        int even = num_list.Count(x => x % 2 == 0);

        return new int[] { even, odd };
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/120825
    public string s120825(string my_string, int n)
    {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < my_string.Length; i++)
        {
            for (int m = 0; m < n; m++)
            {
                sb.Append(my_string[i]);
            }
        }

        return sb.ToString();
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/120833
    public int[] s120833(int[] numbers, int num1, int num2)
    {
        List<int> answer = new List<int>();

        for (int i = 0; i <= num2 - num1; i++)
        {
            answer.Add(numbers[i + num1]);
        }

        return answer.ToArray();
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/120834
    public string s120834(int age)
    {
        char[] array = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j' };
        string ageString = age.ToString();

        string answer = "";

        for (int i = 0; i < ageString.Length; i++)
        {
            int idx = ageString[i] - '0';
            answer += array[idx];
        }

        return answer;
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/120835
    public int[] s120835(int[] emergency)
    {
        var sortedEmergency = emergency.Select((key, value) => new { Key = key, Value = value })
                                        .OrderByDescending(x => x.Key)
                                        .ToList();

        return sortedEmergency.Select((item, rank) => new { item.Value, Rank = rank + 1 })
                                    .OrderBy(x => x.Value)
                                    .Select(x => x.Rank)
                                    .ToArray();
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/120836
    public int s120836(int n)
    {
        int answer = 0;

        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                answer++;
            }
        }

        return answer;
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/120837
    public int s120837(int hp)
    {
        int answer = 0;
        int[] attack = { 5, 3, 1 };
        int index = 0;

        while (hp != 0)
        {
            int atk = attack[index];

            if (hp >= atk)
            {
                hp -= atk;
                answer++;
            }
            else
            {
                index++;
            }
        }

        return answer;
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/120838
    public string s120838(string letter)
    {
        Dictionary<string, char> morse = new Dictionary<string, char>
        {
            { ".-" , 'a'},
            { "-..." , 'b'},
            { "-.-." , 'c'},
            { "-.." , 'd'},
            { "." , 'e'},
            { "..-." , 'f'},
            { "--." , 'g'},
            { "...." , 'h'},
            { ".." , 'i'},
            { ".---" , 'j'},
            { "-.-" , 'k'},
            { ".-.." , 'l'},
            { "--" , 'm'},
            { "-." , 'n'},
            { "---" , 'o'},
            { ".--." , 'p'},
            { "--.-" , 'q'},
            { ".-." , 'r'},
            { "..." , 's'},
            { "-" , 't'},
            { "..-" , 'u'},
            { "...-" , 'v'},
            { ".--" , 'w'},
            { "-..-" , 'x'},
            { "-.--" , 'y'},
            { "--.." , 'z'}

        };

        string[] msg = letter.Split(' ');
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < msg.Length; i++)
        {
            sb.Append(morse[msg[i]]);
        }

        return sb.ToString();
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/120839
    public string s120839(string rsp)
    {
        Dictionary<char, char> plan = new Dictionary<char, char>
        {
            { '2', '0'},
            { '0', '5'},
            { '5', '2'},
        };

        char[] array = rsp.ToCharArray();
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < array.Length; i++)
        {
            sb.Append(plan[array[i]]);
        }

        return sb.ToString();
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/120840
    public int s120840(int balls, int share)
    {
        if (share > balls - share)
            share = balls - share;  // nCk == nC(n-k)

        long result = 1;
        for (int i = 0; i < share; i++)
        {
            result *= (balls - i);
            result /= (i + 1);
        }

        return (int)result;
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/120841
    public int s120841(int[] dot)
    {
        int x = dot[0];
        int y = dot[1];

        if (x > 0)
        {
            return y > 0 ? 1 : 4;
        }
        else
        {
            return y > 0 ? 2 : 3;
        }
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/120842
    public int[,] s120842(int[] num_list, int n)
    {
        int[,] answer = new int[num_list.Length / n, n];

        for (int i = 0; i < num_list.Length; i++)
        {
            int row = i / n;
            int col = i % n;

            answer[row, col] = num_list[i];
        }

        return answer;
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/120843
    public int s120843(int[] numbers, int k)
    {
        int idx = ((k - 1) * 2) % numbers.Length;
        return numbers[idx];
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/120844
    public int[] s120844(int[] numbers, string direction)
    {
        List<int> list = new List<int>(numbers);

        if (direction.Equals("right"))
        {
            int targetIndex = list.Count - 1;
            int target = list[targetIndex];

            list.RemoveAt(targetIndex);
            list.Insert(0, target);
        }
        else
        {
            int targetIndex = 0;
            int target = list[targetIndex];

            list.RemoveAt(targetIndex);
            list.Insert(list.Count, target);
        }

        return list.ToArray();
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/120845
    public int s120845(int[] box, int n)
    {
        int width = box[0] / n;
        int length = box[1] / n;
        int height = box[2] / n;

        if (width == 0 || length == 0 || height == 0)
            return 0;

        return width * length * height;
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/120846
    public int s120846(int n)
    {
        int answer = 0;

        for (int i = 4; i <= n; i++)
        {
            int count = 0;

            for (int m = 1; m <= i; m++)
            {
                if (i % m == 0)
                    count++;

                if (count >= 3)
                    break;
            }

            if (count >= 3)
                answer++;
        }

        return answer;
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/120847
    public int s120847(int[] numbers)
    {
        int answer = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            for (int m = i + 1; m < numbers.Length; m++)
            {
                answer = Math.Max(numbers[i] * numbers[m], answer);
            }
        }

        return answer;
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/120848
    public int s120848(int n)
    {
        int answer = 1;

        while (answer < n)
        {
            answer++;
            n /= answer;
        }

        return answer;
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/120849
    public string s120849(string my_string)
    {
        string[] removeList = new string[] { "a", "e", "i", "o", "u" };

        for (int i = 0; i < removeList.Length; i++)
        {
            my_string = my_string.Replace(removeList[i], "");
        }

        return my_string;
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/120850
    public int[] s120850(string my_string)
    {
        List<int> answer = new List<int>();

        for (int i = 0; i < my_string.Length; i++)
        {
            char c = my_string[i];

            if (char.IsDigit(c) == true)
            {
                answer.Add(c - '0');
            }
        }

        return answer.OrderBy(x => x).ToArray();
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/120851
    public int s120851(string my_string)
    {
        List<int> answer = new List<int>();

        for (int i = 0; i < my_string.Length; i++)
        {
            char c = my_string[i];

            if (char.IsDigit(c) == true)
            {
                answer.Add(c - '0');
            }
        }

        return answer.Sum();
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/120852
    public int[] s120852(int n)
    {
        HashSet<int> answer = GetPrimeFactors(n).ToHashSet();
        return answer.ToArray();
    }

    public List<int> GetPrimeFactors(int n)
    {
        List<int> factors = new List<int>();

        // 2로 나누기
        while (n % 2 == 0)
        {
            factors.Add(2);
            n /= 2;
        }

        // 3 이상의 소수로 나누기
        for (int i = 3; i <= Math.Sqrt(n); i += 2)
        {
            while (n % i == 0)
            {
                factors.Add(i);
                n /= i;
            }
        }

        // 남아 있는 수가 소수인 경우
        if (n > 2)
        {
            factors.Add(n);
        }

        return factors;
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/120853
    public int s120853(string s)
    {
        int answer = 0;
        string[] split = s.Split(' ');

        for (int i = 0; i < split.Length; i++)
        {
            if (split[i].Equals("Z"))
            {
                answer -= int.Parse(split[i - 1]);
            }
            else
            {
                answer += int.Parse(split[i]);
            }
        }

        return answer;
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/120854
    public int[] s120854(string[] strlist)
    {
        var answer = strlist.Select(x => x.Length).ToArray();
        return answer;
    }



    //https://school.programmers.co.kr/learn/courses/30/lessons/120860
    public int s120860(int[,] dots)
    {
        int x1 = dots[0, 0];
        int y1 = dots[0, 1];

        int x2 = 0;
        int y2 = 0;

        for (int i = 1; i < 4; i++)
        {
            if (dots[i, 0] != x1)
            {
                x2 = dots[i, 0];
            }
            if (dots[i, 1] != y1)
            {
                y2 = dots[i, 1];
            }
        }

        int length = Math.Abs(x2 - x1);
        int width = Math.Abs(y2 - y1);

        return length * width;
    }
}