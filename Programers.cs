using System.Formats.Asn1;
using System.Text;

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
        input = Console.ReadLine().Split(' ');

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
        s = Console.ReadLine();

        StringBuilder sb = new StringBuilder();
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
}
