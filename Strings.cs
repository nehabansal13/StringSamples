using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSamples
{

    public class Strings
    {
        public string RemoveDuplicateChar(string input)
        {
            char[] chars = input.ToLower().ToCharArray();
            char temp = ' ';
            char[] result = new char[chars.Length];
            int k = 0;
            for (int i = 0; i < chars.Length; i++)
            {
                bool unique = true;
                temp = chars[i];
                for (int j = 0; j <= chars.Length - 1; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    if (temp == (chars[j]))
                    {
                        unique = false;
                    }

                }
                if (unique == true)
                {

                    result[k] = temp;
                    k++;
                }
            }
            return new string(result);
        }


        public string GetLongestWord(string input)

        {
            string[] wordsInput = input.Split(' ');


            string longestWord = "";


            for (int i = 0; i < wordsInput.Length; i++)

            {
                if (wordsInput[i].Length > longestWord.Length)
                {
                    longestWord = wordsInput[i];
                }


            }

            return longestWord;



        }
        public int[] SortInt(int[] input)
        {
            for (int i = 0; i < input.Length - 1; i++)
            {
                for (int j = 0; j < input.Length - i - 1; j++)
                {
                    if (input[j] > input[j + 1])
                    {
                        int temp = input[j];
                        input[j] = input[j + 1];
                        input[j + 1] = temp;
                    }
                }
            }
            return input;
        }

       public  char[] SortChars(char[] input)
        {
            for (int i = 0; i < input.Length - 1; i++)
            {
                for (int j = 0; j < input.Length - i - 1; j++)
                {
                    if (input[j] > input[j + 1])
                    {
                        char temp = input[j];
                        input[j] = input[j + 1];
                        input[j + 1] = temp;
                    }
                }
            }
            return input;
        }

      public  bool IsAnagram(string input1, string input2)
        {
            if (input1.Length != input2.Length)
                return false;

            char[] arr1 = input1.ToCharArray();
            char[] arr2 = input2.ToCharArray();

            char[] sortedarr1 = SortChars(arr1);
            char[] sortedarr2 = SortChars(arr2);

            if (new string(sortedarr1) == new string(sortedarr2))
                return true;
            else
                return false;
        }
    }
}