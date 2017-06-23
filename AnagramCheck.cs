using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramCheck
{
    class Program
    {
        //Write a function to check whether two given strings are anagram of each other or not.

         public static int CheckAnagram(string str1, string str2)
        {
            int result = 0;
            int count = 1;
            Dictionary<char, int> lookUp = new Dictionary<char, int>();

            if (str1.Length != str2.Length)
                return result = -1;

            foreach(char c in str1)
            {
                int value1;
                if (lookUp.TryGetValue(c, out value1))
                    //if (lookUp.ContainsKey(c))
                {
                    count = value1 + 1;
                    lookUp.Remove(c);
                }
                else
                    count = 1;

                lookUp.Add(c, count);
            }

            foreach(char c in str2)
            {
                    int value;
                //result = -1;
                if (lookUp.TryGetValue(c, out value))
                {
                        count = value;
                        count = count - 1;
                        lookUp.Remove(c);
                        lookUp.Add(c, count);
                    //    if (count == 0)
                    //        result = 0;
                    //else
                    //    result = result - 1;

                }
                else
                {
                    return result = -1;
                }

            }

            ICollection<int> values = lookUp.Values;
            foreach(var num in values)
            {
                if (num != 0)
                    return num;// result = -1;
            }

            return result;
        }
        static void Main(string[] args)
        {
            //string str1 = "geeksforgeeks";
            //string str2 = "forgeeksgeeks";

            //string str1 = "TRIANGLE";
            //string str2 = "INTEGRAL";

            string str1 = "taste";
            //string str2 = "ssatt";
            //string str2 = "states";
            string str2 = "abcde";
            int result;

            result = CheckAnagram(str1, str2);

            if (result == 0)
                Console.WriteLine("The given strings '{0}', '{1}' are anagram", str1, str2);
            else
                Console.WriteLine("The given strings '{0}', '{1}' are not anagram", str1, str2);

            Console.ReadLine();
        }
    }
}
