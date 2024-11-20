

namespace Challenge3_4
{
    internal class Program
    {
        // You are given a string s consisting only of uppercase English letters.

        // You can apply some operations to this string where, in one operation, you can remove any occurrence of one of the substrings "AB" or "CD" from s.

        // Return the minimum possible length of the resulting string that you can obtain.
        static void Main(string[] args)
        {
            string newString = "abFCaCDbCpDcdCD";
            string target1 = "AB";
            string target2 = "CD";
            Console.WriteLine($"Original String: {newString}");
            Console.WriteLine($"Original String Length: {newString.Length}");
            Console.WriteLine();
            newString = RemoveTargetSubstring(newString, target1, target2);
            Console.WriteLine($"New String: {newString}");
            Console.WriteLine($"New String Length: {newString.Length}");
        }

        // Removes the target substring from the given string
        static string RemoveTargetSubstring(string s, string substring1, string substring2)
        {
            string testSubstring;
            bool cond = true;
            while (cond) 
            {
                for (int i = 0; i < s.Length-1; i++)
                {
                    testSubstring = (s[i].ToString() + s[i + 1].ToString());
                    if(testSubstring.ToUpper().Equals(substring1) || testSubstring.ToUpper().Equals(substring2))
                    {
                        s = s.Replace(testSubstring, "");
                        cond = true;
                        break;
                    }
                    else
                    {
                        cond = false;
                    }
                }
            }
            return s;
        }
    }
}
