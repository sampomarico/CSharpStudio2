using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Studio2_Counting_Characters
{
    class CountCharacters
    {
        public static void countCharacters(string sentence)
        {
            sentence = sentence.ToLower();
            char[] charactersInString = sentence.ToCharArray();
            Dictionary<char, int> output = new Dictionary<char, int>();
            char[] accepted = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            foreach (char i in charactersInString)
            {
                if (accepted.Contains(i))
                {
                    if (output.ContainsKey(i))
                    {
                        output[i] += 1;
                    }
                    else
                    {
                        output.Add(i, 1);
                    }
                } else
                {
                    continue;
                }
            }
            foreach (KeyValuePair<char, int> letter in output)
            {
                Console.WriteLine(letter.Key + ": " + letter.Value);
            }
        }
    }
}
