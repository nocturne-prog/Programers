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
        string[] answer = new string[] { };
        return answer;
    }

}
