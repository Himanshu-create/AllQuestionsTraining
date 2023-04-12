namespace AllQuestions
{
    public class Program
    {
        static void generateParenthesis(int left, int right, string s,List<string> answer)
        {
            if (left == 0 && right == 0)
            {
                answer.Add(s);
            }

            if (left > right || left < 0 || right < 0)
            {
                return;
            }

            s += "{";
            generateParenthesis(left - 1, right, s, answer);
            s = s.Substring(0, s.Length - 1);

            s += "}";
            generateParenthesis(left, right - 1, s, answer);
            s = s.Substring(0, s.Length - 1);
        }

        public static void Main(string[] args)
        {
            int n = 3;

            List<string> ans = new List<string>();
            string s = "";
            generateParenthesis(n, n, s, ans);

            foreach (string k in ans) { 
                Console.WriteLine(k); 
            }
        }
    }
}